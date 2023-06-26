---
layout: post
title: Style and appearance in ##Platform_Name## TimePicker Component
description: Learn here all about style and appearance in Syncfusion ##Platform_Name## TimePicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: timepicker
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style and appearance in TimePicker Component

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the appearance of TimePicker wrapper element

Use the following CSS to customize the appearance of wrapper element.

```css
/* To specify height and font size */
.e-input-group input.e-input, .e-input-group.e-control-wrapper input.e-input, .e-input-group textarea.e-input, .e-input-group.e-control-wrapper textarea.e-input {
        font-size: 20px;
        height: 40px;
}
```

## Customizing the TimePicker icon element

Use the following CSS to customize the TimePicker icon element

```css
/* To specify background color and font size */
.e-time-wrapper .e-time-icon.e-icons, *.e-control-wrapper.e-time-wrapper .e-time-icon.e-icons {
        font-size: 20px;
        background-color: beige;
}
```

## Customizing the TimePicker popup

Use the following CSS to customize the TimePicker popup

```css
/* To specify height */
.e-timepicker.e-popup {
        height: 100px;
}
```

## Customizing the TimePicker popup content

Use the following CSS to customize the TimePicker popup content

```css
/* To specify height */
.e-timepicker.e-popup .e-list-parent.e-ul li.e-list-item {
        background-color: beige;
        font-size: 20px;
}
```

## Full Screen Mode: Enhancing the TimePicker Component (Mobile Support Only)

We have introduced the Full Screen Mode functionality in our TimePicker component, enabling users to see the TimePicker popup element in full-screen mode for better visibility and an upgraded user experience. It is important to mention that this feature is exclusively available for mobile devices in both landscape and portrait orientations. To activate the Full Screen Mode within the TimePicker component, simply set the `fullScreenMode` API value to `true`. This action will extend the popup element to occupy the entire screen on mobile devices.

{% if page.publishingplatform == "aspnet-core" %}
```html
<ejs-timepicker id="time" fullScreenMode=true></ejs-timepicker>
```

{% elsif page.publishingplatform == "aspnet-mvc" %}
```html
@Html.EJS().TimePicker("time").FullScreenMode(true).Render()
```
{% endif %}
![TimePickerFullScreen](./images/TimePickerFullScreen.gif)
