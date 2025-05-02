---
layout: post
title: Caption Template in ##Platform_Name## Grid Component
description: Learn here all about Caption Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Caption Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Caption template in ASP.NET MVC Grid component

The caption template feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid allows you to customize and enhance the appearance of group caption row. It provides a flexible way to display additional information about grouped data, such as counts or grouped value, and enables you to incorporate custom content like images, icons, or other HTML elements. This feature empowers you to create visually appealing and informative group captions in the grid component.

To achieve this customization, you can utilize the [CaptionTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property. By accessing the `data` parameter, which represents the currently displayed group, you can incorporate its properties such as `Field` (column's field name), `HeaderText` (column's header text), `Key`(grouped value) and `Count` (count of the grouped records) into the caption template.

The following example demonstrates how to customize the group header caption in the Grid by utilizing  the `CaptionTemplate` property. It displays the **headerText**, **key** and **count** of the grouped columns.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-template/group.cs %}
{% endhighlight %}
{% endtabs %}

![Caption template](../images/grouping/group-caption-template.png)

## Adding custom text in group caption

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid allows you to enhance the group captions by adding custom text, providing a more meaningful and informative representation of the grouped data. By utilizing the [CaptionTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property, you can add specific text or information to the group caption, offering flexibility in customization.

The following example demonstrates how to add a custom text to the group caption using the `CaptionTemplate` property. The data parameter is utilized to display the  **key**, **count** and **headerText** of the grouped columns along with the custom text. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-customtext-caption-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-customtext-caption-template/group.cs %}
{% endhighlight %}
{% endtabs %}

![Adding custom text in group caption](../images/grouping/group-captiontext-template.png)

## Customize group caption text using locale

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid allows you to customize the group caption text based on the locale. This feature enables you to display localized text or translated content in the group captions according to different language or region settings.

To achieve this, you can utilize the `L10n` and `setCulture` methods from the `@syncfusion/ej2-base` package. The `L10n.load()` method is used to load the localized strings, where the grid object contains the specific translations for the group caption text and the `setCulture` method sets the active locale to **ar** culture to the Grid component.

The following example demonstrates, how to customize group caption text based on **"ar"** locale.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-locale/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-locale/group.cs %}
{% endhighlight %}
{% endtabs %}

![Customize group caption text using locale](../images/grouping/grouping-caption-locale-text.gif)

## Render custom component in group caption

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid offers the flexibility to render a custom component in the group caption, providing advanced or interactive functionality within the group caption row. This feature allows you to display custom UI elements, like buttons, icons, or dropdowns, and handle user interactions directly within the group caption. 

To render custom component in the group caption, you can utilize the [CaptionTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property. This feature enables you to replace plain text with a custom component in the group caption, enhancing customization and interactivity.

The following example demonstrates how to add a custom component to the group caption using the `CaptionTemplate` property. In the template, the [Chips](https://ej2.syncfusion.com/aspnetmvc/documentation/chips/getting-started) component is utilized, with the text content set as the group key.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-caption-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-caption-component/group.cs %}
{% endhighlight %}
{% endtabs %}

![Render custom component in group caption](../images/grouping/grouping-cation-component.png)