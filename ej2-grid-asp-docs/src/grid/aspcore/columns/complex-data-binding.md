# Complex Data Binding

You can achieve complex data binding in the grid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column** tag helper.

{% aspTab template="grid/columns/complexbinding", sourceFiles="complexbinding.cs" %}

{% endaspTab %}

For OData and ODataV4 adaptors, you need to add [`expand`](https://ej2.syncfusion.com/documentation/api/data/query/#expand) query to the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property (of Grid), to eager load the complex data.

{% aspTab template="grid/columns/query", sourceFiles="query.cs" %}

{% endaspTab %}