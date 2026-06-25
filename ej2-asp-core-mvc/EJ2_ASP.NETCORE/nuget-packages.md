---
layout: post
title: NuGet Packages List | Syncfusion ASP.NET Core Controls
description: Learn here about installing, managing and upgrading of individual NuGet packages of Syncfusion ASP.NET Core Controls.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# NuGet Packages for Syncfusion® ASP.NET Core UI Controls

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core UI controls are available as individual NuGet packages, segregated based on component usage and namespace. These individual packages help reduce the application size by referencing only the packages required for the components used. The complete package [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) is also available and continues to be supported.

> Do not use both `Syncfusion.EJ2.AspNet.Core` and individual NuGet packages in the same application. It will throw ambiguous errors while compiling the project.

## Syncfusion.AspNetCore.Base

This package contains the base component, common classes, common functionalities, and interfaces for all Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core UI controls.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Base/">Syncfusion.AspNetCore.Base</a></td>
<td>Base</td>
<td>
<ul>
<li><a href="https://www.nuget.org/packages/Newtonsoft.Json/" target="_blank">Newtonsoft.Json</a></li>
<li><a href="https://www.nuget.org/packages/Syncfusion.Licensing/" target="_blank">Syncfusion.Licensing</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.BarcodeGenerator

The ASP.NET Core BarcodeGenerator supports the most common 1D and 2D barcode types with complete customization of its appearance.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.BarcodeGenerator/">Syncfusion.AspNetCore.BarcodeGenerator</a></td>
<td>
<ul>
<li>Barcode Generator</li>
<li>Data Matrix Generator</li>
<li>QR Code Generator</li>
</ul>
</td>
<td>
<ul>
<li>ejs-barcodegenerator</li>
<li>ejs-datamatrixgenerator</li>
<li>ejs-qrcodegenerator</li>
</ul>
</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.BlockEditor

The ASP.NET Core BlockEditor is a modern, block-based content editor for composing rich, structured documents.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.BlockEditor/">Syncfusion.AspNetCore.BlockEditor</a></td>
<td>Block Editor</td>
<td>ejs-blockeditor</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.BulletChart

The ASP.NET Core Bullet Chart is used to visually compare measures, similar to the commonly used bar chart. It displays one or more measures and compares them with a target value across performance ranges such as poor, satisfactory, and good.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.BulletChart/">Syncfusion.AspNetCore.BulletChart</a></td>
<td>Bullet Chart</td>
<td>ejs-bulletchart</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Buttons

The ASP.NET Core Buttons package contains UI components such as Button, Checkbox, RadioButton, Switch, and Chip. It is easy to use and integrate within forms.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Buttons/">Syncfusion.AspNetCore.Buttons</a></td>
<td>
<ul>
<li>Button</li>
<li>CheckBox</li>
<li>Chip</li>
<li>Floating Action Button</li>
<li>RadioButton</li>
<li>Speed Dial</li>
<li>Toggle Switch Button</li>
</ul>
</td>
<td>
<ul>
<li>ejs-button</li>
<li>ejs-checkbox</li>
<li>ejs-chiplist</li>
<li>ejs-fab</li>
<li>ejs-radiobutton</li>
<li>ejs-speeddial</li>
<li>ejs-switch</li>
</ul>
</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.Calendars

The ASP.NET Core Calendars package contains date and time components such as Calendar, DatePicker, DateRangePicker, DateTimePicker, and TimePicker. These components come with options to disable dates, restrict selection, and show custom events.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Calendars/">Syncfusion.AspNetCore.Calendars</a></td>
<td>
<ul>
<li>Calendar</li>
<li>DatePicker</li>
<li>DateRangePicker</li>
<li>DateTime Picker</li>
<li>Time Picker</li>
</ul>
</td>
<td>
<ul>
<li>ejs-calendar</li>
<li>ejs-datepicker</li>
<li>ejs-daterangepicker</li>
<li>ejs-datetimepicker</li>
<li>ejs-timepicker</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Charts

