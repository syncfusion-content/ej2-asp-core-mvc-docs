---
layout: post
title: Execute Command in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Execute Command in Syncfusion ##Platform_Name## Rich Text Editor Control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Execute Command
publishingplatform: ##Platform_Name##
documentation: ug
---

# Execute command in ##Platform_Name## Rich text editor Control

In Rich Text Editor, executeCommand used to perform commands for the modification of content in editable area. The executeCommand will perform the following commands.

| Commands | Description | Code snippets |
|----------------|---------| -----------|
| bold | Bold the selected content in the Rich Text Editor. |`rteObj.executeCommand('bold');`|
| italic | The selected text will be italics. |`rteObj.executeCommand('italic');`|
| underline | Underline the selected text in the Rich Text Editor. |`rteObj.executeCommand('underline');`|
| strikeThrough | Apply single line strike through formatting for the selected text. |`rteObj.executeCommand('strikeThrough');`|
| superscript | Makes the selected text as superscript (higher). |`rteObj.executeCommand('superscript');`|
| subscript | Makes the selected text as subscript (lower). |`rteObj.executeCommand('subscript');`|
| uppercase | Change the case of selected text to upper  in the content. |`rteObj.executeCommand('uppercase');`|
| lowercase | Change the case of selected text to lower in the content. |`rteObj.executeCommand('uppercase');`|
| fontColor | Apply the specified font color for the selected text. |`rteObj.executeCommand('fontColor', 'yellow');`|
| fontName | Apply the specified font name for the selected text. |`rteObj.executeCommand('fontName', 'Arial');`|
| fontSize | Apply the specified font size for the selected text. |`rteObj.executeCommand('fontSize', '10pt');`|
| formatBlock | Apply the specified format styles for the selected text. |`rteObj.executeCommand('formatBlock', 'H1');`|
| backColor | Apply the specified background color the selected text. | `rteObj.executeCommand('backColor', 'red');`|
| justifyCenter | Align the content with center margin. | `rteObj.executeCommand('justifyCenter');`|
| justifyFull | Align the content with justify margin. |`rteObj.executeCommand('justifyFull');`|
| justifyLeft | Align the content with left margin. | `rteObj.executeCommand('justifyLeft');`|
| justifyRight | Align the content with right margin. | `rteObj.executeCommand('justifyLeft');`|
| undo | Allows to undo the actions. | `rteObj.executeCommand('undo');`|
| createLink | Creates a hyperlink to a text or image to a specific location in the content. | `rteObj.executeCommand('createLink',{ text: 'Links', url: 'http://', title : 'Link' });` |
| indent | Allows to increase the indent level of the content. | `rteObj.executeCommand('indent');`|
| insertHTML | Insert the html content to the current cursor position. | `rteObj.executeCommand('insertHTML', 'inserted an html');`|
| insertOrderedList | Create a new list item(numbered). | `rteObj.executeCommand('insertOrderedList');`|
| insertUnorderedList | Create a new list item(bulleted). |`rteObj.executeCommand('insertUnorderedList');`|
| outdent | Allows to decrease the indent level of the content. | `rteObj.executeCommand('outdent');`|
| redo | Allows to redo the actions | `rteObj.executeCommand('redo');`|
| removeFormat | remove all formatting styles (such as bold, italic, underline, color, superscript, subscript, and more) from currently selected text. |`rteObj.executeCommand('removeFormat');`|
| insertText | Insert text to the current cursor position. | `rteObj.executeCommand('insertText', 'inserted a text');` |
| insertImage | Insert an image to the current cursor position. | `rteObj.executeCommand('insertImage', { url: 'https://ej2.syncfusion.com/javascript/demos/src/rich-text-editor/images/RTEImage-Feather.png', cssClass: 'rte-img'});` |
| copyFormatPainter | Copy the format of selected text and apply it to another text. | `rteObj.executeCommand('copyFormatPainter', formatPainterSettings);`|
| applyFormatPainter | Apply the copied format to the selected text. | `rteObj.executeCommand('applyFormatPainter');`|
| escapeFormatPainter | Remove the previously copied format and disable the sticky mode | `rteObj.executeCommand('escapeFormatPainter');`|
| insertVideo | Insert a video to the current cursor position. | `rteObj.executeCommand('insertVideo', { url: 'https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Ocean-Waves.mp4', cssClass: 'e-rte-video'});` |
| insertAudio | Insert a audio to the current cursor position. | `rteObj.executeCommand('insertAudio', { url: 'https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Audio.wav', cssClass: 'e-rte-audio'});` |

N> The ‘ExecuteCommand’ public method is not supported in Syncfusion<sup style="font-size:70%">&reg;</sup> Markdown Editor
