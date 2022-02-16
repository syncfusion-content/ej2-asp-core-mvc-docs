---
layout: post
title: Localization in ##Platform_Name## Sparkline Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Sparkline component and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The sparkline control supports localization. The default culture for localization is `en-US`. You can change the culture using the `setCulture` method.

## Tooltip format

Sparkline tooltip supports localization. The following code sample shows tooltip text with currency format based on culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/localization/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/localization/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/localization/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/localization/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

