---
layout: post
title: Customize The Dialog Appearance in ##Platform_Name## Dialog Component
description: Learn here all about how to customize the Dialog Appearance in Syncfusion ##Platform_Name## Dialog component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize The Dialog Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the Dialog appearance

You can customize the dialog appearance by providing dialog template through [`e-content-template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ContentTemplate) tag.

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



![dialog](../images/dialog-custom-apperance.png)