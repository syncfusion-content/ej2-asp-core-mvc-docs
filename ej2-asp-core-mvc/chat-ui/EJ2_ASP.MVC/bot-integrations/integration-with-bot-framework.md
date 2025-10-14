---
layout: post
title: Microsoft Bot in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Integration of Microsoft Bot in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integration of Microsoft Bot
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Microsoft Bot Framework with ASP.NET MVC Chat UI control

The Chat UI control integrates seamlessly with a [Microsoft Bot Framework](https://learn.microsoft.com/en-us/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0) bot hosted on Azure, enabling a custom chat interface for seamless user interaction. The process involves setting up a secure backend token server, configuring Direct Line in Azure, and integrating the Chat UI in the application.

## Prerequisites

Before starting, ensure you have the following:

* **Node.js**: Version 16 or higher with npm.

* [Microsoft Azure Account](https://portal.azure.com/#home) : Required to create and host the bot.

* **Syncfusion Chat UI**: Package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) installed.

* **Deployed Azure Bot**: A bot should be created and published using the [Microsoft Bot Framework](https://learn.microsoft.com/en-us/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0), which is accessible via an Azure App Service. Refer to Microsoft's Bot Creation Guide.

## Set Up the AI AssistView control

Follow the Syncfusion AI AssistView [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Install Dependencies

* Install backend dependencies for bot communication using NuGet:

```bash

Install-Package Microsoft.Bot.Connector.DirectLine
Install-Package Newtonsoft.Json

```

## Configure the Azure Bot

1. In the [Azure Portal](https://portal.azure.com/#home), navigate to your bot resource.

2. Enable the direct line channel:
    * Go to `Channels` > `Direct Line` > `Default-Site`.
    * Copy one of the displayed secret keys.

3. Verify the messaging endpoint in the configuration section (e.g., https://your-bot-service.azurewebsites.net/api/messages).

> `Security Note`: Never expose the Direct Line secret key in frontend code. Use a backend token server to handle it securely.

##  Set Up Token Server

Create a Web API controller in your ASP.NET MVC project to handle direct line token generation. Add `Controllers/TokenController.cs`:

{% tabs %}
{% highlight cs tabtitle="TokenController.cs" %}

using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;

namespace YourNamespace.Controllers
{
    public class TokenController : ApiController
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        [HttpPost]
        [Route("api/token/directline/token")]
        public async Task<IHttpActionResult> GenerateToken()
        {
            var directLineSecret = ConfigurationManager.AppSettings["DirectLineSecret"];
            if (string.IsNullOrEmpty(directLineSecret))
            {
                return BadRequest("Direct Line secret is not configured.");
            }
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://directline.botframework.com/v3/directline/tokens/generate");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", directLineSecret);
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic tokenResponse = JsonConvert.DeserializeObject(responseContent);
                return Ok(new { token = tokenResponse.token });
            }
            catch (HttpRequestException ex)
            {
                return InternalServerError(new Exception("Failed to generate Direct Line token.", ex));
            }
        }
    }
}

{% endhighlight %}
{% endtabs %}

Add the Direct Line secret to `Web.config`:

{% tabs %}
{% highlight js tabtitle=".env" %}
<appSettings>
  <add key="DirectLineSecret" value="PASTE_YOUR_DIRECT_LINE_SECRET_HERE" />
</appSettings>

{% endhighlight %}
{% endtabs %}

>`Security Note`: Store the Direct Line secret in a secure configuration, such as Azure Key Vault, for production environments.

## Configure ChatUI

Use the Chat UI `messageSend` event to handle message exchanges. This event is triggered before a message is sent, allowing you to forward it to the bot via the direct line API. Use the `addMessage` method to programmatically add the bot's reply to the Chat UI.

Modify the `Views/Home/Index.cshtml` file to integrate the Syncfusion Chat UI with the direct line API:

{% tabs %}
{% highlight Html tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.InteractiveChat

@{
    var currentUserModel = new ChatUIUser { Id = "user1", User = "You" };
    var botUserModel = new ChatUIUser { Id = "bot", User = "Bot" };
}

<div id='chat-container' style="height: 400px; width: 400px;">
    @Html.EJS().ChatUI("chatUI").User(currentUserModel).MessageSend("onMessageSend").Created("onCreated").Render()
</div>

<script src="https://cdn.syncfusion.com/ej2/31.1.17/dist/ej2.min.js"></script>
<script src="https://cdn.botframework.com/botframework-webchat/latest/webchat.js"></script>
<script>
    var chatUIObj;
    var currentUserId = "@currentUserModel.Id";
    var botUser = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(botUserModel));
    var directLine;
    var chatUiEle = document.getElementById('chatUI');
    var isConnected = false; // Flag to prevent multiple initializations
    
    async function onMessageSend(args) {
        chatUIObj = ej.base.getInstance(chatUiEle, 'chatui');
        // Initialize Direct Line connection on first message if not already connected
        if (!isConnected) {
            try {
                // Fetch Direct Line token
                const response = await fetch('/api/token/directline/token', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' }
                });
                const data = await response.json();
                if (data.error) {
                    chatUIObj.addMessage({ text: 'Failed to connect to bot.', author: botUser });
                    return;
                }

                // Initialize Direct Line
                directLine = new BotFramework.DirectLine.DirectLine({ token: data.token });
                isConnected = true; // Mark as connected

                // Subscribe to bot messages
                directLine.activity$
                    .filter(activity => activity.type === 'message' && activity.from.id !== currentUserId)
                    .subscribe(message => {
                        chatUIObj.addMessage({ text: message.text, author: botUser });
                    });
            } catch (error) {
                chatUIObj.addMessage({ text: 'Sorry, I couldn’t connect to the bot.', author: botUser });
                console.error('Connection error:', error);
                return;
            }
        }

        // Ensure Direct Line is available before sending message
        if (!directLine) {
            console.error('Direct Line connection not established.');
            chatUIObj.addMessage({ text: 'Bot connection not ready. Please wait.', author: botUser });
            return;
        }

        // Send message to bot
        directLine.postActivity({
            from: { id: currentUserId, name: '@currentUserModel.User' },
            type: 'message',
            text: args.message.text
        }).subscribe(
            id => console.log('Sent message with ID: ', id),
            error => {
                console.error('Error sending message: ', error);
                chatUIObj.addMessage({ text: 'Error sending message.', author: botUser });
            }
        );
    }
</script>

{% endhighlight %}
{% endtabs %}

>Ensure Syncfusion scripts and styles are included in `_Layout.cshtml` as per the getting started guide. Also, include the Bot Framework Web Chat script for Direct Line functionality. Register the Syncfusion script manager in `_Layout.cshtml`.

## Configure Web.config for CORS (if needed)

To enable CORS for API requests, add to `Web.config` under `<system.webServer>`:

{% tabs %}
{% highlight js tabtitle="Web.config.js" %}

<httpProtocol>
  <customHeaders>
    <add name="Access-Control-Allow-Origin" value="*" />
    <add name="Access-Control-Allow-Headers" value="Content-Type" />
    <add name="Access-Control-Allow-Methods" value="GET, POST, PUT, DELETE, OPTIONS" />
  </customHeaders>
</httpProtocol>

{% endhighlight %}
{% endtabs %}

## Run and Test

### Start the Application:

Run the project in Visual Studio or use IIS Express.
Open your app in the browser (e.g., `http://localhost:port`) to interact with your Microsoft Bot Framework chatbot.

## Troubleshooting

* `Token Server Error (500)`: Ensure the `DirectLineSecret` in `Web.config` is correct and the token endpoint is accessible.
* `CORS Error`: Verify the CORS configuration in `Web.config` allows requests from your frontend URL.
* `Bot is Not Responding`:
  - Test the bot in the Azure Portal using the `Test in Web Chat` feature to ensure it’s running correctly.
  - Check the bot’s `Messaging endpoint` in the Configuration section and ensure it is correct and accessible.
* `Connection Fails on Load`: Verify the token controller is running and accessible. Check the browser console for network errors.
* `Token Expiration`: Direct Line tokens are short-lived. The Direct Line client typically handles token refresh, but if issues persist, restart the Direct Line connection.