---
layout: post
title: MCP in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Integration of MCP in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: MCP
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Integrate Model Context Protocol (MCP) with ASP.NET Core AI AssistView control

The AI AssistView control can be integrated with an [MCP](https://modelcontextprotocol.io/docs/getting-started/intro) backend to enable conversational AI features powered by OpenAI, along with [local tool](https://modelcontextprotocol.io/docs/develop/connect-local-servers) capabilities such as file-aware analysis via `@mentions`. This integration allows the control to reference files in prompts using `@filename`, inject their contents into the model context, and enables analysis of those files alongside the user’s prompt.

## Prerequisites

Before integrating `MCP Server`, ensure the following:

1. `Node.js`: Version 16 or higher, along with npm installed.

2. `OpenAI Account`: Access to OpenAI services and a generated API key.

3. `Syncfusion AI AssistView`: Install the package [Syncfusion.EJ2.Core](https://www.nuget.org/packages/Syncfusion.EJ2.Core).

4. [Markdig](https://www.nuget.org/packages/Markdig) package: For parsing Markdown responses.

## Install server dependencies

Create a folder for the MCP server (e.g., `mcp-demo`) and install the required packages:

```bash

npm install express cors @modelcontextprotocol/sdk

```
## Configure the MCP Server

Create a file named `mcp-server.mjs` in your server folder. This server will:

* Expose `MCP-style SSE endpoints`:
    * `GET /events` – Server-Sent Events stream for clients to subscribe to.
    * `POST /messages` – Accepts client messages and broadcasts them to the corresponding SSE stream.
* Register `tools`:
    * `text.generate` → Calls OpenAI Chat Completions to generate responses.
    * `fs.read` → Reads a file under a configured base directory only.
* Provide a `REST endpoint`:
    * `POST /assist/chat` – A simple REST interface that your Angular app can call.
* Detect `@filename` tokens in prompts, read the file contents, and attach them to the conversation for contextual analysis.
* Maintain session history in memory using a `sessionId` sent from the client.

>Note: This implementation uses `Node.js ESM`, `express`, `cors`, and `@modelcontextprotocol/sdk`. It also expects an OpenAI API key via OPENAI_API_KEY.

{% tabs %}
{% highlight razor tabtitle="mcp-server.mjs" %}
{% include code-snippet/ai-assistview/ai-integrations/mcp-server/mcp-demo.mjs %}
{% endhighlight %}
{% endtabs %}

## Configure AI AssistView with MCP Server

To integrate the MCP server with the AI AssistView component, update the `Views/Home/Index.cshtml` file in your Angular application.

You can type `@` in the prompt box to select and mention files. The contents of these mentioned files will be included in the AI context, enabling more accurate and code-aware responses.

In the following example, the [PromptRequest](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptRequest) event sends the user’s prompt (including any `@mentions`) to the MCP server endpoint `/assist/chat`. The server:
    * Extracts unique file mentions from the prompt.
    * Safely reads those files from the configured FS_BASE_DIR.
    * Injects their contents into the conversation as contextual messages.

OpenAI then receives both the original prompt and the attached file contents, allowing it to provide `code-aware analysis and responses`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/ai-integrations/mcp-server/tagHelper %}
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
