---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Datetimepicker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Datetimepicker component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of DateTimePicker component from Essential JS 1 to Essential JS 2.

## DateTime selection

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
    <ej-date-time-picker id="datetime"  value="DateTime.Now"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>value</i>

 ```html
    <ejs-datetimepicker id="datetime" value="DateTime.Now"></ejs-datetimepicker>
```

</td>
</tr>
</thead>
</table>

## DateTime format

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
Display datetime format
</td>
<td>
<b>Property:</b> <i>date-time-format</i>

 ```html
    <ej-date-time-picker id="datetime" value="DateTime.Now" date-time-format="dd/MM/yyyy hh:mm tt"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>format</i>

```html
    <ejs-datetimepicker id="datetime" format="dd/MM/yyyy hh:mm a" value="DateTime.Now"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Day header format
</td>
<td>
<b>Property:</b> <i>day-header-format</i>

```html
     <ej-date-time-picker id="datetime" day-header-format="Short"></ej-date-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>

## Calendar views

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
Start
</td>
<td>
<b>Property:</b> <i>start-level</i>

```html
    <ej-date-time-picker id="datetime" start-level="Year"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>start</i>

```html
    <ejs-datetimepicker id="datetime" start="Decade"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Depth
</td>
<td>
<b>Property:</b> <i>depth-level</i>

```html
    <ej-date-time-picker id="datetime" depth-level="Year"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>depth</i>

```html
    <ejs-datetimepicker id="datetime" depth="Year"></ejs-datetimepicker>
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
Minimum datetime
</td>
<td>
<b>Property:</b> <i>min-date-time</i>

```html
    <ej-date-time-picker id="datetime" min-date-time="new DateTime(2018,9,3,4,00,00)"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>min</i>

```html
    <ejs-datetimepicker id="datetime" min="new DateTime(2018,9,3,4,00,00)"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Maximum datetime
</td>
<td>
<b>Property:</b> <i>max-date-time</i>

```html
    <ej-date-time-picker id="datetime" max-date-time="new DateTime(2019,1,1,6,00,00)"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>max</i>

