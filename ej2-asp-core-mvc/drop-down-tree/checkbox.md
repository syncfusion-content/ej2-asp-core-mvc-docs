---
layout: post
title: Checkbox in ##Platform_Name## Dropdown Tree Control
description: Learn here all about checkbox in Syncfusion ##Platform_Name## Dropdown Tree control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Checkbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# CheckBox

The Dropdown Tree control allows to check more than one item from the tree without affecting the UI's appearance by enabling the [`showCheckBox`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_ShowCheckBox) property. When this property is enabled, checkbox appears before each item text in the popup.

In the following example, the `showCheckBox` property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cshtml.cs" %}
{% include code-snippet/dropdowntree/check-box/checkbox/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/dropdowntree/check-box/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![DropDown Tree Checkbox Sample](./images/check-box.PNG)

## Auto Check

By default, the checkbox state of the parent and child items in the Dropdown Tree will not be dependent over each other. If you need dependent checked state, then enable the [`autoCheck`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownTreeTreeSettings.html#Syncfusion_EJ2_DropDowns_DropDownTreeTreeSettings_AutoCheck) property which is a member of [`treeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_TreeSettings) property.

* If one or more child items are not in the checked state, then the parent item will be in the intermediate state.

* If all the child items are checked, then the parent item will also be in the checked state.

* If a parent item is checked, then all the child items will also be changed to checked state.

In the following example, the `autoCheck` property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/autoCheck/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoCheck.cshtml.cs" %}
{% include code-snippet/dropdowntree/check-box/autoCheck/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/autoCheck/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AutoCheck.cs" %}
{% include code-snippet/dropdowntree/check-box/autoCheck/autoCheck.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![DropDown Tree AutoCheck Sample](./images/auto-check.PNG)

## Select All

The Dropdown Tree control has in-built support to select all the tree items using Select All options in the header.

When the [`showSelectAll`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_ShowSelectAll) property is set to true, a checkbox will be displayed in the popup header that allows to select or deselect all the tree items in the popup.

By default, `Select All` and `unSelect All` text values will be showcased along with the checkbox in the popup header to indicate the action to be performed on checking or unchecking the checkbox. You can customize these name attributes by using [`selectAllText`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_SelectAllText) and [`unSelectAllText`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_UnSelectAllText) properties respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/selectAll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectAll.cshtml.cs" %}
{% include code-snippet/dropdowntree/check-box/selectAll/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/check-box/selectAll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectAll.cs" %}
{% include code-snippet/dropdowntree/check-box/selectAll/selectAll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![DropDown Tree SelectAll Sample](./images/select-all.PNG)