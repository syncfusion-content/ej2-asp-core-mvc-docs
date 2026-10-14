---
layout: post
title: How to clear selected items in ##Platform_Name## DropDownList | Syncfusion
description: Clear Syncfusion ##Platform_Name## DropDownList selection by setting value to null and triggering change, or by calling clearText on the popup input element.
platform: ej2-asp-core-mvc
control: Clear Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to clear selected items in ##Platform_Name## DropDownList

You can clear the selected item in two ways.

By clicking on the `clear icon` which is shown in DropDownList element, you can clear the selected item in DropDownList through **interaction**. By using [ShowClearButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ShowClearButton) property, you can enable the clear icon in DropDownList element.

**Programmatically** you can set `null` value to any one of the [Index](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Index), [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Text) or [Value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Value) properties to clear the selected item in DropDownList.

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

