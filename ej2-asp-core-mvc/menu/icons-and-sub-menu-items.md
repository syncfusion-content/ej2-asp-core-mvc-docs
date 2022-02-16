---
layout: post
title: Icons And Sub Menu Items in ##Platform_Name## Menu Component
description: Learn here all about Icons And Sub Menu Items in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Icons And Sub Menu Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons and Sub menu items

## Icons

The menu item contains an icon/image in it to provide a visual representation of an action.
To place the icon on a menu item, set the `iconCss`
property with the required icon CSS. By default, the icon is positioned at the left of the
menu item. In the following sample, the icons of `File` and `Edit` menu items and `Open`,
`Save`, `Cut`, `Copy`,and `Paste` sub menu items are added using the `iconCss` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/menu/icon/icon/Icon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/menu/icon/icon/Icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Navigation

Navigation in Menu is used to navigate to the other web page when a menu item is clicked.
It can be achieved by providing a link to the menu item using the url property. In the following sample,
the Navigation URL is added to sub menu items using the url property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/menu/icon/navigation/Navigation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/menu/icon/navigation/Navigation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multilevel nesting

The Menu supports multiple level nesting, and it can be achieved by mapping the `items`
property inside the parent `menuItems`.
In the following sample, three-level nesting of menu has been provided.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/multi-level-nesting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/menu/icon/multi-level-nesting/Nesting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/icon/multi-level-nesting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/menu/icon/multi-level-nesting/Nesting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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