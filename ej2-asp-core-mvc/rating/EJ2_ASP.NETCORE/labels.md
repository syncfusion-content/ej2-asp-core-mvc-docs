---
layout: post
title: Labels in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Labels in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Labels in ASP.NET Core Rating Control

You can use the [showLabel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ShowLabel) property to display a label that shows the current value of the rating. When the `showLabel` property is set to `true`, a label will be displayed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/show-label/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Label](./images/rating-label.png)

## Label position

The Rating control allows you to place the label on the top, bottom, left, or right side of the rating using the [labelPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_LabelPosition) property. 

The following label positions are supported:

* Top: The label is placed on the top of the rating.
* Bottom: The label is placed on the bottom of the rating.
* Left: The label is placed on the left side of the rating.
* Right: The label is placed on the right side of the rating.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/label-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with different label positions](./images/rating-label-positions.png)


## Label template

You can use the [labelTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_LabelTemplate) tag directive to specify a custom template for the `Label` of the rating. The current value of the rating will be passed as the `value` property in the template context when building the content of the label. This allows you to include dynamic information about the rating in the template.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/label-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Label template](./images/rating-label-template.png)