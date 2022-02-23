# Group and Caption Aggregate

Group and caption aggregate values are calculated from the current group items.
If [`GroupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate) is provided, the aggregate values are displayed in the group footer cells; and if [`GroupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate)
 is provided, aggregate values are displayed in the group caption cells.

{% aspTab template="grid/aggregate/group-caption", sourceFiles="group-caption.cs" %}

{% endaspTab %}

> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property of [`GridAggregate Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html) name.