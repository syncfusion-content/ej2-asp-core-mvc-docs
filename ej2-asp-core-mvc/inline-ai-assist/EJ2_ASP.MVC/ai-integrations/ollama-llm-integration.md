---
layout: post
title: LLM Model in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about Integration of LLM Model in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: LLM Model
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate LLM via Ollama with ASP.NET MVC Inline AI Assist control

The Inline AI Assist control integrates with [LLM via Ollama](https://ollama.com) to enable advanced conversational AI features in your ASP.NET MVC application. The control acts as a user interface where user prompts are sent to the selected LLM model via API calls, providing natural language understanding and context-aware responses.
 
## Prerequisites

Before starting, ensure you have the following:

* [Ollama](https://ollama.com) installed to run and manage LLM models locally.

* **Syncfusion Inline AI Assist**: Package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) installed.

* [Markdig](https://www.nuget.org/packages/Markdig) package: For parsing Markdown responses.

## Set Up the Inline AI Assist control

Follow the [Getting Started](../getting-started) guide to configure and render the Inline AI Assist control in the application and that prerequisites are met.

## Install Dependency

To install the Markdig package by run `NuGet\Install-Package Markdig` in Package Manager Console.

## Configuring Ollama

Install the LLM Model package in the application using Package Manager Console.
 
```bash
 
NuGet\Install-Package Microsoft.Extensions.AI

NuGet\Install-Package Microsoft.Extensions.AI.Ollama
 
```
 
## Configure Inline AI Assist with Ollama in ASP.NET MVC

Modify the `index.cshtml` file to integrate the Ollama with the Inline AI Assist control.

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
{% include code-snippet/inline-ai-assist/ai-integrations/llm-model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="llm-model.cs" %}
{% include code-snippet/inline-ai-assist/ai-integrations/llm-model/llm-model-mvc.cs %}
{% endhighlight %}
{% endtabs %}
 
![LLM Model](images/llm-model.png)
