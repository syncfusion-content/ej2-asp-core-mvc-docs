# Getting Started

This section briefly explains about how to include a simple ContextMenu in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ContextMenu to the project

We are going to render `ContextMenu` component in **Index.cshtml** page.

{% aspTab template="context-menu/getting-started/demo" %}

{% endaspTab %}

`ViewBag.menuItems` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the menu items in `ContextMenu` by using the `items` property. Here, the JSON values are passed to the
ContextMenu component are generated in `default.cs` and assigned to `ViewBag` variable.

```cs
public IActionResult Index()
        {
            //define the array of JSON
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut"
            });
            menuItems.Add(new
            {
                text = "Copy"
            });
            menuItems.Add(new
            {
                text = "Paste"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }

```

Output be like the below.

![ContextMenu Sample](./images/context-menu.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic ContextMenu.

{% aspTab template="context-menu/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Rendering items with Separator

The Separators are the horizontal lines that are used to separate the menu items. You cannot select the separators. You
can enable separators to group the menu items using the [`separator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Separator.html)
property. Cut, Copy, and Paste menu items are grouped using the `separator` property in the following sample.

{% aspTab template="context-menu/separator", sourceFiles="separator.cs" %}

{% endaspTab %}

> The [`separator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Separator.html) property should not be given along with the other fields in the [`MenuItem`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem.html).

## See Also

* [ContextMenu with icons](./icons-and-navigation#icons)
* [Multi-level nesting](./template-and-multilevel-nesting#multilevel-nesting)