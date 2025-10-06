---
layout: post
title: Gemini AI in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of Gemini AI in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Gemini AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Gemini AI With AI AssistView control
 
The Syncfusion AI AssistView supports integration with [Gemini](https://ai.google.dev/gemini-api/docs), enabling advanced conversational AI features in your Core applications.
 
## Getting Started With the AI AssistView control
 
Before integrating Gemini AI, ensure that the Syncfusion AI AssistView control is correctly rendered in your Core application:
 
[ ASP.NET CORE Getting Started Guide](../getting-started)
 
## Prerequisites
 
* Google account to generate API key on accessing [Gemini](https://ai.google.dev/gemini-api/docs).
* [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) to create Core application
 
## Install Packages
 
Install the Syncfusion ASP.NET Core package in the application  using Package Manager Console.
 
```bash
 
NuGet\Install-Package Syncfusion.EJ2.AspNet.Core
 
```
 
Install the Gemini AI package in the application using Package Manager Console.
 
```bash
 
NuGet\Install-Package Mscc.GenerativeAI
 
```
 
## Generate API Key
 
1. Go to [Google AI Studio](https://aistudio.google.com/app/apikey) and sign in with your google account. If you don’t have one, create a new account.
 
2. Once logged in, click on `Get API Key` from the left-hand menu or the top-right corner of the dashboard.
 
3. Click the `Create API Key` button. You’ll be prompted to either select an existing Google Cloud project or create a new one. Choose the appropriate option and proceed.
 
4. After selecting or creating a project, your API key will be generated and displayed. Copy the key and store it securely, as it will only be shown once.
 
> `Security Note`: Never commit the API key to version control. Use environment variables or a secret manager for production.
 
## Configure Gemini AI with AI AssistView
 
You can add the below respective files in your application:
 
* Add your generated `API Key` at the line
 
```bash
 
string apiKey = 'Place your API key here';
 
```
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/gemini-ai/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/gemini-ai/geminicore.cs %}
{% endhighlight %}
{% endtabs %}

![Gemini AI](../images/gemini-ai.png)
 
## Run and Test
 
Run the application in the browser using the following command.
 
Build and run the app (Ctrl + F5).
 
Open the hosted link to interact with the Gemini AI for dynamic response