The ASP.NET Core Charts package is a well-crafted charting component to visualize data. It contains a rich gallery of 30+ charts and graphs, ranging from line to financial charts that cater to all charting scenarios. It comes with features such as zooming, panning, tooltip, crosshair, trackball, highlight, and selection.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Charts/">Syncfusion.AspNetCore.Charts</a></td>
<td>
<ul>
<li>Charts</li>
<li>Accumulation Chart</li>
</ul>
</td>
<td>
<ul>
<li>ejs-chart</li>
<li>ejs-accumulationchart</li>
</ul>
</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.Chart3D

The ASP.NET Core 3D Chart is a graphical representation of data in three dimensions, showcasing relationships and trends among variables.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Chart3D/">Syncfusion.AspNetCore.Chart3D</a></td>
<td>3D Chart</td>
<td>ejs-chart3d</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.CircularChart3D

The ASP.NET Core Circular 3D Chart renders pie and donut series in a three-dimensional space, enabling rich visual representations of proportional data.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.CircularChart3D/">Syncfusion.AspNetCore.CircularChart3D</a></td>
<td>Circular 3D Chart</td>
<td>ejs-circularchart3d</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.CircularGauge

The ASP.NET Core Circular Gauge is used for visualizing numeric values on a circular scale with features like multiple axes, rounded corners, and more. The appearance of the gauge can be completely customized to simulate a speedometer, meter gauge, analog clock, etc.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.CircularGauge/">Syncfusion.AspNetCore.CircularGauge</a></td>
<td>Circular Gauge</td>
<td>ejs-circulargauge</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.Diagram

The ASP.NET Core Diagram component is a high-speed, robust library for crafting, editing, and interacting with dynamic diagrams. It supports flowcharts, org charts, mind maps, and more with seamless editing and intuitive interactions.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Diagram/">Syncfusion.AspNetCore.Diagram</a></td>
<td>
<ul>
<li>Diagram</li>
<li>Overview Panel</li>
<li>Symbol Palette</li>
</ul>
</td>
<td>
<ul>
<li>ejs-diagram</li>
<li>ejs-overview</li>
<li>ejs-symbolpalette</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.DocumentEditor

The ASP.NET Core Document Editor (Word Processor) provides all the common Word processing features including editing text, formatting contents, resizing images and tables, finding and replacing text, bookmarks, tables of contents, printing, and importing and exporting Word documents.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.DocumentEditor/">Syncfusion.AspNetCore.DocumentEditor</a></td>
<td>
<ul>
<li>Document Editor</li>
<li>Document Editor Container</li>
</ul>
</td>
<td>
<ul>
<li>ejs-documenteditor</li>
<li>ejs-documenteditorcontainer</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.DropDowns

The ASP.NET Core DropDowns package contains a collection of dropdown components such as DropDown List, Combo Box, AutoComplete, MultiSelect DropDown, ListBox, and Mention. These components include features such as data binding, grouping, sorting, filtering, and templates.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.DropDowns/">Syncfusion.AspNetCore.DropDowns</a></td>
<td>
<ul>
<li>AutoComplete</li>
<li>ComboBox</li>
<li>DropDown List</li>
<li>ListBox</li>
<li>MultiSelect DropDown</li>
<li>Mention</li>
</ul>
</td>
<td>
<ul>
<li>ejs-autocomplete</li>
<li>ejs-combobox</li>
<li>ejs-dropdownlist</li>
<li>ejs-listbox</li>
<li>ejs-multiselect</li>
<li>ejs-mention</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.FileManager

The ASP.NET Core FileManager is a graphical user interface component used to manage the file system. It enables users to perform common file operations such as accessing, editing, uploading, downloading, and sorting files and folders, and also allows easy navigation for browsing or selecting a file or folder from the file system.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.FileManager/">Syncfusion.AspNetCore.FileManager</a></td>
<td>FileManager</td>
<td>ejs-filemanager</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelayouts">Syncfusion.AspNetCore.Layouts</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Gantt

