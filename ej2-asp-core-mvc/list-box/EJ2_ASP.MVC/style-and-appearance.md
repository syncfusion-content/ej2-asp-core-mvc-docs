---
layout: post
title: Style And Appearance in ##Platform_Name## List Box Component
description: Learn here all about Style And Appearance in Syncfusion ##Platform_Name## List Box component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style And Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Styles and Appearances

To modify the ListBox appearance, you need to override the default CSS of ListBox component. Find the list of CSS classes and its corresponding section in ListBox component. Also, you have an option to create your own custom theme for the controls using our [`Theme Studio`](https://ej2.syncfusion.com/themestudio/?theme=material).

CSS Class | Purpose of Class
-----|-----
|.e-listbox-wrapper|To customize the listbox wrapper
|.e-list-parent .e-list-item|To customize the listbox list items
|.e-list-parent .e-list-item:hover|To customize the listbox list items on hover
|.e-list-parent .e-list-item.e-selected|To customize the listbox selected list item
|.e-listboxtool-wrapper .e-listbox-tool|To customize the listbox toolbar
|.e-listboxtool-wrapper .e-listbox-tool .e-btn|To customize the listbox toolbar button
|.e-listboxtool-wrapper .e-listbox-tool .e-btn .e-btn-icon.e-icons::before|To customize the listbox toolbar icon

## Horizontal ListBox

You can use [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_CssClass) property to display the Listbox horizontally.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/horizontal-listbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/listbox/horizontal-listbox/data.cs %}
{% endhighlight %}
{% endtabs %}
