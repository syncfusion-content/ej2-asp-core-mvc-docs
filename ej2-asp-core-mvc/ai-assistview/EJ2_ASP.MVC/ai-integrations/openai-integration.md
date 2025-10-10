---
layout: post
title: Azure Open AI in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of Azure Open AI in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Azure Open AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Azure Open AI With AI AssistView control
 
The Syncfusion AI AssistView supports integration with [Azure Open AI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai), enabling advanced conversational AI features in your MVC applications.
 
## Getting Started With the AI AssistView control
 
Before integrating Azure Open AI, ensure that the Syncfusion AI AssistView control is correctly rendered in your MVC application:
 
[ MVC Getting Started Guide](../getting-started)
 
## Prerequisites
 
* An Azure account with access to [Azure Open AI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai) services and a generated API key.
* [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) to create MVC application
 
## Install Packages
 
Install the Syncfusion ASP.NET MVC package in the application using Package Manager Console.
 
```bash
 
NuGet\Install-Package Syncfusion.EJ2.MVC5

```
 
Install the Open AI and Azure Open AI package in the application using Package Manager Console.
 
```bash
 
NuGet\Install-Package OpenAI
NuGet\Install-Package Azure.AI.OpenAI
NuGet\Install-Package Azure.Core

```
 
## Configure Azure Open AI
 
1. Log in to the [Azure Portal](https://portal.azure.com/#home) and navigate to your Azure Open AI resource.

2. Under Resource Management, select Keys and Endpoint to retrieve your API key and endpoint URL.  

3. Copy the API key, endpoint, and deployment name (e.g., gpt-4o-mini). Ensure the API version matches your resource configuration.

4. Store these values securely, as they will be used in your application.

> `Security Note`: expose your API key in client-side code for production applications. Use a server-side proxy or environment variables to manage sensitive information securely.
 
## Configure Azure Open AI with AI AssistView
 
You can add the below respective files in your application:
 
* Update the following configuration values with your Azure Open AI details:
 
```bash
 
string endpoint = "Your_Azure_OpenAI_Endpoint";
string apiKey = "Your_Azure_OpenAI_API_Key";
string deploymentName = "Your_Deployment_Name";
 
```
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/open-ai/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/open-ai/openaimvc.cs %}
{% endhighlight %}
{% endtabs %}

![Azure Open AI](../images/open-ai.png)
 
## Run and Test
 
Run the application in the browser using the following command.
 
Build and run the app (Ctrl + F5).
 
Open the Hosted link to interact with your Azure Open AI for dynamic response.
