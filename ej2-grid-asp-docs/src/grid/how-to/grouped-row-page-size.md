---
title: "How to show grouped rows based on the pageSize"
component: "Grid"
description: "Learn how to show the grouped row based on the pageSize"
---

# How to show grouped rows based on the pageSize

By default, we have displayed the no of records based on the `pageSize`. If you want to show grouped column rows based on the `pageSize` then we suggest you to use the below way.

In the below sample, we have overridden the default `generateQuery` to display the grouped rows instead of grid rows based on the `pageSize`.

{% aspTab template="grid/how-to/group-page-size", sourceFiles="group-page-size.cs" %}

{% endaspTab %}