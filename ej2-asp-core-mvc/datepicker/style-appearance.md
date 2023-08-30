---
layout: post
title: Style and appearance in ##Platform_Name## DatePicker Component
description: Learn here all about style and appearance in Syncfusion ##Platform_Name## DatePicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: datepicker
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style and appearance in DatePicker Component

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the appearance of DatePicker wrapper element

Use the following CSS to customize the appearance of wrapper element.

```css
/* To specify height and font size */
.e-input-group input.e-input, .e-input-group.e-control-wrapper input.e-input {
        height: 40px;
        font-size: 20px;
}
```

## Customizing the DatePicker icon element

Use the following CSS to customize the DatePicker icon element.

```css
/* To specify background color and font size */
.e-input-group .e-input-group-icon:last-child, .e-input-group.e-control-wrapper .e-input-group-icon:last-child {
        font-size: 12px;
        background-color: darkgray;
}
```

## Customizing the Calendar popup of the DatePicker

Check the below section, to customize the style and appearance of the Calendar component.

[Customizing Calendar's style and appearance](../calendar/style-appearance/)

## Full screen mode support in mobiles and tablets

The DatePicker full-screen mode feature enables users to view the popup element in full-screen mode on mobile devices with improved visibility and a better user experience. It is important to mention that this feature is exclusively available for mobile and tablet devices in both landscape and portrait orientations. To activate the full screen mode within the DatePicker, simply set the [FullScreenMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_FullScreenMode) API value to `true`. This action will extend the calendar element to occupy the entire screen on mobile devices.

{% if page.publishingplatform == "aspnet-core" %}
```html
<ejs-datepicker id="date" FullScreenMode=true></ejs-datepicker>
```

{% elsif page.publishingplatform == "aspnet-mvc" %}
```html
@Html.EJS().DatePicker("date").FullScreenMode(true).Render()
```
{% endif %}
![DatePickerFullScreen](./images/DatePickerFullScreen.gif)