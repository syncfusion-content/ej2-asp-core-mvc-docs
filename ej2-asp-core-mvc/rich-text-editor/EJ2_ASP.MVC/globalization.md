---
layout: post
title: Globalization in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Globalization in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization

## Localization

The Rich Text Editor provides an option to localize its strings; it is used to adapting the editor to a particular local language. By default, the editor will use the `US English (en-US)` as its language. Please find the table with a list of keys and their corresponding values for the default language (en-US).

```typescript
{
    "en-US": {
        "richtexteditor": {
            "alignments": "Alignments",
            "justifyLeft": "Align Left",
            "justifyCenter": "Align Center",
            "justifyRight": "Align Right",
            "justifyFull": "Align Justify",
            "fontName": "Font Name",
            "fontSize": "Font Size",
            "fontColor": "Font Color",
            "backgroundColor": "Background Color",
            "bold": "Bold",
            "italic": "Italic",
            "underline": "Underline",
            "strikethrough": "Strikethrough",
            "clearFormat": "Clear Format",
            "clearAll": "Clear All",
            "cut": "Cut",
            "copy": "Copy",
            "paste": "Paste",
            "unorderedList": "Bulleted List",
            "orderedList": "Numbered List",
            "indent": "Increase Indent",
            "outdent": "Decrease Indent",
            "undo": "Undo",
            "redo": "Redo",
            "superscript": "Superscript",
            "subscript": "Subscript",
            "createLink": "Insert Link",
            "openLink": "Open Link",
            "editLink": "Edit Link",
            "removeLink": "Remove Link",
            "image": "Insert Image",
            "replace": "Replace",
            "align": "Align",
            "caption": "Image Caption",
            "remove": "Remove",
            "insertLink": "Insert Link",
            "display": "Display",
            "altText": "Alternative Text",
            "dimension": "Change Size",
            "fullscreen": "Maximize",
            "maximize": "Maximize",
            "minimize": "Minimize",
            "lowerCase": "Lower Case",
            "upperCase": "Upper Case",
            "print": "Print",
            "formats": "Formats",
            "sourcecode": "Code View",
            "preview": "Preview",
            "viewside": "ViewSide",
            "insertCode": "Insert Code",
            "linkText": "Display Text",
            "linkTooltipLabel": "Title",
            "linkWebUrl": "Web Address",
            "linkTitle": "Enter a title",
            "linkurl": "http://example.com",
            "linkOpenInNewWindow": "Open Link in New Window",
            "linkHeader": "Insert Link",
            "dialogInsert": "Insert",
            "dialogCancel": "Cancel",
            "dialogUpdate": "Update",
            "imageHeader": "Insert Image",
            "imageLinkHeader": "You can also provide a link from the web",
            "mdimageLink": "Please provide a URL for your image",
            "imageUploadMessage": "Drop image here or browse to upload",
            "imageDeviceUploadMessage": "Click here to upload",
            "imageAlternateText": "Alternate Text",
            "alternateHeader": "Alternative Text",
            "browse": "Browse",
            "imageUrl": "http://example.com/image.png",
            "imageCaption": "Caption",
            "imageSizeHeader": "Image Size",
            "imageHeight": "Height",
            "imageWidth": "Width",
            "textPlaceholder": "Enter Text",
            "inserttablebtn": "Insert Table",
            "tabledialogHeader": "Insert Table",
            "tableWidth": "Width",
            "cellpadding": "Cell Padding",
            "cellspacing": "Cell Spacing",
            "columns": "Number of columns",
            "rows": "Number of rows",
            "tableRows": "Table Rows",
            "tableColumns": "Table Columns",
            "tableCellHorizontalAlign": "Table Cell Horizontal Align",
            "tableCellVerticalAlign": "Table Cell Vertical Align",
            "createTable": "Create Table",
            "removeTable": "Remove Table",
            "tableHeader": "Table Header",
            "tableRemove": "Table Remove",
            "tableCellBackground": "Table Cell Background",
            "tableEditProperties": "Table Edit Properties",
            "styles": "Styles",
            "insertColumnLeft": "Insert Column Left",
            "insertColumnRight": "Insert Column Right",
            "deleteColumn": "Delete Column",
            "insertRowBefore": "Insert Row Before",
            "insertRowAfter": "Insert Row After",
            "deleteRow": "Delete Row",
            "tableEditHeader": "Edit Table",
            "TableHeadingText": "Heading",
            "TableColText": "Col",
            "imageInsertLinkHeader": "Insert Link",
            "editImageHeader": "Edit Image",
            "alignmentsDropDownLeft": "Align Left",
            "alignmentsDropDownCenter": "Align Center",
            "alignmentsDropDownRight": "Align Right",
            "alignmentsDropDownJustify": "Align Justify",
            "imageDisplayDropDownInline": "Inline",
            "imageDisplayDropDownBreak": "Break",
            "tableInsertRowDropDownBefore": "Insert row before",
            "tableInsertRowDropDownAfter": "Insert row after",
            "tableInsertRowDropDownDelete": "Delete row",
            "tableInsertColumnDropDownLeft": "Insert column left",
            "tableInsertColumnDropDownRight": "Insert column right",
            "tableInsertColumnDropDownDelete": "Delete column",
            "tableVerticalAlignDropDownTop": "Align Top",
            "tableVerticalAlignDropDownMiddle": "Align Middle",
            "tableVerticalAlignDropDownBottom": "Align Bottom",
            "tableStylesDropDownDashedBorder": "Dashed Borders",
            "tableStylesDropDownAlternateRows": "Alternate Rows",
            "pasteFormat": "Paste Format",
            "pasteFormatContent": "Choose the formatting action",
            "plainText": "Plain Text",
            "cleanFormat": "Clean",
            "keepFormat": "Keep",
            "formatsDropDownParagraph": "Paragraph",
            "formatsDropDownCode": "Code",
            "formatsDropDownQuotation": "Quotation",
            "formatsDropDownHeading1": "Heading 1",
            "formatsDropDownHeading2": "Heading 2",
            "formatsDropDownHeading3": "Heading 3",
            "formatsDropDownHeading4": "Heading 4",
            "fontNameSegoeUI": "SegoeUI",
            "fontNameArial": "Arial",
            "fontNameGeorgia": "Georgia",
            "fontNameImpact": "Impact",
            "fontNameTahoma": "Tahoma",
            "fontNameTimesNewRoman": "Times New Roman",
            "fontNameVerdana": "Verdana"
        }
    }
}

```

