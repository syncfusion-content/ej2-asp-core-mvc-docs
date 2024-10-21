---
layout: post
title: Column Headers in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Headers in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Headers in ASP.NET MVC Grid component

The Syncfusion ASP.NET MVC Grid component provides a comprehensive set of options to customize and manage headers efficiently. Headers play a crucial role in organizing and presenting data effectively in the grid.

## Header text

The `HeaderText` feature proves particularly beneficial when there is a need for more meaningful and descriptive column headers in the Syncfusion ASP.NET MVC Grid component.

By default, the header text of a column in Grid is displayed from the column's `Field` value. However, you can easily override the default header title and provide a custom header text for the column using the `HeaderText` property. 

To enable the `HeaderText` property, you simply need to define it in the **e-grid-column** element. The following example demonstrates how to enable header text for a  Grid column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Header text](../images/columns/Column-headertext.png)

> * If both the `Field` and `HeaderText` are not defined in the column, the column renders with **empty** header text.
> * The `HeaderText` property is optional, and if it is not defined, then the corresponding column's field value is set as header text for that column.  
> * You can also use the `HeaderTemplate` property to apply custom HTML content to the header cell.

## Header template

The header template feature in the Syncfusion ASP.NET MVC Grid component allows you to create custom header layouts and content, providing enhanced functionality such as sorting or filtering.

To implement a header template, set the `HeaderTemplate` property within a specific column definition. This allows you to render custom HTML elements or ASP.NET MVC components to the header.

The following example demonstrate, the custom element is rendered for both **CustomerID**,**Freight** and **OrderDate** column headers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/grid/columns/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Header template](../images/columns/Column-headertext-headerTemplate.png)

>* The `HeaderTemplate` property is only applicable to Grid columns that have a header element.
>* You can use any HTML or ASP.NET MVC component in the header template to add additional functionality to the header element.

## Stacked header 

In Grid, you can group multiple levels of column headers by stacking the Grid columns. This feature allows you to organize the Grid columns in a more structured and understandable way. This can be achieved by setting the [columns->columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) property. Within this property, you can define an array of column objects to group together as sub-headers under a main header. You can define the `HeaderText` property of each sub-header column to set the text for that sub-header.

You can customize the appearance of the stacked header elements by using the `HeaderTemplate` property. This allows you to render custom HTML elements or ASP.NET MVC components to the header. 

Here's an example of how to use stacked headers with a custom `HeaderTemplate` in Syncfusion Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-stacked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedheader.cs" %}
{% include code-snippet/grid/columns/headertext-stacked/stackedHeader.cs %}
{% endhighlight %}
{% endtabs %}

![Stacked header](../images/columns/Column-headertext-stacked.png)

## Align the text of header text

You can horizontally align the text in column headers of the Grid component using the `HeaderTextAlign` property. By default, the text is aligned to the left, but you can change the alignment by setting the value of the `HeaderTextAlign` property to one of the following options:

* **Left**: Aligns the text to the left (default).
* **Center**: Aligns the text to the center.
* **Right**: Aligns the text to the right.
* **Justify**: Header text is justified.

The following example demonstrates how to dynamically change the alignment of the header text based on DropDown change:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-textalign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-textalign/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Align the text of header text](../images/columns/Column-headertext-change-alignment.gif)

>* The `HeaderTextAlign` property only changes the alignment of the text in the column header, and not the content of the column. If you want to align both the column header and content, you can use the [TextAlign](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.TextAlign.html) property.
>* You can also use the `HeaderTextAlign` property with the stacked header feature in Syncfusion Grid. The property will align the header text in the sub-headers as well.

## Autowrap the header text

The autowrap allows the cell content of the grid to wrap to the next line when it exceeds the boundary of the specified cell width. The cell content wrapping works based on the position of white space between words. To support the Autowrap functionality in Syncfusion Grid, you should set the appropriate [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) for the columns. The column width defines the maximum width of a column and helps to wrap the content automatically.

To enable autowrap, set the [AllowTextWrap](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to **true**. You can also configure the auto wrap mode by setting the [TextWrapSettings.WrapMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) property.

Grid provides the below three options for configuring:

* **Both**: This is the default value for wrapMode. With this option, both the grid header text and content is wrapped.
* **Header**: With this option, only the grid header text is wrapped.
* **Content**: With this option, only the grid content is wrapped.

>* If a column width is not specified, then the Autowrap of columns will be adjusted with respect to the grid's width.
>* If a column's header text contains no white space, the text may not be wrapped.
>* If the content of a cell contains HTML tags, the Autowrap functionality may not work as expected. In such cases, you can use the `HeaderTemplate` and `Template` properties of the column to customize the appearance of the header and cell content.

The following example demonstrates how to dynamically change the auto-wrap of the header text based on DropDown change.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-autowrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-autowrap/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Autowrap the header text](../images/columns/Column-headertext-wrap-mode.png)

