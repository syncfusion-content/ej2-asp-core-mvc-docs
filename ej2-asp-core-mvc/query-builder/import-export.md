---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Import Export of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Import Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Importing

Importing allows you to view or edit the predefined conditions. You can import the conditions by using methods and initial rendering.

## Initial Rendering

To apply conditions initially, you can define the `Rule`. Here, you can import structured JSON object by defining the `Rule` property.

{% aspTab template="query-builder/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Post Rendering

### Import from JSON

You can set the conditions from structured JSON object through the `setRules` method.

{% aspTab template="query-builder/import-export/import-json", sourceFiles="default.cs" %}

{% endaspTab %}

### Import From SQL

You can set the conditions from SQL query through the `setRulesFromSql` method.

{% aspTab template="query-builder/import-export/import-sql", sourceFiles="default.cs" %}

{% endaspTab %}

## Exporting

Exporting allows you to save or maintain the created conditions through the Query Builder. You can export the defined conditions by the following ways.

### JSON Export

You can export the defined conditions to structured JSON object through the `getRules` method.

### SQL Support

You can export the defined conditions to SQL query through the `getRulesFromSQL` method.

{% aspTab template="query-builder/import-export/export-sql", sourceFiles="default.cs" %}

{% endaspTab %}