---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Daterangepicker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Daterangepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of DateRangePicker component from Essential JS 1 to Essential JS 2.

## Date selection

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange"  value="5/5/2014 - 6/6/2018"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>value</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" value="@ViewBag.value"></ejs-daterangepicker>
{% endhighlight %}

<b>HomeController.cs</b>
<br>
{% highlight c# %}
    ViewBag.value = new DateTime[] { new DateTime(2018,9,9), new DateTime(2018,9,29) };
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Date format

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" date-format="dd/MM/yyyy"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>format</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" startDate="new DateTime(2017,11,7)" endDate="new DateTime(2017,11,21)" format="dd/MMM/yy hh:mm a"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Date range

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" min-date="new DateTime(2018,9,3)"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>min</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" min="new DateTime(2018,9,3)"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Maximum date
</td>
<td>
<b>Property:</b> <i>max-date</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" max-date="new DateTime(2019,1,1)"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>max</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" max="new DateTime(2019,1,1)"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Start date
</td>
<td>
<b>Property:</b> <i>start-date</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" start-date="new DateTime(2019,1,1)"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>startDate</i>
<br>
{% highlight html %}
    <ejsdaterangepicker id="daterange" startDate="new DateTime(2019,1,1)"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
End date
</td>
<td>
<b>Property:</b> <i>end-date</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" end-date="new DateTime(2019,1,1)"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>endDate</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" endDate="new DateTime(2019,1,1)"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Preset ranges
</td>
<td>
<b>Property:</b> <i>ranges</i>
<br>
{% highlight html %}
    @{  DateTime Today = DateTime.Now; }

    <ej-date-range-picker id="DateRange">
        <e-ranges>
            <e-range label="Last 1 Month" range="new List<Object>() { Today.AddMonths(-1).ToString(), Today.ToString() }" />
            <e-range label="Last 2 Months" range="new List<Object>() { Today.AddMonths(-2).ToString(), Today.ToString() }" />
            <e-range label="Last Week" range="new List<Object>() { Today.AddDays(-7).ToString(), Today.ToString() }" />
        </e-ranges>
    </ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>presets</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange">
        <e-daterangepicker-presets>
            <e-daterangepicker-preset id="week" label="This Week" start="ViewBag.weekStart" end="ViewBag.weekEnd"></e-daterangepicker-preset>
            <e-daterangepicker-preset id="month" label="This Month" start="ViewBag.monthStart" end="ViewBag.monthEnd"></e-daterangepicker-preset>
        </e-daterangepicker-presets>
    </ejs-daterangepicker>
{% endhighlight %}

<b> HomeController.cs </b>
<br>
{% highlight c# %}
    int days = (int)DateTime.Now.DayOfWeek;
    ViewBag.weekStart = DateTime.Now.AddDays(-days);
    ViewBag.weekEnd = ViewBag.weekStart.AddDays(6);
    ViewBag.monthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    ViewBag.monthEnd = ViewBag.monthStart.AddMonths(1).AddDays(-1);
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Add ranges
</td>
<td>
<b>Method:</b> <i>addRanges()</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.addRanges("new Range", [new Date("11/12/2019"), new Date("11/12/2021")]);
        }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.clearRanges();
        }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" start-date="new DateTime(2018,1,1)" end-date="new DateTime(2018,1,10)" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            console.log(dateObj.getSelectedRange());
        }
    </script>
{% endhighlight %}

</td>
<td>
<b>Method:</b> <i>getSelectedRange()</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" startdate="new DateTime(2018,1,1)" enddate="new DateTime(2018,1,10)"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObj = document.getElementById("daterange").ej2_instances[0];
            console.log(daterangeObj.getSelectedRange());
        }
    </script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Set date range
</td>
<td>
<b>Method:</b> <i>setRange()</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var dateObj = $("#daterange").data("ejDateRangePicker");
            dateObj.setRange([new Date("11/12/2011"), new Date("11/12/2019")]);
        }
    </script>
{% endhighlight %}
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>

## Disabled dates

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" renderdaycell="disableDaterange"></ejs-daterangepicker>

    <script>
        function disableDaterange(args) {
            if (args.date.getDay() === 0 || args.date.getDay() === 6) {
                args.isDisabled = true;
            }
        }
    </script>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Customization

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange"  css-class="gradient-lime"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>cssClass</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" cssClass="gradient-lime"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Enable time picker
</td>
<td>
<b>Property:</b> <i>enable-time-picker</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange"  enable-time-picker="true"></ej-date-range-picker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange"  time-format="HH:mm"></ej-date-range-picker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" minDays="5"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" maxDays="10"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Button text
</td>
<td>
<b>Property:</b> <i>button-text</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange">
        <e-date-range-button-text apply="Apply" cancel="Cancel" reset="Reset" />
    </ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Method:</b> <i>load()</i>
