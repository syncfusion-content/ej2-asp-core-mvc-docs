---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set Item Wise Custom Template of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set Item Wise Custom Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set item-wise custom template

The Toolbar supports adding template commands using the  `template` property. Template property can be given as the `HTML element` that is either a `string`  or a `query selector`.

## As a string

The HTML element tag can be given as a string for the template property. Here, the checkbox is rendered as a HTML template.

```typescript
template: "<div><input type='checkbox' id='check1' checked=''>Accept</input></div>"

```

## As a selector

The template property also allows getting template content through query `selector`. Here, checkbox 'ID' attribute is specified in the template.

```typescript
template: "#Template"

```

{% aspTab  template="toolbar/how-to/selector", sourceFiles="selector.cs"%}

{% endaspTab %}