---
layout: post
title: Events in ##Platform_Name## Floating Action Button Control | Syncfusion
description: Learn here all about Events in Syncfusion ##Platform_Name## Floating Action Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in Floating Action Button Component

The primary way to respond to mouse input is to handle mouse events.The following table shows the mouse events

| Mouse Events | Description |
| -------- | -------- |
| click | This event occurs when the mouse button is released, typically before the MouseUp     event. The handler for this event receives an argument of type EventArgs. Handle this event when you only need to determine when a click occurs. |
| mouseclick |  This event occurs when the user clicks the control with the mouse. The handler for this event receives an argument of type MouseEventArgs. Handle this event when you need to get information about the mouse when a click occurs. |

## How to bind click event to Floating Action Button

The `onclick` attribute is used to bind the click event for button. Here, we have explained about the sample code snippets of toggle button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabEvent.cs" %}
{% include code-snippet/floating-action-button/events/fabevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Befor calling Event](images/play-button.png)
![After calling Event](images/pause-button.png)