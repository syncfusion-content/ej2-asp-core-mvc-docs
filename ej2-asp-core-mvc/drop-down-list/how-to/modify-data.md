---
layout: post
title: Modify Data in ##Platform_Name## Drop Down List Component | Syncfusion
description: Learn here all about how to modify data in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Modify Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Modify data before passing to DropDownList for remote data binding

When binding the remote data source, by using the [actionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ActionComplete) event, you can modify the result data before passing it to DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/modifydata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Modifydata.cs" %}
{% include code-snippet/dropdownlist/how-to/modifydata/modifydata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/modifydata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Modifydata.cs" %}
{% include code-snippet/dropdownlist/how-to/modifydata/modifydata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