## Change the height of header

Changing the height of the header can be useful in cases where the default height is not sufficient to display the header content cell. For example, if you have a header with a lot of text or if you want to add an image to the header, you may need to increase the height of the header to accommodate the content.This can be easily achieved by changing the height of the header using CSS or by dynamically adjusting the height using a methods.

**Using css**

You can use CSS to override the default height of the **.e-grid .e-headercell** class to change the height of the header. Here is an example code snippet:

```css
.e-grid .e-headercell {
  height: 130px;
}
```

**Using methods**

To change the height of the header dynamically, you can use the `getHeaderContent` method to get the header content element of the Syncfusion Grid. Then, you can use the **querySelectorAll** method to get all the header cell elements with the class **e-headercell**. Finally, you can loop through each header cell element and set its style property to adjust the height.

The following example demonstrates how to dynamically change the height of the header based on a Button `click` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-change-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-change-height/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Change the height of header](../images/columns/Column-headertext-change-height.gif)

>* You can also use the `GetHeaderTable` method to get the table element of the header, and then adjust the height.
>* You cannot change the height of row below the default height of 42px using the **e-columnheader** class.

## Change header text dynamically

The Syncfusion Grid component provides a way to modify the header text of a corresponding column in real-time based on events or other events. This feature can be useful in various scenarios, such as displaying a custom header text for a specific column or updating the header text dynamically based on input. By allowing for dynamic changes to the header text, the Grid provides a more flexible and customizable experience.

**Using Event**

To modify the header text of a corresponding column dynamically, you can use the [HeaderCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event provided by the Syncfusion Grid. This event is triggered for each header cell element rendered in the Grid.

When the `HeaderCellInfo` event is triggered, it provides a **HeaderCellInfoEventArgs** object as a parameter. This object contains the following properties:

* **cell**: Defines the header cell that is being modified.
* **node**: Defines the DOM element of the header cell that is being modified.

You can use these properties to access and modify the header text of the corresponding column. Once the header text is modified, you can refresh the Grid to reflect the changes by calling the `refreshHeader` method of the Grid.

**Using method**

The Grid component provides several methods that allow you to change the column header text dynamically. Here are some of the methods you can use:

1. `getColumnByField`: This method takes a field name as a parameter and returns the entire column object that corresponds to that field name, including properties such as headerText, width, and alignment. You can use this method to modify any aspect of the column.

2.	`getColumnHeaderByField`: Retrieves the header element of a column based on its field name. You can modify the **textContent** property of the header element to change the header text. This method does not return a reference to the column object itself, only to the header element.

3.	`getColumnIndexByField`: Retrieves the index of a column based on its field name. You can then use the `getColumnByIndex` method to retrieve the column object and modify its `HeaderText` property to change the header text.

4.	`getColumnByUid`: Retrieves the column object based on its unique identifier (UID). You can modify the `HeaderText` property of the column object to change the header text.

5.	`getColumnHeaderByIndex`: Retrieves the header element of a column based on its zero-based index. You can modify the **textContent** property of the header element to change the header text. This method does not return a reference to the column object itself, only to the header element.

6.	`getColumnIndexByUid`: Retrieves the index of a column based on its unique identifier (UID). You can then use the `getColumnByIndex` method to retrieve the column object and modify its `HeaderText` property to change the header text.

7.	`getColumnHeaderByUid`: Retrieves the header element of a column based on its unique identifier (UID). You can modify the **textContent** property of the  header element to change the header text. This method does not return a reference to the column object itself, only to the header element.If you only have an `Template` for the column header, and the column itself is not defined with a `Field` , then you can use the `getColumnHeaderByUid` method to get a reference to the header element and modify its text content to change the header text.
	
>* When you change the header text dynamically, you need to **refresh** the Grid to reflect the changes by calling the `refreshHeader` method.
>* The UID is automatically generated by the Grid component and may change whenever the grid is refreshed or updated.

Here is an example of how to change the header text of a column using the `getColumnByField` method:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-change/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columntext.cs" %}
{% include code-snippet/grid/columns/headertext-change/columntext.cs %}
{% endhighlight %}
{% endtabs %}

![Change header text dynamically](../images/columns/Column-headertext-change.png)


**Changing the header text of all columns**

If you want to change the header text of all columns in the grid, you can loop through the Columns collection of the grid and set the `headerText` property for each column. Here is an example:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-change-all/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columntext.cs" %}
{% include code-snippet/grid/columns/headertext-change-all/columntext.cs %}
{% endhighlight %}
{% endtabs %}

![Changing the header text of all columns](../images/columns/Column-headertext-change-all.gif)

## Change the orientation of header text

By default, the text in the column headers of the Syncfusion Grid control is oriented horizontally. However, in some cases, you may want to change the orientation of the header text to vertical, diagonal, or at a custom angle. This can be achieved by adding a custom CSS class to the column header cell using the `CustomAttributes` property of the Grid columns.

Follow the below steps to change the orientation of the header text in Grid:

**Step 1**: **Create a CSS class with orientation style for grid header cell**

To `rotate` the header text, you can create a CSS class with the `transform` property that rotates the header text 90 degrees. This class will be added to the header cell using the `CustomAttributes` property.

```css
.orientationcss .e-headercelldiv {
    transform: rotate(90deg);
}
```

**Step 2**: **Add the custom CSS class to the grid column**

Once you have created the CSS class, you can add it to the particular column by using the `CustomAttributes` property. This property allows you to add any custom  attribute to the grid column.

For example, to add the orientation class to the Freight column, you can use the following code:

```typescript
    col.Field("Freight").HeaderText("Freight").Width("120").Format("C").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Center).CustomAttributes(new { @class = "orientationcss" }).Add();
```

**Step 3**: **Resize the header cell height**

After adding the custom CSS class to a column, you need to resize the header cell height so that the rotated header text is fully visible. You can do this by using the following code:

```typescript

    function setHeaderHeight(args) {
        var textWidth = document.querySelector(".orientationcss > div").scrollWidth; // obtain the width of the headerText content.
        var headerCell = document.querySelectorAll(".e-headercell");
        for (var i = 0; i < headerCell.length; i++) {
            headerCell.item(i).style.height = textWidth + 'px'; // assign the obtained textWidth as the height of the headerCell.
        }
    }

```

The following example demonstrates how to change the orientation of the **Freight** column header text to 90 degrees:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-orientation/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Change the orientation of header text](../images/columns/Column-headertext-orientation.png)

