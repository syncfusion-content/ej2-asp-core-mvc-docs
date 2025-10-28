---
layout: post
title: LLM Model in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of LLM Model in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: LLM Model
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate LLM via Ollama with ASP.NET Core AI AssistView control

The AI AssistView control integrates with [LLM via Ollama](https://ollama.com) to enable advanced conversational AI features in your ASP.NET Core application. The control acts as a user interface where user prompts are sent to the selected LLM model via API calls, providing natural language understanding and context-aware responses.

## Prerequisites

Before starting, ensure you have the following:

* [Ollama](https://ollama.com) installed to run and manage LLM models locally.

* **Syncfusion AI AssistView**: Package [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) installed.

* [Markdig](https://www.nuget.org/packages/Markdig) package: For parsing Markdown responses.

## Set Up the AI AssistView control

Follow the [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Install Dependency

To install the Markdig package by run `NuGet\Install-Package Markdig` in Package Manager Console.
 
## Configuring Ollama

Install the LLM Model package in the application using Package Manager Console.
 
```bash
 
NuGet\Install-Package Microsoft.Extensions.AI

NuGet\Install-Package Microsoft.Extensions.AI.Ollama
 
```
 
## Configure AI AssistView with Ollama in ASP.NET Core

Modify the `index.cshtml` file to integrate the Ollama with the AI AssistView control.

Add services in `Program.cs` file 

```bash

using Microsoft.Extensions.AI;

builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddChatClient(new OllamaChatClient(new Uri("http://localhost:11434/"), "deepseek-r1"))
    .UseDistributedCache()
    .UseLogging();

```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/llm-model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="llm-model.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/llm-model/llm-model-core.cs %}
{% endhighlight %}
{% endtabs %}
 
![LLM Model](../images/llm-model.png)
