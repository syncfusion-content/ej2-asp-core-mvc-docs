---
layout: post
title: Chip Customization in ##Platform_Name## MultiSelect | Syncfusion
description: Customize Syncfusion ##Platform_Name## MultiSelect chip elements via the tagging event by calling setClass with custom CSS classes for selected items.
platform: ej2-asp-core-mvc
control: Chip Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chip Customization in ##Platform_Name## MultiSelect

The MultiSelect allows the user to customize the selected chip element through the [tagging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Tagging) event. In that event, you can set the custom classes to chip element via that event argument of `setClass` method.

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


