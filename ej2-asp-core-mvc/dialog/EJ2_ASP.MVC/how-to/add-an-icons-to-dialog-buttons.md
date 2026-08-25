---
layout: post
title: How to add icons to Dialog buttons in ##Platform_Name## Dialog | Syncfusion
description: Add icons to the Syncfusion ##Platform_Name## Dialog footer buttons using the Buttons or FooterTemplate property and the icon configuration.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add icons to Dialog buttons in ##Platform_Name## Dialog

You can add icons to the Dialog buttons using the [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property or [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) property . For detailed information about Dialog buttons, refer to the [Getting Started with ASP.NET MVC Dialog](https://ej2.syncfusion.com/aspnetmvc/documentation/dialog/getting-started) documentation.

In the following sample, Dialog footer buttons are customized with icons using `Buttons` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/template-button/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/template-button/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/template-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/template-button/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will look like the following.

![dialog](../images/dialog-btn-icon.png)

In the following sample, Dialog footer buttons are customized with icons using the `FooterTemplate` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/template-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/template-footer/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/template-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/template-footer/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will look like the following.

![dialog](../images/dialog-btn-icon.png)