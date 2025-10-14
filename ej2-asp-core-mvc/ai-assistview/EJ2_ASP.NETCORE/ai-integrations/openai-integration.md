---
layout: post
title: Azure OpenAI in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of Azure OpenAI in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Azure OpenAI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate Azure OpenAI with ASP.NET Core AI AssistView control
 
The AI AssistView control integrates with [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai) to enable advanced conversational AI features in your applications. The control acts as a user interface, where user prompts are sent to the Azure OpenAI service via API calls, providing natural language understanding and context-aware responses.

## Prerequisites

Before starting, ensure you have the following:

* **An Azure account**: with access to [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai) services and a generated API key.

* **Syncfusion AI AssistView**: Package [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) installed.

* [Markdig](https://www.nuget.org/packages/Markdig) package available in the project for Markdown-to-HTML conversion (required by the sample code).

## Set Up the AI AssistView control

Follow the Syncfusion AI AssistView [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Install Dependencies

Install the required packages:

1. Install the `OpenAI` and `Azure` nuget packages in the application.

```bash

NuGet\Install-Package OpenAI
NuGet\Install-Package Azure.AI.OpenAI
NuGet\Install-Package Azure.Core

```

2. Install the `Markdig` nuget packages in the application.

```bash

Nuget\Install-Package Markdig

```

Note: The sample below uses HttpClient directly and does not require the Azure/OpenAI SDKs.
 
## Configure Azure OpenAI
 
1. Log in to the [Azure Portal](https://portal.azure.com/#home) and navigate to your Azure OpenAI resource.

2. Under resource Management, select keys and endpoint to retrieve your API key and endpoint URL. 

3. Note the following values:
   - API key
   - Endpoint (for example, https://<resource-name>.openai.azure.com/)
   - API version (must be supported by your resource)
   - Deployment name (for example, gpt-4o-mini)

4. Store these values securely, as they will be used in your application.

> `Security Note`: expose your API key in client-side code for production applications. Use a server-side proxy or environment variables to manage sensitive information securely.

## Azure OpenAI with AI AssistView
 
Modify the `index.cshtml` file to integrate the Azure OpenAI with the AI AssistView control.
 
* Update the following configuration values with your Azure OpenAI details:
 
```bash
 
string endpoint = "Your_Azure_OpenAI_Endpoint";
string apiKey = "Your_Azure_OpenAI_API_Key";
string deploymentName = "Your_Deployment_Name";
 
```
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/open-ai/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/open-ai/openaicore.cs %}
{% endhighlight %}
{% endtabs %}
 
![Azure OpenAI](../images/open-ai.png)
