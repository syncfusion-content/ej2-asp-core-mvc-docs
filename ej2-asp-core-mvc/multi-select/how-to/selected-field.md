---
layout: post
title: Selected Field in ##Platform_Name## Multi Select Component
description: Learn here all about Selected Field in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Selected Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set preselected items through fields

You can use a boolean field(for ex:"isSelected") of MultiSelect dataSource to set preselected items through fields during initial rendering. You can use `itemCreated` event of fields to push items with **isSelected** field set to true and these values will be selected through [dataBound](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~DataBound.html) event of MultiSelect. Pass empty string of array initially to load the control with preselected values.

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


