---
layout: post
title: Find and replace the text within the selected range of cells in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about how to find and replace the text within the selected range of cells in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Find and replace the text within the selected range of cells in ##Platform_Name## Spreadsheet control

In the Spreadsheet component, there is currently no direct option to find and replace the text within a selected range. However, you can find and replace the text within the selected range of cells in 'Sheet' mode in the [`actionBegin`](https://ej2.syncfusion.com/documentation/api/spreadsheet/#actionbegin) event. 

While doing the `replaceAll` action, the actionBegin event will trigger with the action name as `beforeReplaceAll`. In that event, we can check if the mode is `Sheet` and also get the selected range using the `selectedRange` property from the active sheet. Based on the selected range, we can get a selected range's cell collection using methods like generateCellCollection, as shown in the following code example. In the EventArgs of this actionBegin, we will get the `addressCollection`, which contains the cell collections of the cells that match the find value within the activeSheet. Now, we need to verify whether the addressCollection mentioned above contains the cells from the selected range collections. Subsequently, we have to push the cell collections that exist in both into a new collection, like the property 'newCollection', as shown in the following code example. Finally, we can replace the text in the selected range by assigning the newly created cell collection, stored in the property `newCollection`, to the `addressCollection` of the replaceAll action.

Below is a code example demonstrating how to find and replace the text within the selected range of cells, as mentioned above.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/find-text-within-selected-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="findTextController.cs" %}
{% include code-snippet/spreadsheet/find-text-within-selected-range/findTextController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/find-text-within-selected-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="findTextController.cs" %}
{% include code-snippet/spreadsheet/find-text-within-selected-range/findTextController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}