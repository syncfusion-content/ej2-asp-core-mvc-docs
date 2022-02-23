---
title: "How To"
component: "Grid"
description: "Learn how to refresh the datasource, exporting filtered data, enable and disable grid actions, customize the pager dropdown in Essential JS 2 DataGrid."
---

# How To

<!--## Create custom ToolBar with DropDownList

You can create your own ToolBar items in the Grid. It can be added by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) as HTML element ID. Actions for this ToolBar template items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_ToolbarClick_System_String_).

To include components in the ToolBar, please ensure the following steps:

**Step 1**:

Initialize the template for your custom component. Using the following code add the DropDownList component to the ToolBar.

**Step 2**:

To render the DropDownList component, use the [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event of the Grid.

* You can select the grid row index based on the selected data in the DropDownList. The output will appear as follows.

{% aspTab template="grid/how-to/custom-toolbar", sourceFiles="custom-toolbar.cs" %}

{% endaspTab %}-->

## Refresh the data source

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the `refresh` method.

To refresh the data source:

**Step 1**:

Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**:

Refresh the grid after the data source change by using the `refresh` method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% aspTab template="grid/how-to/refresh-datasource", sourceFiles="refresh-datasource.cs" %}

{% endaspTab %}

## Enable/Disable Grid and its actions

You can enable/disable the Grid and its actions by applying/removing corresponding CSS styles.

To enable/disable the grid and its actions, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
        .disablegrid {
            pointer-events: none;
            opacity: 0.4;
        }
        .wrapper {
            cursor: not-allowed;
        }

```

**Step 2**:

Add/Remove the custom CSS class to the Grid in the click event handler of Button.

```typescript
    <script>
        document.getElementById('element').onclick = function () {
            var gridInst = document.getElementById("Grid").ej2_instances[0];
            if (gridInst.element.classList.contains('disablegrid')) {
                gridInst.element.classList.remove('disablegrid');
                document.getElementById("GridParent").classList.remove('wrapper');
            }
            else {
                gridInst.element.classList.add('disablegrid');
                document.getElementById("GridParent").classList.add('wrapper');
            }
        }
    </script>

```

In the below demo, the button click will enable/disable the Grid and its actions.

{% aspTab template="grid/how-to/disablegrid", sourceFiles="disablegrid.cs" %}

{% endaspTab %}

## Print the expanded state from other pages

By default, the expanded child grids will be printed from the current page alone. You can print the expanded child grids from other pages by using the [`load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event.

In the following example, we have printed expanded child grids form other pages.

{% aspTab template="grid/how-to/hierarchyprint", sourceFiles="hierarchyprint.cs" %}

{% endaspTab %}

## Columns

### Change column header text dynamically

You can change the column [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumnBuilder-1.html#Syncfusion_EJ2_Grids_GridColumnBuilder_1_HeaderText_System_String_) dynamically through an external button.

Follow the given steps to change the header text dynamically:

**Step 1**:

Get the column object corresponding to the field name by using the `getColumnByField` method.
Then, change the header text value.

```typescript
var column = grid.getColumnByField("ShipCity"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**:

To reflect the changes in the grid header, invoke the `refreshHeader` method.

```typescript
grid.refreshHeader();

```

{% aspTab template="grid/how-to/column-header-text", sourceFiles="column-header-text.cs" %}

{% endaspTab %}

### Customize column styles

You can customise the appearance of the header and content of a particular column using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

To customize the grid column, follow the given steps:

**Step 1**:

Create a CSS class with custom style to override the default style for rowcell and headercell.

```css
.e-grid .e-rowcell.customcss{
    background-color: #ecedee;
    color: 'red';
    font-family: 'Bell MT';
    font-size: 20px;
}

.e-grid .e-headercell.customcss{
    background-color: #2382c3;
    color: white;
    font-family: 'Bell MT';
    font-size: 20px;
}

```

**Step 2**:

Add the custom CSS class to the specified column by using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

```typescript
<e-grid-column field="Freight" headerText="Freight" width="150"  customAttributes=@(new { @class="customcss" } )></e-grid-column>

```

{% aspTab template="grid/how-to/custom-column-style", sourceFiles="custom-column-style.cs" %}

{% endaspTab %}

### Display custom ToolTip for columns in Grid

To display custom ToolTip (`EJ2 Tooltip`),  use the
[`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_QueryCellInfo_System_String_) event.

