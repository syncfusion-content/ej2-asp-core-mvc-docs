---
layout: post
title: Gemini AI in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of Gemini AI in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Gemini AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate Gemini AI with ASP.NET MVC AI AssistView control

The AI AssistView control integrates with Google’s [Gemini](https://ai.google.dev/gemini-api/docs) API to deliver intelligent conversational interfaces. It leverages advanced natural language understanding to interpret user input, maintain context throughout interactions, and provide accurate, relevant responses. By configuring secure authentication and data handling, developers can unlock powerful AI-driven communication features that elevate user engagement and streamline support experiences.
 
## Prerequisites

* **Google Account**: For generating a Gemini API key.

* **Syncfusion AI AssistView**: Package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) installed.

* [Markdig](https://www.nuget.org/packages/Markdig) package: For parsing Markdown responses.

## Set Up the AI AssistView control

Follow the Syncfusion AI AssistView [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Install Dependencies
 
1. Install the `Gemini AI` nuget package in the application.
 
```bash
 
NuGet\Install-Package Mscc.GenerativeAI
 
```

2. Install the `Markdig` nuget packages in the application.

```bash

Nuget\Install-Package Markdig

```
 
## Generate API Key

1. **Access Google AI Studio**: Instructs users to sign into [Google AI Studio](https://aistudio.google.com/app/apikey) with a Google account or create a new account if needed. 

2. **Navigate to API Key Creation**: Go to the `Get API Key` option in the left-hand menu or top-right corner of the dashboard. Click the `Create API Key` button.

3. **Project Selection**: Choose an existing Google Cloud project or create a new one.

4. **API Key Generation**: After project selection, the API key is generated. Users are instructed to copy and store the key securely, as it is shown only once.

> Security note: Advises against committing the API key to version control and recommends using environment variables or a secret manager in production.
 
## Gemini AI with AI AssistView

Modify the `index.cshtml` file to integrate the Gemini AI with the AI AssistView control.
 
* Add your Gemini API key securely in the configuration:

```bash

string apiKey = 'Place your API key here';

```
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/gemini-ai/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/gemini-ai/geminimvc.cs %}
{% endhighlight %}
{% endtabs %}
 
![Gemini AI](../images/gemini-ai.png)
