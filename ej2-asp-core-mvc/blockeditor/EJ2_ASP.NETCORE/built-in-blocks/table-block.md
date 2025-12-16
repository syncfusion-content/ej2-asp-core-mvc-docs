---
layout: post
title: Table Block in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Table Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Table Blocks in ##Platform_Name## Block Editor control

The Block Editor control allows you to render structured data in rows and columns by setting the block's `blockType` property to `Table`. You can customize the table layout, header, row numbers, and define columns and rows using the `properties` property.

### Configure Table Block

For Table blocks, you can configure layout and structure using the `properties` property. This property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| width | Specifies the display width of the table. | `100%` |
| enableHeader | Specifies whether to enable header for the table. | `true` |
| enableRowNumbers | Specifies whether to enable row numbers for the table. | `true` |
| readOnly | Specifies whether to render the table in read-only mode, disabling edits. | `false` |
| columns | Defines the columns of the table, including their types and headers. | `[]` |
| rows | Defines the rows of the table, each containing cells tied to columns. | `[]` |

This sample demonstrates the configuration of the `Table` block in the Block Editor.
