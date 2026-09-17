---
layout: post
title: Telemetry in ##Platform_Name## AI AssistView | Syncfusion®
description: Track AI interaction metrics such as duration, tool calls, and token usage with the Syncfusion® ##Platform_Name## AI AssistView telemetry.
platform: ej2-asp-core-mvc
control: AI AssistView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Telemetry in ##Platform_Name## AI AssistView

To get started with the telemetry feature in AI AssistView, configure the `telemetrySettings` option on the component and set its `enable` property to `true`. Once configured, AI AssistView will start tracking AI interaction metrics such as response duration and tool calls, and will render a built-in telemetry summary button (displaying the duration) in each response toolbar.

You can hover over the telemetry summary button in any response toolbar to view the full telemetry report in a tooltip.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/telemetry/getting-started/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Configuring metrics

You can control which telemetry metrics are captured in the report using the `metrics` property of the [telemetrySettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_TelemetrySettings) option. It accepts one or more values from the `TelemetryMetric` type, such as `status`, `duration`, `toolCalls`, `streamingChunks`, `model`, `inputTokens`, and `outputTokens`.

Additionally, the order of metrics in the `metrics` array also determines the display order of rows in the telemetry tooltip.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/telemetry/metrics/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Customizing the report

Use the `beforeReport` callback of the [telemetrySettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_TelemetrySettings) option to intercept the generated report before it is rendered. It accepts the report (`TelemetryReport`) as an argument and allows you to modify it or return `null` to suppress the report delivery. Custom attributes added in this callback will be shown as additional rows in the telemetry tooltip.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/telemetry/before-report/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Enriching with AI usage data

AI AssistView automatically measures the basic metrics such as `duration`, `toolCalls`, and `streamingChunks`. To include model and token usage details, pass the third optional parameter `TelemetryData` to the [addPromptResponse](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_AddPromptResponse) method. The `model`, `inputTokens`, `outputTokens`, `reasoningTokens`, and `cachedInputTokens` values from this object are merged into the final telemetry report.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/telemetry/usage-data/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Custom attributes

Pass arbitrary key/value pairs through the `customAttributes` field of the `TelemetryData` argument to surface domain-specific metrics (for example, `region`, `tenant`, `sessionId`, or `feature`) inside the telemetry report. Each entry is rendered as its own row in the telemetry tooltip and is included alongside the standard metrics regardless of the `metrics` filter.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/telemetry/custom-attributes/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Behavior notes

The following are the key behaviors and constraints of the telemetry feature:

1. **Turn tracking**: A telemetry turn begins when a prompt is sent (or `executePrompt` is called) and ends when the response is completed or canceled (via `stop responding` button, `cancelPrompt`, or `failPrompt`). The status is recorded as `completed` or `canceled` respectively in the report.

2. **Telemetry button state**: The telemetry summary button in the response toolbar displays `— ms` (a disabled state) when no telemetry report is available for the completed or canceled response, and then shows only the `duration` value once the report is generated.

3. **Tooltip display rules**: The telemetry tooltip only displays rows for metrics that have valid values. Count-based metrics `toolCalls`, `inputTokens`, `outputTokens`, `totalTokens`, `reasoningTokens`, `cachedInputTokens`, and `streamingChunks` are displayed only when their values are positive numbers (greater than 0). Other metrics such as `model` and `status` are displayed whenever they are present.

4. **Duration formatting**: Duration values below 1 second are displayed in `ms`, and values of 1 second or above are displayed in `s` with two decimal places (for example, `500 ms`, `1.25 s`).

5. **Total tokens**: The `totalTokens` metric is automatically computed as the sum of `inputTokens` and `outputTokens` whenever either value is provided through `TelemetryData`.

6. **Metrics filter precedence**: When the `metrics` property of the [telemetrySettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_TelemetrySettings) option is configured, only the specified metrics are retained in the report. However, `status` and `duration` are always retained, and `customAttributes` are always included in the tooltip.

7. **Regenerate flow**: Each regenerated response emits its own telemetry report. The report of the latest completion is bound to the prompt response.

8. **Memory cleanup**: Telemetry reports and tooltips are cleared when the component is destroyed.