The ASP.NET Core Gantt is designed to visualize and edit the project schedule and track project progress. It helps to organize and schedule projects, and the project schedule can be updated through interactions like editing, dragging, and resizing.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Gantt/">Syncfusion.AspNetCore.Gantt</a></td>
<td>Gantt Chart</td>
<td>ejs-gantt</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelayouts">Syncfusion.AspNetCore.Layouts</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorerichtexteditor">Syncfusion.AspNetCore.RichTextEditor</a></li>
<li><a href="#syncfusionaspnetcoretreegrid">Syncfusion.AspNetCore.TreeGrid</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Grid

The ASP.NET Core DataGrid is used to display and manipulate tabular data with configuration options to control the way the data is presented. It pulls data from data sources such as IEnumerable collections, OData web services, and more and supports binding data fields to columns with grouped records.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Grid/">Syncfusion.AspNetCore.Grid</a></td>
<td>DataGrid</td>
<td>ejs-grid</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.HeatMap

The ASP.NET Core HeatMap Chart is used to visualize two-dimensional data in which the values are represented in gradient or fixed colors.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.HeatMap/">Syncfusion.AspNetCore.HeatMap</a></td>
<td>HeatMap Chart</td>
<td>ejs-heatmap</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.ImageEditor

The ASP.NET Core Image Editor component loads and modifies images by performing actions like cropping, rotating, resizing, applying filters, inserting text and shapes such as rectangles, circles, and arrows on top of an image, and drawing freehand.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.ImageEditor/">Syncfusion.AspNetCore.ImageEditor</a></td>
<td>Image Editor</td>
<td>ejs-imageeditor</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.InPlaceEditor

The ASP.NET Core In-place Editor component is most useful for editing a value dynamically within its context (in-place). Its features include inline and pop-up modes, and customizable UI and events.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.InPlaceEditor/">Syncfusion.AspNetCore.InPlaceEditor</a></td>
<td>In-place Editor</td>
<td>ejs-inplaceeditor</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorerichtexteditor">Syncfusion.AspNetCore.RichTextEditor</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Inputs

The ASP.NET Core Inputs package comes with a collection of form components used to get different input values from users such as text, numbers, patterns, color, and file inputs.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Inputs/">Syncfusion.AspNetCore.Inputs</a></td>
<td>
<ul>
<li>Color Picker</li>
<li>Input Mask</li>
<li>Numeric TextBox</li>
<li>Rating</li>
<li>Range Slider</li>
<li>TextBox</li>
<li>File Upload</li>
<li>Signature</li>
<li>TextArea</li>
<li>OTP Input</li>
<li>Speech To Text</li>
</ul>
</td>
<td>
<ul>
<li>ejs-colorpicker</li>
<li>ejs-maskedtextbox</li>
<li>ejs-numerictextbox</li>
<li>ejs-rating</li>
<li>ejs-slider</li>
<li>ejs-textbox</li>
<li>ejs-uploader</li>
<li>ejs-signature</li>
<li>ejs-textarea</li>
<li>ejs-otpinput</li>
<li>ejs-speechtotext</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.InteractiveChat

The ASP.NET Core InteractiveChat package provides an AI AssistView interface through which users can interact with AI-driven suggestions and prompts, along with a Chat UI component for real-time messaging experiences.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.InteractiveChat/">Syncfusion.AspNetCore.InteractiveChat</a></td>
<td>
<ul>
<li>AI AssistView</li>
<li>Inline AI Assist</li>
<li>Chat UI</li>
</ul>
</td>
<td>
<ul>
<li>ejs-aiassistview</li>
<li>ejs-inlineaiassist</li>
<li>ejs-chatui</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Kanban

