---
title: "Migration from Essential JS 1"
component: "Pivot Grid"
description: "Explains the common steps for migrating from Essential JS 1 application to Essential JS 2 components especially, pivot grid component."
---

# Migration from Essential JS 1

This article describes the API migration process of Pivot Grid component from Essential JS 1 to Essential JS 2.

## Data Binding

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Data source | **property:** dataSource<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Data((IEnumerable<object>)ViewBag.Data))`| **property:** dataSourceSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.DataSource((IEnumerable<object>)ViewBag.Data)).Render()`|
| Rows |**property:** rows<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").FieldCaption("Country").Add(); }))`| **property:** rows<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Rows(rows =>{ rows.Name("Country").Caption("Country").Add(); })).Render()`|
| Columns |**property:** columns<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Columns(columns => { columns.FieldName("Country").FieldCaption("Country").Add(); }))`| **property:** columns<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Columns(columns =>{ columns.Name("Country").Caption("Country").Add(); })).Render()`|
| Values |**property:** values<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Values(values => { values.FieldName("balance").FieldCaption("Balance($)").Add(); }))`| **property:** values<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Values(values =>{ values.Name("balance").Caption("Balance($)").Add(); })).Render()`|
|Filters |**property:** filters<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Filters(filters => { filters.FieldName("Country").FieldCaption("Country").Add(); }))`|**property:** filters<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Filters(filters =>{ filters.Name("Country").Caption("Country").Add(); })).Render()`|
|Value axis position|Not Applicable|**property:** valueAxis<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ValueAxis("row")).Render()`|

## Aggregation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Summary Type|**property:** summaryType<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Values(values => { values.FieldName("balance").FieldCaption("Balance($)").SummaryType("Count").Add(); }))`|**property:** type<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Values(values =>{ values.Name("Sold").Caption("Units Sold").Add(); values.Name("Amount").Caption("Sold Amount").Type(SummaryType.Count).Add();})).Render()`|

## Number Format

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Format settings|**property:** format<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Values(values => { values.FieldName("balance").FieldCaption("Balance($)").Format("currency").Add(); }))`|**property:** formatSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.FormatSettings(formatsettings => { formatsettings.Name("Amount").Format("C0").MaximumSignificantDigits(10).MinimumSignificantDigits(1).UseGrouping(true).Add(); formatsettings.Name("Year").Format("dd/MM/yyyy-hh:mm").Type("date").Add(); })).Render()`|

## Summary Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide grand totals|**property:** enableGrandTotal<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.EnableGrandTotal(false))`|**property:** showGrandTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ShowGrandTotals(false)).Render()`|
|Show/hide row grand totals|**property:** enableRowGrandTotal<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.EnableRowGrandTotal(false))`|**property:** showRowGrandTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ShowRowGrandTotals(false)).Render()`|
|Show/hide column grand totals|**property:** enableColumnGrandTotal<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.EnableColumnGrandTotal(false))`|**property:** showColumnGrandTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ShowColumnGrandTotals(false)).Render()`|
|Show/hide sub-totals|Not Applicable|**property:** showSubTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSource(dataSource => dataSource.ShowSubTotals(false)).Render()`|
|Show/hide row sub-totals|Not Applicable|**property:** showRowSubTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ShowRowSubTotals(false)).Render()`|
|Show/hide column sub-totals|Not Applicable|**property:** showColumnSubTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ShowColumnSubTotals(false)).Render()`|
| Show/hide sub-totals for specific field|**property:** showSubTotal<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").ShowSubTotal(false).Add(); }))` | **property:** showSubTotals<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Rows(rows =>{ rows.Name("Country").ShowSubTotals(false).Add(); })).Render()`|

