---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Daterangepicker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of DateRangePicker component from Essential JS 1 to Essential JS 2.

## Date selection

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Setting the value
</td>
<td>
<b>Property:</b> <i>value</i>

```html
    <ej-date-range-picker id="daterange"  value="5/5/2014 - 6/6/2018"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>value</i>

```html
    <ejs-daterangepicker id="daterange" value="@ViewBag.value"></ejs-daterangepicker>
```

<b>HomeController.cs</b>

```c#
    ViewBag.value = new DateTime[] { new DateTime(2018,9,9), new DateTime(2018,9,29) };
```

</td>
</tr>
</thead>
</table>

## Date format

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Display date format
</td>
<td>
<b>Property:</b> <i>date-format</i>

```html
    <ej-date-range-picker id="daterange" date-format="dd/MM/yyyy"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>format</i>

```html
    <ejs-daterangepicker id="daterange" startDate="new DateTime(2017,11,7)" endDate="new DateTime(2017,11,21)" format="dd/MMM/yy hh:mm a"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Date range

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Minimum date
</td>
<td>
<b>Property:</b> <i>min-date</i>

```html
    <ej-date-range-picker id="daterange" min-date="new DateTime(2018,9,3)"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>min</i>

```html
    <ejs-daterangepicker id="daterange" min="new DateTime(2018,9,3)"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Maximum date
</td>
<td>
<b>Property:</b> <i>max-date</i>

```html
    <ej-date-range-picker id="daterange" max-date="new DateTime(2019,1,1)"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>max</i>

```html
    <ejs-daterangepicker id="daterange" max="new DateTime(2019,1,1)"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Start date
</td>
<td>
<b>Property:</b> <i>start-date</i>

```html
    <ej-date-range-picker id="daterange" start-date="new DateTime(2019,1,1)"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>startDate</i>

```html
    <ejsdaterangepicker id="daterange" startDate="new DateTime(2019,1,1)"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
End date
</td>
<td>
<b>Property:</b> <i>end-date</i>

```html
    <ej-date-range-picker id="daterange" end-date="new DateTime(2019,1,1)"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>endDate</i>

```html
    <ejs-daterangepicker id="daterange" endDate="new DateTime(2019,1,1)"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Preset ranges
</td>
<td>
<b>Property:</b> <i>ranges</i>

```html
    @{  DateTime Today = DateTime.Now; }

    <ej-date-range-picker id="DateRange">
        <e-ranges>
            <e-range label="Last 1 Month" range="new List<Object>() { Today.AddMonths(-1).ToString(), Today.ToString() }" />
            <e-range label="Last 2 Months" range="new List<Object>() { Today.AddMonths(-2).ToString(), Today.ToString() }" />
            <e-range label="Last Week" range="new List<Object>() { Today.AddDays(-7).ToString(), Today.ToString() }" />
        </e-ranges>
    </ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>presets</i>

```html
    <ejs-daterangepicker id="daterange">
        <e-daterangepicker-presets>
            <e-daterangepicker-preset id="week" label="This Week" start="ViewBag.weekStart" end="ViewBag.weekEnd"></e-daterangepicker-preset>
            <e-daterangepicker-preset id="month" label="This Month" start="ViewBag.monthStart" end="ViewBag.monthEnd"></e-daterangepicker-preset>
        </e-daterangepicker-presets>
    </ejs-daterangepicker>
```

<b> HomeController.cs </b>

```c#
    int days = (int)DateTime.Now.DayOfWeek;
    ViewBag.weekStart = DateTime.Now.AddDays(-days);
    ViewBag.weekEnd = ViewBag.weekStart.AddDays(6);
    ViewBag.monthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    ViewBag.monthEnd = ViewBag.monthStart.AddMonths(1).AddDays(-1);
```

</td>
</tr>
<tr>
<td>
Add ranges
</td>
<td>
<b>Method:</b> <i>addRanges()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.addRanges("new Range", [new Date("11/12/2019"), new Date("11/12/2021")]);
        }
    </script>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Clear ranges
</td>
<td>
<b>Method:</b> <i>clearRanges()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.clearRanges();
        }
    </script>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Get selected range
</td>
<td>
<b>Method:</b> <i>getSelectedRange()</i>

```html
    <ej-date-range-picker id="daterange" start-date="new DateTime(2018,1,1)" end-date="new DateTime(2018,1,10)" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            console.log(dateObj.getSelectedRange());
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>getSelectedRange()</i>

```html
    <ejs-daterangepicker id="daterange" startdate="new DateTime(2018,1,1)" enddate="new DateTime(2018,1,10)"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObj = document.getElementById("daterange").ej2_instances[0];
            console.log(daterangeObj.getSelectedRange());
        }
    </script>
