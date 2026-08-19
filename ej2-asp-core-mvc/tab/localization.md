---
layout: post
title: Localization in ##Platform_Name## Tabs | Syncfusion
description: Localize the close button tooltip text of the Syncfusion ##Platform_Name## Tabs component using the L10n `load` function for any culture.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization in ##Platform_Name## Tabs

Localization library allows to localize the default text content of Tab. In Tab, The close button's tooltip text alone will be localize based on culture.

| Locale key | en-US (default) |
|------|------|
| closeButtonTitle | Close |

## Loading translations

To load translation object in an application use `load` function of `L10n` class.

In the below sample, `French` culture is set to Tab and change the close button's tooltip text.

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