The ASP.NET Core Kanban board visually depicts work at various stages of a process using columns, cards, and swimlanes.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Kanban/">Syncfusion.AspNetCore.Kanban</a></td>
<td>Kanban</td>
<td>ejs-kanban</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Layouts

The ASP.NET Core Layouts package contains Splitter, Dashboard Layout, and Timeline components. The Dashboard Layout is a grid structured layout control that helps to create a dashboard with panels. The Splitter is a layout component used to construct different layouts using multiple and nested panes that are resizable and expandable.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Layouts/">Syncfusion.AspNetCore.Layouts</a></td>
<td>
<ul>
<li>Dashboard Layout</li>
<li>Splitter</li>
<li>Timeline</li>
</ul>
</td>
<td>
<ul>
<li>ejs-dashboardlayout</li>
<li>ejs-splitter</li>
<li>ejs-timeline</li>
</ul>
</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.LinearGauge

The ASP.NET Core Linear Gauge is used for visualizing numeric values in a linear scale with features like multiple axes, different orientations, and more. The appearance of the gauge can be completely customized to simulate a thermometer, pressure gauge, ruler, etc.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.LinearGauge/">Syncfusion.AspNetCore.LinearGauge</a></td>
<td>Linear Gauge</td>
<td>ejs-lineargauge</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.Lists

The ASP.NET Core ListView component allows selecting an item or multiple items from a list-like interface and represents data in an interactive hierarchical structure across different layouts or views.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Lists/">Syncfusion.AspNetCore.Lists</a></td>
<td>ListView</td>
<td>ejs-listview</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Maps

The ASP.NET Core Maps component is used for rendering maps from GeoJSON data or other map providers like OpenStreetMap, Google Maps, and Bing Maps. Its rich feature set includes markers, labels, bubbles, navigation lines, legends, tooltips, zooming, panning, drill down, and much more.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Maps/">Syncfusion.AspNetCore.Maps</a></td>
<td>Maps</td>
<td>ejs-maps</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.MultiColumnComboBox

The ASP.NET Core MultiColumn ComboBox displays a dropdown list with multiple columns, allowing users to select values from a tabular data representation with rich data binding and filtering capabilities.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.MultiColumnComboBox/">Syncfusion.AspNetCore.MultiColumnComboBox</a></td>
<td>MultiColumn ComboBox</td>
<td>ejs-multicolumncombobox</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Navigations

The ASP.NET Core Navigations package contains a collection of navigation components such as Accordion, AppBar, Breadcrumb, Context Menu, DropDown Tree, Menu Bar, Sidebar, Stepper, Tabs, Toolbar, TreeView, and Pager.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Navigations/">Syncfusion.AspNetCore.Navigations</a></td>
<td>
<ul>
<li>Accordion</li>
<li>AppBar</li>
<li>Breadcrumb</li>
<li>Carousel</li>
<li>ContextMenu</li>
<li>DropDown Tree</li>
<li>Menu Bar</li>
<li>Sidebar</li>
<li>Stepper</li>
<li>Tabs</li>
<li>Toolbar</li>
<li>TreeView</li>
</ul>
</td>
<td>
<ul>
<li>ejs-accordion</li>
<li>ejs-appbar</li>
<li>ejs-breadcrumb</li>
<li>ejs-carousel</li>
<li>ejs-contextmenu</li>
<li>ejs-dropdowntree</li>
<li>ejs-menu</li>
<li>ejs-sidebar</li>
<li>ejs-stepper</li>
<li>ejs-tab</li>
<li>ejs-toolbar</li>
<li>ejs-treeview</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Notifications

The ASP.NET Core Notifications package contains components such as Toast, Skeleton, and Message used to notify status or summary information to end-users.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Notifications/">Syncfusion.AspNetCore.Notifications</a></td>
<td>
<ul>
<li>Toast</li>
<li>Skeleton</li>
<li>Message</li>
</ul>
</td>
<td>
<ul>
<li>ejs-toast</li>
<li>ejs-skeleton</li>
<li>ejs-message</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.PdfViewer