```

</td>
</tr>
<tr>
<td>
Set date range
</td>
<td>
<b>Method:</b> <i>setRange()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.setRange([new Date("11/12/2011"), new Date("11/12/2019")]);
        }
    </script>
```

<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>

## Disabled dates

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Disabled dates
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-daterangepicker id="daterange" renderdaycell="disableDaterange"></ejs-daterangepicker>

    <script>
        function disableDaterange(args) {
            if (args.date.getDay() === 0 || args.date.getDay() === 6) {
                args.isDisabled = true;
            }
        }
    </script>
```

</td>
</tr>
</thead>
</table>

## Customization

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
cssClass
</td>
<td>
<b>Property:</b> <i>css-class</i>

```html
    <ej-date-range-picker id="daterange"  css-class="gradient-lime"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-daterangepicker id="daterange" cssClass="gradient-lime"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Enable time picker
</td>
<td>
<b>Property:</b> <i>enable-time-picker</i>

```html
    <ej-date-range-picker id="daterange"  enable-time-picker="true"></ej-date-range-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Time format
</td>
<td>
<b>Property:</b> <i>timeFormat</i>

```html
    <ej-date-range-picker id="daterange"  time-format="HH:mm"></ej-date-range-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Min days
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>minDays</i>

```html
    <ejs-daterangepicker id="daterange" minDays="5"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Max days
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>maxDays</i>

```html
    <ejs-daterangepicker id="daterange" maxDays="10"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Button text
</td>
<td>
<b>Property:</b> <i>button-text</i>

```html
    <ej-date-range-picker id="daterange">
        <e-date-range-button-text apply="Apply" cancel="Cancel" reset="Reset" />
    </ej-date-range-picker>
```

</td>
<td>
<b>Method:</b> <i>load()</i>

```html
    <ejs-daterangepicker id="daterange" locale="en"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            daterangepicker = document.getElementById('daterange').ej2_instances[0];
            var L10n = ej.base.L10n;
            L10n.load({
                'en': {
                    'daterangepicker': { applyText: 'Apply' }
                }
            });
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Show popup button
</td>
<td>
<b>Property:</b> <i>show-popup-button</i>

```html
    <ej-date-range-picker id="daterange" show-popup-button="false"></ej-date-range-picker>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-daterangepicker id="daterange" focus="onFocus"></ejs-daterangepicker>

    <script>
        function onFocus(args) {
            var daterangepicker = document.getElementById("daterange").ej2_instances[0];
            daterangepicker.show();
        }
    </script>

    <style>
        .e-control-wrapper .e-input-group-icon.e-range-icon {
            display: none;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Show rounded corner
</td>
<td>
<b>Property:</b> <i>show-rounded-corner</i>

```html
    <ej-date-range-picker id="daterange" show-rounded-corner="true"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-daterangepicker id="daterange" cssclass="e-custom-style"></ejs-daterangepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-range-wrapper.e-input-group {
            border-radius: 4px;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Focus In event
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-daterangepicker id="daterange" focus="onFocus"></ejs-daterangepicker>

    <script>
        function onFocus(args) { }
    </script>
```

</td>
</tr>
<tr>
<td>
Focus out event
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>blur</i>

```html
    <ejs-daterangepicker id="daterange" blur="onBlur"></ejs-daterangepicker>

    <script>
        function onBlur(args) { }
    </script>
```

</td>
</tr>
<tr>
<td>
Focus In method
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Method:</b> <i>focusIn()</i>

```html
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.focusIn();
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Focus out method
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Method:</b> <i>focusOut()</i>

```html
   <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.focusOut();
        });
    </script>
```

</td>
</tr>
</thead>
</table>

## Accessibility

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Enable RTL
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>enableRtl</i>

```html
    <ejs-daterangepicker id="daterange" enableRtl="true"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Persistence

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Enable Persistence
</td>
<td>
<b>Property:</b> <i>enable-persistence</i>

```html
    <ej-date-range-picker id="daterange" enable-persistence="true"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>enablePersistence</i>

```html
    <ejs-daterangepicker id="daterange" startDate="new DateTime(2018,1,1)" endDate="new DateTime(2018,1,10)" enablePersistence="true"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Common

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Width
</td>
<td>
<b>Property:</b> <i>width</i>

```html
    <ej-date-range-picker id="daterange" width="200"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>width</i>

```html
    <ejs-daterangepicker id="daterange" width="200"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Read only
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>readonly</i>

```html
    <ejs-daterangepicker id="daterange" readonly="true"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Show clear button
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>showClearButton</i>

```html
    <ejs-daterangepicker id="daterange" showClearButton="true"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Height
