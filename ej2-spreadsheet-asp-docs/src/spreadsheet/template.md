---
title: "Template"
component: "Spreadsheet"
description: "This section helps you to learn how to add other controls in the Essential JS 2 Spreadsheet."
---

# Cell Template

Cell Template is used for adding HTML elements into Spreadsheet. You can add the cell template in spreadsheet by using the `template` property and specify the address using the `address` property inside the `ranges` property. You can customize the Html elements similar to Syncfusion components (TextBox, DropDownList, RadioButton, MultiSelect, DatePicker etc) by using the `beforeCellRender` event. In this demo, Cell template is applied to `C2:C9` and instantiated with Html input components like TextBox, RadioButton, TextArea. You need to bind the events to perform any operations through HTML elements or Syncfusion components. Here, we have added `change` event in to the MultiSelect control, and we have updated the selected data into the spreadsheet cell through that change event.

The following code example describes the above behavior.

{% aspTab template="spreadsheet/template", sourceFiles="templateController.cs" %}

{% endaspTab %}

## See Also

* [Worksheet](./worksheet)
* [Rows and columns](./rows-and-columns)