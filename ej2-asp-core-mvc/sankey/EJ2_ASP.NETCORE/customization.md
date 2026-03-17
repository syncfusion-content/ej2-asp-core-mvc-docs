<!-- Converted from: sankey/EJ2_ASP.MVC/customization.md -->

---
layout: post
title: Customization in ##Platform_Name## Sankey Chart Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization in React Sankey Chart component

The Sankey Chart provides extensive customization options to create visualizations that match your specific design requirements and data presentation needs. From styling and theming to advanced visual techniques, the component enables complete control over appearance and behavior.

This guide covers comprehensive customization techniques including styling, theming, color mapping, and visual customization strategies.

## Styling Overview

The Sankey Chart supports multiple levels of styling customization:

- **Global Styling**: Apply consistent styles to all elements
- **Element-Level Styling**: Customize specific nodes, links, or labels
- **Data-Driven Styling**: Apply styles based on data values or conditions
- **Theme-Based Styling**: Use predefined themes or create custom themes

## Node and Link Styling

### Global Node Styling

Apply consistent styling to all nodes using the `nodeStyle` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Global-node.cs" %}
{% include code-snippet/sankey/customization/global-node/global-node.cs %}
{% endhighlight %}
{% endtabs %}

### Global Link Styling

Configure link appearance using the `linkStyle` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Global-link.cs" %}
{% include code-snippet/sankey/customization/global-link/global-link.cs %}
{% endhighlight %}
{% endtabs %}

## Individual Element Customization

### Custom Node Appearance

Customize individual nodes by setting properties on each node object:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-appearance.cs" %}
{% include code-snippet/sankey/customization/custom-node-appearance/custom-node-appearance.cs %}
{% endhighlight %}
{% endtabs %}

### Custom Node Labels

Customize individual node labels with specific text, styling, and positioning:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-labels.cs" %}
{% include code-snippet/sankey/customization/custom-node-labels/custom-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

## Color Customization

### Predefined Color Palettes

Apply predefined color palettes to automatically color nodes:

```typescript
const nodes = [
  { id: 'Source1', label: { text: 'Source 1' }, color: '#3DA6D4' },
  { id: 'Source2', label: { text: 'Source 2' }, color: '#FFA500' },
  { id: 'Target', label: { text: 'Target' }, color: '#28A745' }
];
```

### Color Mapping

Map colors to specific categories or value ranges:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/color-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color-mapping.cs" %}
{% include code-snippet/sankey/customization/color-mapping/color-mapping.cs %}
{% endhighlight %}
{% endtabs %}

## Theme Customization

### Apply Theme

```typescript
const theme = 'Material'; // or 'Fabric', 'Bootstrap', 'HighContrast'

return (
  <SankeyChartComponent 
    theme={theme}
    {...otherProps}
  >
  </SankeyChartComponent>
);
```

## Advanced Customization Patterns

... (content preserved)