<br>
{% highlight html %}
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
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Show popup button
</td>
<td>
<b>Property:</b> <i>show-popup-button</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" show-popup-button="false"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Event:</b> <i>focus</i>
<br>
{% highlight html %}
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
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Show rounded corner
</td>
<td>
<b>Property:</b> <i>show-rounded-corner</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" show-rounded-corner="true"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>cssClass</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" cssclass="e-custom-style"></ejs-daterangepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-range-wrapper.e-input-group {
            border-radius: 4px;
        }
    </style>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" focus="onFocus"></ejs-daterangepicker>

    <script>
        function onFocus(args) { }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" blur="onBlur"></ejs-daterangepicker>

    <script>
        function onBlur(args) { }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.focusIn();
        });
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
   <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.focusOut();
        });
    </script>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Accessibility

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" enableRtl="true"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Persistence

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" enable-persistence="true"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>enablePersistence</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" startDate="new DateTime(2018,1,1)" endDate="new DateTime(2018,1,10)" enablePersistence="true"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Common

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" width="200"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>width</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" width="200"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" readonly="true"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" showClearButton="true"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Height
</td>
<td>
<b>Property:</b> <i>height</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" height="35"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>cssClass</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" cssclass="e-custom-style"></ejs-daterangepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-range-wrapper.e-input-group {
            height: 35px;
        }
    </style>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" weekNumber="true"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Watermark text
</td>
<td>
<b>Property:</b> <i>watermark-text</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" watermark-text="Select Range"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>placeholder</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" placeholder="Select Range"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Enable and disable
</td>
<td>
<b>Property:</b> <i>enabled</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" enabled="false"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>enabled</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" enabled="false"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Disable date
</td>
<td>
<b>Method:</b> <i>disable()</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var daterangeObj = $("#daterange").data("ejDateRangePicker");
            daterangeObj.disable();
        }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate() {
            var daterangeObj = $("#daterange").data("ejDateRangePicker");
            daterangeObj.enable();
        }
    </script>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" allow-edit="false"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>allowEdit</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" allowEdit="false"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" placeholder="Select Range" floatLabelType="Syncfusion.EJ2.Inputs.FloatLabelType.Auto"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" zIndex="100"></ej-date-range-picker>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Separator
</td>
<td>
<b>Property:</b> <i>separator</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" separator="$"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>separator</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" separator="$"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Globalization

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" locale="en-US"></ej-date-range-picker>
{% endhighlight %}

</td>
<td>
<b>Property:</b> <i>locale</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" locale="en"></ejs-daterangepicker>
{% endhighlight %}

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
<br>
{% highlight html %}
    <ejs-dateragepicker id="daterange" firstDayOfWeek="2"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Strict mode

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" strictMode="true"></ejs-daterangepicker>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## Open and Close

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
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" close="onClose"></ej-date-range-picker>

    <script>
        function onClose() {}
    </script>
{% endhighlight %}

</td>
<td>
<b>Event:</b> <i>close</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" close="onClose"></ejs-daterangepicker>

    <script>
        function onClose() {}
    </script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Hide
</td>
<td>
<b>Method:</b> <i>popupHide()</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate(args) {
            var daterangeObject = $("#daterange").data("ejDateRangePicker");
            daterangeObject.popupShow(); daterangeObject.popupHide();
        }
    </script>
{% endhighlight %}

</td>
<td>
<b>Method:</b> <i>hide()</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.show();
            daterangeObject.hide();
        });
    </script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Open
</td>
<td>
<b>Event:</b> <i>open</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" open="onOpen"></ej-date-range-picker>

    <script>
        function onOpen(args) { }
    </script>
{% endhighlight %}

</td>
<td>
<b>Event:</b> <i>open</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" open="onOpen"></ejs-daterangepicker>

    <script>
        function onOpen(args) { }
    </script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>
Show
</td>
<td>
<b>Method:</b> <i>popupShow()</i>
<br>
{% highlight html %}
    <ej-date-range-picker id="daterange" create="onCreate"></ej-date-range-picker>

    <script>
        function onCreate(args) {
            var daterangeObject = $("#daterange").data("ejDateRangePicker");
            daterangeObject.popupShow();
        }
    </script>
{% endhighlight %}

</td>
<td>
<b>Method:</b> <i>show()</i>
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange"></ejs-daterangepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var daterangeObject = document.getElementById("daterange").ej2_instances[0];
            daterangeObject.show();
        }
    </script>
{% endhighlight %}

</td>
</tr>
</thead>
</table>

## View navigation

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
<br>
{% highlight html %}
    <ejs-daterangepicker id="daterange" navigated="onNavigated"></ejs-daterangepicker>

    <script>
        function onNavigated() { }
    </script>
{% endhighlight %}

</td>
</tr>
</thead>
</table>
