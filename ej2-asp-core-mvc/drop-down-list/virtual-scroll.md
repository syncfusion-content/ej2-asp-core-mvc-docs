---
layout: post
title: Virtualization in ##Platform_Name## Drop Down List Component
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in DropDown List

Dropdown list virtualization is a technique used to efficiently render long lists of items in a user interface while minimizing the impact on performance. It's particularly useful when dealing with large datasets, as it ensures that only a fixed number of DOM (Document Object Model) elements are created and displayed in the dropdown list component. As the user scrolls through the list, the existing DOM elements are reused to display the relevant data, rather than creating new elements for each item. Enabling the [`enableVirtualization`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~EnableVirtualization.html) option in a dropdown list activates this virtualization technique, significantly enhancing the list's performance and user experience, especially when handling large datasets.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/virtual-scroll/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/dropdownlist/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Keyboard interaction

Users can navigate through the scrollable content using keyboard actions. This feature loads the next or next set of items based on the key inputs in the popup.

| Key | Action |
|-----|-----|
| `ArrowDown` | Loads the next virtual list item if the selection is present in last item of the current page. Additionally, when holding the key, further virtual list items are loaded in the popup. |
| `ArrowUp` | Loads the previous virtual list item if the selection is present in first item of the current page. Additionally, when holding the key, further virtual list items are loaded in the popup. |
| `PageDown` | Loads the next page and selects the last item in it. Additionally, when holding the key, further virtual list items are loaded in the popup. |
| `PageUp` | Loads the previous page and selects the first item in it. Additionally, when holding the key, further virtual list items are loaded in the popup. |
| `Home` | Loads the initial set of items and selects first item in it. |
| `End` | Loads the last set of items and selects last item in it. |

## Limitation of virtualization

* Virtualization is not supported in the grouping feature.
* Selected Value may or may not be present in the current view port.
* Once filtered, close the popup. Then open the popup with the initially loaded items.
* Virtualization does not work when the popup is closed, and a keyboard action is performed.