---
layout: post
title: Display a Dialog at a custom position in ##Platform_Name## | Syncfusion
description: Position the Syncfusion ##Platform_Name## Dialog inside the target container by providing custom X and Y coordinates to the Position property.
platform: ej2-asp-core-mvc
control: Display A Dialog With Custom Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to display a Dialog at a custom position in ##Platform_Name## Dialog

By default, the dialog is displayed in the center of the target container. The dialog position can be set using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property by providing custom X and Y coordinates. The dialog can be positioned inside the target based on the given X and Y values.

By default, the dialog is displayed in the center of the target container. Set the dialog position by providing custom X and Y coordinates to the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property. The `X` and `Y` values can be numeric (pixels) or one of the predefined alignment strings: `'center'`, `'left'`, `'right'`, `'top'`, or `'bottom'`.

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


![Dialog positioned at custom X and Y coordinates](../images/dialog-custom-position.png)