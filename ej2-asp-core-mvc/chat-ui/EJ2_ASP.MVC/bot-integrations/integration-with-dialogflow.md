---
layout: post
title: Integration of Dialogflow in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Integration of Dialogflow in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integration of Dialogflow
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integration of Google Dialogflow With ASP.NET MVC Chat UI component

The Syncfusion Chat UI supports integration with [Google Dialogflow](https://cloud.google.com/dialogflow/docs), enabling advanced conversational AI features in your ASP.NET MVC applications.

## Getting Started With the ChatUI Component

Before integrating Dialogflow, ensure that the Syncfusion Chat UI component is correctly rendered in your ASP.NET MVC app:

[ASP.NET MVC Getting Started Guide](../getting-started)

## Prerequisites

* Google account to access `Dialogflow` and `Google Cloud Console`.
* Visual Studio with ASP.NET MVC development tools.
* Syncfusion EJ2 ASP.NET MVC installed in your project.
* Dialogflow Service Account with the `Dialogflow API Client` role and its JSON key file.

## Install Dependencies

* Install backend dependencies for Dialogflow and server setup using NuGet:

```bash

Install-Package Google.Cloud.Dialogflow.V2
Install-Package Newtonsoft.Json

```
* Install the Syncfusion EJ2 ASP.NET MVC package in your project:

```bash

Install-Package Syncfusion.EJ2.MVC5

```

## Set Up the Dialogflow Agent

1. In the Dialogflow console, create an [agent](https://cloud.google.com/agent-assist/docs), set a name (e.g., `MyChatBot`), and configure the default language (e.g., English - `en`).

2. Add intents with training phrases and responses (e.g., greetings, FAQs). Test using the Dialogflow simulator.

3. In the Google Cloud Console, go to `APIs & Services` > `Credentials`, create a Service Account with the Dialogflow API Client role, and download the JSON key file.

> `Security Note`: Never commit the JSON key file to version control. Use environment variables or a secret manager (e.g., Google Cloud Secret Manager) for production.

## Configure ASP.NET MVC Backend

Create `service-acct.json` with your Dialogflow service account credentials in your project root:

```json

{
  "type": "service_account",
  "project_id": "your-dialogflow-project-id",
  "private_key_id": "abc123xyz...",
  "private_key": "-----BEGIN PRIVATE KEY-----\nMIIEv...",
  "client_email": "dialogflow-agent@your-dialogflow-project-id.iam.gserviceaccount.com",
  ...
}

```

Set up a Web API controller in `Controllers/ChatController.cs` to handle Dialogflow requests:

```csharp

using Google.Cloud.Dialogflow.V2;
using Google.Apis.Auth.OAuth2;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Http;

namespace YourNamespace.Controllers
{
    public class ChatController : ApiController
    {
        private readonly SessionsClient _sessionsClient;
        private readonly string _projectId;

        public ChatController()
        {
            var credential = GoogleCredential.FromFile("service-acct.json");
            _sessionsClient = SessionsClient.Create(credential.ToChannelCredentials());
            _projectId = ConfigurationManager.AppSettings["DialogflowProjectId"]; // Or hardcode from JSON
        }

        [HttpPost]
        [Route("api/chat/message")]
        public async Task<IHttpActionResult> SendMessage([FromBody] MessageRequest request)
        {
            var sessionId = request.SessionId ?? "default-session";
            var session = SessionName.FromProjectSession(_projectId, sessionId);

            var queryInput = new QueryInput
            {
                Text = new TextInput
                {
                    Text = request.Text,
                    LanguageCode = "en-US"
                }
            };

            try
            {
                var response = await _sessionsClient.DetectIntentAsync(new DetectIntentRequest { Session = session.ToString(), QueryInput = queryInput });
                var reply = response.QueryResult.FulfillmentText;
                return Ok(new { reply });
            }
            catch (Exception ex)
            {
                return InternalServerError(new Exception("Error connecting to Dialogflow.", ex));
            }
        }
    }

    public class MessageRequest
    {
        public string Text { get; set; }
        public string SessionId { get; set; }
    }
}

```

> Use a unique `sessionId` (e.g., Guid) for each user to maintain conversation context. Add the projectId to Web.config if needed:

## Integrate ChatUI in ASP.NET MVC

Use the Chat UI `messageSend` event to exchange messages. This event is triggered before a message is sent, allowing you to forward it to the backend.

### Forward Message to backend:

In the `messageSend` event handler, send a POST request to your backend API endpoint (`/api/chat/message`). The backend forwards the message to Dialogflow and returns the response.

### Displaying Bot response:

Use the `addMessage` method to programmatically add the bot's reply to the Chat UI.

Create `Views/Home/Index.cshtml` to integrate the Syncfusion Chat UI with the Dialogflow backend:

```html

@using Syncfusion.EJ2.InteractiveChat

@{
    var currentUserModel = new ChatUIUser { Id = "user1", User = "Albert" };
    var botUserModel = new ChatUIUser { Id = "user2", User = "Bot", AvatarUrl = "https://ej2.syncfusion.com/demos/src/chat-ui/images/bot.png" };
}

<div id='chat-container' style="height: 400px; width: 400px;">
    @Html.EJS().ChatUI("chatUI").HeaderText("Bot").HeaderIconCss("e-header-icon").User(currentUserModel).MessageSend("onMessageSend").Render()
</div>

<script>
    var chatUIObj;
    var currentUserId = "@currentUserModel.Id";
    var botUser = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(botUserModel));

    document.addEventListener('DOMContentLoaded', function () {
        var chatUiEle = document.getElementById('chatUI');
        chatUIObj = ej.base.getInstance(chatUiEle, ejs.interactivechat.ChatUI);
    });

    function onMessageSend(args) {
        // The user message will be added automatically after this event
        // Send to backend
        fetch('/api/chat/message', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ text: args.message.text, sessionId: currentUserId })
        })
        .then(response => response.json())
        .then(data => {
            // Add bot's reply
            chatUIObj.addMessage({ text: data.reply, author: botUser });
        })
        .catch(error => {
            chatUIObj.addMessage({ text: "Sorry, I couldn't contact the server.", author: botUser });
        });
    }
</script>
<style>
.e-header-icon {
  background-image: url('https://ej2.syncfusion.com/demos/src/chat-ui/images/bot.png');
  background-size: cover;
}
</style>

```

> Ensure to include Syncfusion scripts and styles in `_Layout.cshtml` as per the getting started guide. Also, register the Syncfusion script manager in `_Layout.cshtml`.

## Run and Test

### Start the Application:

Run the project in Visual Studio or use IIS Express.

Open your app in the browser and chat with your Dialogflow-powered bot.

![ChatUI with Dialogflow](../../images/dialogflow.png)

## Troubleshooting:

* `Permission Denied`: Ensure the service account has the `Dialogflow API Client` role in the Google Cloud Console.
* `CORS Error`: If using separate origins, configure CORS in Web.config (e.g., add custom headers under <system.webServer>).
* `No Response`: Test intents in the Dialogflow Console simulator to ensure they are configured correctly.
* `Quota Exceeded`: Check Dialogflow API quotas in the Google Cloud Console.
* `Network Issues`: Confirm the application is running and the frontend is pointing to the correct API URL.
* `Invalid Credentials`: Verify the service account JSON or configuration settings are correctly set up.
