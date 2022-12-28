---
layout: post
title: Ribbon in ##Platform_Name## Spreadsheet Component
description: Learn here all about Ribbon in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ribbon

It helps to organize a spreadsheet’s features into a series of tabs. By clicking the expand or collapse icon, you can expand or collapse the ribbon toolbar dynamically.

## Ribbon Customization

You can customize the ribbon using the following methods,

| Method | Action |
|-------|---------|
| `hideRibbonTabs` | Used to show or hide the existing ribbon tabs. |
| `enableRibbonTabs` | Used to enable or disable the existing
ribbon tabs. |
| `addRibbonTabs` | Used to add custom ribbon tabs. |
| `hideToolbarItems`| Used to show or hide the existing ribbon
toolbar items. |
| `enableToolbarItems` | Used to enable or disable the specified
toolbar items. |
| `addToolbarItems` | Used to add the custom items in ribbon
toolbar. |
| `hideFileMenuItems` | Used to show or hide the ribbon file menu
items. |
| `enableFileMenuItems`| Used to enable or disable file menu items. |
| `addFileMenuItems`| Used to add custom file menu items. |

The following code example shows the usage of ribbon customization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/ribbon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RibbonController.cs" %}
{% include code-snippet/spreadsheet/ribbon/ribbonController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/ribbon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RibbonController.cs" %}
{% include code-snippet/spreadsheet/ribbon/ribbonController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Worksheet](./worksheet)
* [Rows and columns](./rows-and-columns)
