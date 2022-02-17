---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Datepicker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of DatePicker component from Essential JS 1 to Essential JS 2.

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
    <ej-date-picker id="date"  value="DateTime.Now"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>value</i>

```html
    <ejs-datepicker id="date" value="DateTime.Now"></ejs-datepicker>
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
    <ej-date-picker id="date" value="DateTime.Now" date-format="dd/MM/yyyy"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>format</i>

```html
    <ejs-datepicker id="date" format="yyyy-MM-dd" value="DateTime.Now"></ejs-datepicker>
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
    <ej-date-picker id="date" day-header-format="Short"></ej-date-picker>
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
    <ej-date-picker id="date" start-level="Year"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>start</i>

```html
    <ejs-datepicker id="date" start="Decade"></ejs-datepicker>
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
    <ej-date-picker id="date" depth-level="Year"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>depth</i>

```html
    <ejs-datepicker id="date" depth="Year"></ejs-datepicker>
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
    <ej-date-picker id="date" min-date="new DateTime(2018,9,3)"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>min</i>

```html
    <ejs-datepicker id="date" min="new DateTime(2018,9,3)"></ejs-datepicker>
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
    <ej-date-picker id="date" max-date="new DateTime(2019,1,1)"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>max</i>

```html
    <ejs-datepicker id="date" max="new DateTime(2019,1,1)"></ejs-datepicker>
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
Block-out dates
</td>
<td>
<b>Property:</b> <i>blackout-dates</i>

```html
    @{
        List<object> blackoutDates = new List<object>();
        blackoutDates.Add(new DateTime(2018, 5, 10));
        blackoutDates.Add(new DateTime(2018, 5, 15));
    }

    <ej-date-picker id="date" blackout-dates="blackoutDates"></ej-date-picker>
```

</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-datepicker id="date" renderdaycell="disableDate"></ejs-datepicker>

    <script>
        function disableDate(args) {
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
    <ej-date-picker id="date"  css-class="gradient-lime"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-datepicker id="date" cssClass="gradient-lime"></ejs-datepicker>
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
    <ejs-datepicker id="date" renderdaycell="onRenderCell"></ejs-datepicker>

    <script>
        function onRenderCell() { }
    </script>
```

</td>
</tr>
<tr>
<td>
Show today button
</td>
<td>
<b>Property:</b> <i>show-footer</i>

```html
    <ej-date-picker id="date" show-footer="false"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>showTodayButton</i>

```html
    <ejs-datepicker id="date" showTodayButton="false"></ejs-datepicker>
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
    <ej-date-picker id="date" show-other-months="false"></ej-date-picker>
```

</td>
<td>
<b></b>

```html
    <ejs-datepicker id="date"></ejs-datepicker>

    <style>
        .e-datepicker .e-calendar .e-content tr.e-month-hide, .e-datepicker .e-calendar .e-content td.e-other-month > .e-day {
            visibility: none;
        }

        .e-datepicker .e-calendar .e-content td.e-month-hide, .e-datepicker .e-calendar .e-content td.e-other-month {
            pointer-events: none;
            touch-action: none;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Show disabled range
</td>
<td>
<b>Property:</b> <i>show-disabled-range</i>

```html
    <ej-date-picker id="date" show-disabled-range="false"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Show popup button
</td>
<td>
<b>Property:</b> <i>show-popup-button</i>

```html
    <ej-date-picker id="date" show-popup-button="false"></ej-date-picker>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-datepicker id="date" focus="onFocus"></ejs-datepicker>

    <script>
        function onFocus(args) {
            var datepicker = document.getElementById("date").ej2_instances[0];
            datepicker.show();
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
    <ej-date-picker id="date" show-rounded-corner="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-datepicker id="date" cssclass="e-custom-style"></ejs-datepicker>

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
    <ej-date-picker id="date" step-months="2"></ej-date-picker>
```

</td>
<td>
<b>Method:</b> navigateTo()

```html
    <ejs-datepicker id="date" value="new DateTime(2018,09,04)" open="onOpen"></ejs-datepicker>

    <script>
        function onOpen(args) {
            var datepicker = document.getElementById("date").ej2_instances[0];
            datepicker.navigateTo('Year', new Date("03/18/2018"));
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
    <ej-date-picker id="date" show-tooltip="false"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Button text
</td>
<td>
<b>Property:</b> <i>button-text</i>

```html
    <ej-date-picker id="date" button-text="Now"></ej-date-picker>
```

</td>
<td>
<b>Method:</b> <i>load()</i>

```html
    <ejs-datepicker id="datepicker" locale="en"></ejs-datepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            datepicker = document.getElementById('datepicker').ej2_instances[0];
            var L10n = ej.base.L10n;
            L10n.load({
                'en':
                    {
                        'datepicker': { today: 'Now' }
                    }
            });
        });
    </script>
