---
layout: post
title: Adornments in ##Platform_Name## TextArea control | Syncfusion
description: Learn here all about Adornments in Syncfusion ##Platform_Name## TextArea control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adornments
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Adornments in ##Platform_Name## TextArea control

Adornments enhance the textarea by adding custom elements such as icons, text, or buttons before or after the text input area. This feature provides a flexible way to extend textarea functionality with visual indicators, formatting options, or interactive elements for improved user experience and content management.

## Overview

Adornments are useful for:
- **Visual Context**: Adding icons that provide visual indicators about the textarea purpose (e.g., edit icon for comments, document icon for descriptions)
- **Formatting Tools**: Including action buttons such as bold, italic, underline, or text formatting controls
- **Content Actions**: Displaying save, delete, clear, or submit buttons for quick content management
- **Input Validation**: Showing validation status icons or character count indicators
- **Accessibility**: Providing visual and interactive to guide user input and improve discoverability
- **Layout Flexibility**: Configurable flow (horizontal/vertical) and orientation for responsive designs

## Add adornments to textarea

Adornments are added using the [prependTemplate](../api/textarea) and [appendTemplate](../api/textarea) properties. These properties accept HTML content that renders before and after the textarea respectively, enabling flexible customization without modifying the core textarea structure.

**Prepend Adornments (Prefix)**: Displayed at the beginning of the textarea. 
**Append Adornments (Suffix)**: Displayed at the end of the textarea.

## Configure flow and orientation

The [adornmentFlow](../api/textarea) and [adornmentOrientation](../api/textarea) properties control how adornments are arranged around the textarea:

**Adornment Flow** Property to position adornments around the textarea:
- `Horizontal`:  prepend on the left, append on the right
- `Vertical`: prepend above, append below

**Adornment Orientation** property to arrange content inside each adornment:
- `Horizontal`:items in a row
- `Vertical`: items in a column

### Basic implementation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/adornments/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/adornments/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textarea](./images/textarea-adornments.png)