## Custom tooltip for header

Custom tooltips for headers provide additional information when hovering over a column header in the Syncfusion Grid. This can be useful in situations where there is not enough space to display all of the information related to a column, or when there is additional context that may be helpful.

To enable custom tooltips for headers, you can use the `BeforeRender` event of the Grid component. This event is triggered for each header cell before it is rendered, allowing you to add a custom tooltip to the header cell using `tooltip` component.

Here's an example of how to use the `BeforeRender` event to add a custom tooltip to a header cell:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-tooltip/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Custom tooltip for header](../images/columns/Column-headertext-tooltip.png)

> * The [HeaderCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event can also be used to customize the header tooltip. This event is triggered for each header cell after it is rendered.

## Customize header text styles 

Customizing the grid header styles allows you to modify the appearance of the column header in the Grid control to meet your design requirements. You can customize the font, background color, and other styles of the header cells. To customize the header styles in the grid, you can use CSS, properties, methods, or event support provided by the Syncfusion ASP.NET MVC Grid component.

### Using CSS

You can apply styles to the header cells using CSS selectors. The Grid provides a class name for each header cell element, which you can use to apply styles to that specific header cell. The **.e-headercell** class can be used to change the background color and text color of the column header.

```CSS
  .e-grid .e-headercell {
    background-color: #a2d6f4;
    color:rgb(3, 2, 2);
  }
```
Here's an example that demonstrates how to customize the appearance of a column header in the Grid using **className**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-using-css/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-using-css/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Display HTML content](../images/columns/Column-headertext-using-css.png)

### Using property 

You can customize the appearance of the column headers in Grid using the `CustomAttributes` property. The `CustomAttributes` property takes an object with the name-value pair to customize the CSS properties for grid header cells. You can also set multiple CSS properties to the custom class using the `CustomAttributes` property.

To customize the header of a column, you can follow the steps below:

Step 1: Define a CSS class that specifies the styles you want to apply to the header cell of the column. For example, to change the background color and text color of the header cell, define a CSS class like this:

  ```CSS
    .e-grid .e-headercell.custom {
       background-color: rgb(43, 205, 226);
       color: black;
    }

  ```

Step 2: Set the **CustomAttributes** property of the desired column to an object that contains the CSS class **custom**. This CSS class will be applied to the header cell of the specified column in the Grid.

  ```ts
    col.Field("Freight").HeaderText("Freight").Width("120").CustomAttributes(new { @class = "custom" }).Format("C").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
  ```

The following example demonstrates how to customize the appearance of the **OrderID** and **OrderDate** columns using custom attributes.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-using-property/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-using-property/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Using property](../images/columns/Column-headertext-using-property.png)

