---
layout: post
title: Labels in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Labels in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Labels in Asp.Net MVC Rating Control

You can use the [ShowLabel](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ShowLabel) property to display a label that shows the current value of the rating. When the `ShowLabel` property is set to `true`, a label will be displayed.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/show-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowLabel.cs" %}
{% include code-snippet/rating/labels/show-label/showlabel.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Label](./images/rating-label.png)

## Label position

The Rating component allows you to place the label on the top, bottom, left, or right side of the rating using the [LabelPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_LabelPosition) property. 

The following label positions are supported:

* Top: The label is placed on the top of the rating.
* Bottom: The label is placed on the bottom of the rating.
* Left: The label is placed on the left side of the rating.
* Right: The label is placed on the right side of the rating.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/label-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelPosition.cs" %}
{% include code-snippet/rating/labels/label-position/labelposition.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with different label positions](./images/rating-label-positions.png)


## Label template

You can use the [LabelTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_LabelTemplate) tag directive to specify a custom template for the `Label` of the rating. The current value of the rating will be passed as the `context` when building the content of the label. This allows you to include dynamic information about the rating in the template.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/labels/label-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelTemplate.cs" %}
{% include code-snippet/rating/labels/label-template/labeltemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Label template](./images/rating-label-template.png)