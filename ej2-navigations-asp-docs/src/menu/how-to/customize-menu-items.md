# Customize menu items

## Add or remove menu items

Menu items can be added or removed using the `insertAfter`,
`insertBefore` and `removeItems` methods.

In the following example, the **Europe** menu items are added before the **Oceania** item,
the **Africa** menu items are added after the **Asia**, and the **South America**
and **Mexico** items are removed from menu.

{% aspTab template="menu/how-to/customize-menu-items", sourceFiles="CustomizeMenuItems.cs" %}

{% endaspTab %}

> To process items with `ID` values, set `isUnique` to `true`.

## Enable or disable menu items

You can enable and disable the menu items using the `enableItems`
method in Menu. To enable menuItems, set the `enable` property in argument to `true` and vice-versa.

In the following example, the **Directory** header item, **Conferences**, and **Music** sub menu items are disabled.

{% aspTab template="menu/how-to/enable-disable", sourceFiles="EnableDisable.cs" %}

{% endaspTab %}

> To disable sub menu items, use the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event.

## Hide or show menu items

You can show or hide the menu items using the `showItems`
and `hideItems` methods.

In the following example, the **Movies** header item, **Workshops**, and **Music** sub menu items
are hidden in menu.

{% aspTab template="menu/how-to/hide-show", sourceFiles="HideShow.cs" %}

{% endaspTab %}

> Using the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event, you can hide the sub menu items as in the above example since the menu supports to hide items only for headers initially.
