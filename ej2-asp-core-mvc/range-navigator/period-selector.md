---
layout: post
title: Period Selector in ##Platform_Name## Range Navigator Component
description: Learn here all about Period Selector in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Period Selector
publishingplatform: ##Platform_Name##
documentation: ug
---


# Period selector

The period selector allows to select a range with specified periods.

## Periods

An array of objects that allows the users to specify pre-defined time intervals. The `interval` property specifies the count value of the button, and the `text` property specifies the text to be displayed on the button. The `intervaltype` property allows the users to customize the interval type, and it supports the following types:

* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes
* Seconds

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/periods/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Periods.cs" %}
{% include code-snippet/range-navigator/period/periods/periods.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/periods/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Periods.cs" %}
{% include code-snippet/range-navigator/period/periods/periods.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Periods](images/period-selector/periods.png)

## Positioning period selector

The `position` property allows the users to position the period selector at the **Top** or **Bottom**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/range-navigator/period/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/range-navigator/period/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Positioning](images/period-selector/position.png)

## Height

The `height` property allows the users to specify the height of the period selector. The default value of the height property is **43px**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/range-navigator/period/height/height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/range-navigator/period/height/height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Height](images/period-selector/height.png)

## Visibility of range navigator

The `disableRangeSelector` property allows the users to display only the period selector and not the Range Selector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/visible/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/range-navigator/period/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/period/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/range-navigator/period/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [LightWeight](./light-weight/)