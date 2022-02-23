---
title: "Style and appearance"
component: "Grid"
description: "Learn how to change default styling of the grid."
---

# Styling

To modify the Grid appearance, you need to override the default CSS of grid. Please find the CSS structure that can be used to modify the Grid appearance. Also, you have an option to create your own custom theme for all the JavaScript controls using our [`Theme Studio`](https://ej2.syncfusion.com/themestudio/?theme=material).

## Customizing the Grid

Use the below CSS to customize the Grid root element.

```css

.e-grid {
      font-family: cursive;
}

```

## Header

### Customizing the Grid header

Use the below CSS to customize the Grid header root element. Using this, you can override the thin line between header and content of the grid.

```css

.e-grid .e-gridheader {
    border:2px solid green
}

```

### Customizing the Grid header cell

You can customize the Grid header cell elements using this CSS.

```css

.e-grid .e-headercell {
   color: darkblue;
}

```

### Customizing the Grid header cell div element

Use the below CSS to customize the Grid header cell div element. Using this CSS, you can customize the header text content.

```css

.e-grid .e-headercelldiv {
   font-size: 15px;
}

```

## Paging

### Customizing the Grid Pager root element

Using this CSS, you can customize the Grid pager root element.

```css

.e-grid .e-gridpager {
    font-family: cursive;
    background-color: #deecf9;
}

```

### Customizing the Grid Pager container element

Use the below CSS to customize the Grid pager container element.

```css

.e-grid .e-pagercontainer {
    background-color: #deecf9;
}

```

### Customizing the Grid Pager navigation elements

Customize the Grid pager navigation elements, using the below selector.

```css

.e-grid .e-gridpager .e-prevpagedisabled,
.e-grid .e-gridpager .e-prevpage,
.e-grid .e-gridpager .e-nextpage,
.e-grid .e-gridpager .e-nextpagedisabled,
.e-grid .e-gridpager .e-lastpagedisabled,
.e-grid .e-gridpager .e-lastpage,
.e-grid .e-gridpager .e-firstpage,
.e-grid .e-gridpager .e-firstpagedisabled {
    background-color: #deecf9;
}

```

### Customizing the Grid Pager page numeric link elements

Use the below CSS to customize the Grid pager current page numeric link elements.

```css

.e-grid .e-gridpager .e-numericitem {
    border-radius: initial;
}

```

### Customizing the Grid Pager current page numeric element

Using this CSS, you can customize the Grid pager current page numeric item.

```css

.e-grid .e-gridpager .e-currentitem {
    background-color: #0078d7;
}

```

## Sorting

### Customizing the Grid sorting icon

Use the below CSS to customize the Grid sorting icon which present in the Grid header. You can use the available Syncfusion [icons](https://ej2.syncfusion.com/documentation/appearance/icons/#material) based on your theme.

```css

.e-grid .e-icon-ascending::before {
    content: '\e306';
}
.e-grid .e-icon-ascending::before {
    content: '\e304';
}

```

### Customizing the Grid multi sorting icon

Use the below CSS to customize the Grid multi sorting icon which present in the Grid header. You can use the available Syncfusion [icons](https://ej2.syncfusion.com/documentation/appearance/icons/#material) based on your theme.

```css

.e-grid .e-sortnumber {
    background-color: #deecf9;
    font-family: cursive;
}

```

## Filtering

### Customizing the Filterbar cell element

Use the below CSS to customize the Grid Filterbar cell element present in the Grid header.

```css

.e-grid .e-filterbarcell {
      background-color: #deecf9;
}

```

### Customizing the Filterbar input element

Customize the Grid Filterbar input element using this CSS.

```css

.e-grid .e-filterbarcell .e-input-group input.e-input{
      font-family: cursive;
}

```

### Customizing the Filterbar input focus

Use the below CSS to customize the Grid Filterbar highlight color of focused filterbar input element.

```css

.e-grid .e-filterbarcell .e-input-group.e-input-focus::after,
.e-grid .e-filterbarcell .e-input-group.e-input-focus::before{
      background-color: #0078d7;
}

```

### Customizing the Filterbar input clear icon

Use the below CSS to customize the Grid Filterbar input clear icon.

```css

.e-grid .e-filterbarcell .e-input-group .e-clear-icon::before {
    content: '\e825';
}

```

### Customizing the Grid filtering icon

Below CSS customizes the Grid filter icon which present in the Grid header. You can also use custom icons. Here we have used bootstrap icon for filter icon element.

```css

.e-grid .e-icon-filter::before{
    content: '\002a';
}

```

### Customizing the Filter dialog content

Use the below CSS to customize the Grid filter dialog content element.

```css

.e-grid .e-filter-popup .e-dlg-content {
    background-color: #deecf9;
}

```

### Customizing the Filter dialog footer

Grid filter dialog footer element an be customized by using the below CSS.

```css

.e-grid .e-filter-popup .e-footer-content {
    background-color: #deecf9;
}

```

### Customizing the filter dialog input element

Use the below CSS to customize the Grid filter dialog input element.

```css

.e-grid .e-filter-popup .e-input-group input.e-input{
      font-family: cursive;
}

```

### Customizing the filter dialog button element

Use the below CSS to customize the Grid filter dialog button element.

```css

.e-grid .e-filter-popup .e-btn{
      font-family: cursive;
}

```

### Customizing the Excel filter dialog number filters element

Grid Excel filter dialog number filters element can be customized using the below CSS.

```css

.e-grid .e-filter-popup .e-contextmenu-wrapper ul{
      background-color: #deecf9;
}

```

## Grouping

### Customizing the group header

Use the below CSS to customize the group header element.

```css

.e-grid .e-groupdroparea {
    background-color: #deecf9;
}

```

### Customizing the group expand/collapse icons

Use the below CSS to customize the Grid group expand/collapse icon. You can use the available Syncfusion [icons](https://ej2.syncfusion.com/documentation/appearance/icons/#material) based on your theme.

```css

.e-grid .e-icon-gdownarrow::before{
  content:'\e916'
}
.e-grid .e-icon-grightarrow::before{
  content:'\e913'
}

```

### Customizing the group caption row

Below CSS customizes the Grid group caption row element.

```css

.e-grid .e-groupcaption {
    background-color: #deecf9;
}
.e-grid .e-recordplusexpand,
.e-grid .e-recordpluscollapse {
    background-color: #deecf9;
}

```

### Customizing the indent cell

Use the below CSS to customize the Grid grouping indent cell element.

```css

.e-grid .e-indentcell {
    background-color: #deecf9;
}

```

## Toolbar

### Customizing the toolbar root element

Use the below CSS to customize the Grid toolbar root element.

```css

.e-grid .e-toolbar-items {
    background-color: #deecf9;
}

```

### Customizing the toolbar button element

Use the below CSS to customize the Grid toolbar button element.

```css

.e-grid .e-toolbar .e-btn {
    background-color: #deecf9;
}

```

## Editing

### Customizing the edited and added row element

Use the below CSS to customize the Grid edited and added row table elements

```css

.e-grid .e-editedrow table,
.e-grid .e-addedrow table {
    background-color: #deecf9;
}

```

### Customizing the edited row input element

Grid edited row input elements can be customized using the below CSS.

```css

.e-grid .e-gridform .e-rowcell .e-input-group .e-input.e-field {
    font-family: cursive;
}

```

### Customizing the edit dialog header element

Use the below CSS to customize the Grid edit dialog header element

```css

.e-edit-dialog .e-dlg-header-content {
    background-color: #deecf9;
}

```

### Customizing the edited row input element in Dialog edit mode

Below CSS customizes the Grid edited row input element in Dialog edit mode

```css

.e-gridform .e-rowcell .e-float-input .e-field {
    font-family: cursive;
}

```

## Aggregate

### Customizing the Aggregate root element

Use the below CSS to customize the Grid aggregate root elements

```css

.e-grid .e-gridfooter {
    background-color: #deecf9;
}

```

### Customizing the Aggregate cell elements

Using this CSS, you can customize the Grid summary row cell elements.

```css

.e-grid .e-summaryrow .e-summarycell {
    background-color: #deecf9;
}

```

## Selection

### Customizing the Row selection background

Row selection background can be customized using below CSS.

```css

.e-grid td.e-selectionbackground {
    background-color: #deecf9;
}

```

### Customizing the Cell selection background

Cell selection background can be customized using below CSS.

```css

.e-grid td.e-cellselectionbackground {
    background-color: #deecf9;
}

```

### Customizing the Column selection background

Column selection background can be customized using below CSS.

```css

.e-grid .e-columnselection {
    background-color: #deecf9;
}
```