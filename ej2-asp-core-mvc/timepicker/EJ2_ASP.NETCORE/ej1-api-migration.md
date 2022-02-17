---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Timepicker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of TimePicker component from Essential JS 1 to Essential JS 2.

## Time selection

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
    <ej-time-picker id="time" value="DateTime.Now"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>value</i>

```html
    <ejs-timepicker id="time" value="DateTime.Now"></ejs-timepicker>
```

</td>
</tr>
</thead>
</table>

## Time format

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
Display time format
</td>
<td>
<b>Property:</b> <i>time-format</i>

```html
    <ej-time-picker id="time" time-format="h:mm:ss tt"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>format</i>

```html
    <ejs-timepicker id="time" value="DateTime.Now" format="h:mm:ss a"></ejs-timepicker>
```

</td>
</tr>
</thead>
</table>

## Time range

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
Minimum time
</td>
<td>
<b>Property:</b> <i>min-time</i>

```html
    <ej-time-picker id="time" min-time="2:00 AM"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>min</i>

```html
    <ejs-timepicker id="time" min="new DateTime(2018,5,5,4,00,00)"></ejs-timepicker>
```

</td>
</tr>
<tr>
<td>
Maximum time
</td>
<td>
<b>Property:</b> <i>max-time</i>

```html
    <ej-time-picker id="time" max-time="2:00 AM"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>max</i>

```html
    <ejs-timepicker id="time" max="new DateTime(2018,5,5,4,00,00)"></ejs-timepicker>
