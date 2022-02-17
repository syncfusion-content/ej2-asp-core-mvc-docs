---
layout: post
title: Feature Module in ##Platform_Name## Document Editor Component
description: Learn here all about Feature Module in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Feature Module
publishingplatform: ##Platform_Name##
documentation: ug
---


# Feature modules

Document editor features are segregated into individual feature-wise modules to enable selective referencing. By default, the document editor displays the document in read-only mode. The required modules should be injected to extend its functionality. The following are the selective modules of document editor that can be included as required:
* **Print** - Prints the document.
* **SfdtExport** - Exports the document as Syncfusion Document Text (.SFDT) file.
* **Selection** - Selects a portion of the document and copy it to the clipboard.
* **Search** - Searches specific text and navigate between the results.
* **WordExport** - Exports the document as Word Document (.DOCX) file.
* **TextExport** - Exports the document as Text Document (.TXT) file.
* **Editor** - Performs all kind of editing operations.
* **EditorHistory** - Maintains the history of editing operations so that you can perform undo and redo at any time.
* User interface options such as context menu, options pane, image resizer, and dialog are available as individual modules.

>In addition to injecting the required modules in your application, enable corresponding properties to extend the functionality for a document editor instance.
Refer to the following table.

| Module | Property to enable the functionality for a document editor instance |
|---|---|
|Print|`<ejs-documenteditor enablePrint= true ></ejs-documenteditor>`|
|SfdtExport|`<ejs-documenteditor enableSfdtExport= true ></ejs-documenteditor>`|
|Selection|`<ejs-documenteditor enableSelection= true ></ejs-documenteditor>`|
|Search|`<ejs-documenteditor enableSearch= true ></ejs-documenteditor>`|
|WordExport|`<ejs-documenteditor enableWordExport= true ></ejs-documenteditor>`|
|TextExport|`<ejs-documenteditor enableTextExport= true ></ejs-documenteditor>`|
|Editor|`<ejs-documenteditor isReadOnly= false enableEditor= true ></ejs-documenteditor>`|
|EditorHistory|`<ejs-documenteditor isReadOnly= false enableEditor= true enableEditorHistory= true ></ejs-documenteditor>`|
|OptionsPane(Find)|`<ejs-documenteditor enableSearch= true enableOptionsPane= true ></ejs-documenteditor>`|
|OptionsPane(Find and Replace)|`<ejs-documenteditor isReadOnly= false enableEditor= true enableSearch= true enableOptionsPane= true ></ejs-documenteditor>`|
|ContextMenu|`<ejs-documenteditor enableSelection= true enableContextMenu= true ></ejs-documenteditor>`|
|ImageResizer|`<ejs-documenteditor isReadOnly= false enableEditor= true enableImageResizer= true ></ejs-documenteditor>`|
|HyperlinkDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableHyperlinkDialog= true ></ejs-documenteditor>`|
|TableDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableTableDialog= true ></ejs-documenteditor>`|
|FontDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableFontDialog= true ></ejs-documenteditor>`|
|ParagraphDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableParagraphDialog= true ></ejs-documenteditor>`|
|BookmarkDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableBookmarkDialog= true ></ejs-documenteditor>`|
|PageSetupDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enablePageSetupDialog= true ></ejs-documenteditor>`|
|TableOfContentsDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableTableOfContentsDialog= true ></ejs-documenteditor>`|
|ListDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableListDialog= true ></ejs-documenteditor>`|
|TablePropertiesDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableTablePropertiesDialog= true ></ejs-documenteditor>`|
|CellOptionsDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableTablePropertiesDialog= true ></ejs-documenteditor>`|
|BordersAndShadingDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableBordersAndShadingDialog= true ></ejs-documenteditor>`|
|TableOptionsDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableTableOptionsDialog= true ></ejs-documenteditor>`|
|StylesDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableStyleDialog= true ,enableStylesDialog= true ></ejs-documenteditor>`|
|StyleDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableStyleDialog= true ></ejs-documenteditor>`|
|BulletsAndNumberingDialog|`<ejs-documenteditor isReadOnly= false enableEditor= true enableStyleDialog= true ></ejs-documenteditor>`|