</td>
<td>
<b>Property:</b> <i>height</i>

```html
    <ej-date-range-picker id="daterange" height="35"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-daterangepicker id="daterange" cssclass="e-custom-style"></ejs-daterangepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-range-wrapper.e-input-group {
            height: 35px;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Week number
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>weekNumber</i>

```html
    <ejs-daterangepicker id="daterange" weekNumber="true"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Watermark text
</td>
<td>
<b>Property:</b> <i>watermark-text</i>

```html
    <ej-date-range-picker id="daterange" watermark-text="Select Range"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>placeholder</i>

```html
    <ejs-daterangepicker id="daterange" placeholder="Select Range"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Enable and disable
</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ej-date-range-picker id="daterange" enabled="false"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ejs-daterangepicker id="daterange" enabled="false"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Disable date
</td>
<td>
<b>Method:</b> <i>disable()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var daterangeObj = $("#daterange").data("ejDateRangePicker");
            daterangeObj.disable();
        }
    </script>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Enable date
</td>
<td>
<b>Method:</b> <i>enable()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var daterangeObj = $("#daterange").data("ejDateRangePicker");
            daterangeObj.enable();
        }
    </script>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Allow edit
</td>
<td>
<b>Property:</b> <i>allow-edit</i>

```html
    <ej-date-range-picker id="daterange" allow-edit="false"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>allowEdit</i>

```html
    <ejs-daterangepicker id="daterange" allowEdit="false"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
Float label type
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>floatLabelType</i>

```html
    <ejs-daterangepicker id="daterange" placeholder="Select Range" floatLabelType="Syncfusion.EJ2.Inputs.FloatLabelType.Auto"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
z Index
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>zIndex</i>

```html
    <ej-date-range-picker id="daterange" zIndex="100"></ej-date-range-picker>
```

</td>
</tr>
<tr>
<td>
Separator
</td>
<td>
<b>Property:</b> <i>separator</i>

```html
    <ej-date-range-picker id="daterange" separator="$"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>separator</i>

```html
    <ejs-daterangepicker id="daterange" separator="$"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Globalization

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Locale
</td>
<td>
<b>Property:</b> <i>locale</i>

```html
    <ej-date-range-picker id="daterange" locale="en-US"></ej-date-range-picker>
```

</td>
<td>
<b>Property:</b> <i>locale</i>

```html
    <ejs-daterangepicker id="daterange" locale="en"></ejs-daterangepicker>
```

</td>
</tr>
<tr>
<td>
First day of week
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>firstDayOfWeek</i>

```html
    <ejs-dateragepicker id="daterange" firstDayOfWeek="2"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Strict mode

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Strict mode
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>strictMode</i>

```html
    <ejs-daterangepicker id="daterange" strictMode="true"></ejs-daterangepicker>
```

</td>
</tr>
</thead>
</table>

## Open and Close

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Close
</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ej-date-range-picker id="daterange" close="onClose"></ej-date-range-picker>

    <script>
        function onClose() {}
    </script>
```

</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ejs-daterangepicker id="daterange" close="onClose"></ejs-daterangepicker>

    <script>
        function onClose() {}
    </script>
```

</td>
</tr>
<tr>
<td>
Hide
</td>
<td>
<b>Method:</b> <i>popupHide()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate(args) {
            var daterangeObject = $("#daterange").data("ejDateRangePicker");
            daterangeObject.popupShow(); daterangeObject.popupHide();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>hide()</i>

```html
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.show();
            daterangeObject.hide();
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Open
</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ej-date-range-picker id="daterange" open="onOpen"></ej-date-range-picker>

    <script>
        function onOpen(args) { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ejs-daterangepicker id="daterange" open="onOpen"></ejs-daterangepicker>

    <script>
        function onOpen(args) { }
    </script>
```

</td>
</tr>
<tr>
<td>
Show
</td>
<td>
<b>Method:</b> <i>popupShow()</i>

```html
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate(args) {
            var daterangeObject = $("#daterange").data("ejDateRangePicker");
            daterangeObject.popupShow();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>show()</i>

```html
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.show();
        }
    </script>
```

</td>
</tr>
</thead>
</table>

## View navigation

<!-- markdownlint-disable MD033 -->
<table>
<thead>
<tr>
<th>Behavior</th>
<th>API in Essential JS 1</th>
<th>API in Essential JS 2</th>
</tr>
<tr>
<td>
Navigation
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>navigated</i>

```html
    <ejs-daterangepicker id="daterange" navigated="onNavigated"></ejs-daterangepicker>

    <script>
        function onNavigated() { }
    </script>
```

</td>
</tr>
</thead>
</table>
