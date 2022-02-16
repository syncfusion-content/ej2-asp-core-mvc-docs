---
layout: post
title: Display A Dialog With Custom Position in ##Platform_Name## Dialog Component
description: Learn here all about Display A Dialog With Custom Position in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Display A Dialog With Custom Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display a Dialog with custom position

By default, the dialog is displayed in the center of the target container. The dialog position can be set using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property by providing custom X and Y coordinates.
The dialog can be positioned inside the target based on the given X and Y values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/position/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/position/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![dialog](../images/dialog-custom-position.png)