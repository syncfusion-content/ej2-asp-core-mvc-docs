---
layout: post
title: Custom Value in ##Platform_Name## Multi Select Component
description: Learn here all about Custom Value in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Custom Value
publishingplatform: ##Platform_Name##
documentation: ug
---


# CustomValue

The MultiSelect allows user to add a new non-present option to the control value when [allowCustomValue](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~AllowCustomValue.html) is enabled. while selecting the new custom value `customValueSelection` event will be triggered.

The following sample demonstrates configuration of custom value support with the MultiSelect control.

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


