---
title: "Templates"
component: "QueryBuilder"
description: "Documentation on Templates in the Essential JS 2 QueryBuilder control."
---

# Templates

## Header Template

Header Template allows to define your own user interface for Header, which includes creating or deleting rules and groups and to customize the AND/OR condition and NOT condition options. To implement header template in querybuilder, you can create the user interface using `x-template` and assign the values when requestType is header-template-create in  `actionBegin` event.

{% aspTab template="query-builder/header-template", sourceFiles="default.cs" %}

{% endaspTab %}