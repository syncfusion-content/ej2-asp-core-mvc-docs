---
layout: post
title: Custom AI Service Integration with ##Platform_Name## Smart Paste Button Control | Syncfusion
description: Learn how to integrate custom AI services with ##Platform_Name## Smart Paste Button control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Custom AI Service
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom AI Service Integration with ASP.NET Core Smart Paste Button

The Syncfusion ASP.NET Core Smart Paste Button leverages AI to parse clipboard content and populate form fields, enhancing user productivity. By default, it supports OpenAI and Azure OpenAI services, but you can integrate custom AI services using the `IChatInferenceService` interface. This interface facilitates communication between the Smart Paste Button and your custom AI provider, enabling precise mapping of clipboard data to form fields.

## IChatInferenceService Interface

The `IChatInferenceService` interface defines a contract for integrating AI services with the Smart Paste Button, enabling the control to process clipboard data for form field mapping.

```csharp
public interface IChatInferenceService
{
    Task<string> GenerateResponseAsync(ChatParameters options);
}
```

The `GenerateResponseAsync` method takes `ChatParameters` (containing clipboard data and form field metadata) and returns a string response from the AI service, which the Smart Paste Button uses to populate form fields.

## Simple Implementation of a Custom AI Service

Below is a sample implementation of a mock AI service named `MockAIService`. This service demonstrates how to implement the `IChatInferenceService` interface by returning sample, context-aware responses. You can replace the logic with your own AI integration.

```csharp
using Syncfusion.EJ2.AI;
using System.Threading.Tasks;

public class MockAIService : IChatInferenceService
{
    public Task<string> GenerateResponseAsync(ChatParameters options)
    {

    }
}
```

## Registering the Custom AI Service

Register the custom AI service in the **~/Program.cs** file of your ASP.NET Core Application:

```csharp
using Syncfusion.EJ2;
using Syncfusion.EJ2.AI;

builder.Services.AddRazorPages();
builder.Services.AddSyncfusionSmartComponents();
builder.Services.AddSingleton<IChatInferenceService, MockAIService>();

var app = builder.Build();
// ...
```

## Implemented AI Services

Here are examples of AI services integrated using the `IChatInferenceService` interface:

| Service | Documentation |
|---------|---------------|
| Claude | [Claude Integration](claude-service) |
| DeepSeek | [DeepSeek Integration](deepseek-service) |
| Groq | [Groq Integration](groq-service) |
| Gemini | [Gemini Integration](gemini-service) |

## Troubleshooting

If the custom AI integration does not work as expected, try the following:
- **Fields Not Populating**: Verify that the custom AI service’s endpoint, model, and API key are correct in `appsettings.json`. Ensure the `GenerateResponseAsync` method returns valid data.
- **Service Registration Errors**: Confirm that `CustomAIService` and `CustomInferenceService` are registered in **Program.cs**.
- **AI Parsing Errors**: Check the AI service’s response format and ensure it matches the expected `CustomAIResponse` structure. Test the API independently to verify connectivity.

## See Also

- [Getting Started with Syncfusion ASP.NET Core Smart Paste Button](https://ej2.syncfusion.com/aspnetcore/documentation/smart-paste/getting-started)