## Drill operation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Expand All|**property:** enableCollapseByDefault<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCollapseDyDefault(true)`|**property:** expandAll<br/><br/>`@Html.EJS().PivotView("PivotView").ExpandAll(true).Render()`|
|Drill Up/Down|**property:** collapsedMembers<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad(args) {`<br/>`args.model.collapsedMembers = { Country: ["Canada", "France"] }`<br/>`}`|**property:** drilledMembers<br/><br/>`@Html.EJS().PivotView("PivotView").DrilledMembers(drilledmembers =>{ drilledmembers.Name("Country").Items(ViewBag.drilledMembers).Add();}).Render()`|

## Field List

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide field list pop-up button on pivot grid|Not Applicable|**property:** showFieldList<br/><br/>`@Html.EJS().PivotView("PivotView").ShowFieldList(true).Render()`|
|Defer update|**property:** enableDeferUpdate<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableDeferUpdate(true)`|Not Applicable|
|Control initialization|**component:** PivotSchemaDesigner<br/><br/>`@Html.EJ().Pivot().PivotSchemaDesigner("PivotSchemaDesigner")`|**component:** PivotFieldListComponent<br/><br/>`@Html.EJS().PivotFieldList("PivotFieldList").Render()`|
|Render mode|Not Applicable|**property:** renderMode<br/><br/>`@Html.EJS().PivotFieldList("PivotFieldList").RenderMode("Fixed").Render()`|
|Show/hide calculated field button|Not Applicable|**property:** allowCalculatedField<br/><br/>`@Html.EJS().PivotFieldList("PivotFieldList").AllowCalculatedField(true).Render()`|
|Show/hide value group button|Not Applicable|**property:** showValuesButton<br/><br/>`@Html.EJS().PivotFieldList("PivotFieldList").ShowValuesButton(true).Render()`|

## Grouping Bar

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide Grouping bar|**property:** enableGroupingBar<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableGroupingBar(true)`|**property:** showGroupingBar<br/><br/>`@Html.EJS().PivotView("PivotView").ShowGroupingBar(true).Render()`|
|Grouping Bar Settings|Not Applicable|**property:** groupingBarSettings<br/><br/>`@Html.EJS().PivotView("PivotView").GroupingBarSettings( new PivotViewGroupingBarSettings { ShowFilterIcon =false ShowSortIcon=true ShowRemoveIcon=false}).Render()`|
|Show/hide value group button|Not Applicable|**property:** showValuesButton<br/><br/>`@Html.EJS().PivotView("PivotView").ShowValuesButton(true).Render()`|

## Filtering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Filter settings|**property:** filterItems<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").FieldCaption("Country").Add(); })).ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad(args) {`<br/>`args.model.dataSource.rows[0].filterItems = {`<br/>`filterType: ej.PivotAnalysis.FilterType.Exclude,`<br/> `values: ["Canada", "France"] };`<br/>`}`|**property:** filterSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.FilterSettings(filtersettings =>{ filtersettings.Name("Country").Type("Exclude").Items(ViewBag.filterMembers).Add();})).Render()`|

## Maximum node limit in member editor

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Max node limit in member editor|**property:** maxNodeLimitInMemberEditor<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").MaxNodeLimitInMemberEditor(100)`|**property:** maxNodeLimitInMemberEditor<br/><br/>`@Html.EJS().PivotView("PivotView").MaxNodeLimitInMemberEditor(100).Render()`|

## No Data Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide "no data" items|Not Applicable|**property:** showNoDataItems<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.Rows(rows =>{ rows.Name("Country").showNoDataItems(true).Add(); })).Render()`|