The ASP.NET Core PDF Viewer supports viewing and reviewing PDF files in web applications and also printing them. The thumbnail, bookmark, hyperlink, and the table of contents support provides easy navigation within and outside PDF files. The form-filling support provides a platform to fill and print with AcroForms, and the PDF files can be reviewed with the available annotation tools.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.PdfViewer/">Syncfusion.AspNetCore.PdfViewer</a></td>
<td>PDF Viewer</td>
<td>ejs-pdfviewer</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinplaceeditor">Syncfusion.AspNetCore.InPlaceEditor</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorerichtexteditor">Syncfusion.AspNetCore.RichTextEditor</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.PivotView

The ASP.NET Core Pivot Table is a powerful control used to organize and summarize business data and display the result in a cross-table format. It includes major functionalities such as data binding, drilling up and down, Excel-like filtering and sorting, editing, Excel and PDF exporting, and several built-in aggregations.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.PivotView/">Syncfusion.AspNetCore.PivotView</a></td>
<td>
<ul>
<li>Pivot Table</li>
<li>Pivot Field List</li>
</ul>
</td>
<td>
<ul>
<li>ejs-pivotview</li>
<li>ejs-pivotfieldlist</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelayouts">Syncfusion.AspNetCore.Layouts</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Popups

The ASP.NET Core Popups package contains Dialog and Tooltip components used to display information or to get input from users in a popup.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Popups/">Syncfusion.AspNetCore.Popups</a></td>
<td>
<ul>
<li>Dialog</li>
<li>Tooltip</li>
</ul>
</td>
<td>
<ul>
<li>ejs-dialog</li>
<li>ejs-tooltip</li>
<li>ejs-tooltip</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.ProgressBar

The ASP.NET Core Progress Bar control can be used to visualize the changing status of an extended operation such as a download, file transfer, or installation. All progress bar elements are rendered using scalable vector graphics (SVG) to ensure the quality of the visual experience.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.ProgressBar/">Syncfusion.AspNetCore.ProgressBar</a></td>
<td>ProgressBar</td>
<td>ejs-progressbar</td>
<td><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></td>
</tr>
</table>

## Syncfusion.AspNetCore.QueryBuilder

The ASP.NET Core QueryBuilder package contains the QueryBuilder component that allows users to create and edit filters. It supports data binding, templates, validation, and horizontal and vertical orientation.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.QueryBuilder/">Syncfusion.AspNetCore.QueryBuilder</a></td>
<td>QueryBuilder</td>
<td>ejs-querybuilder</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.RangeNavigator

The ASP.NET Core Range Navigator is an interface for selecting a small range from a larger collection. It is commonly used in financial dashboards to filter a date range for data that needs to be visualized.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.RangeNavigator/">Syncfusion.AspNetCore.RangeNavigator</a></td>
<td>Range Navigator</td>
<td>ejs-rangenavigator</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Ribbon

The ASP.NET Core Ribbon component provides a Microsoft Office-style toolbar that organizes commands and tools into tabs and groups for efficient access to application functionality.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Ribbon/">Syncfusion.AspNetCore.Ribbon</a></td>
<td>Ribbon</td>
<td>ejs-ribbon</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.RichTextEditor

The ASP.NET Core Rich Text Editor component is the HTML and Markdown editor that provides the best user experience for creating, updating, and formatting content.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.RichTextEditor/">Syncfusion.AspNetCore.RichTextEditor</a></td>
<td>
<ul>
<li>Rich Text Editor</li>
<li>Markdown Editor</li>
</ul>
</td>
<td>ejs-richtexteditor</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Sankey

