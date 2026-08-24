---
layout: post
title: Customize dialog appearance | Syncfusion
description: Customize the Syncfusion ##Platform_Name## Dialog appearance by providing a custom content template through the ContentTemplate property.
platform: ej2-asp-core-mvc
control: Customize The Dialog Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the Dialog appearance in ##Platform_Name## Dialog

You can customize the dialog appearance by providing dialog template through [`ContentTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ContentTemplate) property. In the following sample, dialog is customized as error window appearance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/customize-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/customize-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/customize-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/customize-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![dialog](../images/dialog-custom-apperance.png)