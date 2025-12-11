---
layout: post
title: Adornments in ##Platform_Name## Textbox control | Syncfusion
description: Learn here all about Adornments in Syncfusion ##Platform_Name## Textbox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adornments
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Adornments in ##Platform_Name## Textbox control

Adornments enhance the textbox by adding custom elements such as icons, text, or buttons at the before or after of the input field. This feature provides a flexible way to extend textbox functionality with visual indicators or interactive elements for improved user experience.

## Overview

Adornments are useful for:
- **Visual Context**: Adding icons that indicate the expected input type (e.g., user icon for username, envelope icon for email)
- **Functional Enhancement**: Including action buttons such as password visibility toggles or clear buttons
- **Input Validation**: Displaying validation status icons or error indicators
- **Unit Indicators**: Showing currency symbols, temperature units, domain extensions, or measurement units
- **Accessibility**: Providing visual and interactive guidance to help users input and improve discoverability

## Add adornments to textbox

Adornments are added using the prependTemplate and appendTemplate properties. These properties accept HTML content that renders before and after the input field respectively, enabling flexible customization without modifying the core textbox structure.

**PrependTemplate**: Renders before the textbox. 
**AppendTemplate**: Renders after the textbox.

### Basic implementation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/adornments/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/adornments/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textbox](./images/textbox-adornments.png)