Render the ToolTip component for the grid cells by using the following code in the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_QueryCellInfo_System_String_) event.

```typescript
function tooltip (args) {
    var tooltip = new ej.popups.Tooltip({
        content: args.data[args.column.field].toString();
    }, args.cell);
}

```

{% aspTab template="grid/how-to/custom-tooltip", sourceFiles="custom-tooltip.cs" %}

{% endaspTab %}

### Render other components in a column

You can render any component in a grid column using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumnBuilder-1.html#Syncfusion_EJ2_Grids_GridColumnBuilder_1_Template_System_String_) property.

To render other components in the grid, ensure the following steps:

**Step 1**:

Initialize the column template for your custom component.

```typescript
template:`<div>
            <select class="e-control e-dropdownlist">
                <option value="1" selected="selected">Order Placed</option>
                <option value="2">Processing</option>
                <option value="3">Delivered</option>
            </select>
        </div>`

```

**Step 2**:

Using the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_QueryCellInfo_System_String_) event, you can render the DropDown component with the following code.

```typescript
    function dropdown(args) {
        let ele=args.cell.querySelector('select');
        let drop = new ej.dropdowns.DropDownList({popupHeight: 150, popupWidth: 150});
        drop.appendTo(ele);
    }

```

{% aspTab template="grid/how-to/render-other-comp", sourceFiles="grouping-events.cs" %}

{% endaspTab %}

### Change the orientation of the header text

