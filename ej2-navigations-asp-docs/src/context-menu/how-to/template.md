# Template

## Table in Sub ContextMenu

Menu items of the ContextMenu can be customized according to the requirement. The section explains about how to customize table template
in sub menu item.

This can be achieved by appending table layout while `li` rendering by using [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event.

{% aspTab template="context-menu/howto/table", sourceFiles="table.cs" %}

{% endaspTab %}

### UI Components in ContextMenu

UI components can also be placed inside the each `li` element of ContextMenu.

In the following example, CheckBox component is placed inside each `li` element and this can be achieved by creating
CheckBox component in [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event and appending it into the `li` element.

{% aspTab template="context-menu/howto/ui-components", sourceFiles="uicomponents.cs" %}

{% endaspTab %}
