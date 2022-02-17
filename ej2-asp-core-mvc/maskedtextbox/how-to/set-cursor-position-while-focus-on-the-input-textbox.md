---
layout: post
title: Set Cursor Position While Focus On The Input Textbox in ##Platform_Name## Maskedtextbox Component
description: Learn here all about Set Cursor Position While Focus On The Input Textbox in Syncfusion ##Platform_Name## Maskedtextbox component and more.
platform: ej2-asp-core-mvc
control: Set Cursor Position While Focus On The Input Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set cursor position while focus on the input textbox

By default, on focusing the MaskedTextBox the entire mask gets selected. You can customize by using any one of the following methods:

* Setting cursor position at the start of the MaskedTextBox.
* Setting cursor position at the end of the MaskedTextBox.
* Setting cursor at the specified position in the MaskedTextBox.

> The **selectionStart** and **selectionEnd** set to **0** instead of the input element value's length, when we focus on a MaskedTextBox control filled with all mask characters. This is the default behavior of the HTML 5 input element.

Following is an example that demonstrates the above cases to set cursor position in the MaskedTextBox using [focus](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.MaskedTextBox.html#Syncfusion_EJ2_Inputs_MaskedTextBox_Focus) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/cursorposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CursorPosition.cs" %}
{% include code-snippet/maskedtextbox/cursorposition/cursorPosition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/cursorposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CursorPosition.cs" %}
{% include code-snippet/maskedtextbox/cursorposition/cursorPosition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![MaskedTextBox Sample](../images/cursor-position.png)