---
layout: post
title: Data in ##Platform_Name## Range Navigator Component
description: Learn here all about Data in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Data
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Types of data

## Numeric

The numeric scale is used to represent the numeric values of data in a Range Selector. By default, the `valueType` of a Range Selector is **Double**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/double/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Double.cs" %}
{% include code-snippet/range-navigator/data/double/double.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/double/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Double.cs" %}
{% include code-snippet/range-navigator/data/double/double.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Numeric](images/data/double.png)

### Range

The minimum and the maximum of the scale will be calculated automatically based on the provided data. It can be customized by using the `minimum`, `maximum`, and `interval` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/range-navigator/data/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/range-navigator/data/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Numeric range](images/data/numeric-range.png)

### Label Format

The numeric labels can be formatted using the `labelFormat` property and it supports all the globalized formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/range-navigator/data/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/range-navigator/data/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Numeric label format](images/data/format.png)

The following table describes the result of applying some commonly used label formats on numeric values.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format property value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>1000</td>
<td>n1</td>
<td>1000.0</td>
<td>The Number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n2</td>
<td>1000.00</td>
<td>The Number is rounded to 2 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n3</td>
<td>1000.000</td>
<td>The Number is rounded to 3 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p1</td>
<td>1.0%</td>
<td>The Number is converted to percentage with 1 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p2</td>
<td>1.00%</td>
<td>The Number is converted to percentage with 2 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p3</td>
<td>1.000%</td>
<td>The Number is converted to percentage with 3 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c1</td>
<td>$1,000.0</td>
<td>The Currency symbol is appended to number and number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c2</td>
<td>$1,000.00</td>
<td>The Currency symbol is appended to number and number is rounded to 2 decimal place</td>
</tr>
</table>

### Custom Label Format

The Range Selector also supports the Custom Label formats using the placeholders such as **{value}$**, in which the value represents the axis label, e.g. 20$.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/range-navigator/data/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/range-navigator/data/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Custom label format](images/data/custom-format.png)

## Logarithmic Axis

<!-- markdownlint-disable MD033 -->

The Logarithmic supports the logarithmic scale, and it is used to visualize the data when the Range Selector has numerical values in both the lower (e.g.: 10-6) and the higher (e.g.: 106) orders of the magnitude.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/range-navigator/data/log/log.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/range-navigator/data/log/log.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Logarithmic](images/data/log.png)

### Range

The minimum and the maximum of the Range Selector will be calculated automatically based on the provided data. It can be customized by using the `minimum`, `maximum`, and `interval` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log-range.cs" %}
{% include code-snippet/range-navigator/data/log-range/log-range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log-range.cs" %}
{% include code-snippet/range-navigator/data/log-range/log-range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Logarithmic range](images/data/log-range.png)

### Logarithmic Base

The Logarithmic Base can be customized using the `logBase` property. The default value of this property is **10**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log-base/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log-base.cs" %}
{% include code-snippet/range-navigator/data/log-base/log-base.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/log-base/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log-base.cs" %}
{% include code-snippet/range-navigator/data/log-base/log-base.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Logarithmic base](images/data/log-base.png)

## Date-time

The Range Selector supports the DateTime scale and displays the DateTime values as labels in the specified format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time.cs" %}
{% include code-snippet/range-navigator/data/date-time/date-time.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time.cs" %}
{% include code-snippet/range-navigator/data/date-time/date-time.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![DateTime](images/data/datetime.png)

>Date-time Range navigator supports date-time scale and displays date-time values as a labels in the specified format.

### Interval Customization

The DateTime intervals can be customized using the `interval` and the `intervalType` properties of the Range Selector. For example, if the `interval` is set to 2 and the `intervalType` is set to years, the interval will be considered to be 2 years.

DateTime supports the following interval types:
* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time-interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-interval.cs" %}
{% include code-snippet/range-navigator/data/date-time-interval/date-time-interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time-interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-interval.cs" %}
{% include code-snippet/range-navigator/data/date-time-interval/date-time-interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![DateTime interval type](images/data/datetime-interval.png)

### Label Format

The `labelFormat` property is used to format and parse the date to all globalize format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-format.cs" %}
{% include code-snippet/range-navigator/data/date-time-format/date-time-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/data/date-time-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-time-format.cs" %}
{% include code-snippet/range-navigator/data/date-time-format/date-time-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following table shows the results of applying some common DateTime formats to the `labelFormat` property.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format Property Value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>EEEE</td>
<td>Monday</td>
<td>The Date is displayed in day format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>yMd</td>
<td>04/10/2000</td>
<td>The Date is displayed in month/date/year format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td> MMM </td>
<td>Apr</td>
<td>The Shorthand month for the date is displayed</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hm</td>
<td>12:00 AM</td>
<td>Time of the date value is displayed as label</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hms</td>
<td>12:00:00 AM</td>
<td>The Label is displayed in hours:minutes:seconds format</td>
</tr>
</table>