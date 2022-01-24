---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Context Menu of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context menu customization

## How to customize context menu in Document Editor

Document Editor allows you to add custom option in context menu. It can be achieved by using the `addCustomMenu()` method and custom action is defined using the `customContextMenuSelect`.

### Add Custom Option

The following code shows how to add custom option in context menu.

{% aspTab template="document-editor-container/add-custom-menu" %}

{% endaspTab %}

### Customize custom option in context menu

Document Editor allows you to customize the added custom option and also to hide/show default context menu.

#### Hide default context menu items

Using `addCustomMenu()` method, you can hide the default context menu. By setting second parameter as true.

The following code shows how to hide default context menu and add custom option in context menu.

{% aspTab template="document-editor-container/hide-context-menu" %}

{% endaspTab %}

#### Customize added context menu items

The following code shows how to hide/show added custom option in context menu using the `customContextMenuBeforeOpen`.

{% aspTab template="document-editor-container/customize-context-menu" %}

{% endaspTab %}