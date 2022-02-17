---
layout: post
title: Clear Item in ##Platform_Name## Drop Down List Component
description: Learn here all about Clear Item in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Clear Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# Clear the selected item in DropDownList

You can clear the selected item in the below two different ways.

By clicking on the `clear icon` which is shown in DropDownList element, you can clear the selected item in
DropDownList through **interaction**. By using [showClearButton](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ShowClearButton.html) property, you can enable the clear icon in DropDownList element.

Through **programmatic** you can set `null` value to anyone of the index, text or value property to clear the selected item in DropDownList.

The following example demonstrate about how to clear the selected item in DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/clear-selected-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/dropdownlist/how-to/clear-selected-item/clearselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/clear-selected-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/dropdownlist/how-to/clear-selected-item/clearselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