The ASP.NET Core Sankey chart visualizes flow quantities between nodes using proportional-width bands, making it ideal for displaying energy transfers, budget flows, and other weighted relationships.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Sankey/">Syncfusion.AspNetCore.Sankey</a></td>
<td>Sankey</td>
<td>ejs-sankey</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Schedule

The ASP.NET Core Scheduler component is an event calendar that facilitates users with common Outlook-calendar features, allowing them to plan and manage their events and appointments in an efficient way.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Schedule/">Syncfusion.AspNetCore.Schedule</a></td>
<td>
<ul>
<li>Scheduler</li>
<li>Recurrence Editor</li>
</ul>
</td>
<td>
<ul>
<li>ejs-schedule</li>
<li>ejs-recurrenceeditor</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.SmartComponents

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Smart Components are designed to seamlessly integrate with AI, offering intelligent features that go beyond standard user interfaces.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.SmartComponents/">Syncfusion.AspNetCore.SmartComponents</a></td>
<td>
<ul>
<li>Smart Paste Button</li>
<li>Smart TextArea</li>
</ul>
</td>
<td>
<ul>
<li>ejs-smartpastebutton</li>
<li>ejs-smarttextarea</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Smithchart

The ASP.NET Core Smith Chart is a control for showing the parameters of transmission lines in high-frequency circuit applications. Its rich feature set includes legends, markers, tooltips, and data labels.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Smithchart/">Syncfusion.AspNetCore.Smithchart</a></td>
<td>Smith Chart</td>
<td>ejs-smithchart</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Sparkline

The ASP.NET Core Sparkline Charts are a replacement for normal charts to display trends in a very small area. Completely customize sparklines by changing the series or axis type and by adding markers, data labels, range bands, and more.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Sparkline/">Syncfusion.AspNetCore.Sparkline</a></td>
<td>Sparkline</td>
<td>ejs-sparkline</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.SplitButtons

The ASP.NET Core SplitButtons package contains UI components such as DropDownButton, SplitButton, ProgressButton, and ButtonGroup. DropDownButton and SplitButton display a list of items when a button is clicked, and ButtonGroup can be used for easy navigation.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.SplitButtons/">Syncfusion.AspNetCore.SplitButtons</a></td>
<td>
<ul>
<li>DropDownButton</li>
<li>ProgressButton</li>
<li>SplitButton</li>
</ul>
</td>
<td>
<ul>
<li>ejs-dropdownbutton</li>
<li>ejs-progressbutton</li>
<li>ejs-splitbutton</li>
</ul>
</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Spreadsheet

The ASP.NET Core Spreadsheet provides all the common Excel features, including data binding, selection, editing, formatting, resizing, sorting, importing, and exporting Excel documents.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Spreadsheet/">Syncfusion.AspNetCore.Spreadsheet</a></td>
<td>Spreadsheet</td>
<td>ejs-spreadsheet</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorelayouts">Syncfusion.AspNetCore.Layouts</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenavigations">Syncfusion.AspNetCore.Navigations</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoreribbon">Syncfusion.AspNetCore.Ribbon</a></li>
<li><a href="#syncfusionaspnetcorerichtexteditor">Syncfusion.AspNetCore.RichTextEditor</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcoretreegrid">Syncfusion.AspNetCore.TreeGrid</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.StockChart

The ASP.NET Core Stock Chart is an easy-to-use financial charting package to track and visualize the stock price of any company over a specific period using charting and range tools. It also comes with features such as zooming, panning, tooltip, crosshair, trackball, period selector, range selector, and events.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.StockChart/">Syncfusion.AspNetCore.StockChart</a></td>
<td>Stock Chart</td>
<td>ejs-stockchart</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.Themes