## Excel-like filtering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Label filtering|**property:** enableAdvancedFilter<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableAdvancedFilter(true).DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").FieldCaption("Country").Add(); })).ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad(args) {`<br/>`args.model.dataSource.rows[0].advancedFilter = [{`<br/> `labelFilterOperator: ej.olap.LabelFilterOptions.EndsWith,`<br/>`values: ["s"]}]`<br/>`}`|**property:** allowLabelFilter<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.AllowLabelFilter(true).FilterSettings(filtersettings =>{ filtersettings.Name("Country").Type(FilterType.Label).Condition(Operators.GreaterThan).Value1('United Kingdom').Add();})).Render()`|
|Value filtering|**property:** enableAdvancedFilter<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableAdvancedFilter(true).DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").FieldCaption("Country").Add(); })).ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad(args) {`<br/>`args.model.dataSource.rows[0].advancedFilter = [{`<br/> `measure: "balance"`<br/>`valueFilterOperator: ej.olap.ValueFilterOptions.EndsWith,`<br/>`values: ["002"]}]`<br/>`}`|**property:** allowValueFilter<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.AllowValueFilter(true).FilterSettings(filtersettings =>{ filtersettings.Name("Country").Measure("quantity").Type(FilterType.Value).Condition(Operators.Between).Value1("3250")..Value2("5000").Add();})).Render()`|

## Drill Through

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide drill though feature|**property:** enableDrillThrough<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableDrillThrough(true)`|**property:** allowDrillThrough<br/><br/>`@Html.EJS().PivotView("PivotView").AllowDrillThrough(true).Render()`|
|Event Triggers when cell clicked in pivot grid control|**event:** drillThrough<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.DrillThrough("onDrillThrough"))`<br/><br/>`function onDrillThrough() { }`|**event:** drillThrough<br/><br/>`@Html.EJS().PivotView("PivotView").DrillThrough("onDrillThrough").Render()`<br/><br/>`function onDrillThrough() { }`|

## Cell Editing

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Edit settings|Not Applicable|**property:** editSettings<br/><br/>`@Html.EJS().PivotView("PivotView").EditSettings(new PivotViewCellEditSettings{}).Render()`|
|Show/hide cell editing feature|**property:** enableCellEditing<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCellEditing(true)`|**property:** allowEditing<br/><br/>`@Html.EJS().PivotView("PivotView").EditSettings(new PivotViewCellEditSettings{AllowAdding=true;AllowDeleting=true;AllowEditing=true;Mode=EditMode.Dialog}).Render()`|

## Hyperlink

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Hyperlink settings|**property:** hyperlinkSettings<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").HyperlinkSettings()`|**property:** hyperlinkSettings<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings().Render()`|
|Show/hide hyperlink to all cells|Not Applicable|**property:** showHyperlink<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { showHyperlink =true }).Render()`|
|Show/hide hyperlink to row headers|**property:** enableRowHeaderHyperlink<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").HyperlinkSettings(hypLink => hypLink.EnableRowHeaderHyperlink(true))`|**property:** showRowHeaderHyperlink<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { showRowHeaderHyperlink =true }).Render()`|
|Show/hide hyperlink to column headers|**property:** enableColumnHeaderHyperlink<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").HyperlinkSettings(hypLink => hypLink.EnableColumnHeaderHyperlink(true))`|**property:** showColumnHeaderHyperlink<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { showColumnHeaderHyperlink =true }).Render()`|
|Show/hide hyperlink to value cells|**property:** enableValueCellHyperlink<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").HyperlinkSettings(hypLink => hypLink.EnableValueCellHyperlink(true))`|**property:** showValueCellHyperlink<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { showValueCellHyperlink =true }).Render()`|
|Show/hide hyperlink to summary cells|**property:** enableSummaryCellHyperlink<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").HyperlinkSettings(hypLink => hypLink.EnableSummaryCellHyperlink(true))`|**property:** showSummaryCellHyperlink<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { showSummaryCellHyperlink =true }).Render()`|
|Show/hide hyperlink using specific conditions|Not Applicable|**property:** conditionalSettings<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings(hyperlinksettings => hyperlinksettings..ConditionalSettings( format =>{format.Conditions(Condition.Between).Measure("Units Sold").Value1(150).Value2(200).Add();})).Render()`|
|Show/hide hyperlink for row or column|Not Applicable|**property:** headerText<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkSettings( new PivotViewHyperLinkSettings { headerText ='FY 2015.Q1.Units Sold' }).Render()`|
|Event Triggers when row headers clicked in pivot grid control|**event:** rowHeaderHyperlinkClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.RowHeaderHyperlinkClick("onClick"))`<br/><br/>`function onClick() { }`|**event:** hyperlinkCellClick<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkCellClick("onClick").Render()`<br/><br/>`function onClick() { }`|
|Event Triggers when column headers clicked in pivot grid control|**event:** columnHeaderHyperlinkClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.ColumnHeaderHyperlinkClick("onClick"))`<br/><br/>`function onClick() { }`|**event:** hyperlinkCellClick<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkCellClick("onClick").Render()`<br/><br/>`function onClick() { }`|
|Event Triggers when value cells clicked in pivot grid control|**event:** valueCellHyperlinkClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.ValueCellHyperlinkClick("onClick"))`<br/><br/>`function onClick() { }`|**event:** hyperlinkCellClick<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkCellClick("onClick").Render()`<br/><br/>`function onClick() { }`|
|Event Triggers when summary cells clicked in pivot grid control|**event:** summaryCellHyperlinkClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.SummaryCellHyperlinkClick("onClick"))`<br/><br/>`function onClick() { }`|**event:** hyperlinkCellClick<br/><br/>`@Html.EJS().PivotView("PivotView").HyperlinkCellClick("onClick").Render()`<br/><br/>`function onClick() { }`|

## Defer Layout Update

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide defer layout update|**property:** enableDeferUpdate<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableDeferUpdate(true)`|**property:** allowDeferLayoutUpdate<br/><br/>`@Html.EJS().PivotView("PivotView").AllowDeferLayoutUpdate(true).Render()`|

