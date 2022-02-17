---
layout: post
title: Cascading in ##Platform_Name## Combo Box Component
description: Learn here all about Cascading in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Cascading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Configure the Cascading ComboBox

The cascading ComboBox is a series of ComboBox, where the value of one ComboBox depends
upon  another's value. This can be configured by using the [change](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~Change.html) event of the parent ComboBox.
Within that change event handler, data has to be loaded to the child ComboBox based on the selected
value of the parent ComboBox.

The following example, shows the cascade behavior of country, state, and city
ComboBox. Here, the [dataBind](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBoxBuilder~DataBound.html) method is used to reflect the property changes immediately
to the ComboBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/cascading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/combobox/how-to/cascading/State.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/cascading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/combobox/how-to/cascading/State.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

