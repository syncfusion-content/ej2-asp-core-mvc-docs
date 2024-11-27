---
layout: post
title: Paging in ##Platform_Name## Grid Component
description: Learn here all about Paging in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---

# Paging in ASP.NET MVC Grid component

Paging provides an option to display grid data in segmented pages, making it easier to navigate through large datasets. This feature is particularly useful when dealing with extensive data sets. 

To enable paging, you need to set the [AllowPaging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) property to **true**. This property determines whether paging is enabled or disabled for the grid. When paging is enabled, a pager component rendered at the bottom of the grid, allowing you to navigate through different pages of data.

Paging options can be configured through the [PageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PageSettings) property. The `PageSettings` object allows you to control various aspects of paging, such as the page size, current page, and total number of records.

> You can achieve better performance by using grid paging to fetch only a pre-defined number of records from the data source.

## Customize the pager options 

Customizing the pager options in the Syncfusion Grid allows you to tailor the pagination control according to your specific requirements. You can customize the pager to display the number of pages using the `PageCount` property, change the current page using `CurrentPage` property, display the number of records in the grid using the `PageSize` property, and even adjust the page sizes in a dropdown using the `PageSizes` property. Additionally, you can include the current page as a query string in the URL for convenient navigation. 

### Change the page size 

The Syncfusion Grid allows you to control the number of records displayed per page, providing you with flexibility in managing your data. This feature is particularly useful when you want to adjust the amount of data visible to you at any given time. To achieve this, you can utilize the [PageSettings.PageSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) property. This property is used to specify the initial number of records to display on each page. The default value of `PageSize` property is **12**.

The following example demonstrates how to change the page size of a Grid using an external button click based on **TextBox** input.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/change-page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/change-page-size/page.cs %}
{% endhighlight %}
{% endtabs %}

![Change the page size](images/page/change-page-size.png)

### Change the page count 

The Syncfusion Grid allows you to adjust the number of pages displayed in the pager container. This is useful when you want to manage the number of pages you see while navigating through extensive datasets. The default value of `PageCount` property is **8**.

To change the page count in the Syncfusion Grid, you can utilize the [PageSettings.PageCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageCount) property, which defines the number of pages displayed in the pager container.

The following example demonstrates how to change the page count of a Grid using an external button click based on **TextBox** input.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/change-page-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/change-page-count/page.cs %}
{% endhighlight %}
{% endtabs %}

![Change the page count](images/page/change-page-count.png)

### Change the current page

The Syncfusion Grid allows you to change the currently displayed page, which can be particularly useful when you need to navigate through different pages of data either upon the initial rendering of the grid or update the displayed page based on interactions or specific conditions. The default value of `CurrentPage` property is **1**.

To change the current page in the Syncfusion Grid, you can utilize the [PageSettings.CurrentPage](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_CurrentPage) property, which defines the current page number of the pager.

The following example demonstrates how to dynamically change the current page using an external button click based on **TextBox** input:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/change-current-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/change-current-page/page.cs %}
{% endhighlight %}
{% endtabs %}

![Change the current page](images/page/change-current-page.png)

### Add current page in URL as a query string 

The Syncfusion Grid allows you to include the current page information as a query string in the URL. This feature is particularly useful for scenarios where you need to maintain and share the state of the grid's pagination.

To add the current page detail to the URL as a query string in the Syncfusion Grid, you can enable the [EnableQueryString](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_EnableQueryString) property. When this property is set to **true**, it will automatically pass the current page information as a query string parameter along with the URL when navigating to other pages within the grid. 

> By enabling the `EnableQueryString` property, you can easily copy the URL of the current page and share it with others. When the shared URL is opened, it will load the grid with the exact page that was originally shared.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) component is added to enable or disable the addition of the current page to the URL as a query string. When the switch is toggled, the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the `EnableQueryString` property of the grid is updated accordingly.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/add-query-string/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/add-query-string/page.cs %}
{% endhighlight %}
{% endtabs %}

![Add query string ](images/page/change-query-string.png)

## Pager template

The pager template in Syncfusion Grid allows you to customize the appearance and behavior of the pager element, which is used for navigation through different pages of grid data. This feature is particularly useful when you want to use custom elements inside the pager instead of the default elements.

To use the pager template, you need to specify the [PagerTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PagerTemplate) property in your Syncfusion Grid configuration. The `PagerTemplate` property allows you to define a custom template for the pager. Within the template, you can access the [CurrentPage](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_CurrentPage), [PageSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize), [PageCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageCount), **totalPage** and **totalRecordCount** values.

The following example demonstrates how to render a **NumericTextBox** component in the pager using the `PagerTemplate` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pager-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page-template.cs" %}
{% include code-snippet/grid/paging/pager-template/page-template.cs %}
{% endhighlight %}
{% endtabs %}

![Pager template](images/page/pager-template.gif)

## Pager with page size dropdown

The pager with a page size dropdown in Syncfusion Grid allows you to dynamically change the number of records displayed in the grid. This feature is useful when you want to easily customize the number of records to be shown per page.

