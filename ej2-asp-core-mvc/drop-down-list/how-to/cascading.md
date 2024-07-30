---
layout: post
title: Cascading in ##Platform_Name## Drop Down List Component | Syncfusion
description: Learn here all about cascading in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cascading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Configure the Cascading DropDownList

The cascading DropDownList is a series of DropDownList, where the value of one DropDownList depends upon another's value. This can be configured by using the [change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_Change_System_String_) event of the parent DropDownList. Within that change event handler, data has to be loaded to the child DropDownList based on the selected value of the parent DropDownList.

The following example, shows the cascade behavior of country, state, and city DropDownList. Here, the [dataBind](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_DataBound_System_String_) method is used to reflect the property changes immediately to the DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Country.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Country.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

