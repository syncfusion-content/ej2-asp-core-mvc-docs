---
layout: post
title: Gemini AI Integration in ##Platform_Name## Smart Paste Button Control | Syncfusion
description: Learn how to implement a custom AI service using Google's Gemini API with ##Platform_Name## Smart Paste Button control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Gemini AI
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gemini AI Integration with ASP.NET Core Smart Paste Button

The Syncfusion ASP.NET Core SmartPaste Button control enables AI-powered, context-aware content pasting into forms, typically using OpenAI or Azure OpenAI.  This guide explains how to integrate the Google Gemini AI service with the Smart Paste Button using the `IChatInferenceService` interface, enabling custom AI-driven responses in a ASP.NET Core Web App.

## Setting Up Gemini

1. **Obtain a Gemini API Key**  
   Visit [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key), sign in, and generate an API key.
2. **Review Model Specifications**  
   Refer to [Gemini Models Documentation](https://ai.google.dev/gemini-api/docs/models) for details on available models.

## Create a Gemini AI Service

Create a service class to manage interactions with the Gemini API, including authentication, request/response handling, and safety settings for the Smart Paste Button.

1. Create a `Services` folder in your project.
2. Add a new file named `GeminiService.cs` in the `Services` folder.
3. Implement the service as shown below, storing the API key securely in a configuration file or environment variable (e.g., `appsettings.json`).

```csharp
using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

public class GeminiService
{
    private readonly string _apiKey;
    private readonly string _modelName = "gemini-2.0-flash"; // Example model
    private readonly string _endpoint = "https://generativelanguage.googleapis.com/v1beta/models/";
    private static readonly HttpClient HttpClient = new(new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(30),
        EnableMultipleHttp2Connections = true
    })
    {
        DefaultRequestVersion = HttpVersion.Version20 // Fallback to HTTP/2 for compatibility
    };
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public GeminiService(IConfiguration configuration)
    {
        _apiKey = configuration["Gemini:ApiKey"] ?? throw new ArgumentNullException("Gemini API key is missing.");
        HttpClient.DefaultRequestHeaders.Clear();
        HttpClient.DefaultRequestHeaders.Add("x-goog-api-key", _apiKey);
    }

    public async Task<string> CompleteAsync(IList<ChatMessage> chatMessages)
    {
        var requestUri = $"{_endpoint}{_modelName}:generateContent";
        var parameters = BuildGeminiChatParameters(chatMessages);
        var payload = new StringContent(
            JsonSerializer.Serialize(parameters, JsonOptions),
            Encoding.UTF8,
            "application/json"
        );

        try
        {
            using var response = await HttpClient.PostAsync(requestUri, payload);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<GeminiResponseObject>(json, JsonOptions);
            return result?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text
                ?? "No response from model.";
        }
        catch (Exception ex) when (ex is HttpRequestException or JsonException)
        {
            throw new InvalidOperationException("Gemini API error.", ex);
        }
    }

    private GeminiChatParameters BuildGeminiChatParameters(IList<ChatMessage> messages)
    {
        var contents = messages.Select(m => new ResponseContent(
            m.Text,
            m.Role == ChatRole.User ? "user" : "model"
        )).ToList();

        return new GeminiChatParameters
        {
            Contents = contents,
            GenerationConfig = new GenerationConfig
            {
                MaxOutputTokens = 2000,
                StopSequences = new List<string> { "END_INSERTION", "NEED_INFO", "END_RESPONSE" } // Configurable stop sequences
            },
            SafetySettings = new List<SafetySetting>
            {
                new() { Category = "HARM_CATEGORY_HARASSMENT", Threshold = "BLOCK_ONLY_HIGH" },
                new() { Category = "HARM_CATEGORY_HATE_SPEECH", Threshold = "BLOCK_ONLY_HIGH" },
                new() { Category = "HARM_CATEGORY_SEXUALLY_EXPLICIT", Threshold = "BLOCK_ONLY_HIGH" },
                new() { Category = "HARM_CATEGORY_DANGEROUS_CONTENT", Threshold = "BLOCK_ONLY_HIGH" }
            }
        };
    }
}
```

N> Store the Gemini API key in `appsettings.json` (e.g., `{ "Gemini": { "ApiKey": "your-api-key" } }`) or as an environment variable to ensure security. The `SafetySettings` filter harmful content; adjust thresholds based on your application’s needs.

## Define Request and Response Models

Define C# classes to match the Gemini API’s JSON request and response format.

1. Create a new file named `GeminiModels.cs` in the `Services` folder.
2. Add the following model classes:

```csharp
public class Part
{
    public string Text { get; set; }
}

public class Content
{
    public Part[] Parts { get; init; } = Array.Empty<Part>();
}

public class Candidate
{
    public Content Content { get; init; } = new();
}

public class GeminiResponseObject
{
    public Candidate[] Candidates { get; init; } = Array.Empty<Candidate>();
}

public class ResponseContent
{
    public List<Part> Parts { get; init; }
    public string Role { get; init; }

    public ResponseContent(string text, string role)
    {
        Parts = new List<Part> { new Part { Text = text } };
        Role = role;
    }
}

public class GenerationConfig
{
    public int Temperature { get; init; } = 0;
    public int TopK { get; init; } = 0;
    public int TopP { get; init; } = 0;
    public int MaxOutputTokens { get; init; } = 2048;
    public List<string> StopSequences { get; init; } = new();
}

public class SafetySetting
{
    public string Category { get; init; } = string.Empty;
    public string Threshold { get; init; } = string.Empty;
}

public class GeminiChatParameters
{
    public List<ResponseContent> Contents { get; init; } = new();
    public GenerationConfig GenerationConfig { get; init; } = new();
    public List<SafetySetting> SafetySettings { get; init; } = new();
}
```

## Create a Custom AI Service

Implement the `IChatInferenceService` interface to connect the Smart Paste Button to the Gemini service, acting as a bridge for AI-generated responses.

1. Create a new file named `GeminiInferenceService.cs` in the `Services` folder.
2. Add the following implementation:

```csharp
using Syncfusion.EJ2.AI;
using System.Threading.Tasks;

public class GeminiInferenceService : IChatInferenceService
{
    private readonly GeminiService _geminiService;

    public GeminiInferenceService(GeminiService geminiService)
    {
        _geminiService = geminiService;
    }

    public async Task<string> GenerateResponseAsync(ChatParameters options)
    {
        return await _geminiService.CompleteAsync(options.Messages);
    }
}
```

## Configure the ASP.NET Core App

Register the Gemini service and `IChatInferenceService` implementation in the dependency injection container.

Update the **~/Program.cs** file as follows:

```csharp
using Syncfusion.EJ2;
using Syncfusion.EJ2.AI;

builder.Services.AddRazorPages();

builder.Services.AddSyncfusionSmartComponents();
builder.Services.AddSingleton<GeminiService>();
builder.Services.AddSingleton<IChatInferenceService, GeminiInferenceService>();

var app = builder.Build();
// ...
```

## Add the Smart Paste Button

Add the Smart Paste Button to a form in the **~/Pages/Index.chtml** file to test the Gemini AI integration.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<h1>Contact Form</h1>
<form action="/submit" method="post">
    <div class="mb-2">
        <label for="name" class="form-label">Full Name</label>
        <input type="text" class="form-control" id="name" name="name" required>
    </div>
    <div class="mb-2">
        <label for="email" class="form-label">Email</label>
        <input type="email" class="form-control" id="email" name="email" required>
    </div>
    <div class="mb-2">
        <label for="phone" class="form-label">Phone Number</label>
        <input type="tel" class="form-control" id="phone" name="phone">
    </div>
    <div class="mb-2">
        <label for="message" class="form-label">Message</label>
        <textarea class="form-control" id="message" name="message" rows="4"></textarea>
    </div>
    <div class="mb-2 form-check">
        <input type="checkbox" class="form-check-input" id="newsletter" name="newsletter" checked>
        <label class="form-check-label" for="newsletter">Subscribe to newsletter</label>
    </div>
    <div class="mb-2">
        <label class="form-label">Preferred Contact Method</label>
        <div class="form-check">
            <input type="radio" class="form-check-input" id="email-contact" name="contact" value="email">
            <label class="form-check-label" for="email-contact">Email</label>
        </div>
        <div class="form-check">
            <input type="radio" class="form-check-input" id="phone-contact" name="contact" value="phone">
            <label class="form-check-label" for="phone-contact">Phone</label>
        </div>
    </div>
    <div class="mb-2">
        <label for="country" class="form-label">Country</label>
        <select class="form-select" id="country" name="country">
            <option value="">Select Country</option>
            <option value="United States">United States</option>
            <option value="Canada">Canada</option>
            <option value="United Kingdom">United Kingdom</option>
        </select>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
    <button type="reset" class="btn btn-secondary">Reset</button>
    <ejs-smartpaste id="smartPasteBtn" content="Smart Paste" cssClass="e-primary" iconCss="e-icons e-paste"></ejs-smartpaste>
</form>

<br />
<div>
    I am John Doe from the United States. My email is johndoe@example.com, and my phone number is 555-123-4567. I’d like to inquire about your services and have a detailed discussion regarding your product offerings. Please contact me via email. I’m happy to subscribe to your newsletter for updates. Thank you!
</div>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core 
Smart Paste Button control will be rendered in the default web browser.

![ASP.NET Core Smart Paste Button Control](../images/SmartPaste.gif)

## Troubleshooting

If the Gemini AI integration does not work, try the following:
- **No Suggestions Displayed**: Verify that the Gemini API key and model name are correct in the configuration. Check the `GeminiService` implementation for errors.
- **HTTP Request Failures**: Ensure a stable internet connection and that the Gemini API endpoint (`https://generativelanguage.googleapis.com/v1beta/models/`) is accessible. Test with HTTP/2 if compatibility issues arise.
- **Service Registration Errors**: Confirm that `GeminiService` and `GeminiInferenceService` are registered in **Program.cs**.

## See Also

- [Getting Started with Syncfusion ASP.NET Core Smart Paste Button](https://ej2.syncfusion.com/aspnetcore/documentation/smart-paste/getting-started)