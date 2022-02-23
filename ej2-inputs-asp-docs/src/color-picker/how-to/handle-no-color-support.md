# Handle no color support

The ColorPicker component supports no color functionality. By clicking the no color tile from palette, the selected color becomes `empty` and considered as no color has been selected from color picker.

## Default no color

To achieve this, set [`noColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_NoColor) property as `true`.

In the following sample, the first tile of the color palette represents the no color tile. By clicking the no color tile you can achieve the above functionalities.

{% aspTab template="color-picker/nocolor", sourceFiles="nocolor.cs" %}

{% endaspTab %}

## Custom no color

The following sample show the color palette with custom no color option.

{% aspTab template="color-picker/custom-nocolor", sourceFiles="custom-nocolor.cs" %}

{% endaspTab %}
