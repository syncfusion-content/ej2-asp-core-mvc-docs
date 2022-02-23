---
title: "Tooltip Content"
component: "Tooltip"
description: "Tooltip component's content can be assigned with static text, template, or loaded dynamically via AJAX."
---

# Content

A text or a piece of information assigned to the Tooltip's `content` property will be displayed as the main text stream of the Tooltip.
 It can be a string or a template content. If the `content` property is not provided with any specific value, then it takes the value
  assigned to the `title` attribute of the target element on which the Tooltip was initialized. The content can also dynamically be
   assigned to the Tooltip via AJAX.

## Template content

Any text or image can be added to the Tooltip, by default. To customize the Tooltip layout or to create your own visualized element on the
 Tooltip, template can be used.

Refer to the following code example to add formatted HTML content to the Tooltip.

{% aspTab template="tooltip/template", sourceFiles="template.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Content](./images/tooltip-content.png)

## Dynamic content via AJAX

The Tooltip content can be dynamically loaded  by making use of the AJAX call. The AJAX request is usually made within the `beforeRender`
 event of the Tooltip, and then the Tooltip's `content` is assigned the value retrieved on it's success.

{% aspTab template="tooltip/ajaxcontent", sourceFiles="ajaxcontent.cs,icons.css" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Dynamic Content via Ajax](./images/dynamic-content.png)