## Sorting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable/disable sorting|Not Applicable|**property:** enableSorting<br/><br/>`@Html.EJS().PivotView("PivotView").EnableSorting(true).Render()`|
|Sort settings|**property:** sortOrder<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").DataSource(dataSource => dataSource.Rows(rows => { rows.FieldName("Country").FieldCaption("Country").SortOrder(SortOrder.Descending).Add(); }))`|**property:** sortSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.SortSettings(sortsettings =>{ sortsettings.Name("company").Order("Descending").Add();})).Render()`|

## Value Sorting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable/disable value sorting|Not Applicable|**property:** enableSorting<br/><br/>`@Html.EJS().PivotView("PivotView").EnableValueSorting(true).Render()`|
|Value sort settings|**property:** valueSortSettings<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").ValueSortSettings(valuesortsettings=>valuesortsettings.HeaderText("Bike##Quantity").HeaderDelimiters("##").SortOrder(SortOrder.Descending))`|**property:** valueSortSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.ValueSortSettings(new PivotViewValueSortSettings { HeaderText = "FY 2015##Sold Amount",    HeaderDelimiter = "##", SortOrder = Sorting.Descending })).Render()`|

## Calculated Field

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide calculated field|Not Applicable|**property:** allowCalculatedField<br/><br/>`@Html.EJS().PivotView("PivotView").AllowCalculatedField(true).Render()`|
|Calculated field settings|**property:** values<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").DataSource(dataSource => dataSource.Values(values => { values.FieldName("Amount").Add(); values.FieldName("Price").FieldCaption("Price").IsCalculatedField(true).Formula("Amount * 15").Add(); }))`|**property:** calculatedFieldSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource.CalculatedFieldSettings(calculatedfieldsettings => {     calculatedfieldsettings.Name("Total").Formula(totalPrice).Add(); })).Render()`<br/><br/>`@{var stock = "\"" + "Sum(In_Stock)" + "\"";}`<br/>`@{var sold = "\"" + "Sum(Sold)" + "\"";}`<br/>`@{ var totalPrice = stock + "+" + sold;}`|

## Paging

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Paging|**property:** enablePaging<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnablePaging(true)`|Not Applicable|
|Virtual scrolling|**property:** enableVirtualScrolling<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableVirtualScrolling(true)`|**property:** enableVirtualization<br/><br/>`@Html.EJS().PivotView("PivotView").EnableVirtualization(true).Render()`|

## Conditional Formatting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show/hide conditional formatting|**property:** enableConditionalFormatting<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableConditionalFormatting(true)`|**property:** allowConditionalFormatting<br/><br/>`@Html.EJS().PivotView("PivotView").AllowConditionalFormatting(true).Render()`|
|Conditional formatting settings|**property:** conditionalFormatSettings<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad(args) {`<br/>`args.model.dataSource.conditionalFormatSettings = [{`<br/>`name: "Format2",`<br/> `style: {` <br/>`"color": "#000000",`<br/> `"backgroundcolor": "#0000FF",`<br/> `"bordercolor": "#000000",`<br/>`"borderstyle": "Dashed",`<br/> `"borderwidth": "5",`<br/> `"fontsize": "12",`<br/> `"fontstyle": "Algerian" },`<br/>`condition: ej.PivotGrid.ConditionalOptions.LessThan,`<br/> `value: "200",`<br/> `measures: "Amount,Quantity" }]`<br/>`}`|**property:** conditionalFormatSettings<br/><br/>`@Html.EJS().PivotView("PivotView").DataSourceSettings(dataSource => dataSource..ConditionalFormatSettings( format =>{               format.Conditions(Condition.LessThan).Measure("In Stock").Value1(5000).Style( style => { style.BackgroundColor("#80cbc4").Color("black").FontFamily("Tahoma").FontSize("12px"); }).Add(); format.Conditions(Condition.Between).Measure("Units Sold").Value1(3400).Value2(40000).Style(style => { style.BackgroundColor("#f48fb1").Color("black").FontFamily("Tahoma").FontSize("12px"); }).Add(); }))..Render()`|

## Exporting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Excel Export|Not Applicable|**property:** allowExcelExport<br/><br/>`@Html.EJS().PivotView("PivotView").AllowExcelExport(true).Render()`|
|Pdf Export|Not Applicable|**property:** allowPdfExport<br/><br/>`@Html.EJS().PivotView("PivotView").AllowPdfExport(true).Render()`|

## Grid Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Set width for pivot grid|Not Applicable|**property:** width<br/><br/>`@Html.EJS().PivotView("PivotView").Width(800).Render()`|
|Set height for pivot grid|Not Applicable|**property:** height<br/><br/>`@Html.EJS().PivotView("PivotView").Height(400).Render()`|
|Set row height for pivot grid|Not Applicable|**property:** rowHeight<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { RowHeight = 60 }).Render()`|
|Set column width for pivot grid|Not Applicable|**property:** columnWidth<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { ColumnWidth = 120 }).Render()`|
|Drag and drop column headers in pivot grid|Not Applicable|**property:** allowReordering<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { AllowReordering = true }).Render()`|
|Resizing the column headers in pivot grid|**property:** enableColumnResizing<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableColumnResizing(true)`|**property:** allowResizing<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { AllowResizing = true }).Render()`|
|Wrap the cell content in pivot grid|Not Applicable|**property:** allowTextWrap<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { AllowTextWrap = true }).Render()`|
|Display cell border in pivot grid|Not Applicable|**property:** gridLines<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { GridLines = "Vertical" }).Render()`|
|Cell selection|**property:** enableCellSelection<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCellSelection(true)`|**property:** allowSelection<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { AllowSelection = true }).Load("onLoad").Render()`<br/><br/>`function onLoad()  {`<br/>`pivotObj = document.getElementById('PivotView').ej2_instances[0];`<br/>`pivotObj.gridSettings.selectionSettings = {`<br/>`cellSelectionMode: 'Box',`<br/>`type: 'Multiple',`<br/> `mode: 'Cell' };`<br/>`}`|
|Display overflow cell content in pivot grid|Not Applicable|**property:** clipMode<br/><br/>`@Html.EJS().PivotView("PivotView").GridSettings(new PivotViewGridSettings { ClipMode = "Clip" }).Render()`|
|Cell Editing|**property:** enableCellEditing<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCellEditing(true)`|Not Applicable|
|Cell double click|**property:** enableCellDoubleClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCellDoubleClick(true)`|Not Applicable|
|Cell context|**property:** enableCellContext<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableCellContext(true)`|Not Applicable|

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Localization|**property:** locale<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").Locale("es-ES")`|**property:** locale<br/><br/>`@Html.EJS().PivotView("PivotView").Locale("es-ES").Render()`|
|Right to left|**property:** enableRTL<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").EnableRtl(true)`|**property:** enableRtl<br/><br/>`@Html.EJS().PivotView("PivotView").EnableRTL(true).Render()`|

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Adding custom class to wrapper element|**property:** cssClass<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid").CssClass("custom-class")`|**property:** cssClass<br/><br/>`@Html.EJS().PivotView("PivotView").CssClass("custom-class").Render()`|
|Keeping the model values in cookies|Not Applicable|**property:** enablePersistence<br/><br/>`@Html.EJS().PivotView("PivotView").EnablePersistence(true).Render()`|
|Event triggers when control initializing|**event:** load<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.Load("onLoad"))`<br/><br/>`function onLoad() { }`|**event:** load<br/><br/>`@Html.EJS().PivotView("PivotView").Load("onLoad").Render()`<br/><br/>`function onLoad() { }`|
|Event Triggers before the pivot engine starts|**event:** beforePivotEnginePopulate<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.BeforePivotEnginePopulate("onBeforePivotEnginePopulate"))`<br/><br/>`function onBeforePivotEnginePopulate() { }`|**event:** enginePopulating<br/><br/>`@Html.EJS().PivotView("PivotView").EnginePopulating("onEnginePopulating").Render()`<br/><br/>`function onEnginePopulating() { }`|
|Event Triggers after the pivot engine populated|**event:** afterPivotEnginePopulate<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.AfterPivotEnginePopulate("onAfterPivotEnginePopulate"))`<br/><br/>`function onAfterPivotEnginePopulate() { }`|**event:** enginePopulated<br/><br/>`@Html.EJS().PivotView("PivotView").EnginePopulated("onEnginePopulated").Render()`<br/><br/>`function onEnginePopulated() { }`|
|Event Triggers after the control populated with data source|**event:** renderSuccess<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.RenderSuccess("onRenderSuccess"))`<br/><br/>`function onRenderSuccess() { }`|**event:** dataBound<br/><br/>`@Html.EJS().PivotView("PivotView").DataBound("onDataBound").Render()`<br/><br/>`function onDataBound() { }`|
|Event Triggers after the control created|Not Applicable|**event:** created<br/><br/>`@Html.EJS().PivotView("PivotView").Created("onCreated").Render()`<br/><br/>`function onCreated() { }`|
|Event Triggers when destroy the control|Not Applicable|**event:** destroyed<br/><br/>`@Html.EJS().PivotView("PivotView").Destroyed("onDestroyed").Render()`<br/><br/>`function onDestroyed() { }`|
|Event Triggers the cell clicked in pivot grid control|**event:** cellClick<br/><br/>`@Html.EJ().Pivot().PivotGrid("PivotGrid1").ClientSideEvents(clientSideEvents => clientSideEvents.CellClick("onCellClick"))`<br/><br/>`function onCellClick() { }`|**event:** cellClick<br/><br/>`@Html.EJS().PivotView("PivotView").CellClick("onCellClick").Render()`<br/><br/>`function onCellClick() { }`|
