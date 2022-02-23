# Getting Started

This section briefly explains about how to include a default ColorPicker in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ColorPicker to the project

We are going to render `ColorPicker` component in **Index.cshtml** page.

{% aspTab template="color-picker/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![ColorPicker Sample](./images/color-picker.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of ColorPicker.

{% aspTab template="color-picker/getting-started/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Inline type

By default, the ColorPicker will be rendered using SplitButton and open the pop-up to access the ColorPicker. To
render the ColorPicker container alone and to access it directly, render it as inline. It can be achieved by setting the [`inline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Inline) property to `true`.

The following sample shows the inline type rendering of ColorPicker.

{% aspTab template="color-picker/getting-started/inline", sourceFiles="inline.cs" %}

{% endaspTab %}

>> The `showButtons` property is disabled in this sample because the control buttons are not needed for inline type. To know about the control buttons functionality, refer to the [`showButtons`](./how-to/hide-control-buttons) sample.

## See Also

* [Set color value](./mode-and-value#color-value)
* [ColorPicker customization](./how-to/customize-colorpicker)