```

</td>
</tr>
<tr>
<td>
Display inline
</td>
<td>
<b>Property:</b> <i>display-inline</i>

```html
    <ej-date-picker id="date" tag-name="div" display-inline="true"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Enable animation
</td>
<td>
<b>Property:</b> <i>enable-animation</i>

```html
    <ej-date-picker id="date" enable-animation="false"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Highlight section
</td>
<td>
<b>Property:</b> <i>highlight-section</i>

```html
    <ej-date-picker id="date" highlight-section="Week"></ej-date-picker>
```

</td>
<td>
<b>Event:</b> renderDayCell

```html
    <ejs-datepicker id="datepicker" renderdaycell="highlightDate"></ejs-datepicker>

    <script>
        function highlightDate(args) {
            if (args.date.getDate() === 10) {
                args.element.classList.add('e-highlightweekend');
            }
        }
    </script>

    <style>
        body.highcontrast #date_label {
            color: white;
        }

        .e-highlightweekend {
            background-color: #cfe9f3;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Highlight weekend
</td>
<td>
<b>Property:</b> <i>highlight-weekend</i>

```html
    <ej-date-picker id="date" highlight-weekend="true"></ej-date-picker>
```

</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-datepicker id="datepicker" renderdaycell="highlightDate"></ejs-datepicker>

    <script>
        function highlightDate(args) {
            if (args.date.getDay() === 0 || args.date.getDay() === 6) {
                args.element.classList.add('e-highlightweekend');
            }
        }
    </script>

    <style>
        body.highcontrast #date_label {
            color: white;
        }

        .e-highlightweekend {
            background-color: #cfe9f3;
        }
    </style>
```

</td>
</tr>
<tr>
<td>
Tooltip format
</td>
<td>
<b>Property:</b> <i>tooltip-format</i>

```html
    <ej-date-picker id="date" tooltip-format="dd/MM/yyyy"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
<tr>
<td>
Special Dates
</td>
<td>
<b>Property:</b> <i>special-dates</i>

```html
    <ej-date-picker id="date">
        <e-special-dates>
            <e-special-date date="1/1/2019" tooltip="In Australia" icon-class="flags sprite-Australia" />
            <e-special-date date="1/2/2019" tooltip="In France" icon-class="flags sprite-France" />
        </e-special-dates>
    </ej-date-picker>
```

</td>
<td>
<b>Event:</b> <i>renderDayCell</i>

```html
    <ejs-datepicker id="datepicker" renderdaycell="customDates" value="new DateTime(2017,05,05)"></ejs-datepicker>

    <script>
        function customDates(args) {
            if (args.date.getDate() === 10) {
                var span = document.createElement('span');
                span.setAttribute('class', 'e-icons highlight');
                args.element.firstElementChild.setAttribute('title', 'Birthday !');
                args.element.setAttribute('title', 'Birthday !');
                args.element.setAttribute('data-val', 'Birthday !');
                args.element.appendChild(span);
            }
        }
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
    <ej-date-picker id="date" focus-in="onFocus"></ej-date-picker>

    <script>
        function onFocus() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>focus</i>

```html
    <ejs-datepicker id="date" focus="onFocus"></ejs-datepicker>

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
    <ej-date-picker id="date" focus-out="onFocusout"></ej-date-picker>

    <script>
        function onFocusout() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>blur</i>

