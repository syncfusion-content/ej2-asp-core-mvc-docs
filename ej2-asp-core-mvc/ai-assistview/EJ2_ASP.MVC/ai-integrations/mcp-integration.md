---
layout: post
title: MCP in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of MCP in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: MCP
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate Model Context Protocol (MCP) with ASP.NET MVC AI AssistView control

The AI AssistView control can be integrated with an [MCP](https://modelcontextprotocol.io/docs/getting-started/intro) backend to enable conversational AI features powered by OpenAI, along with [local tool](https://modelcontextprotocol.io/docs/develop/connect-local-servers) capabilities such as file-aware analysis via `@mentions`. This integration allows the control to reference files in prompts using `@filename`, inject their contents into the model context, and enables analysis of those files alongside the user’s prompt.

## Prerequisites

Before integrating `MCP Server`, ensure the following:
1. **Syncfusion AI AssistView**: Package [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) installed.

2. The AI AssistView control is integrated with [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai).
    - [Integration of Azure OpenAI With ASP.NET MVC AI AssistView control](../ai-integrations/openai-integration.md)

## Install server dependencies

Create a folder for the MCP server (e.g., `mcp-demo`) and install the required packages:

```bash

npm install express cors @modelcontextprotocol/sdk

```

## Configure the MCP Server

Create a file named `mcp-server.mjs` in your server folder. This server:

* Exposes MCP SSE endpoints (/events, /messages) with tools:
    * `text.generate` → Calls OpenAI Chat Completions
    * `fs.read` → Reads a file under a configured base directory
* Provides a REST endpoint `/assist/chat` for the ASP.NET MVC app
* Detects `@filename` in prompts, reads file contents, and attaches them to the conversation for contextual analysis.
* Maintains session history using a `sessionId` sent from the client. The server stores messages in memory for multi-turn conversations.

{% tabs %}
{% highlight razor tabtitle="mcp-server.mjs" %}
{% include code-snippet/ai-assistview/ai-integrations/mcp-server/mcp-demo.mjs %}
{% endhighlight %}
{% endtabs %}

## Configure AI AssistView with MCP Server

To integrate the MCP server with the Syncfusion AI AssistView control, update the `Views/Home/Index.cshtml` file in your application.

Type `@` in the prompt box to select and mention files. The contents of these files will be included in the AI context for better code-aware responses.

In the following sample, the [PromptRequest](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptRequest) event sends the user’s prompt, including `@mentions`, to the MCP server at `/assist/chat`. The server extracts unique mentions, safely reads those files from `FS_BASE_DIR`, and injects them into the conversation as a contextual message and OpenAI receives both the file contents and the prompt, enabling code-aware analysis.

>Note: The control uses a `session ID` to maintain conversation history. It is stored in `localStorage` and sent with each request. The MCP server keeps session data in memory, and clicking Clear Prompts resets the session via `/assist/clear`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/mcp-server/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MCP.cs" %}
{% include code-snippet/ai-assistview/ai-integrations/mcp-server/mcp-core.cs %}
{% endhighlight %}
{% endtabs %}
 
![MCP](../images/mcp-server.png)

## Run and Test

### Start the MCP server:

Navigate to your MCP server folder and run the following command to start the Node.js server:

```bash

node mcp-server.mjs

```

### Start the frontend:

Run the project in Visual Studio or use IIS Express, it will render the **Syncfusion<sup style="font-size:70%">&reg;</sup> AI AssistView** control to interact with the integrated MCP.

## Troubleshooting
* `401/403 from OpenAI`: Verify your `OPENAI_API_KEY` and model deployment name.
* `File path errors`: Ensure FS_BASE_DIR is correctly set and paths are relative to it.
* `CORS issues`: Confirm the server allows requests from `http://localhost:port`.
* `SSE stream testing`: Run `curl -N http://localhost:3000/events` to verify the stream is active.
