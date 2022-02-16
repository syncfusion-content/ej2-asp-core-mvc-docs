---
layout: post
title: Methods in ##Platform_Name## Linear Gauge Component
description: Learn here all about Methods in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Methods
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ASP.NET Core Linear Gauge

The following methods are available in the Linear Gauge component.

## setPointerValue

To change the pointer value dynamically, use the [`setPointerValue`](https://ej2.syncfusion.com/documentation/api/linear-gauge#setpointervalue) method in the Linear Gauge component. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     axisIndex        |    Specifies the index of the axis in which the pointer value is to be updated.|
|     pointerIndex     |    Specifies the index of the pointer to be updated.           |
|     pointerValue     |    Specifies the value of the pointer to be updated.           |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/setPointerValue/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/setPointerValue/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## setAnnotationValue

To change the annotation content dynamically, use the [`setAnnotationValue`](https://ej2.syncfusion.com/documentation/api/linear-gauge#setannotationvalue) method in the Linear Gauge component. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     annotationIndex  |    Specifies the index number of the annotation to be updated. |
|     content          |    Specifies the text for the annotation to be updated.        |
|     axisValue        |    Specifies the value of the axis where the annotation is to be placed.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/setAnnotationValue/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/setAnnotationValue/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## refresh

The [`refresh`](https://ej2.syncfusion.com/documentation/api/linear-gauge#refresh) method can be used to change the state of the component and render it again.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/refresh/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/methods/refresh/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

