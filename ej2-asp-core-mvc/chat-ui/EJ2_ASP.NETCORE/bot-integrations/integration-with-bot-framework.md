---
layout: post
title: Microsoft Bot in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Integration of Microsoft Bot in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integration of Microsoft Bot
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Microsoft Bot Framework with ASP.NET Core Chat UI control

The Chat UI control integrates seamlessly with a [Microsoft Bot Framework](https://learn.microsoft.com/en-us/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0) bot hosted on Azure, enabling a custom chat interface for seamless user interaction. The process involves setting up a secure backend token server, configuring Direct Line in Azure, and integrating the Chat UI in the application.

## Prerequisites

Before starting, ensure you have the following:

* **Node.js**: Version 16 or higher with npm.

* [Microsoft Azure Account](https://portal.azure.com/#home) : Required to create and host the bot.

* **Syncfusion Chat UI**: Package [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) installed.

* **Deployed Azure Bot**: A bot should be created and published using the [Microsoft Bot Framework](https://learn.microsoft.com/en-us/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0), which is accessible via an Azure App Service. Refer to Microsoft's Bot Creation Guide.

## Set Up the Chat UI control

Follow the [Getting Started](../getting-started) guide to configure and render the Chat UI control in the application and that prerequisites are met.

## Install Dependencies

* Install backend dependencies for bot communication using NuGet:

```bash

dotnet add package Microsoft.Bot.Connector.DirectLine
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson

```

## Configure the Azure Bot

1. In the [Azure Portal](https://portal.azure.com/#home), navigate to your bot resource.

2. Enable the direct line channel:
    * Go to `Channels` > `Direct Line` > `Default-Site`.
    * Copy one of the displayed secret keys.

3. Verify the messaging endpoint in the configuration section (e.g., https://your-bot-service.azurewebsites.net/api/messages).

> `Security Note`: Never expose the Direct Line secret key in frontend code. Use a backend token server to handle it securely.

##  Set Up Token Server

Create a controller in your ASP.NET Core project to handle direct line token generation. Add `Controllers/TokenController.cs`:

{% tabs %}
{% highlight cs tabtitle="TokenController.cs" %}

using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public TokenController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpPost("directline/token")]
        public async Task<IActionResult> GenerateToken()
        {
            var directLineSecret = _configuration["DirectLine:Secret"];
            if (string.IsNullOrEmpty(directLineSecret))
            {
                return BadRequest(new { error = "Direct Line secret is not configured." });
            }

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://directline.botframework.com/v3/directline/tokens/generate");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", directLineSecret);
                
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<dynamic>(responseContent);
                return Ok(new { token = tokenResponse.token });
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, new { error = "Failed to generate Direct Line token.", details = ex.Message });
            }
        }
    }
}

{% endhighlight %}
{% endtabs %}

Add the Direct Line secret to `appsettings.json`:

{% tabs %}
{% highlight js tabtitle="appsettings.json" %}

{
  "DirectLine": {
    "Secret": "PASTE_YOUR_DIRECT_LINE_SECRET_HERE"
  }
}

{% endhighlight %}
{% endtabs %}

> `Security Note`: Store the Direct Line secret in a secure configuration, such as Azure Key Vault, for production environments.|

## Configure ChatUI

Use the Chat UI [messageSend](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_MessageSend) event to handle message exchanges. This event is triggered before a message is sent, allowing you to forward it to the bot via the Direct Line API. Use the `addMessage` method to programmatically add the bot's reply to the Chat UI.

Modify the `Views/Home/Index.cshtml` file to integrate the Chat UI with the direct line API:

{% tabs %}
{% highlight Html tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.InteractiveChat

@{
    var currentUserModel = new ChatUIUser { Id = "user1", User = "You" };
    var botUserModel = new ChatUIUser { Id = "bot", User = "Bot" };
}

<div id='chat-container' style="height: 400px; width: 400px;">
    <ejs-chatui id="chatUI" messageSend="onMessageSend">
        <e-chatui-user id="@currentUserModel.Id" user="@currentUserModel.User" created="onCreated"></e-chatui-user>
    </ejs-chatui>
</div>

<script src="https://cdn.syncfusion.com/ej2/31.1.17/dist/ej2.min.js"></script>
<script src="https://cdn.botframework.com/botframework-webchat/latest/webchat.js"></script>
<script>
    var chatUIObj;
    var currentUserId = "@currentUserModel.Id";
    var botUser = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(botUserModel));
    var directLine;
    var isConnected = false; // Flag to prevent multiple initializations
    var chatUiEle = document.getElementById('chatUI');

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

> Ensure Syncfusion scripts and styles are included in `_Layout.cshtml` as per the getting started guide. Also, register `<ejs-scripts>` in `_Layout.cshtml`. Include the Bot Framework Web Chat script for Direct Line functionality.

## Configure Program.cs

Ensure CORS and HttpClient are configured in `Program.cs`:

{% tabs %}
{% highlight cs tabtitle="Program.cs" %}

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddHttpClient();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");
app.UseRouting();
app.MapControllers();

app.Run();

{% endhighlight %}
{% endtabs %}

## Run and Test

### Start the Application:

Navigate to your project folder and run:

```bash

dotnet run

``` 

Open your app in the browser Hosted link to interact with your Microsoft Bot Framework chatbot.

## Troubleshooting

* `Token Server Error (500)`: Ensure the DirectLine:Secret in appsettings.json is correct and the token endpoint is accessible.
* `CORS Error`: Verify the CORS policy in Program.cs allows requests from your frontend URL.
* `Bot is Not Responding`:
  - Test the bot in the Azure Portal using the `Test in Web Chat` feature to ensure it's running correctly.
  - Check the bot's `Messaging endpoint` in the Configuration section and ensure it is correct and accessible.
* `Connection Fails on Load`: Verify the token controller is running and accessible. Check the browser console for network errors.
* `Token Expiration`: direct line tokens are short-lived. The direct line client typically handles token refresh, but if issues persist, restart the direct line connection.