### Using method 

The Syncfusion Grid provides methods to customize the appearance of the grid columns header.

1. `getColumnHeaderByIndex`: The method is used to customize the appearance of a specific column header in the grid by specifying the index of the column for which you want to customize the header.

2. `getColumnHeaderByField`: This method is used to retrieve the header element of a specific column by its field name. You can use the retrieved element to customize the appearance of the header element.
3. `getColumnHeaderByUid`: This method is used to retrieve the header element of a specific column by its unique ID. You can use the retrieved element to customize the appearance of the header element.

 4. `getColumnIndexByField`:This method is used to retrieve the index of a specific column by its field name. You can use the retrieved index to access the header element and customize its appearance.

 5. `getColumnIndexByUid`: This method is used to retrieve the index of a specific column by its unique ID. You can use the retrieved index to access the header element and customize its appearance.

Here's an example of how to use these methods to change the style of a specific column header:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-using-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-using-method/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Using method](../images/columns/Column-headertext-using-method.png)

>* The UID is automatically generated by the Grid component and may change whenever the grid is refreshed or updated.

### Using event

To customize the appearance of the grid header, you can handle the [HeaderCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event of the grid. This event is triggered when each header cell is rendered in the grid, and provides an object that contains information about the header cell. You can use this object to modify the styles of the header column.

The following example demonstrates how to add a `HeaderCellInfo` event handler to the grid. In the event handler, checked whether the current header column is **Order Date** field and then applied the appropriate CSS class to the cell based on its value.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-using-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-using-event/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![Using event](../images/columns/Column-headertext-using-event.png)

## How to refresh header 

The refresh header feature in the Syncfusion ASP.NET MVC Grid allows you to update the header section of the grid whenever changes are made to the grid's columns. This feature is useful when you want to reflect changes in the header immediately, such as modifying the column header text, width, or alignment.

To use the refresh header feature, you can call the `refreshHeader` method of the Grid component. This method updates the grid header with the latest changes made to the columns.

The following example demonstrates how to use the `refreshHeader` method to update the grid header:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext-refresh/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext-refresh/headertext.cs %}
{% endhighlight %}
{% endtabs %}

![How to refresh header](../images/columns/Column-headertext-refresh-header.png)

>* The `refreshHeader` method updates only the grid header and not the entire grid.
>* If you want to refresh the entire grid, you can use the `refresh` method instead.

## How to get header element 

To get the header element in a Syncfusion Grid, you can use one of the following methods:

1. `getHeaderContent`: This method returns the header div element of the Grid. You can use this method to access the entire header content of the Grid.

    ```ts
    var grid = document.getElementById("Grid").ej2_instances[0]
    const headerTableElement=grid.getHeaderContent();    
    ```
2. `getHeaderTable`: This method returns the header table element of the Grid. You can use this method to access only the header table of the Grid.

   ```ts
    var grid = document.getElementById("Grid").ej2_instances[0]
    const headerTableElement = grid.getHeaderTable();
   ```

3. `getColumnHeaderByUid`: This method returns the column header element by its unique identifier.

   ```ts
    var grid = document.getElementById("Grid").ej2_instances[0]
    const columnHeaderElement = grid.getColumnHeaderByUid("e-grid2");
   ```

4. `getColumnHeaderByIndex`: This method returns the column header element by its index.

   ```ts
    var grid = document.getElementById("Grid").ej2_instances[0]
    const columnHeaderElement = grid.getColumnHeaderByIndex(0);
   ```
5. `getColumnHeaderByField`: This method returns the column header element by its field name.

   ```ts
    var grid = document.getElementById("Grid").ej2_instances[0]
    const columnHeaderElement = grid.getColumnHeaderByField("OrderID"); 
   ```

>* The UID is automatically generated by the Grid component and may change whenever the grid is refreshed or updated.