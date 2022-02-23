---
title: "Hyperlink"
component: "DocumentEditor"
description: "Learn how to insert, delete, or navigate links in ASP.NET CORE document editor."
---

# Hyperlink

Document editor supports hyperlink field. You can link a part of the document content to Internet or file location, mail address, or any text within the document.

## Navigate a hyperlink

Document editor triggers ‘requestNavigate’ event whenever user clicks Ctrl key or tap a hyperlink within the document. This event provides necessary details about link type, navigation URL, and local URL (if any) as arguments, and allows you to easily customize the hyperlink navigation functionality. Refer to the following example.

{% aspTab template="document-editor/hyperlink", sourceFiles="document-editor.cs" %}

{% endaspTab %}

If the selection is in hyperlink, trigger this event by calling ‘navigateHyperlink’ method of ‘Selection’ instance. Refer to the following example.

```typescript
documenteditor.selection.navigateHyperlink();
```

## Copy link

Document editor copies link text of a hyperlink field to the clipboard if the selection is in hyperlink. Refer to the following example.

```typescript
documenteditor .selection.copyHyperlink();
```

## Add hyperlink

To create a basic hyperlink in the document, press `ENTER` / `SPACEBAR` / `SHIFT + ENTER` / `TAB` key after typing the address, for instance `http://www.google.com`. Document editor automatically converts this address to a hyperlink field. The text can be considered as a valid URL if it starts with any of the following.

><http://><br>
><https://><br>
>file:///<br>
>www.<br>
>mailto:<br>

Refer to the following example.

{% aspTab template="document-editor/hyperlink-edit", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Remove hyperlink

To remove link from hyperlink in the document, press Backspace key at the end of a hyperlink. By removing the link, it will be converted as plain text. You can use ‘removeHyperlink’ method of ‘Editor’ instance if the selection is in hyperlink. Refer to the following example.

```typescript
documenteditor.editor.removeHyperlink();
```

## Hyperlink dialog

Document editor provides dialog support to insert or edit a hyperlink. Refer to the following example.

{% aspTab template="document-editor/hyperlink-dialog", sourceFiles="document-editor.cs" %}

{% endaspTab %}

You can use the following keyboard shortcut to open the hyperlink dialog if the selection is in hyperlink.

| Key Combination | Description |
|-----------------|-------------|
|Ctrl + K | Open hyperlink dialog that allows you to create or edit hyperlink|

## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Hyperlink dialog](../../document-editor/dialog/#hyperlink-dialog)