```html
    <ejs-datepicker id="date" blur="onBlur"></ejs-datepicker>

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
    <ejs-datepicker id="datepicker"></ejs-datepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var dateObject = document.getElementById("datepicker").ej2_instances[0];
            dateObject.focusIn();
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
    <ejs-datepicker id="datepicker"></ejs-datepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var dateObject = document.getElementById("datepicker").ej2_instances[0];
            dateObject.focusOut();
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
    <ejs-datepicker id="datepicker" close="onClose"></ejs-datepicker>

    <script>
        function onClose(args) {
            args.cancel = true;
        }

        document.addEventListener('DOMContentLoaded', function () {
            var dateObject = document.getElementById("datepicker").ej2_instances[0];
            dateObject.show();
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
    <ejs-datepicker id="datepicker" open="onOpen"></ejs-datepicker>

    <script>
        function onOpen(args) {
            args.cancel = true;
        }
    </script>
```

</td>
</tr>
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
    <ej-date-picker id="date" enable-rtl="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>enableRtl</i>

```html
    <ejs-datepicker id="datepicker" enableRtl="true"></ejs-datepicker>
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
    <ej-date-picker id="date" enable-persistence="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>enablePersistence</i>

```html
    <ejs-datepicker id="datepicker" enablePersistence="true"></ejs-datepicker>
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
    <ej-date-picker id="date" validation-rules='new Dictionary<string, object>() {{ "required",true}}'></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
    <form id="form-element" class="form-vertical">
        <ejs-datepicker id="datepicker"></ejs-datepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = { rules: { 'datepicker': { required: true } } };
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
    <ej-date-picker id="date" validation-rules='new Dictionary<string, object>() {{ "required",true}}' validation-messages='new Dictionary<string, object>() {{ "required","Required Date value"}}'></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>rules</i>

```html
    <form id="form-element" class="form-vertical">
        <ejs-datepicker id="datepicker"></ejs-datepicker>
    </form>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var options = { rules: { 'datepicker': { required: true } },
                customPlacement: (inputElement, errorElement) => {
                    inputElement.parentElement.parentElement.appendChild(errorElement);
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
    <ej-date-picker id="date" width="200"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>width</i>

```html
    <ejs-datepicker id="datepicker" width="200"></ejs-datepicker>
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
    <ej-date-picker id="date" read-only="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>readonly</i>

```html
    <ejs-datepicker id="datepicker" readonly="true"></ejs-datepicker>
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
    <ejs-datepicker id="datepicker" showClearButton="true"></ejs-datepicker>
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
    <ej-date-picker id="date" height="35"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>cssClass</i>

```html
    <ejs-datepicker id="datepicker" cssclass="e-custom-style"></ejs-datepicker>

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
    @{

    IDictionary<string, object> htmlAttr = new Dictionary<string, object>();
    htmlAttr.Add("required", "required");

    }
    <ej-date-picker id="date" html-attributes="htmlAttr"></ej-date-picker>
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
<ej-date-picker id="date" week-number="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>weekNumber</i>

```html
    <ejs-datepicker id="datepicker" weekNumber="true"></ejs-datepicker>
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
    <ej-date-picker id="date" watermark-text="Enter date"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>placeholder</i>

```html
    <ejs-datepicker id="datepicker" placeholder="Enter date"></ejs-datepicker>
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
    <ej-date-picker id="date" enabled="false"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>enabled</i>

