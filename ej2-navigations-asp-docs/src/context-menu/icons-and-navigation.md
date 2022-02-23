# Icons and Navigation

## Icons

The ContextMenu item have an icon/image in it to provide visual representation of the action.
To place the icon on a menu item, set the [`iconCss`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~IconCss.html)
property to e-icons with the required icon CSS. By default, the icon is positioned to the left
side of the menu item. In the following sample, the icons for Cut, Copy and Paste menu items are
added using the `iconCss` property.

{% aspTab template="context-menu/icons", sourceFiles="icons.cs" %}

{% endaspTab %}

> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the contextmenu menuItems using the `iconCss`property.

## Navigation

Navigation in ContextMenu is usage to navigate to the other web page when menu item is
clicked. This can be achieved by providing link to the menu item using the
[`url`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Url.html) property. In the following sample, Navigation URL for Flipkart, Amazon, and Snapdeal menu items
are added using the `url` property.

{% aspTab template="context-menu/navigation", sourceFiles="navigation.cs" %}

{% endaspTab %}