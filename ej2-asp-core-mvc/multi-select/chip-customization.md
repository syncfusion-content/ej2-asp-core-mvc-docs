---
layout: post
title: Chip Customization in ##Platform_Name## Multi Select Component
description: Learn here all about Chip Customization in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Chip Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chip Customization

The MultiSelect allows the user to customize the selected chip element through the [tagging](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Tagging.html) event. In that event, you can set the custom classes to chip element via that event argument of `setClass` method.

The following sample demonstrates chip-customization with the MultiSelect control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/chip-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/chip-customization/gamelist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/chip-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/chip-customization/gamelist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