To enable the page size dropdown feature in the Syncfusion Grid, you need to set the [PageSettings.PageSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) property to **true** in the grid configuration. This property configuration triggers the rendering of a dropdown list within the pager, allowing you to select the desired page size. The selected page size determines the number of records displayed on each page of the grid.

The following example that demonstrates how to integrate the page size dropdown feature by configuring the `PageSizes` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pager-dropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/pager-dropdown/page.cs %}
{% endhighlight %}
{% endtabs %}

![Pager with page size dropdown](images/page/pager-dropdown.png)

> If the `PageSizes` property is set to a boolean value like 'true' or 'false,' the page size dropdown defaults to an array of strings containing options such as ['All', '5', '10', '15', '20'].

### Customize page size dropdown 

The Syncfusion Grid allows you to customize the default values of the page size dropdown in the pager, allowing you to change the number of records displayed per page. To achieve this, you can define the [PageSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) property as an array of string instead of boolean value.

The following example demonstrate how to customize the default values of the pager dropdown using the `PageSizes` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/customize-page-dropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/customize-page-dropdown/page.cs %}
{% endhighlight %}
{% endtabs %}

![Customize page size dropdown](images/page/customize-pager.png)

> The `PageSizes` property can be configured with either an array of strings or a boolean value.

## How to navigate to particular page 

Navigating to a particular page in the Syncfusion Grid is particularly useful when dealing with large datasets. It provides a quick and efficient way to jump to a specific page within the grid.

To achieve page navigation, you can use the `goToPage` method provided by Syncfusion Grid. This method allows you to programmatically navigate to a specific page within the grid.

The following example demonstrates how to dynamically navigate to a particular page using the `goToPage` method triggered by an external button click based on **TextBox** input:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/navigate-particular-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/navigate-particular-page/page.cs %}
{% endhighlight %}
{% endtabs %}

![Navigate to particular page](images/page/navigate-page.png)

## How to get the pager element

You can get pager element in the Syncfusion Grid. This allows you to customize the pager's appearance or behavior to meet the requirements of your application.

`getPager`- This method allows you to obtain a reference to the pager element within the Syncfusion Grid. It returns an HTML element representing the pager.

```ts
    var grid = document.getElementById("grid").ej2_instances[0];
    grid.getPager()
```

## Dynamically calculate page size based on element height

You have an option to dynamically calculate the page size of a grid by considering the height of its parent element. This functionality proves invaluable in ensuring that the grid's content remains within the available space, preventing the need for excessive scrolling. It primarily serves the purpose of automatically adjusting the `PageSize` when the height of the grid's parent element changes dynamically. Upon each alteration in the parent element's height, invoking this method will compute the grid's `PageSize` and present the current page records accordingly. This feature effectively addresses situations where a static `PageSize` value does not cater to the varying heights of different parent elements, preventing any unwanted empty spaces within the grid.

To achieve page size calculation based on an element's height in the Grid, you can utilize the `calculatePageSizeByParentHeight` method. This method calculates the page size based on the height of the parent element.

The following example demonstrates how to calculate the page size based on element height using the `calculatePageSizeByParentHeight` method triggered by a change event based on the **NumericTextBox** input:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/dynamically-calculate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/dynamically-calculate/page.cs %}
{% endhighlight %}
{% endtabs %}

![calculate page size](images/page/calculate-page.png)

## Render pager at the top of the grid 

The Grid component provides built-in support for rendering a pager at the bottom of the grid by default. However, in certain scenarios, you might want to display the pager at the top of the grid. This can be achieved by utilizing the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. This event is triggered when the Grid completes rendering its data. By handling this event, you can customize the rendering of the pager and move it to the top of the Grid.

Here's an example that demonstrates how to render the pager at the top of the grid using the `DataBound` event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/render-pager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/render-pager/page.cs %}
{% endhighlight %}
{% endtabs %}

![render pager at the top of the grid ](images/page/render-pager-top.png)

> During the paging action, the pager component triggers the below three events.
> * The [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event triggers when Pager is created.
> * The `Click` event triggers when the numeric items in the pager is clicked.
> * The `DropDownChanged` event triggers when pageSize DropDownList value is selected.

## Pager events 

The Syncfusion Grid component triggers two pager events during paging actions:

[ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin)-  This event triggered before any paging action (such as changing the page, changing the page size and etc) is initiated. You can use this event to customize or control the behavior of paging actions.

[ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete)- This event triggered after a pager action is completed. It provides information about the action, such as the new page number, page size, and the total number of records. You can use this event to perform actions or update the UI after the operation has been executed.

The following example that example demonstrates how to use these events to display notification messages to indicate the current and next page during paging actions in the Syncfusion ASP.NET MVC Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pager-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="page.cs" %}
{% include code-snippet/grid/paging/pager-events/page.cs %}
{% endhighlight %}
{% endtabs %}

![Pager events](images/page/pager-event.png)
