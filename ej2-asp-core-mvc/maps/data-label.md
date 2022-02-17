---
layout: post
title: Data Label in ##Platform_Name## Maps Component
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data labels

Data labels provide information to users about the shapes of the Maps component. It can be enabled by setting the `Visible` property of the `MapsDataLabelSettings` to **true**.

## Adding data labels

To display data labels in the Maps, the `LabelPath` property of `MapsDataLabelSettings` must be used. The value of the `LabelPath` property can be taken from the field name in the shape data or data source. In the following example, the value of the `LabelPath` property is the field name in the shape data of the Maps layer.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/maps/datalabel/label/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/maps/datalabel/label/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Setting label path value](./images/Datalabel/label.PNG)

In the following example, the value of `LabelPath` property is set from the field name in the data source of the layer settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-ds/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-ds.cs" %}
{% include code-snippet/maps/datalabel/label-ds/label-ds.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-ds/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-ds.cs" %}
{% include code-snippet/maps/datalabel/label-ds/label-ds.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Setting label path value from datasource](./images/Datalabel/label-datasource.PNG)

## Customization

The following properties are available in the `MapsDataLabelSettings` to customize the data label of the Maps component.

* `Border` - To customize the color, width and opacity for the border of the data labels in Maps.
* `Fill` - To apply the color of the data labels in Maps.
* `Opacity` - To customize the transparency of the data labels in Maps.
* `TextStyle` - To customize the text style of the data labels in Maps.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-customization.cs" %}
{% include code-snippet/maps/datalabel/label-customization/label-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-customization.cs" %}
{% include code-snippet/maps/datalabel/label-customization/label-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Data label customization](./images/Datalabel/label-customization.PNG)

## Smart labels

The Maps component provides an option to handle the labels when they intersect with the corresponding shape borders using the `SmartLabelMode` property. The following options are available in the `SmartLabelMode` property.

* None
* Hide
* Trim

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-mode.cs" %}
{% include code-snippet/maps/datalabel/label-mode/label-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-mode.cs" %}
{% include code-snippet/maps/datalabel/label-mode/label-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Smart labels](./images/Datalabel/label-mode.PNG)

## Intersect action

The Maps component provides an option to handle the labels when a label intersects with another label using the `IntersectionAction` property. The following options are available in the `IntersectionAction` property.

* None
* Hide
* Trim

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-intersection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-intersection.cs" %}
{% include code-snippet/maps/datalabel/label-intersection/label-intersection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-intersection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-intersection.cs" %}
{% include code-snippet/maps/datalabel/label-intersection/label-intersection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Intersect action](./images/Datalabel/label-intersect.PNG)

## Adding data label as a template

The data label can be added as a template in the Maps component. The `Template` property of `MapsDataLabelSettings` is used to set the data label as a template. Any text or HTML element can be added as the template in data labels.

>The customization properties of data label, `SmartLabelMode` and `IntersectionAction` properties are not applicable to `Template` property. The styles can be applied to the label template using the CSS styles of the template element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-template.cs" %}
{% include code-snippet/maps/datalabel/label-template/label-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-template.cs" %}
{% include code-snippet/maps/datalabel/label-template/label-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Intersect action](./images/Datalabel/label-template.PNG)