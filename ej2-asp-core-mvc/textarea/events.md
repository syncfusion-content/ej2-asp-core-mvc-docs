---
layout: post
title: Events in ##Platform_Name## TextArea control | Syncfusion
description: Handling events triggered by user interactions or changes in the ##Platform_Name## TextArea control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Events in ##Platform_Name## TextArea control

This section describes the TextArea events that will be triggered when appropriate actions are performed. The following events are available in the TextArea control.

## Created

The TextArea control triggers the [Created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Created) event when the TextArea component is created. This event provides users with an opportunity to perform actions immediately after the TextArea has been created and initialized.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/created/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Input

The TextArea control triggers the [Input](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Input) each time when the value of TextArea has changed. This event provides users with an opportunity to perform actions in response to real-time changes in the TextArea's content.
The [InputEventArgs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_InputEventArgs/) passed as an event argument provides the details about the input event in the TextArea.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/input/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/input/input.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/input/input.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Change

The TextArea control triggers the [Change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Change) event when the content of TextArea has changed and gets focus-out. This event provides users with an opportunity to execute specific actions in response to changes made by the user.
The [ChangedEventArgs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_ChangedEventArgs/) passed as an event argument provides the details about the changes in the TextArea's value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/change/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/change/change.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/change/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/change/change.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Focus 

The TextArea control triggers the [Focus](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Focus ) when the TextArea gains focus. This event allows developers to execute specific actions when the user interacts with the TextArea by focusing on it.
The [FocusInEventArgs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FocusInEventArgs/) passed as an argument provides details about the focus event in the TextArea.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Blur 

The TextArea control triggers the [Blur](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Blur) when the TextArea loses focus. This event allows users to execute specific actions when the user interacts with the TextArea by moving focus away from it.
The [FocusOutEventArgs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FocusOutEventArgs/) passed as an argument provides details about the blur event in the TextArea.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/blur/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/blur/blur.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/blur/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/blur/blur.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Destroyed 

The TextArea control triggers the [Destroyed](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Destroyed) when the TextArea component is destroyed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/destroyed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/destroyed/destroyed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/events/destroyed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/events/destroyed/destroyed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