You can change the orientation of the header text by using the [`CustomAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

Ensure the following steps:

**Step 1**:

Create a CSS class with orientation style for the grid header cell.

```css
.orientationcss .e-headercelldiv {
    transform: rotate(90deg);
}

```

**Step 2**:

Add the custom CSS class to a particular column by using the [`CustomAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

```typescript
    <e-grid-column field="ShipCity" headerText="Ship City" width="150" customAttributes=new { class='orientationcss' }"></e-grid-column>

```

**Step 3**:

Resize the header cell height by using the following code.

```typescript
function setHeaderHeight(args) {
    var textWidth = document.querySelector(".orientationcss > div").scrollWidth;//Obtain the width of the headerText content.
    var headerCell = document.querySelectorAll(".e-headercell");
    for(var i = 0; i < headerCell.length; i++) {
        headerCell.item(i).style.height = textWidth + 'px'; //Assign the obtained textWidth as the height of the headerCell.
    }
}

```

{% aspTab template="grid/how-to/orientation", sourceFiles="orientation.cs" %}

{% endaspTab %}

### Customize the icon for column menu

You can customize the column menu icon by overriding the default grid class `.e-icons.e-columnmenu` with a custom property `content` as mentioned below,

```css
.e-grid .e-columnheader .e-icons.e-columnmenu::before {
              content: "\e941";
      }
```

In the below sample, grid is rendered with a customized column menu icon.

{% aspTab template="grid/how-to/custom-column-menu-icon", sourceFiles="column-icon.cs" %}

{% endaspTab %}

## Editing

### Perform CRUD operation using anti-forgery token

Anti-forgery token is used between the client and server to prevent cross-site request forgery (CSRF) attack. For more information on preventing CSRF attack, please refer to the [link]( https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-2.1#authentication-fundamentals).

While performing grid save operation, you can send anti-forgery token along with the save request using the below custom adaptor.

This custom adaptor will read the anti-forgery token from the hidden element and send it along with the request. Also content type is set to `application/x-www-form-urlencoded; charset=UTF-8` since the `ValidateAntiForgeryToken` will look for the token in the form encoded data.

```javascript
<script>

    window.customAdaptor = new ej.data.UrlAdaptor();

    customAdaptor = ej.base.extend(customAdaptor, {

        processResponse: function (data, ds, query, xhr, request, changes) {
            request.data = JSON.stringify(data);
            return ej.data.UrlAdaptor.prototype.processResponse.call(this,data, ds, query, xhr, request, changes);
        },
        insert: function (dm, data, tableName) {
            return {
                url: dm.dataSource.insertUrl || dm.dataSource.crudUrl || dm.dataSource.url,
                data: $.param({
                    //Added the anti-forgery token.
                    __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
                    value: data,
                    table: tableName,
                    action: 'insert'
                }),
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
            }
        },
        update: function (dm, keyField, value, tableName) {
            return {
                url: dm.dataSource.updateUrl || dm.dataSource.crudUrl || dm.dataSource.url,
                data: $.param({
                    //Added the anti-forgery token.
                    __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
                    value: value,
                    table: tableName,
                    action: 'insert'
                }),
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
            };
        },
    });
</script>

```

Now assign the custom adaptor to the grid as follows.

```javascript

<script>
    function load(args) {
        this.dataSource.adaptor = customAdaptor;
    }
</script>

```

{% aspTab template="grid/how-to/anti-forgery-token", sourceFiles="anti-forgery-token.cs" %}

{% endaspTab %}

> You can find the full sample at our [GitHub repository](https://github.com/SyncfusionSamples/ej2-mvc-grid-antiforgerytoken).

### Editing with template column

You can edit the template column value by defining the `Field` for that particular column.

In the below demo, the `ShipCountry` column is rendered with the template.

{% aspTab template="grid/how-to/edit-temp", sourceFiles="edit-temp.cs" %}

{% endaspTab %}

### Customize the Edit Dialog

You can customize the appearance of the edit dialog in the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_ActionComplete_System_String_) event based on `requestType` as `beginEdit` or `add`.

In the below example, we have changed the dialog's header text for editing and adding records.

{% aspTab template="grid/edit/customizedialog", sourceFiles="*.cs" %}

{% endaspTab %}

### Show or Hide columns in Dialog editing

You can show hidden columns or hide visible column's editor in the dialog while editing the grid record using [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) events.

In the `actionBegin` event, based on `requestType` as `beginEdit` or  `add`. We can show or hide the editor by using `column.visible` property.

In the `actionComplete` event, based on `requestType` as `save`. We can reset the properties back to the column state.

In the below example, we have rendered the grid columns `CustomerID` as hidden column and `ShipCountry` as visible column. In the edit mode, we have changed the `CustomerID` column to visible state and `ShipCountry` column to hidden state.

{% aspTab template="grid/edit/show-hide-edit-dialog", sourceFiles="*.cs" %}

{% endaspTab %}

<!-- ## Cascading DropDownList with Grid editing

You can achieve the Cascading DropDownList with grid Editing by using the Cell Edit Template feature.

In the below demo, Cascading DropDownList is rendered for the `ShipCountry` and `ShipState` column.

{% aspTab template="grid/how-to/cascading", sourceFiles="cascading.cs" %}

{% endaspTab %} -->

### Provide custom data source and enabling filtering to DropDownList

You can provide data source to the DropDownList by using the `columns.edit.params` property.

While setting new data source using edit params, you must specify a new `query` property too for the DropDownList as follows,

```typescript
@{
    var DropDownList = new Syncfusion.EJ2.DropDowns.DropDownList() { DataSource = ViewBag.DropDownData, Query = "new ej.data.Query()", Fields = new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings() { Value = "Country", Text = "Country" }, AllowFiltering = true, ActionComplete="actionComplete" };
}
{
    col.Field("ShipName").HeaderText("ShipName").Width("150").EditType("dropdownedit").Edit(new { @params = DropDownList }).Add();
}
```

You can also enable filtering for the DropDownList by passing the `allowFiltering` as `true` to the edit params.

In the below demo, DropDownList is rendered with custom Datasource for the `ShipCountry` column and enabled filtering to search DropDownList items.

{% aspTab template="grid/how-to/dropdown-edit", sourceFiles="edit-dropdownlist.cs" %}

{% endaspTab %}

### Access Editor components

You can access the component instance from the component element using the `ej2_instances` property.

In the below demo, you can access the Editor component instance while adding or editing actions on the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_ActionComplete_System_String_) event.

{% aspTab template="grid/how-to/access-editor", sourceFiles="access-editor.cs" %}

{% endaspTab %}

### Use Wizard like Dialog Editing

Wizard helps you create intuitive step-by-step forms to fill. You can achieve the wizard like editing by using the dialog template feature. It support your own editing template by defining [`EditSettings.Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) as `Dialog` and [`EditSettings.Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the wizard like editing in the grid with the obtrusive Validation.

The following example demonstrate the wizard like editing in grid.

{% aspTab template="grid/edit/wizardediting", sourceFiles="*.cs" %}

{% endaspTab %}

### Using Tab Inside the Dialog Template

You can use [`tab`](../../../tab/index.html) component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`EditSettings.Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) as `Dialog` and [`EditSetting.Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% aspTab template="grid/edit/tabediting", sourceFiles="*.cs" %}

{% endaspTab %}

### Disable editing for a particular row/cell

You can disable the editing for a particular row by using the `ActionBegin` event of Grid.

In the below demo, the rows which are having the value for `ShipCountry` column as "Denmark" is prevented from editing.

{% aspTab template="grid/how-to/disable-edit", sourceFiles="disable-edit.cs" %}

{% endaspTab %}

For batch mode of editing, you can use `CellEdit` event of Grid. In the below demo, the cells which are having the value as "Denmark" is prevented from editing.

{% aspTab template="grid/how-to/disable-edit-batch", sourceFiles="disable-edit-batch.cs" %}

{% endaspTab %}

### Perform Grid actions by keyboard shortcut keys

Using keyboard shortcuts, Grid performs navigation and actions.

In addition, You can also perform grid actions with custom keyboard shortcuts. This operation has to be achieved outside of the grid with the help of `keydown` event.

The following example demonstrates on `Adding` a new row when `Enter` key is pressed in the grid.

{% aspTab template="grid/edit/keyboard-actions", sourceFiles="*.cs" %}

{% endaspTab %}

### Make a cell editable on a single click with batch editing

You can make a cell editable on a single click with `batch` mode of editing in Grid, by using the [`editCell`](https://ej2.syncfusion.com/documentation/api/grid/edit/#editcell/) method.

Bind the click event for the Grid and in the click event handler call the [`editCell`](https://ej2.syncfusion.com/documentation/api/grid/edit/#editcell/) method, based on the clicked target element.

{% aspTab template="grid/how-to/editable-single-click", sourceFiles="editable-single-click.cs" %}

{% endaspTab %}

## Filter

### Customizing filter menu operators list

 You can customize the default filter operator list by defining the `FilterSettings.Operators` property.
The available options are:
* `stringOperator`- defines customized string operator list.
* `numberOperator` - defines customized number operator list.
* `dateOperator` - defines customized date operator list.
* `booleanOperator` - defines customized boolean operator list.

In the following sample, we have customized string filter operators.

{% aspTab template="grid/how-to/customize-filter-menu", sourceFiles="customize-filter-menu.cs" %}

{% endaspTab %}

## Sort

### Perform single/multi sorting dynamically

You can perform single-column or multi-column sorting dynamically through an external button.

To perform single-column sorting, use the [`sortColumn`](https://ej2.syncfusion.com/documentation/api/grid/#sortcolumn/) method of Grid.

```typescript
    document.getElementById('SingleSort').addEventListener('click', () => {
        var grid = document.getElementById("Grid").ej2_instances[0];
        grid.sortColumn("OrderID", "Descending")
    });
```

To perform multi-column sorting, you need to push the columns to be sorted into the [`sortSettings.columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns).

```typescript
    document.getElementById('MultiSort').addEventListener('click', () => {
        var grid = document.getElementById("Grid").ej2_instances[0];
        grid.sortModule.sortSettings.columns.push({ field: 'ShipCountry', direction: 'Ascending' }, { field: 'CustomerID', direction: 'Descending' });
        grid.refresh();
    });
```

In the below demo, click on the corresponding button to perform single-column or multi-column sorting.

{% aspTab template="grid/how-to/dynamicsort", sourceFiles="dynamicsort.cs" %}

{% endaspTab %}

### Dynamically clear sort for particular/entire sorted columns in Grid

You can clear the sorting for a particular column or the entire sorted columns in Grid dynamically through an external button.

To clear sort for a particular column, you need to splice the particular column from the [`sortSettings.columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns).

```typescript
    document.getElementById('SingleClearSort').addEventListener('click', () => {
        var grid = document.getElementById("Grid").ej2_instances[0];
        var column = grid.sortModule.sortSettings.columns;
        for(var i=0;i < column.length;i++){
            if(column[i].field == "OrderID") {
                column.splice(i,1);
                grid.refresh();
            }
        }
    });
```

To clear sorting for all the sorted columns, use the [`clearSorting`](https://ej2.syncfusion.com/documentation/api/grid/#clearsorting/) method of Grid.

```typescript
    document.getElementById('MultiClearSort').addEventListener('click', () => {
        var grid = document.getElementById("Grid").ej2_instances[0];
        grid.clearSorting();
    });
```

In the below demo, click on the corresponding button to clear sort for particular or entire sorted columns in Grid.

{% aspTab template="grid/how-to/dynamicclearsort", sourceFiles="dynamicclearsort.cs" %}

{% endaspTab %}

## Foreign Key

### Use Edit Template in Foreign Key Column

By default, foreign key column uses dropdown component for editing. You can render other than the dropdown by using the [`Column.Edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property. The following example demonstrates the way of using edit template in foreign column.

In the following example, The `Employee Name` is a foreign key column and while editing, AutoComplete component is rendered instead of DropDownList.

{% aspTab template="grid/how-to/edit-template-foreign", sourceFiles="edit-template-foreign.cs" %}

{% endaspTab %}

### Customize filter UI in foreign key column

You can create your own filtering UI by using [`Column.Filter`](https://helpsyncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Grids.GridColumn~Filter.html) property. The following example demonstrates the way to create a custom filtering UI in the foreign column.

In the following example, The `Employee Name` is a foreign key column. DropDownList is rendered using Filter UI.

{% aspTab template="grid/how-to/filter-ui-foreign", sourceFiles="filter-ui-foreign.cs" %}

{% endaspTab %}

### Use filter bar template in foreign key column

You can use the filter bar template in foreign key column by defining the [`column.FilterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) property. The following example demonstrates the way to use filter bar template in foreign column.

In the following example, The `Employee Name` is a foreign key column. This column header shows the custom filter bar template and you can select filter value by using the `DropDown` options.

{% aspTab template="grid/how-to/filterbar-temp-foreign", sourceFiles="filterbar-temp-foreign.cs" %}

{% endaspTab %}

### Perform aggregation in Foreign Key Column

Default aggregations are not supported in a foreign key column. You can achieve aggregation for the foreign key column by using the custom aggregates. The following example demonstrates the way to achieve aggregation in foreign key column.

In the following example, The `Employee Name` is a foreign key column and the aggregation for the foreign column was calculated in customAggregateFn.

{% aspTab template="grid/how-to/aggregate-foreign", sourceFiles="aggregate-foreign.cs" %}

{% endaspTab %}

## Exporting

### Exporting Filtered Data Only

You can export the filtered data by defining the resulted data in `exportProperties.dataSource` before export.

In the below Pdf exporting demo, We have gotten the filtered data by applying filter query to the grid data and then defines the resulted data in `exportProperties.dataSource` and pass it to `pdfExport` method.

{% aspTab template="grid/how-to/export-filtered-data", sourceFiles="export-filtered-data.cs" %}

{% endaspTab %}

## Pager

### Customize Pager DropDown

To customize default values of pager dropdown, you need to define `pageSizes` as array of strings.

{% aspTab template="grid/how-to/pagerdropdown", sourceFiles="pagerdropdown.cs" %}

{% endaspTab %}

## Hide the expand/collapse icon in parent row when no records in child grid

By default, the expand/collapse icon will be visible even if the child grid is empty.

You can use `rowDataBound` event to hide the icon when there are no records in child grid.

To hide the expand/collapse icon in parent row when no records in child grid, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
    .e-row[aria-selected="true"] .e-customizedExpandcell {
        background-color: #e0e0e0;
    }

    .e-grid.e-gridhover tr[role='row']:hover {
        background-color: #eee;
    }

```

**Step 2**:

Add the CSS class to the Grid in the `rowDataBound` event handler of Grid.

```typescript

    function rowDataBound(args) {
        var filter = args.data.EmployeeID;
        var data = new ej.data.DataManager(this.childGrid.dataSource).executeLocal(new ej.data.Query().where("EmployeeID", "equal", parseInt(filter), true));
        if (data.length == 0) {
            //here hide which parent row has no child records
            args.row.querySelector('td').innerHTML = " ";
            args.row.querySelector('td').className = "e-customizedExpandcell";
        }
    }

```

In the below demo, the expand/collapse icon in the row with `EmployeeID` as `1` is hidden as it does not have record in child Grid.

{% aspTab template="grid/how-to/hidearrow", sourceFiles="hidearrow.cs" %}

{% endaspTab %}

## Render both EJ1 and EJ2 Grids in same application

To achieve this requirement, you need to use the below code in `_Layout.cshtml` page. Because EJ1 and EJ2 has same library names to perform the different actions. So conflicts may occur when we refer this both controls in same application. To overcome this we need to extend this libraries in ej namespace.

```javascript
<script>
    var dataCopy = Object.assign({}, ej.data);
    $.extend(ej, Syncfusion);
    $.extend(ej.data, dataCopy);
</script>
```

The Layout page looks like

```html
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    @* Syncfusion Essential JS 1 Styles *@
    @Styles.Render("http://cdn.syncfusion.com/16.3.0.21/js/web/flat-azure/ej.web.all.min.css")
    @* Syncfusion Essential JS 2 Styles *@
    @Styles.Render("https://cdn.syncfusion.com/ej2/styles/compatibility/material.css")
</head>

<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/Scripts/jsrender.min.js")
    @* Syncfusion Essential JS 1 Scripts *@
    @Scripts.Render("~/Scripts/ej/web/ej.web.all.min.js")
    @* Syncfusion Essential JS 2 Scripts *@
    @Scripts.Render("~/Scripts/ej2/ej2.min.js")
    @RenderSection("scripts", required: false)

    <script>
        var dataCopy = Object.assign({}, ej.data);
        $.extend(ej, Syncfusion);
        $.extend(ej.data, dataCopy);
    </script>

    <div class="container body-content">
        @RenderBody()
    </div>

    @Html.EJ().ScriptManager()
    @Html.EJS().ScriptManager()
</body>
</html>
```

## How to import localization scripts into grid

For `Internationalization` and `localization` usage in grid, you need to include cldr files into your application. Please find the steps to include the cldr-data in your application.

You need to download cldr-data globally in any location by using below command.

```bash
npm install cldr-data
```

After installing cldr-data, you can find cldr-data for all locale in this location.

```bash
node_modules->cldr-data->main
```

You need to copy the required(or all) locale cldr-data and paste into your application folder.

```bash
Scripts->cldr->main->paste copied cldr files
```

You need to include cldr-data into your application and refer file location in `index.cshtml` file.

{% aspTab template="grid/how-to/localization-scripts", sourceFiles="localization-scripts.cs" %}

{% endaspTab %}

## Render Grid from Controller

To render grid from controller, We need to create instance for Grid model class. Also we need to define the values for the Grid properties by using this instance. Once the values are defined, we need to return the Grid instance in `view` to render the Grid in view page.

{% aspTab template="grid/how-to/render-grid-from-server", sourceFiles="controller.cs" %}

{% endaspTab %}