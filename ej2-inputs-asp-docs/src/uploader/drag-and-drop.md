# Drag and drop

The uploader component allows you to drag and drop the files to upload.
You can drag the files from file explorer and drop into the drop area.
By default, the uploader component act as drop area element. The drop area gets highlighted when you drag the files over drop area.

## Custom drop area

The uploader component allows you to set external target element as drop area using the [dropArea](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Inputs.Uploader~DropArea.html) property. The element can be represented as HTML element or element’s id.

{% aspTab template="uploader/custom-drop", sourceFiles="custom-drop.cs,index.css" %}

{% endaspTab %}

## Customize drop area

You can customize the appearance of drop area by overriding the default drop area styles.
The class “” and “” is available to handle this customization.

{% aspTab template="uploader/customize-drop", sourceFiles="customize-drop.cs" %}

{% endaspTab %}