To localize the editor???s strings with your own localization, copy the default language informations and localize the strings in the values column. For example, to localize the editor in German language (???de-DE???).

```typescript
{
    "de-DE": {
        "richtexteditor": {
            "alignments": "Alignments",
            "justifyLeft": "Ausrichten von Text links",
            "justifyCenter": "Text-Zentrum",
            "justifyRight": "Ausrichten von Text rechts",
            "justifyFull": "rechtfertigen",
            "fontName": "W??hlen Sie Schriftfamilie",
            "fontSize": "W??hlen Sie Schriftgr????e",
            "fontColor": "W??hlen Sie die Farbe",
            "backgroundColor": "Hintergrundfarbe",
            "bold": "fett",
            "italic": "kursiv",
            "underline": "unterstreichen",
            "strikethrough": "Durchgestrichen",
            "clearAll": "Alles",
            "clearFormat": "Klar Format",
            "cut": "schneiden",
            "copy": "Kopieren",
            "paste": "Paste",
            "unorderedList": "Legen Sie ungeordnete Liste",
            "orderedList": "Geordnete Liste einf??gen",
            "indent": "Einzug",
            "outdent": "Einzug verkleinern",
            "undo": "l??sen",
            "redo": "Wiederherstellen",
            "superscript": "??berschrift",
            "subscript": "index",
            "createLink": "link einf??gen",
            "removeLink": "fjern Hyperlink",
            "openLink": "Open link",
            "editLink": "Edit link",
            "image": "Bild einf??gen",
            "replace": "ersetzen",
            "align": "ausrichten",
            "caption": "Bildbeschriftung",
            "formats": "Formats",
            "remove": "L??schen",
            "insertLink": "Link einf??gen",
            "display": "Anzeige",
            "alttext": "alternativer Text",
            "dimension": "Gr????e",
            "fullscreen": "Vollbild",
            "maximize": "Maximieren",
            "minimize": "minimieren",
            "zoomIn": "hineinzoomen",
            "zoomOut": "Rauszoomen",
            "upperCase": "Gro??buchstaben",
            "lowerCase": "Kleinbuchstaben",
            "print": "Drucken",
            "sourcecode": "Quellcode",
            "preview": "Vorschau",
            "viewside": "Seite anzeigen",
            "insertcode": "Code eingeben",
            "linkText": "Displaytekst",
            "linkTooltipLabel": "tooltip",
            "linkWebUrl": "Webadres",
            "linkOpenInNewWindow": "Open de link in een nieuw venster",
            "linkHeader": "Link invoegen",
            "dialogInsert": "invoegen",
            "dialogCancel": "Annuleer",
            "dialogUpdate": "Bijwerken",
            "imageHeader": "Voeg afbeelding in",
            "imageLinkHeader": "U kunt ook een link van internet opgeven",
            "imageUploadMessage": "Zet hier een afbeelding neer of klik om te uploaden",
            "imageDeviceUploadMessage": "Klik hier om te uploaden",
            "imageAlternateText": "Alternatieve tekst",
            "alternateHeader": "Alternatieve tekst",
            "browse": "Blader",
            "imageUrl": "URL",
            "imageCaption": "onderschrift",
            "imageSizeHeader": "Afbeeldingsgrootte",
            "imageHeight": "Hoogte",
            "imageWidth": "Breedte",
            "textPlaceholder": "Text eingeben",
            "inserttablebtn": "Tabelle einf??gen",
            "tabledialogHeader": "Tabelle einf??gen",
            "tableWidth": "Breite",
            "cellpadding": "Zellauff??llung",
            "cellspacing": "Zellabstand",
            "columns": "Anzahl der Spalten",
            "rows": "Reihenanzahl",
            "tableRows": "Tabellenzeilen",
            "tableColumns": "Tabellenspalten",
            "tableCellHorizontalAlign": "Horizontale Ausrichtung der Tabellenzelle",
            "tableCellVerticalAlign": "Vertikale Ausrichtung der Tabellenzelle",
            "createTable": "Tabelle erstellen",
            "removeTable": "Tabelle entfernen",
            "tableHeader": "Tabellenkopfzeile",
            "tableRemove": "Tabelle entfernen",
            "tableCellBackground": "Tabellenzellenhintergrund",
            "tableEditProperties": "Eigenschaften der Tabellenbearbeitung",
            "styles": "Styles",
            "insertColumnLeft": "Spalte links einf??gen",
            "insertColumnRight": "Spalte rechts einf??gen",
            "deleteColumn": "Spalte l??schen",
            "insertRowBefore": "Zeile vor einf??gen",
            "insertRowAfter": "Zeile einf??gen nach",
            "deleteRow": "Zeile l??schen",
            "tableEditHeader": "Tabelle bearbeiten",
            "TableHeadingText": "??berschrift",
            "TableColText": "Col",
            "imageInsertLinkHeader": "Link einf??gen",
            "editImageHeader": "Bild bearbeiten",
            "alignmentsDropDownLeft": "Linksb??ndig",
            "alignmentsDropDownCenter": "Im Zentrum anordnen",
            "alignmentsDropDownRight": "Rechts ausrichten",
            "alignmentsDropDownJustify": "Justize ausrichten",
            "imageDisplayDropDownInline": "In der Reihe",
            "imageDisplayDropDownBreak": "Brechen",
            "tableInsertRowDropDownBefore": "Reihe vorher einf??gen",
            "tableInsertRowDropDownAfter": "Zeile danach einf??gen",
            "tableInsertRowDropDownDelete": "Zeile l??schen",
            "tableInsertColumnDropDownLeft": "Spalte links einf??gen",
            "tableInsertColumnDropDownRight": "Spalte rechts einf??gen",
            "tableInsertColumnDropDownDelete": "Spalte l??schen",
            "tableVerticalAlignDropDownTop": "Top ausrichten",
            "tableVerticalAlignDropDownMiddle": "Mitte ausrichten",
            "tableVerticalAlignDropDownBottom": "Unten ausrichten",
            "tableStylesDropDownDashedBorder": "Gestrichelte Grenzen",
            "tableStylesDropDownAlternateRows": "Alternative Zeilen",
            "pasteFormat": "Format einf??gen",
            "pasteFormatContent": "W??hlen Sie die Formatierungsaktion aus",
            "plainText": "Einfacher Text",
            "cleanFormat": "sauber",
            "keepFormat": "Behalten",
            "formatsDropDownParagraph": "Absatz",
            "formatsDropDownCode": "Kodex",
            "formatsDropDownQuotation": "Zitat",
            "formatsDropDownHeading1": "??berschrift 1",
            "formatsDropDownHeading2": "??berschrift 2",
            "formatsDropDownHeading3": "??berschrift 3",
            "formatsDropDownHeading4": "??berschrift 4",
            "fontNameSegoeUI": "SegoeUI",
            "fontNameArial": "Arial",
            "fontNameGeorgia": "Georgia",
            "fontNameImpact": "Einschlag",
            "fontNameTahoma": "Tahoma",
            "fontNameTimesNewRoman": "Mal Neu r??misch",
            "fontNameVerdana": "Verdana"
        }
    }
}

```

The below sample demonstrate that, the Rich Text Editor control rendered with 'de-DE' German language using [`Locale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_Locale_System_String_) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/globalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/globalization/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/globalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/globalization/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## RTL

Specifies the direction of the Rich Text Editor control using the [`EnableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EnableRtl_System_Boolean_) property. For writing systems that require it like Arabic, Hebrew, etc., the direction can be switched to right-to-left.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/rtl/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/rtl/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> [`EnableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EnableRtl_System_Boolean_) property will not change based on [`Locale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_Locale_System_String_) property.