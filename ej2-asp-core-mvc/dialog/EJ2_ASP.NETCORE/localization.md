---
layout: post
title: Localization in ##Platform_Name## Dialog | Syncfusion
description: Localize the close button tooltip text of the Syncfusion ##Platform_Name## Dialog by setting the culture and using the L10n load function with translation objects.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization in ##Platform_Name## Dialog

Localization library allows to localize the default text content of Dialog. In Dialog, the close button's tooltip text alone will be localized based on the culture.

| Locale key | en-US (default)  |
|------|------|
| close |  close |

## Loading translations

To load translation object in an application, use `load` function of `L10n` class.

In the below sample, `French` culture is set to Dialog and change the close button's tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/localization/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/localization/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![dialog](./images/dialog-locale.png)