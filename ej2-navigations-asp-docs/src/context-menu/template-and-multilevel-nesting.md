# Template and Multilevel nesting

## Template

The ContextMenu items can be customized by using the [`Render`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html)
event. The item render event triggers while rendering each menu item. The event argument will be used to identify the menu
item and customize it based on the requirement. In the following sample, the menu item is rendered with keycode for specified action in ContextMenu using the template. Here, the keycode is specified for Save as,
View page source, and Inspect in the right side corner of the menu items by adding span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event.

{% aspTab template="context-menu/template", sourceFiles="template.cs" %}

{% endaspTab %}

## Multilevel nesting

The Multiple level nesting supports in ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Items.html)
property inside the parent [`menuItems`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem.html). In the below sample, three level nesting of ContextMenu is provided.

{% aspTab template="context-menu/nesting", sourceFiles="nesting.cs" %}

{% endaspTab %}

## See Also

* [Populate menu items with data source](./how-to#data-binding)