This package contains the Syncfusion® ASP.NET Core UI components theme files. 

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/">Syncfusion.AspNetCore.Themes</a></td>
<td>
<ul>
    <li>Bootstrap</li>
    <li>Bootstrap</li>
    <li>Bootstrap Dark</li>
    <li>Bootstrap v4</li>
    <li>Bootstrap v5</li>
    <li>Bootstrap v5 Dark</li>
    <li>Bootstrap v5.3</li>
    <li>Bootstrap v5.3 Dark</li>
    <li>Fluent</li>
    <li>Fluent</li>
    <li>Fluent Dark</li>
    <li>Fluent v2</li>
    <li>Fluent v2 Dark</li>
    <li>Fluent v2 High Contrast</li>
    <li>Material</li>
    <li>Material</li>
    <li>Material Dark</li>
    <li>Material v3</li>
    <li>Material v3 Dark</li>
    <li>Tailwind</li>
    <li>Tailwind</li>
    <li>Tailwind Dark</li>
    <li>Tailwind v3</li>
    <li>Tailwind v3 Dark</li>
    <li>Others</li>
    <li>Fabric</li>
    <li>Fabric Dark</li>
    <li>High Contrast</li>
</ul>
</td>
<td>-</td>
<td>
<ul>
none
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.TreeGrid

The ASP.NET Core Tree Grid is a feature-rich control used to visualize self-referential and hierarchical data effectively in a tabular format. It supports expanding and collapsing child data using the tree column.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.TreeGrid/">Syncfusion.AspNetCore.TreeGrid</a></td>
<td>TreeGrid</td>
<td>ejs-treegrid</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorebuttons">Syncfusion.AspNetCore.Buttons</a></li>
<li><a href="#syncfusionaspnetcorecalendars">Syncfusion.AspNetCore.Calendars</a></li>
<li><a href="#syncfusionaspnetcoredropdowns">Syncfusion.AspNetCore.DropDowns</a></li>
<li><a href="#syncfusionaspnetcoregrid">Syncfusion.AspNetCore.Grid</a></li>
<li><a href="#syncfusionaspnetcoreinputs">Syncfusion.AspNetCore.Inputs</a></li>
<li><a href="#syncfusionaspnetcorepopups">Syncfusion.AspNetCore.Popups</a></li>
<li><a href="#syncfusionaspnetcoresplitbuttons">Syncfusion.AspNetCore.SplitButtons</a></li>
<li><a href="#syncfusionaspnetcorelists">Syncfusion.AspNetCore.Lists</a></li>
<li><a href="#syncfusionaspnetcorenotifications">Syncfusion.AspNetCore.Notifications</a></li>
</ul>
</td>
</tr>
</table>

## Syncfusion.AspNetCore.TreeMap

The ASP.NET Core TreeMap is a feature-rich component used to visualize both hierarchical and flat data. The look and feel of the treemaps can be customized by using the built-in features like color mapping, legends, and label templates.

<table>
<tr>
<td><b>NuGet package</b></td>
<td><b>Components friendly name</b></td>
<td><b>Components name</b></td>
<td><b>Dependencies</b></td>
</tr>
<tr>
<td><a href="https://www.nuget.org/packages/Syncfusion.AspNetCore.TreeMap/">Syncfusion.AspNetCore.TreeMap</a></td>
<td>TreeMap</td>
<td>ejs-treemap</td>
<td>
<ul>
<li><a href="#syncfusionaspnetcorebase">Syncfusion.AspNetCore.Base</a></li>
<li><a href="#syncfusionaspnetcorecharts">Syncfusion.AspNetCore.Charts</a></li>
</ul>
</td>
</tr>
</table>

<!-- markdownlint-enable MD033 -->

## Benefits of using individual NuGet packages

* Individual NuGet packages help reduce the overall application deployment size by referencing only the packages required for the components used in the application.

* Installing `Syncfusion.EJ2.AspNet.Core` loads the complete Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core library, which increases the application size. Individual package installation resolves this and loads only the required component assemblies.

* These individual NuGet packages can be used in ASP.NET Core applications to reduce the application deployment size in production.
