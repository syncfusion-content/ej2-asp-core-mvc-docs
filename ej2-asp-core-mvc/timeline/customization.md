---
layout: post
title: Customization in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Customization in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization in ##Platform_Name## Timeline control

You can customize the Timeline items dot size, connectors, dot borders, dot outer space and more to personalize its appearance. This section explains the different ways for styling the items.

## Connector styling

### Common styling

You can define the styles applicable to the all the Timeline item connectors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/connector-common/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/connector-common/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/connector-common/connectorcommon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Common styling](images/connector-common.png)

### Individual styling

You can also apply unique styles to individual connectors, to differentiate specific items within the Timeline.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/connector-individual/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/connector-individual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/connector-individual/connectorindividual.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Individual styling](images/connector-individual.png)

## Dot styling

### Dot color

You can modify the color of the dots to highlight the specific Timeline items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/dot-color/dotcolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot color](images/dot-color.png)

### Dot size

You can adjust the size of the dot to make it larger or smaller by using the `--dot-size` variable.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-size/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/dot-size/dotsize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot size](images/dot-size.png)

### Dot shadow

You can add shadow effects to the Timeline dots to make it feel visually engaging by using the `--dot-outer-space` & `--dot-border` variables.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-shadow/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-shadow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/dot-shadow/dotshadow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot shadow](images/dot-shadow.png)

### Dot variant

You can achieve the desired dot variant by customizing the border, outline and background colors of the Timeline dots.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-variant/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-variant/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/dot-variant/dotvariant.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot variant](images/dot-variant.png)

### Dot outline

By adding the `e-outline` class to the Timeline [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_CssClass) property it enables the dots to have an outline state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-outline/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/customization/dot-outline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/customization/dot-outline/dot-outline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot outline](images/dot-outline.png)
