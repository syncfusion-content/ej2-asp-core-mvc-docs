---
layout: post
title: Light Weight in ##Platform_Name## Range Navigator Component
description: Learn here all about Light Weight in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Light Weight
publishingplatform: ##Platform_Name##
documentation: ug
---


# Lightweight range navigator

By default, when the `dataSource` for `series` is empty, a lightweight Range Selector will be shown without Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/light-weight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Light-weight.cs" %}
{% include code-snippet/range-navigator/light-weight/light-weight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/light-weight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Light-weight.cs" %}
{% include code-snippet/range-navigator/light-weight/light-weight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Lightweight Range Selector](images/light-weight.png)

## See Also

* [Period Selector](./period-selector/)