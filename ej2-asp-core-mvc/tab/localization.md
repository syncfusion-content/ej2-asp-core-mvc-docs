---
layout: post
title: Localization in ##Platform_Name## Tab control | Syncfusion
description: Learn here all about Localization in Syncfusion ##Platform_Name## Tab control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization in ##Platform_Name## Tab control

The localization library allows you to localize the default text content of the Tab. In Tab, the close button's tooltip text alone will be localize based on culture.

| Locale key | en-US (default) |
|------|------|
| closeButtonTitle | Close |

## Loading translations

To load translation object in an application use `load` function of `L10n` class.

In the below sample, the `French` culture is applied to the Tab, and the close button tooltip text is changed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/tab/localization/Localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/tab/localization/Localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [How to load Tab with DataSource](./how-to/load-tab-with-data-source)
* [How to load Tab items dynamically](./how-to/load-tab-items-dynamically)
* [How to render the Tab items using content template](./how-to/render-the-tab-items-using-content-template)