```html
    <ejs-datetimepicker id="datetime" max="new DateTime(2019,1,1,6,00,00)"></ejs-datetimepicker>
```

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
    <ejs-datetimepicker id="datetime" renderdaycell="disableDatetime"></ejs-datetimepicker>
  
    <script>
    function disableDatetime(args) {
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
css Class
</td>
<td>
<b>Property:</b> <i>css-class</i>

```html
    <ej-date-time-picker id="datetime"  css-class="gradient-lime"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-datetimepicker id="datetime" cssClass="gradient-lime"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Show button
</td>
<td>
<b>Property:</b> <i>css-class</i>

```html
    <ej-date-time-picker id="datetime" css-class="e-custom-class"></ej-date-time-picker>

    <style>
        .e-datetime-popup.e-popup.e-custom-class .e-button-container {
            display: none !important;
        }
    </style>
```

</td>
<td>
<b>Property:</b> <i>showTodayButton</i>

```html
    <ejs-datetimepicker id="datetime" showTodayButton="false"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Show other month dates
</td>
<td>
<b>Property:</b> <i>show-other-months</i>

```html
    <ej-date-time-picker id="datetime" show-other-months="false"></ej-date-time-picker>
```

</td>
<td>
<b></b>

```html
    <ejs-datetimepicker id="datetime"></ejs-datetimepicker><br /><br />

    <style>
        .e-DateTimePicker .e-calendar .e-content tr.e-month-hide, .e-DateTimePicker .e-calendar .e-content td.e-other-month > .e-day {
            visibility: none;
        }

        .e-DateTimePicker .e-calendar .e-content td.e-month-hide, .e-DateTimePicker .e-calendar .e-content td.e-other-month {
            pointer-events: none;
            touch-action: none;
        }
    </style>
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
    <ej-date-time-picker id="datetime" show-popup-button="false"></ej-date-time-picker>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-datetimepicker id="datetime" focus="onFocus"></ejs-datetimepicker>

    <script>
        function onFocus(args) {
            var datetimepicker = document.getElementById("datetime").ej2_instances[0];
            datetimepicker.show();
        }
    </script>

    <style>
        .e-control-wrapper .e-input-group-icon.e-date-icon {
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
    <ej-date-time-picker id="datetime" show-rounded-corner="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>css-class</i>

```html
    <ejs-datetimepicker id="datetime" cssclass="e-custom-style"></ejs-datetimepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-wrapper.e-input-group {
            border-radius: 4px;
        }
    </style>

```

</td>
</tr>
<tr>
<td>
Skip a month
</td>
<td>
<b>Property:</b> <i>step-months</i>

```html
    <ej-date-time-picker id="datetime" step-months="2"></ej-date-time-picker>
```

</td>
<td>
<b>Method:</b> <i>navigateTo()</i>

```html
    <ejs-datetimepicker id="datetime" value="new DateTime(2018,09,04,5,00,00)" open="onOpen"></ejs-datetimepicker>

    <script>
        function onOpen(args) {
            var datetimepicker = document.getElementById("datetime").ej2_instances[0];
            datetimepicker.navigateTo('Year', new Date("03/18/2018"));
        }
    </script>
```

</td>
</tr>
<tr>
<td>
Show tooltip
</td>
<td>
<b>Property:</b> <i>show-tooltip</i>

```html
    <ej-date-time-picker id="datetime" show-tooltip="false"></ej-date-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Interval
</td>
<td>
<b>Property:</b> <i>interval</i>

```html
    <ej-date-time-picker id="datetime" interval="60"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>step</i>

```html
    <ejs-datetimepicker id="datetime" step="60"></ejs-datetimepicker>
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
    <ej-date-time-picker id="datetime"><br/><e-date-time-button-text done="Done" time-now="Time Now" today="Today" time-title="Time"/><br/></ej-date-time-picker>
```

</td>
<td>
<b>Method:</b> <i>load()</i>

```html
    <ejs-datetimepicker id="datetime" locale="en"></ejs-datetimepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            datetimepicker = document.getElementById('datetime').ej2_instances[0];
            var L10n = ej.base.L10n;
            L10n.load({
                'en': {
                    'datetimepicker': { today: 'Now' }
                }
            });
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Enable animation
</td>
<td>
<b>Property:</b> <i>enable-animation</i>

```html
    <ej-date-time-picker id="datetime" enable-animation="false"></ej-date-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Focus in method
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Method:</b> <i>focusIn()</i>

```html
    <ejs-datetimepicker id="datetime"></ejs-datetimepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datetimeObject = document.getElementById("datetime").ej2_instances[0];
            datetimeObject.focusIn();
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
    <ejs-datetimepicker id="datetime"></ejs-datetimepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datetimeObject = document.getElementById("datetime").ej2_instances[0];
            datetimeObject.focusOut();
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Prevent close
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ejs-datetimepicker id="datetime" close="onClose"></ejs-datetimepicker>

    <script>
        function onClose(args) {
            args.cancel = true;
        }

        document.addEventListener('DOMContentLoaded', function () {
            var datetimeObject = document.getElementById("datetime").ej2_instances[0];
            datetimeObject.show();
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Prevent open
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ejs-datetimepicker id="datetimepicker" open="onOpen"></ejs-datetimepicker>

    <script>
        function onOpen(args) {
            args.cancel = true;
        }
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
<b>Property:</b> <i>enable-rtl</i>

```html
    <ej-date-time-picker id="datetime" enable-rtl="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enableRtl</i>

```html
    <ejs-datetimepicker id="datetime" enableRtl="true"></ejs-datetimepicker>
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
    <ej-date-time-picker id="datetime" enable-persistence="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enablePersistence</i>

```html
    <ejs-datetimepicker id="datetime" enablePersistence="true"></ejs-datetimepicker>
```

</td>
</tr>
</thead>
</table>

## Validation

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
Validation rules
</td>
<td>
<b>Property:</b> <i>validation-rules</i>

```html
    <ej-date-time-picker id="datetime" validation-rules='new Dictionary<string, object>() {{ "required",true}}'></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
    <form id="form-element" class="form-vertical">
        <ejs-datetimepicker id="datetime"></ejs-datetimepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = { rules: { 'datetime': { required: true } } };
            var formObject = new ej.inputs.FormValidator('#form-element', options);
        });
    </script>  
```

</td>
</tr>
<tr>
<td>
Validation message
</td>
<td>
<b>Property:</b> <i>validation-messages</i>

```html
    <ej-date-time-picker id="datetime" validation-rules='new Dictionary<string, object>() {{ "required",true}}' validation-messages='new Dictionary<string, object>() {{ "required","Required Date Time value"}}'></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
    <form id="form-element" class="form-vertical">
        <ejs-datetimepicker id="datetime"></ejs-datetimepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = { rules: { 'datetime': { required: true } },
                customPlacement: (inputElement, errorElement) => { inputElement.parentElement.parentElement.appendChild(errorElement);
        }};
        var formObject = new ej.inputs.FormValidator('#form-element', options);
        });
    </script>
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
    <ej-date-time-picker id="datetime" width="200"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>width</i>

```html
    <ejs-datetimepicker id="datetime" width="200"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Read only
</td>
<td>
<b>Property:</b> <i>read-only</i>

```html
    <ej-date-time-picker id="datetime" read-only="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>readonly</i>

```html
    <ejs-datetimepicker id="datetime" readonly="true"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Show Clear Button
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>showClearButton</i>

```html
    <ejs-datetimepicker id="datetime" showClearButton="true"></ejs-datetimepicker>
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
    <ej-date-time-picker id="datetime" height="35"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-datetimepicker id="datetime" cssclass="e-custom-style"></ejs-datetimepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-date-wrapper.e-input-group {
            height: 35px;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Html Attributes
</td>
<td>
<b>Property:</b> <i>html-attributes</i>

```html
    @{ IDictionary<string, object> htmlAttr = new Dictionary<string, object>();
       htmlAttr.Add("required", "required");
    }

    <ej-date-time-picker id="datetime" html-attributes="htmlAttr"></ej-date-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Week Number
</td>
<td>
<b>Property:</b> <i>week-number</i>

```html
    <ej-date-time-picker id="datetime" week-number="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>weekNumber</i>

```html
    <ejs-datetimepicker id="datetime" weekNumber="true"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Watermark Text
</td>
<td>
<b>Property:</b> <i>watermark-text</i>

```html
    <ej-date-time-picker id="datetime" watermark-text="Enter date and time"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>placeholder</i>

```html
    <ejs-datetimepicker id="datetime" placeholder="Enter date and time"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Disable and enable
</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ej-date-time-picker id="datetime" enabled="false"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ejs-datetimepicker id="datetime" enabled="false"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Allow Editing
</td>
<td>
<b>Property:</b> <i>allow-edit</i>

```html
    <ej-date-time-picker id="datetime" allow-edit="false"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>allowEdit</i>

```html
    <ejs-datetimepicker id="datetime" allowEdit="false"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
z Index
</td>
<td>
<b>Property:</b> <i>css-class</i>

```html
    <ej-date-time-picker id="datetime" css-class="e-custom-class"></ej-date-time-picker>

    <style>
        .e-datetime-popup.e-popup.e-custom-class {
            z-index: 100 !important;
        }
    </style>
```

</td>
<td>
<b>Property:</b> <i>zIndex</i>

```html
    <ej-date-time-picker id="datetime" zIndex="100"></ej-date-time-picker>
```

</td>
</tr>
<tr>
<td>
Float Label Type
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>floatLabelType</i>

```html
    <ejs-datetimepicker id="datetime" placeholder="Enter date and time" floatLabelType="Syncfusion.EJ2.Inputs.FloatLabelType.Auto"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
Render day cell
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-datetimepicker id="datetime" renderdaycell="onRenderCell"></ejs-datetimepicker>

    <script>
        function onRenderCell() { }
    </script>

```

</td>
</tr>
<tr>
<td>
Focus In event
</td>
<td>
<b>Event:</b> <i>focus-in</i>

```html
    <ej-date-time-picker id="datetime" focus-in="onFocus"></ej-date-time-picker>
    <script>
        function onFocus() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-datetimepicker id="datetime" focus="onFocus"></ejs-datetimepicker>

    <script>
        function onFocus() { }
    </script>
```

</td>
</tr>
<tr>
<td>
Focus out event
</td>
<td>
<b>Event:</b> <i>focus-out</i>

```html
    <ej-date-time-picker id="datetime" focus-out="onFocusout"></ej-date-time-picker>

    <script>
        function onFocusout() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>blur</i>

```html
    <ejs-datetimepicker id="datetime" blur="onBlur"></ejs-datetimepicker>

    <script>
        function onBlur() { }
    </script>
  
```

</td>
</tr>
<tr>
<td>
Change event
</td>
<td>
<b>Event:</b> <i>change</i>

```html
    <ej-date-time-picker id="datetime" change="onChange"></ej-date-time-picker>

    <script>
        function onChange() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>change</i>

```html
    <ejs-datetimepicker id="datetime" blur="onChange"></ejs-datetimepicker>

    <script>
        function onChange() { }
    </script>
  
```

</td>
</tr>
<tr>
<td>
Created event
</td>
<td>
<b>Event:</b> <i>create</i>

```html
    <ej-date-time-picker id="datetime" create="onCreate"></ej-date-time-picker>

    <script>
        function onCreate() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>created</i>

```html
    <ejs-datetimepicker id="datetime" created="onCreated"></ejs-datetimepicker>

    <script>
        function onCreated() { }
    </script>
```

</td>
</tr>
<tr>
<td>
Destroy event
</td>
<td>
<b>Event:</b> <i>destroy</i>

```html
    <ej-date-time-picker id="datetime" destroy="onDestroy"></ej-date-time-picker>

    <script>
        function onDestroy() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>destroyed</i>

```html
    <ejs-datetimepicker id="datetime" destroyed="onDestroyed"></ejs-datetimepicker>

    <script>
        function onDestroyed() { }
    </script>
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
    <ej-date-time-picker id="datetime" locale="en-US"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>locale</i>

```html
    <ejs-datetimepicker id="datetime" locale="en"></ejs-datetimepicker>
```

</td>
</tr>
<tr>
<td>
First day of week
</td>
<td>
<b>Property:</b> <i>start-day</i>

```html
    <ej-date-time-picker id="datetime" start-day="2"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>firstDayOfWeek</i>

```html
    <ejs-datetimepicker id="datetime" firstDayOfWeek="2"></ejs-datetimepicker>
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
<b>Property:</b> <i>enable-strict-mode</i>

```html
    <ej-date-time-picker id="datetime" enable-strict-mode="true"></ej-date-time-picker>
```

</td>
<td>
<b>Property:</b> <i>strictMode</i>

```html
    <ejs-datetimepicker id="datetime" strictMode="true" min="new DateTime(2017,5,5,12,00,00)" max="new DateTime(2017,05,25,12,00,00)" value="new DateTime(2017,05,28,12,00,00)"></ejs-datetimepicker>
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
    <ej-date-time-picker id="datetime" close="onClose"></ej-date-time-picker>

    <script>
        function onClose() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ejs-datetimepicker id="datetime" close="onClose"></ejs-datetimepicker>

    <script>
        function onClose() { }
    </script>
```

</td>
</tr>
<tr>
<td>
Hide
</td>
<td>
<b>Method:</b> <i>hide()</i>

```html
    <ej-date-time-picker id="datetime" create="onCreate"></ej-date-time-picker>

    <script>
        function onCreate(args) {
            var datetimeObject = $("#datetime").data("ejDateTimePicker");
            datetimeObject.show();
            datetimeObject.hide();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>hide()</i>

```html
    <ejs-datetimepicker id="datetime"></ejs-datetimepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datetimepickerObject = document.getElementById("datetime").ej2_instances[0];
            datetimepickerObject.show();
            datetimepickerObject.hide();
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
    <ej-date-time-picker id="datetime" open="onOpen"></ej-date-time-picker>

    <script>
        function onOpen()
    </script>
```

</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ejs-datetimepicker id="datetime" open="onOpen"></ejs-datetimepicker>

    <script>
        function onOpen()
    </script>
```

</td>
</tr>
<tr>
<td>
Show
</td>
<td>
<b>Method:</b> <i>show()</i>

```html
    <ej-date-time-picker id="datetime" create="onCreate"></ej-date-time-picker>

    <script>
        function onCreate(args) {
            var datetimeObject = $("#datetime").data("ejDateTimePicker");
            datetimeObject.show();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>show()</i>

```html
    <ejs-datetimepicker id="datetime"></ejs-datetimepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datetimepickerObject = document.getElementById("datetime").ej2_instances[0];
            datetimepickerObject.show();
        });
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
Navigate to
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Method:</b> <i>navigateTo()</i>

```html
    <ejs-datetimepicker id="datetime" open="onOpen"></ejs-datetimepicker>

    <script>
        function onOpen(args) {
            var datetimeObject = document.getElementById("datetime").ej2_instances[0];
            datetimeObject.navigateTo('Year', new Date("03/18/2018"));
        }
    </script>
```

</td>
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
    <ejs-datetimepicker id="datetime" navigated="onNavigated"></ejs-datetimepicker>

    <script>
        function onNavigated() { }
    </script>
```

</td>
</tr>
<tr>
<td>
Drill down
</td>
<td>
<b>Property:</b> <i>timeDrillDown</i>

```html
    <ej-date-time-picker id="datetime"><br/><e-time-drill-down auto-close="true" enabled="true" interval="10" show-meridian="true"></ej-date-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>