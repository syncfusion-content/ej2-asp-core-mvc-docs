---
layout: post
title: Prevent Focus to previous element in ##Platform_Name## Dialog
description: Learn here all about Prevent the Focus to previous element in Syncfusion ##Platform_Name## Dialog component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Prevent the focus to the previous element
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prevent the focus to the Previous element

By default, when the dialog is closed, focus returns to the element that was previously focused before the dialog opened. You can prevent this behavior using the `beforeClose` event and setting the `preventFocus` argument to `true`.

Bind the `beforeClose` event and enable the `preventFocus` argument as shown in the sample below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-focus-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-focus-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dlg-focus-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dlg-focus-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

