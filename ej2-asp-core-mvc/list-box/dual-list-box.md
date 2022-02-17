---
layout: post
title: Dual List Box in ##Platform_Name## List Box Component
description: Learn here all about Dual List Box in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Dual List Box
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dual list box

The dual list box allows the user to move items between two list boxes by clicking the toolbar buttons. Dual list box can be created by listing items in the
[`toolbarSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~ToolbarSettings.html) along with the `scope` property.

The following operations can be performed in dual list box,

| Options | Description |
|------|-------------|
| moveUp | Move the selected item in the upward direction within the list box. |
| moveDown | Move the selected item in the downward direction within the list box. |
| moveTo |  Move the selected item to the another list box. |
| moveFrom | Move the selected item from one list box to the another list box. |
| moveAllTo | Move all the items to the another list box. |
| moveAllFrom |  Move all the items from one list box to the another list box. |

The following example illustrates how to move items from `Group A` to `Group B` list box.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/dual-listbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Duallistbox.cs" %}
{% include code-snippet/listbox/dual-listbox/duallistbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/dual-listbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Duallistbox.cs" %}
{% include code-snippet/listbox/dual-listbox/duallistbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

