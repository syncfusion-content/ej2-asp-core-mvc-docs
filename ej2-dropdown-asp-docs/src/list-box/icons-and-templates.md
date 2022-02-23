---
title: "ListBox with icons and customization"
component: "ListBox"
description: "Angular ListBox supports icons, images and customization of each list elements."
---

# Icons and Customization

## Icons

To place the icon on a list box, set the [`iconCss`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~IconCss.html) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the list.

In the following sample, icon classes are mapped with `iconCss` field.

{% aspTab template="listbox/icons-template/icons", sourceFiles="icons.cs" %}

{% endaspTab %}

## Templates

ListBox items can be customized according to the requirement using [`itemTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~ItemTemplate.html) property.

In the following sample, the items in the cart are displayed using list box template,

{% aspTab template="listbox/icons-template/template", sourceFiles="template.cs" %}

{% endaspTab %}