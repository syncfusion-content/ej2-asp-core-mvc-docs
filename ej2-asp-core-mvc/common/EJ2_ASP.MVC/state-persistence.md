---
layout: post
title: State Persistence in ##Platform_Name## control
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# State Persistence

The Syncfusion ASP.NET MVC library supports persisting a control's state across page refreshes or navigation. To enable this feature, set `enablePersistence` property as true to the required control. This will store the control’s state in browser’s `localStorage` object on page `unload` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/common/persistence/tagHelper %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/common/persistence/razor %}
{% endhighlight %}{% endtabs %}
{% endif %}

## State Persistence Supported controls and Properties

The following table demonstrates the list of Syncfusion ASP.NET MVC controls that are supported with state persistence and describes the list of properties stored in the `localStorage`.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>control Name</b></td>
<td><b>Properties</b></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/grid/state-persistence">Grid</a></td>
<td>
<ul>
<li>Columns</li>
<li>filterSettings</li>
<li>searchSettings</li>
<li>groupSettings</li>
<li>pageSettings</li>
<li>selectedRowIndex</li>
<li>scrollPosition</li>
</ul>
</td>
</tr>
<tr>
<td>Accordion</td>
<td>
<ul>
<li>expandedIndices</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/tab/how-to/set-state-persistence-of-the-tab-component">Tabs</a></td>
<td>
<ul>
<li>selectedItem</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/schedule/state-persistence">Schedule</a></td>
<td>
<ul>
<li>currentView</li>
<li>selectedDate</li>
<li>scrollLeft</li>
<li>scrollTop</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/kanban/persistence">Kanban</a></td>
<td>
<ul>
<li>columns</li>
<li>dataSource</li>
<li>swimlaneToggleArray</li>
</ul>
</td>
</tr>
<tr>
<td>Chart</td>
<td>
<ul>
<li>zoomFactor</li>
<li>zoomPosition</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/maps/state-persistence">Maps</a></td>
<td>
<ul>
<li>zoomSettings</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/pivot-table/state-persistence">Pivot Table</a></td>
<td>
<ul>
<li>dataSourceSettings</li>
<li>pivotValues</li>
<li>gridSettings</li>
<li>chartSettings</li>
<li>displayOption</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/tree-grid/state-persistence">TreeGrid</a></td>
<td>
<ul>
<li>columns</li>
<li>pageSettings</li>
<li>searchSettings</li>
<li>filterSettings</li>
<li>selectedRowIndex</li>
<li>sortSettings</li>
</ul>
</td>
</tr>
<tr>
<td>Switch</td>
<td>
<ul>
<li>checked</li>
</ul>
</td>
</tr>
<tr>
<td>Checkbox</td>
<td>
<ul>
<li>checked</li>
</ul>
</td>
</tr>
<tr>
<td>RadioButton</td>
<td>
<ul>
<li>checked</li>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>ColorPicker</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>ListBox</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetmvc/documentation/query-builder/how-to/state-persistence">QueryBuilder</a></td>
<td>
<ul>
<li>rule</li>
</ul>
</td>
</tr>
<tr>
<td>In-placeEditor</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>RichTextEditor</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>Splitter</td>
<td>
<ul>
<li>paneSettings</li>
</ul>
</td>
</tr>
<tr>
<td>Autocomplete</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>Calendar</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>ComboBox</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>DatePicker</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>DropDownList</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>MaskedTextBox</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>NumericTextBox</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>Textbox</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>TimePicker</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>Multiselect</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>DateTimePicker</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>DateRangePicker</td>
<td>
<ul>
<li>startDate</li>
<li>endDate</li>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>Uploader</td>
<td>
<ul>
<li>filesData</li>
</ul>
</td>
</tr>
<tr>
<td>Slider</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
<tr>
<td>ListView</td>
<td>
<ul>
<li>cssClass</li>
<li>enableRtl</li>
<li>htmlAttributes</li>
<li>enable</li>
<li>fields</li>
<li>animation</li>
<li>headerTitle</li>
<li>sortOrder</li>
<li>showIcon</li>
<li>height</li>
<li>width</li>
<li>showCheckBox</li>
<li>checkBoxPosition</li>
</ul>
</td>
</tr>
<tr>
<td>TreeView</td>
<td>
<ul>
<li>selectedNodes</li>
<li>checkedNodes</li>
<li>expandedNodes</li>
</ul>
</td>
</tr>
<tr>
<td>Dashboard Layout</td>
<td>
<ul>
<li>panels</li>
</ul>
</td>
</tr>
<tr>
<td>File Manager</td>
<td>
<ul>
<li>view</li>
<li>path</li>
<li>selectedItems</li>
</ul>
</td>
</tr>
<tr>
<td>Sidebar</td>
<td>
<ul>
<li>type</li>
<li>position</li>
<li>isOpen</li>
</ul>
</td>
</tr>
<tr>
<td>Dropdown Tree</td>
<td>
<ul>
<li>value</li>
</ul>
</td>
</tr>
</table>
<!-- markdownlint-enable MD033 -->
