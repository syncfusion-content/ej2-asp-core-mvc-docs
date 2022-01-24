---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set Default Format In Document Editor of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set Default Format In Document Editor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set the default character, paragraph and section format in Document Editor component

You can set the default character format, paragraph format and section format in Document editor.

## Set the default character format

You can use `setDefaultCharacterFormat` method to set the default character format. For example, Document editor default font size is 11 and you can change it as any valid value.

The following example code illustrates how to change the default font size in Document editor.

{% aspTab template="document-editor-container/character-format-font" %}

{% endaspTab %}

Similarly, you can change the required `CharacterFormatProperties` default value.

The following example code illustrates how to change other character format default value in Document editor.

{% aspTab template="document-editor-container/character-format" %}

{% endaspTab %}

## Set the default paragraph format

You can use `setDefaultParagraphFormat` API to set the default paragraph format. You can change the required `ParagraphFormatProperties` default value.

The following example code illustrates how to change the paragraph format(before spacing, line spacing etc.,) default value in Document editor.

{% aspTab template="document-editor-container/paragraph-format" %}

{% endaspTab %}

## Set the default section format

You can use `setDefaultSectionFormat` API to set the default section format. You can change the required `SectionFormatProperties` default value.

The following example code illustrates how to change the section format(header and footer distance, page width and height, etc.,) default value in Document editor.

{% aspTab template="document-editor-container/section-format" %}

{% endaspTab %}