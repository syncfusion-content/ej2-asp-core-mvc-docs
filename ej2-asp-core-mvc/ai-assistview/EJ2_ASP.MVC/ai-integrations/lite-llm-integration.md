---
layout: post
title: LiteLLM in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of LiteLLM in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: LiteLLM
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate AI AssistView with LiteLLM

The **AI AssistView** component can also be integrated with [LiteLLM](https://docs.litellm.ai/docs), an open-source proxy that provides a unified, OpenAI-compatible API for multiple LLM providers such as [OpenAI](https://openai.com) and [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai).

In this setup:
* **AI AssistView** serves as the user interface for entering prompts.
* Prompts are sent to the **LiteLLM proxy**, which forwards them to the configured LLM provider.
* The LLM provider processes the prompt and returns a response through LiteLLM.
* This enables **natural language understanding** and **context-aware responses** without changing the AssistView integration logic, as LiteLLM uses the same OpenAI-style API.

## Prerequisites

Before starting, ensure you have the following:

* **ASP.NET MVC**: Version **5 or higher** with the .NET Framework installed.

* **OpenAI Account**: Access to OpenAI services and a generated **API key**.

* **Python**: Required to run the **LiteLLM proxy**.

* **Syncfusion AI AssistView**: Install the package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5).

## Set Up the AI AssistView control

Follow the [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Configure AI AssistView with LiteLLM

To integrate **LiteLLM** with the **Syncfusion AI AssistView** component, update the `index.cshtml` file in your ASP.NET MVC application. The component will send user prompts to the LiteLLM proxy, which forwards them to the configured LLM provider (e.g., **OpenAI** or **Azure OpenAI**) and returns natural language responses.

In the following example:

* The [promptRequest](https://ej2.syncfusion.com/aspnetmvc/documentation/api/ai-assistview/aiassistviewmodel#promptrequest) event sends the user prompt to the LiteLLM proxy at `http://localhost:4000/v1/chat/completions`. 
* The proxy uses the **model alias** defined in `config.yaml` (e.g., `openai/gpt-4o-mini`) and routes the request to the actual LLM provider. 
* The response is parsed and displayed in the AI AssistView component.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/lite-llm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LiteLLM.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/lite-llm/litellmmvc.cs %}
{% endhighlight %}

{% highlight yaml tabtitle="config.yaml" %}
{% include code-snippet/ai-assistview/ai-integrations/lite-llm/config.yaml %}
{% endhighlight %}
{% endtabs %}

## Run and Test

### Start the proxy:

Navigate to your project folder and run the following command to start the proxy:

```bash
pip install "litellm[proxy]"
litellm --config ".\config.yaml" --port 4000 --host 0.0.0.0
```

### Start the application:

In a separate terminal window, navigate to your project folder and start the ASP.NET MVC application by pressing **F5** in Visual Studio or run:

```bash
dotnet build
```

Open your app to interact with the AI AssistView component integrated with LiteLLM.

## Troubleshooting
* `401 Unauthorized`: Verify your `API_KEY` and model deployment name.
* `Model not found`: Ensure model matches `model_name` in `config.yaml`.
* `CORS issues`: Configure `router_settings.cors_allow_origins` properly.