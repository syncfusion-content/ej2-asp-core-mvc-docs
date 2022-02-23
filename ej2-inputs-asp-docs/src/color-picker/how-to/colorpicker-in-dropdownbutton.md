# ColorPicker in DropDownButton

This section explains about how to render the ColorPicker in DropDownButton. The
[`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Splitbuttons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) property of the DropDownButton helps to achieve this scenario. To know about the usage of `target` property refer to [`Popup templating`](./../../drop-down-button/popup-items.html#popup-templating) section.

In the below sample, the color picker is rendered as inline type by setting [`inline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Inline) property as `true` and the rendered color picker wrapper is passed as a `target` to the DropDownButton to achieve the above scenario.

{% aspTab template="color-picker/dropdownbtn", sourceFiles="dropdownbtn.cs" %}

{% endaspTab %}
