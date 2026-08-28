---
layout: post
title: Custom Value in ##Platform_Name## MultiSelect | Syncfusion
description: Allow Syncfusion ##Platform_Name## MultiSelect users to add custom values by enabling allowCustomValue and handling the customValueSelection event.
platform: ej2-asp-core-mvc
control: Custom Value
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom Value in ##Platform_Name## MultiSelect

The MultiSelect allows user to add a new option that is not present in the data source to the control value when [allowCustomValue](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_AllowCustomValue) is enabled. When the new custom value is selected, the `customValueSelection` event is triggered.

The following sample demonstrates the custom value configuration with the MultiSelect control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/custom-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/custom-value/gamelist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/custom-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/custom-value/gamelist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


