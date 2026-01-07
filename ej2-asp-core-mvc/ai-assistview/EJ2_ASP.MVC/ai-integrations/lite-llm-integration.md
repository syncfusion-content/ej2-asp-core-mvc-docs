---
layout: post
title: LiteLLM in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of LiteLLM in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: LiteLLM
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate LiteLLM with ASP.NET MVC AI AssistView control
 
The AI AssistView control integrates with [LiteLLM](https://docs.litellm.ai/docs), an open-source proxy that provides a unified OpenAI-compatible API for multiple LLM providers such as OpenAI and Azure OpenAI. It serves as the user interface, sending prompts to the LiteLLM proxy, which forwards them to the configured LLM provider and returns natural-language responses. By configuring the proxy with secure authentication and model routing, developers can enable flexible, multi-provider AI interactions that enhance conversational capabilities.
 
## Prerequisites
 
* **OpenAI Account**: For generating an OpenAI API key to use with LiteLLM.

* **Python**: Version 3.8 or higher, to run the LiteLLM proxy.

* **Syncfusion AI AssistView**: Package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) installed.

## Set Up the AI AssistView control

Follow the [Getting Started](../getting-started) guide to configure and render the AI AssistView control in the application and that prerequisites are met.

## Install Dependencies
 
* Install the LiteLLM proxy via pip in your Python environment.

```bash
 
pip install "litellm[proxy]"
```
## Configure LiteLLM Proxy

* **Set Environment Variable**: Set your OpenAI API key as an environment variable for security (e.g., `export OPENAI_API_KEY=sk-your-openai-key` on macOS/Linux or `set OPENAI_API_KEY=sk-your-openai-key` on Windows). Avoid hardcoding the key in files.

* **Create config.yaml**: In your project root, create a `config.yaml` file to define the model alias and routing. This exposes an OpenAI-compatible endpoint at `http://localhost:4000/v1/chat/completions`.

{% tabs %}
{% highlight yaml tabtitle="config.yaml" %}
```yaml
model_list:

model_name: openai/gpt-4o-mini      # Alias your frontend will use
litellm_params:
model: gpt-4o-mini                # OpenAI base model name
api_key: os.environ/OPENAI_API_KEY

router_settings:
Optional: master_key for proxy authentication
master_key: test_key
cors:

"*"
cors_allow_origins:
"*"
```
{% endhighlight %}
{% endtabs %}


### Start the Proxy: 
Run the following command in your project root to start the LiteLLM proxy:

```bash
litellm --config "./config.yaml" --port 4000 --host 0.0.0.0
```
Security note: In production, use a secret manager for the API key and restrict CORS origins. The optional `master_key` can add proxy-level authentication—set `liteLlmApiKey` in the C# code to match if enabled.

## LiteLLM with AI AssistView

Modify the `index.cshtml` file to integrate LiteLLM with the AI AssistView control via a server-side handler.

The frontend sends prompts to the server (`/Home/GetAIResponse`), which proxies the request to LiteLLM.

Add your optional LiteLLM master key (if enabled) securely in the following configuration:

```bash
const string liteLlmApiKey = "";
```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/lite-llm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LiteLLM.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/lite-llm/litellmmvc.cs %}
{% endhighlight %}
{% endtabs %}