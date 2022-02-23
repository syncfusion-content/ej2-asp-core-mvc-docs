---
title: "Menu with Images, URL, and Multi level items"
component: "Menu"
description: "Menu supports submenu, images, and url navigations in menu items"
---

# Icons and Sub menu items

## Icons

The menu item contains an icon/image in it to provide a visual representation of an action.
To place the icon on a menu item, set the `iconCss`
property with the required icon CSS. By default, the icon is positioned at the left of the
menu item. In the following sample, the icons of `File` and `Edit` menu items and `Open`,
`Save`, `Cut`, `Copy`,and `Paste` sub menu items are added using the `iconCss` property.

{% aspTab template="menu/icon/icon", sourceFiles="Icon.cs" %}

{% endaspTab %}

## Navigation

Navigation in Menu is used to navigate to the other web page when a menu item is clicked.
It can be achieved by providing a link to the menu item using the url property. In the following sample,
the Navigation URL is added to sub menu items using the url property.

{% aspTab template="menu/icon/navigation", sourceFiles="Navigation.cs" %}

{% endaspTab %}

## Multilevel nesting

The Menu supports multiple level nesting, and it can be achieved by mapping the `items`
property inside the parent `menuItems`.
In the following sample, three-level nesting of menu has been provided.

{% aspTab template="menu/icon/multi-level-nesting", sourceFiles="Nesting.cs" %}

{% endaspTab %}

> You can achieve multi level nesting with data source by mapping `name` of the child items
to the `children` sub-property
of [`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~Fields.html) property. For more information, refer to
the [`data source binding`](./data-source-binding-and-custom-menu-items#data-binding) section.

The below table represents the MenuItem properties and it's description.

Property Name | Type | Description
-----|----- | -----
|iconCss|string|Defines class/multiple classes separated by a space for the menu Item that is used to include an icon. Menu Item can include font icon and sprite image.
|id|string|Specifies the id for menu item.
|separator|boolean|Specifies separator between the menu items. Separator are either horizontal or vertical lines used to group menu items.
|items|MenuItemModel[]|Specifies the sub menu items that is the array of MenuItem model/
|text|string|Specifies text for menu item.
|url|string|Specifies url for menu item that creates the anchor link to navigate to the url provided.

## See Also

* [Customize menu items](./how-to#customize-menu-items)
* [Group menu items with separator](./getting-started#group-menu-items-with-separator)