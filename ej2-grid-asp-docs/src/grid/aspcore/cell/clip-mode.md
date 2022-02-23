# Clip Mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`clipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) property of **e-grid-column** tag helper.

There are three types of **ClipMode**. They are:

* **Clip**: Truncates the cell content when it overflows its area.
* **Ellipsis**: Displays ellipsis when the cell content overflows its area.
* **EllipsisWithTooltip**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

{% aspTab template="grid/cell/clipmode", sourceFiles="clipmode.cs" %}

{% endaspTab %}

>By default, [`clipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) value is **Ellipsis**.