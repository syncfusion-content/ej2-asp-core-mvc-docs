---
layout: post
title: Localization in ##Platform_Name## Chart Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The localization library localizes the Chart's default text content. Static text used by chart features (for example, zoom toolbar labels) can be translated by providing a locale value and a translation object.

<!-- markdownlint-disable MD033 -->

<table>
<tr>
<td><b>Locale keys</b></td>
<td><b>Text to display</b></td>
</tr>
<tr>
<td>Zoom</td>
<td>Zoom</td>
</tr>
<tr>
<td>ZoomIn</td>
<td>ZoomIn</td>
</tr>
<tr>
<td>ZoomOut</td>
<td>ZoomOut</td>
</tr>
<tr>
<td>Reset</td>
<td>Reset</td>
</tr>
<tr>
<td>Pan</td>
<td>Pan</td>
</tr>
<tr>
<td>ResetZoom</td>
<td>Reset Zoom</td>
</tr>
</table>

To load translations in an application, use the `L10n.load()` function.

For more information about localization, see the localization guide: [`localization`](https://ej2.syncfusion.com/aspnetcore/documentation/common/localization/)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/chart/getting-started/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/chart/getting-started/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

