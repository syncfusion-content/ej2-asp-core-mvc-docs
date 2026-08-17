---
layout: post
title: How to preselect ##Platform_Name## MultiSelect items via fields | Syncfusion
description: Preselect Syncfusion ##Platform_Name## MultiSelect items by setting a boolean isSelected field on the dataSource and binding via fields and dataBound events.
platform: ej2-asp-core-mvc
control: Selected Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to preselect ##Platform_Name## MultiSelect items via fields

You can use a boolean field(for ex:"isSelected") of MultiSelect dataSource to set preselected items through fields during initial rendering. You can use `itemCreated` event of fields to push items with **isSelected** field set to true and these values will be selected through [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_DataBound) event of MultiSelect. Pass empty string of array initially to load the control with preselected values.

In the following sample, selected values are mapped through **isSelected** field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/selected/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/multiselect/how-to/selected/country.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/selected/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/multiselect/how-to/selected/country.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


