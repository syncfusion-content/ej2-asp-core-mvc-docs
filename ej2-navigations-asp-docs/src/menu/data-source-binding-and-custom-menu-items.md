---
title: "Menu with datasource"
component: "Menu"
description: "Menu supports databinding with local data source, parent child data, array of JSON data, and remote service with query."
---

# Data source binding and Custom menu items

## Data binding

The Menu supports data source bindings such as array of JavaScript objects
that can be structured as either `hierarchical` or `self-referential` data.

### Hierarchical data

The Menu can be populated with hierarchical data source by assigning it to the `items`
property, and the fields with corresponding keys can be mapped to the
[`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~Fields.html) property.

#### JSON data

The Menu can generate its menu items through an array of complex data source by mapping fields
from the [`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~Fields.html) property.

{% aspTab template="menu/databinding/localdata", sourceFiles="LocalData.cs,Model.cs" %}

{% endaspTab %}

### Self-referential data

Menu can be populated from self-referential data structure that contains array of JSON objects
with `parentId` mapping.

You can directly assign self-referential data to the `items`
property, and map all the field members
with corresponding keys from self-referential data to [`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~Fields.html) property.

To render the root level nodes, specify the `parentId` as null or no need to specify the `parentId` in data source.

In the following example, **id**, **pId**, and **text** columns from self-referential data
have been mapped to **itemId**, **parentId**, and **text** fields, respectively.

{% aspTab template="menu/databinding/self-referential", sourceFiles="SelfReferential.cs" %}

{% endaspTab %}

## Custom menu items

The Menu can be customized using Essential JS2
[Template engine](https://ej2.syncfusion.com/documentation/common/template-engine.html) to render the elements.

To customize menu items in your application, set your customized template string to the
[`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~Template.html) property.
In the following example, the menu has been rendered with customized menu items.

{% aspTab template="menu/databinding/template", sourceFiles="Template.cs" %}

{% endaspTab %}

## See Also

* [Render menu with items](./getting-started#getting-started)