```

</td>
</tr>
<tr>
<td>
Set current time
</td>
<td>
<b>Method:</b> <i>setCurrentTime()</i>

```html
    <ej-time-picker id="time" create="onCreate"></ej-time-picker>

    <script>
        function onCreate() {
            var timeObj = $("#time").data("ejTimePicker");
            timeObj.setCurrentTime();
    </script>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>

## Disabled time ranges

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
Disable Time Ranges
</td>
<td>
<b>Property:</b> <i>disable-time-ranges</i>

```html
    <ej-time-picker id="time">
        <e-disable-time-ranges>
            <e-disable-time-range start-time="3:00 AM" end-time="9:00 AM" />
        </e-disable-time-ranges>
    </ej-time-picker>
```

</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-timepicker id="time" itemrender="onItemrender"></ejs-timepicker>

    <script>
        function onItemrender(args) {
            if (args.value.getHours() === 4) {
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
    <ej-time-picker id="time"  css-class="gradient-lime"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-timepicker id="time" cssClass="gradient-lime"></ejs-timepicker>
```

</td>
</tr>
<tr>
<td>
Item Render
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Event:</b> <i>itemRender</i>

```html
    <ejs-timepicker id="time" itemrender="onItemrender"></ejs-timepicker>

    <script>
        function onItemrender() { }
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
    <ej-time-picker id="time" show-popup-button="false"></ej-time-picker>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-timepicker id="time" focus="onFocus"></ejs-timepicker>

    <script>
        function onFocus(args) {
            var timeObject = document.getElementById("time").ej2_instances[0];
            timeObject.show();
        }
    </script>

    <style>
        .e-control-wrapper .e-input-group-icon.e-time-icon {
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
    <ej-time-picker id="time" show-rounded-corner="true"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-timepicker id="time" cssclass="e-custom-style"></ejs-timepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-time-wrapper.e-input-group {
            border-radius: 4px;
        }
    </style>
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
    <ej-time-picker id="time" enable-animation="false"></ej-time-picker>
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
    <ej-time-picker id="time" interval="60"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>step</i>

```html
    <ejs-timepicker id="time" step="60"></ejs-timepicker>
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
    <ej-time-picker id="time" focus-in="onFocus"></ej-time-picker>

    <script>
        function onFocus() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-timepicker id="time" focus="onFocus"></ejs-timepicker>

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
    <ej-time-picker id="time" focus-out="onFocusout"></ej-time-picker>

    <script>
        function onFocusout() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>blur</i>

```html
    <ejs-timepicker id="time" blur="onBlur"></ejs-timepicker>

    <script>
        function onBlur() { }
    </script>
```

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
    <ejs-timepicker id="time"></ejs-timepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var timeObject = document.getElementById("time").ej2_instances[0];
            timeObject.focusIn();
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
<b>Event:</b> <i>blur</i>

```html
    <ejs-timepicker id="time"></ejs-timepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var timeObject = document.getElementById("time").ej2_instances[0];
            timeObject.focusOut();
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
    <ejs-timepicker id="time" close="onClose"></ejs-timepicker>

    <script>
        function onClose(args) {
            args.cancel = true;
        }

        document.addEventListener('DOMContentLoaded', function () {
            var timeObject = document.getElementById("time").ej2_instances[0];
            timeObject.show();
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
    <ejs-timepicker id="timepicker" open="onOpen"></ejs-timepicker>

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
    <ej-time-picker id="time" enable-rtl="true"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enableRtl</i>

```html
    <ejs-timeicker id="time" enableRtl="true"></ejs-timepicker>
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
    <ej-time-picker id="time" enable-persistence="true"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enablePersistence</i>

```html
    <ejs-timepicker id="time" enablePersistence="true"></ejs-timepicker>
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
    <ej-time-picker id="time" validation-rules='new Dictionary<string, object>() {{ "required",true}}'></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
    <form id="form-element" class="form-vertical">
        <ejs-timepicker id="timepicker"></ejs-timepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = { rules: { 'timepicker': { required: true } } };
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
    <ej-time-picker id="time" validation-rules='new Dictionary<string, object>() {{ "required",true}}' validation-messages='new Dictionary<string, object>() {{ "required","Required Time value"}}'></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
     <form id="form-element" class="form-vertical">
        <ejs-timepicker id="timepicker"></ejs-timepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = {
                rules: {'timepicker': { required: true } },
                customPlacement: (inputElement, errorElement) => { inputElement.parentElement.parentElement.appendChild(errorElement);
        }
        };
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
    <ej-time-picker id="time" width="200"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>width</i>

```html
    <ejs-timepicker id="time" width="200"></ejs-timepicker>
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
    <ej-time-picker id="time" read-only="true"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>readonly</i>

```html
   <ejs-timepicker id="time" readonly="true"></ejs-timepicker>
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
    <ejs-timepicker id="time" showClearButton="true"></ejs-timepicker>
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
    <ej-time-picker id="time" height="35"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-timepicker id="time" cssclass="e-custom-style"></ejs-timepicker>

    <style>
        .e-control-wrapper.e-custom-style.e-time-wrapper.e-input-group {
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

    <ej-time-picker id="time" html-attributes="htmlAttr"></ej-time-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Watermark Text
</td>
<td>
<b>Property:</b> <i>watermark-text</i>

```html
    <ej-time-picker id="time" watermark-text="Enter time"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>placeholder</i>

```html
    <ejs-timepicker id="time" placeholder="Enter time"></ejs-timepicker>
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
    <ej-time-picker id="time" enabled="false"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ejs-timepicker id="time" enabled="false"></ejs-timepicker>
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
    <ej-time-picker id="time" create="onCreate"></ej-time-picker>

    <script>
        function onCreate(args) {
            var timeObject = $("#time").data("ejTimePicker");
            timeObject.disable();
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
    <ej-time-picker id="time" create="onCreate"></ej-time-picker>

    <script>
        function onCreate(args) {
            var timeObject = $("#time").data("ejTimePicker");
            timeObject.enable();
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
Allow Editing
</td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property:</b> <i>allowEdit</i>

```html
    <ejs-timepicker id="timepicker" allowEdit="true"></ejs-timepicker>
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
    <ejs-timepicker id="time" zIndex="100"></ejs-timepicker>
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
    <ejs-timepicker id="time" placeholder="Enter time" floatLabelType="Syncfusion.EJ2.Inputs.FloatLabelType.Auto"></ejs-timepicker>
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
    <ej-time-picker id="time" locale="en-US"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>locale</i>

```html
    <ejs-timepicker id="time" locale="en"></ejs-timepicker>
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
    <ej-time-picker id="time" enable-strict-mode="true"></ej-time-picker>
```

</td>
<td>
<b>Property:</b> <i>strictMode</i>

```html
    <ejs-timepicker id="time" strictMode="true"></ejs-timepicker>
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
    <ej-time-picker id="time" close="onClose"></ej-time-picker>

    <script>
        function onClose() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ejs-timepicker id="time" close="onClose"></ejs-timepicker>

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
    <ej-time-picker id="time" create="onCreate"></ej-time-picker>

    <script>
        function onCreate(args) {
            var timeObject = $("#time").data("ejTimePicker");
            timeObject.show();
            timeObject.hide();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>hide()</i>

```html
    <ejs-timepicker id="time"></ejs-timepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var timepickerObject = document.getElementById("time").ej2_instances[0];
            timepickerObject.show();
            timepickerObject.hide();
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
    <ej-time-picker id="time" open="onOpen"></ej-time-picker>

    <script>
        function onOpen() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ejs-timepicker id="time" open="onOpen"></ejs-timepicker>

    <script>
        function onOpen() { }
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
    <ej-time-picker id="time" create="onCreate"></ej-time-picker>

    <script>
        function onCreate(args) {
            var timeObject = $("#time").data("ejTimePicker");
            timeObject.show();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>show()</i>

```html
    <ejs-timepicker id="time"></ejs-timepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var timepickerObject = document.getElementById("time").ej2_instances[0];
            timepickerObject.show();
        });
    </script>
```

</td>
</tr>
</thead>
</table>