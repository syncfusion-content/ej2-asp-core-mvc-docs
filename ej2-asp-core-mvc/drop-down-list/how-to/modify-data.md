---
layout: post
title: Modify Data in ##Platform_Name## Drop Down List Component
description: Learn here all about Modify Data in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Modify Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Modify the result data before passing to DropDownList when binding remote data source

When binding the remote data source, by using the [actionComplete](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~ActionComplete.html) event,
you can modify the result data before passing it to DropDownList.

The following sample demonstrate how to modify the result data.

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

