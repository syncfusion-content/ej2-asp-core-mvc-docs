---
layout: post
title: Custom AI with ##Platform_Name## Smart TextArea Control | Syncfusion
description: Learn how to integrate custom AI services with ##Platform_Name## Smart TextArea control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Custom AI Service
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom AI Service Integration with ASP.NET Core Smart TextArea

The Syncfusion ASP.NET Core Smart TextArea control leverages AI to provide context-aware autocompletion, typically using OpenAI or Azure OpenAI services. Developers can integrate custom AI services using the `IChatInferenceService` interface, which standardizes communication between the Smart TextArea and third-party AI providers. This section explains how to implement and register a custom AI service for the Smart TextArea.

## IChatInferenceService Interface

The `IChatInferenceService` interface defines a contract for integrating custom AI services with Syncfusion Smart Controls. It enables the Smart TextArea to request and receive AI-generated responses.

```csharp
public interface IChatInferenceService
{
    Task<string> GenerateResponseAsync(ChatParameters options);
}
```

- **Purpose**: Standardizes communication for AI-generated responses.
- **Parameters**: The `ChatParameters` type includes properties like user input and context.
- **Benefits**: Enables seamless switching between AI providers without modifying component code.

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

If the custom AI service does not work as expected, try the following:
- **No Suggestions Displayed**: Ensure the `IChatInferenceService` implementation is registered in **Program.cs** and returns valid responses. Check for errors in the `GenerateResponseAsync` method.
- **Dependency Issues**: Verify that all required NuGet packages are installed. Run `dotnet restore` to resolve dependencies.
- **Incorrect Responses**: Debug the custom AI service implementation to ensure it processes `ChatParameters` correctly and returns expected responses.

