---
layout: post
title: Set The Read Only Textbox in Syncfusion ##Platform_Name## Textbox Component
description: Learn here all about Set The Read Only Textbox in Syncfusion ##Platform_Name## Textbox component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Set The Read Only Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the read-only TextBox

To make the TextBox `read-only`, set the [readonly](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.textbox.html#Syncfusion_EJ2_Inputs_TextBox_Readonly) property to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% include code-snippet/textbox/how-to/read-only/read-only.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% include code-snippet/textbox/how-to/read-only/read-only.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

