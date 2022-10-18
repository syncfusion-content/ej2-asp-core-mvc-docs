---
layout: post
title: Editing in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing in ##Platform_Name## Grid Component

## Customizing the edited and added row element

Use the below CSS to customize the Grid edited and added row table elements.

```css

.e-grid .e-editedrow table,
.e-grid .e-addedrow table {
    background-color: #deecf9;
}

```

## Customizing the edited row input element

Grid edited row input elements can be customized using the below CSS.

```css

.e-grid .e-gridform .e-rowcell .e-input-group .e-input.e-field {
    font-family: cursive;
}

```

## Customizing the edit dialog header element

Use the below CSS to customize the Grid edit dialog header element.

```css

.e-edit-dialog .e-dlg-header-content {
    background-color: #deecf9;
}

```

## Customizing the edited row input element in dialog edit mode

Below CSS customizes the Grid edited row input element in Dialog edit mode.

```css

.e-gridform .e-rowcell .e-float-input .e-field {
    font-family: cursive;
}

```

## Customizing the command column buttons

Use the below CSS to customize the command column buttons such as edit, delete, update, and cancel.

```css

.e-grid .e-edit::before {
    color: #deecf9;
}

.e-grid .e-delete::before {
    color: #deecf9;
}

.e-grid .e-update::before {
    color: #0078d7;
}

.e-grid .e-cancel-icon::before {
    color: #0078d7;
}

```