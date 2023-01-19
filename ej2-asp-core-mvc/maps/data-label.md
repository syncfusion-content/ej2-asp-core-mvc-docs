---
layout: post
title: Data Label in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data labels in ##Platform_Name## Maps Component

{% if page.publishingplatform == "aspnet-core" %}

Data labels provide information to users about the shapes of the Maps component. It can be enabled by setting the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Visible) property of the [dataLabelSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) to **true**.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Data labels provide information to users about the shapes of the Maps component. It can be enabled by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Visible) property of the [DataLabelSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) to **true**.

{% endif %}

## Adding data labels

{% if page.publishingplatform == "aspnet-core" %}

To display data labels in the Maps, the [`labelPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_LabelPath) property of [dataLabelSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) must be used. The value of the `labelPath` property can be taken from the field name in the shape data or data source. In the following example, the value of the `labelPath` property is the field name in the shape data of the Maps layer.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/maps/datalabel/label/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

To display data labels in the Maps, the [LabelPath](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_LabelPath) property of [DataLabelSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) must be used. The value of the `LabelPath` property can be taken from the field name in the shape data or data source. In the following example, the value of the `LabelPath` property is the field name in the shape data of the Maps layer.

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

{% if page.publishingplatform == "aspnet-core" %}

In the following example, the value of [labelPath](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_LabelPath) property is set from the field name in the data source of the layer settings.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-ds/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-ds.cs" %}
{% include code-snippet/maps/datalabel/label-ds/label-ds.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the following example, the value of [LabelPath](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_LabelPath) property is set from the field name in the data source of the layer settings.

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

{% if page.publishingplatform == "aspnet-core" %}

The following properties are available in the [dataLabelSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) to customize the data label of the Maps component.

* [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Border) - To customize the color, width and opacity for the border of the data labels in Maps.
* [fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Fill) - To apply the color of the data labels in Maps.
* [opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Opacity) - To customize the transparency of the data labels in Maps.
* [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_TextStyle) - To customize the text style of the data labels in Maps.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-customization.cs" %}
{% include code-snippet/maps/datalabel/label-customization/label-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The following properties are available in the [DataLabelSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) to customize the data label of the Maps component.

* [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Border) - To customize the color, width and opacity for the border of the data labels in Maps.
* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Fill) - To apply the color of the data labels in Maps.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Opacity) - To customize the transparency of the data labels in Maps.
* [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_TextStyle) - To customize the text style of the data labels in Maps.

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

{% if page.publishingplatform == "aspnet-core" %}

The Maps component provides an option to handle the labels when they intersect with the corresponding shape borders using the [smartLabelMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_SmartLabelMode) property. The following options are available in the `smartLabelMode` property.

* None
* Hide
* Trim

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-mode.cs" %}
{% include code-snippet/maps/datalabel/label-mode/label-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Maps component provides an option to handle the labels when they intersect with the corresponding shape borders using the [SmartLabelMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_SmartLabelMode) property. The following options are available in the `SmartLabelMode` property.

* None
* Hide
* Trim

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

{% if page.publishingplatform == "aspnet-core" %}

The Maps component provides an option to handle the labels when a label intersects with another label using the [intersectionAction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_IntersectionAction) property. The following options are available in the `intersectionAction` property.

* None
* Hide
* Trim

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-intersection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-intersection.cs" %}
{% include code-snippet/maps/datalabel/label-intersection/label-intersection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Maps component provides an option to handle the labels when a label intersects with another label using the [IntersectionAction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_IntersectionAction) property. The following options are available in the `IntersectionAction` property.

* None
* Hide
* Trim

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

{% if page.publishingplatform == "aspnet-core" %}

The data label can be added as a template in the Maps component. The [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Template) property of [dataLabelSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) is used to set the data label as a template. Any text or HTML element can be added as the template in data labels.

N>The customization properties of data label, [smartLabelMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_SmartLabelMode) and [intersectionAction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_IntersectionAction) properties are not applicable to [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Template) property. The styles can be applied to the label template using the CSS styles of the template element.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/datalabel/label-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-template.cs" %}
{% include code-snippet/maps/datalabel/label-template/label-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data label can be added as a template in the Maps component. The [Template](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Template) property of [DataLabelSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) is used to set the data label as a template. Any text or HTML element can be added as the template in data labels.

N>The customization properties of data label, [SmartLabelMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_SmartLabelMode) and [IntersectionAction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_IntersectionAction) properties are not applicable to `Template` property. The styles can be applied to the label template using the CSS styles of the template element.

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