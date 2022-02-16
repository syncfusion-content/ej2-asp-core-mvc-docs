---
layout: post
title: Smithchart Dimensions in ##Platform_Name## Smithchart Component
description: Learn here all about Smithchart Dimensions in Syncfusion ##Platform_Name## Smithchart component and more.
platform: ej2-asp-core-mvc
control: Smithchart Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Smithchart Dimensions

You can render the smithchart either corresponding to its container size or you can set the size of the smithchart as per your requirement. To render the smithchart corresponding to its container size, you need to set the size for the smithchart container. Else to set the size for the smithchart as per your requirement, you can use the width and height properties in the smithchart.

## Size for Container

You can render smithchart to it's container size. To achieve this, you need to specify the width and height of the smithchart's container via inline or CSS as demonstrated below.

```javascript
    <div id='container'>
        <div id='element' style="width:650px; height:350px;"></div>
    </div>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/container/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Container.cs" %}
{% include code-snippet/smithchart/dimension/container/container.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/container/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Container.cs" %}
{% include code-snippet/smithchart/dimension/container/container.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size for Smithchart

<!-- markdownlint-disable MD036 -->

You can also set size for smithchart directly through [`width`] and [`height`] properties. Using this properties, you can directly mention the width and height of the smithchart in pixels or you can set the width and height in percentage.

**In Pixel**

In smithchart's width and height property, you can directly give values in pixels like below demonstration. This will render smithchart in same size as you mentioned in you code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/smithchart/dimension/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/smithchart/dimension/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In percentage**

You can also specify the width and height of the smithchart in percentage. If you mention the width and height in percentage, then smithchart will be render as per the percentage of it's container size. You can set the values in percentage like below demonstration.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/smithchart/dimension/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/dimension/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/smithchart/dimension/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

