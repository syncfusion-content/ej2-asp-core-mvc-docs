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

| Module |  Property to Enable the functionality for a document editor instance |
|---|---|---|
|Print|`@Html.EJS().DocumentEditor("container").EnablePrint(true).Render()`|
|SfdtExport|`@Html.EJS().DocumentEditor("container").EnableSfdtExport(true).Render()`|
|Selection|`@Html.EJS().DocumentEditor("container").EnableSelection(true).Render()`|
|Search|`@Html.EJS().DocumentEditor("container").EnableSearch(true).Render()`|
|WordExport|`@Html.EJS().DocumentEditor("container").EnableWordExport(true).Render()`|
|TextExport|`@Html.EJS().DocumentEditor("container").EnableTextExport(true).Render()`|
|Editor|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).Render()`|
|EditorHistory|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableEditorHistory(true).Render()`|
|OptionsPane(Find)|`@Html.EJS().DocumentEditor("container").EnableSearch(true).EnableOptionsPane(true).Render()`|
|OptionsPane(Find and Replace)|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableSearch(true).EnableOptionsPane(true).Render()`|
|ContextMenu|`@Html.EJS().DocumentEditor("container").EnableSelection(true).EnableContextMenu(true).Render()`|
|ImageResizer|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableImageResizer(true).Render()`|
|HyperlinkDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableHyperlinkDialog(true).Render()`|
|TableDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableTableDialog(true).Render()`|
|FontDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableFontDialog(true).Render()`|
|ParagraphDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableParagraphDialog(true).Render()`|
|BookmarkDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableBookmarkDialog(true).Render()`|
|PageSetupDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnablePageSetupDialog(true).Render()`|
|TableOfContentsDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableTableOfContentsDialog(true).Render()`|
|ListDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableListDialog(true).Render()`|
|TablePropertiesDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableTablePropertiesDialog(true).Render()`|
|CellOptionsDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableTablePropertiesDialog(true).Render()`|
|BordersAndShadingDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableBordersAndShadingDialog(true).Render()`|
|TableOptionsDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableTableOptionsDialog(true).Render()`|
|StylesDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableStyleDialog(true).EnableStylesDialog(true).Render()`|
|StyleDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableStyleDialog(true).Render()`|
|BulletsAndNumberingDialog|`@Html.EJS().DocumentEditor("container").IsReadOnly(false).EnableEditor(true).EnableStyleDialog(true).Render()`|