---
title: "CheckBox Label and Size"
component: "CheckBox"
description: "CheckBox control supports different sizes and label."
---

# Label and Size

This section explains the different sizes and labels.

## Label

The CheckBox caption can be defined by using the [`label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Label) property.
This reduces the manual addition of label for CheckBox. You can customize the label position before or after the CheckBox
through the [`labelPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_LabelPosition) property.

{% aspTab template="check-box/label", sourceFiles="label.cs" %}

{% endaspTab %}

## Size

The different CheckBox sizes available are default and small. To reduce the size of default CheckBox to small,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_CssClass) property to `e-small`.

{% aspTab template="check-box/size", sourceFiles="size.cs" %}

{% endaspTab %}

## See Also

* [CheckBox customization](./how-to/customized-checkbox)