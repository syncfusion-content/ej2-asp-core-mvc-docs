---
layout: post
title: ##Platform_Name## Grid Caption Template | Syncfusion
description: Learn how to use Caption Template in ##Platform_Name## Data Grid to customize group captions, apply formatting, and display group information effectively.
platform: ej2-asp-core-mvc
control: Caption Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Caption Template in ASP.NET Core Data Grid

The [Data Grid](https://www.syncfusion.com/aspnet-core-ui-controls/grid) provides the [captionTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property to customize the content displayed in group caption rows. This capability enhances the presentation of grouped data by enabling the display of grouped values, record counts, and custom elements such as icons and images.

The `captionTemplate` property supports dynamic content through the `data` parameter, which exposes properties such as `field`, `headerText`, `key`, and `count`. These values can be used to display grouped values, record counts, custom text, localized content, and custom UI elements within group caption rows.

The following example illustrates displaying the `headerText`, `key`, and `count` within a customized group caption.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-template/group.cs %}
{% endhighlight %}
{% endtabs %}

![Caption template](../images/grouping/group-caption-template.png)

## Add custom text to group captions 

The Data Grid supports adding custom text to group captions with the [captionTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property. This feature makes group captions more informative by including grouped values, record counts, or descriptive text, and the template can also display custom HTML elements such as icons or images.

In the following example, the `data` parameter displays the `key`, `count`, and `headerText` of the grouped column, along with custom text within the caption.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-customtext-caption-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-customtext-caption-template/group.cs %}
{% endhighlight %}
{% endtabs %}

![Adding custom text in group caption](../images/grouping/group-captiontext-template.png)

## Customize group caption text using locale

The Data Grid supports localization of group caption text, enabling the display of translated or region-specific content within group captions.

Localization can be achieved using the `L10n.load()` and `setCulture()` methods from the `@syncfusion/ej2-base` package. The `L10n.load()` method defines localized strings, while `setCulture()` applies the desired locale to the Data Grid. The following example demonstrates customizing group caption text for the "ar" (Arabic) locale.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-locale/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-locale/group.cs %}
{% endhighlight %}
{% endtabs %}

![Customize group caption text using locale](../images/grouping/grouping-caption-locale-text.gif)

## Render custom component in group captions

The Data Grid supports rendering custom components within group captions using the [captionTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property. This functionality enables the integration of interactive UI elements, such as buttons, icons, or dropdowns, directly within the group caption row, enhancing both functionality and presentation.

In the following example, the [Chips](https://ej2.syncfusion.com/aspnetcore/documentation/chips/getting-started) component is rendered through the caption template, with its text value dynamically assigned based on the group key.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-component/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-component/group.cs %}
{% endhighlight %}
{% endtabs %}

![Render custom component in group caption](../images/grouping/grouping-cation-component.png)

## See also
- [Grouping overview](./grouping)
- [GroupSettings API](https://ej2.syncfusion.com/angular/documentation/api/grid/groupSettings#captiontemplate)
- [Style group captions](../style-and-appearance/grouping#customize-the-group-caption-row)