```html
    <ejs-datepicker id="datepicker" enabled="false"></ejs-datepicker>
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
    <ej-date-picker id="date" create="onCreate"></ej-date-picker>

    <script>
        function onCreate(args) {
            var dateObject = $("#date").data("ejDatePicker");
            dateObject.disable();
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
    <ej-date-picker id="date" create="onCreate"></ej-date-picker>

    <script>
        function onCreate(args) {
            var dateObject = $("#date").data("ejDatePicker");
            dateObject.enable();
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
<b>Property:</b> <i>allow-edit</i>

```html
    <ej-date-picker id="date" allow-edit="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>allowEdit</i>

```html
    <ejs-datepicker id="datepicker" allowEdit="true"></ejs-datepicker>
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
    <ejs-datepicker id="date" zIndex="100"></ejs-datepicker>
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
    <ejs-datepicker id="datepicker" placeholder="Enter date" floatLabelType="Syncfusion.EJ2.Inputs.FloatLabelType.Auto"></ejs-datepicker>
```

</td>
</tr>
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
    <ej-date-picker id="date" locale="en-US"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>locale</i>

```html
    <ejs-datepicker id="datepicker" locale="en"></ejs-datepicker>
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
    <ej-date-picker id="date" start-day="2"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>firstDayOfWeek</i>

```html
    <ejs-datepicker id="datepicker" firstDayOfWeek="2"></ejs-datepicker>
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
<b>Property:</b> <i>enableStrictMode</i>

```html
    <ej-date-picker id="date" enable-strict-mode="true"></ej-date-picker>
```

</td>
<td>
<b>Property:</b> <i>strictMode</i>

```html
    <ejs-datepicker id="datepicker" strictMode="true"></ejs-datepicker>
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
    <ej-date-picker id="date" close="onClose"></ej-date-picker>  

    <script>
        function onClose() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>close</i>

```html
    <ejs-datepicker id="datepicker" close="onClose"></ejs-datepicker>

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
    <ej-date-picker id="date" create="onCreate"></ej-date-picker>

    <script>
        function onCreate(args) {
            var dateObject = $("#date").data("ejDatePicker");
            dateObject.show();
            dateObject.hide();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>hide()</i>

```html
    <ejs-datepicker id="datepicker"></ejs-datepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datepickerObject = document.getElementById("datepicker").ej2_instances[0];
            datepickerObject.show();
            datepickerObject.hide();
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
    <ej-date-picker id="date" open="onOpen"></ej-date-picker>

    <script>
        function onOpen() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>open</i>

```html
    <ejs-datepicker id="datepicker" open="onOpen"></ejs-datepicker>

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
    <ej-date-picker id="date" create="onCreate"></ej-date-picker>

    <script>
        function onCreate(args) {
            var dateObject = $("#date").data("ejDatePicker");
            dateObject.show();
        }
    </script>
```

</td>
<td>
<b>Method:</b> <i>show()</i>

```html
    <ejs-datepicker id="datepicker"></ejs-datepicker>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var datepickerObject = document.getElementById("datepicker").ej2_instances[0];
            datepickerObject.show();
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
    <ejs-datepicker id="datepicker" open="onOpen"></ejs-datepicker>

    <script>
        function onOpen(args) {
            var dateObject = document.getElementById("datepicker").ej2_instances[0];
            dateObject.navigateTo('Year', new Date("03/18/2018"));
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
<b>Event:</b> <i>navigate</i>

```html
    <ej-date-picker id="date" navigate="onNavigate"></ej-date-picker>  

    <script>
        function onNavigate() { }
    </script>
```

</td>
<td>
<b>Event:</b> <i>navigated</i>

```html
    <ejs-datepicker id="datepicker" navigated="onNavigated"></ejs-datepicker>

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
<b>Property:</b> <i>allow-drill-down</i>

```html
    <ej-date-picker id="date" allow-drill-down="true"></ej-date-picker>
```

</td>
<td>
<b>Not Applicable</b>
</td>
</tr>
</thead>
</table>