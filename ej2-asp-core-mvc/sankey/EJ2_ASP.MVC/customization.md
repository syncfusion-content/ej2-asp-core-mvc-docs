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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Global-node.cs" %}
{% include code-snippet/sankey/customization/global-node/global-node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-node/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Global-node.cs" %}
{% include code-snippet/sankey/customization/global-node/global-node.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Global Link Styling

Configure link appearance using the `linkStyle` property:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Global-link.cs" %}
{% include code-snippet/sankey/customization/global-link/global-link.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/global-link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Global-link.cs" %}
{% include code-snippet/sankey/customization/global-link/global-link.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Individual Element Customization

### Custom Node Appearance

Customize individual nodes by setting properties on each node object:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-appearance.cs" %}
{% include code-snippet/sankey/customization/custom-node-appearance/custom-node-appearance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-appearance.cs" %}
{% include code-snippet/sankey/customization/custom-node-appearance/custom-node-appearance.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Custom Node Labels

Customize individual node labels with specific text, styling, and positioning:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-labels.cs" %}
{% include code-snippet/sankey/customization/custom-node-labels/custom-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-node-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-node-labels.cs" %}
{% include code-snippet/sankey/customization/custom-node-labels/custom-node-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/color-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color-mapping.cs" %}
{% include code-snippet/sankey/customization/color-mapping/color-mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/color-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color-mapping.cs" %}
{% include code-snippet/sankey/customization/color-mapping/color-mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

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

### Custom Theme Colors

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-theme.cs" %}
{% include code-snippet/sankey/customization/custom-theme/custom-theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/custom-theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-theme.cs" %}
{% include code-snippet/sankey/customization/custom-theme/custom-theme.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Tooltip Customization

### Template-Based Tooltips

Create custom tooltip templates for rich content:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/template-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template-tooltip.cs" %}
{% include code-snippet/sankey/customization/template-tooltip/template-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/template-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template-tooltip.cs" %}
{% include code-snippet/sankey/customization/template-tooltip/template-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Advanced Customization Patterns

### Conditional Styling Based on Data

Apply different styles based on data conditions or value ranges:

```typescript
const onNodeRendering = (args) => {
  const value = args.node.value || 0;
  
  if (value > 200) {
    args.node.color = '#00A651'; // High flow - green
  } else if (value > 100) {
    args.node.color = '#FFB81C'; // Medium flow - orange
  } else {
    args.node.color = '#E81B23'; // Low flow - red
  }
};
```

### Category-Based Styling

Assign colors and styles based on node categories:

```typescript
const categoryColors = {
  'Energy': '#FF6B6B',
  'Transport': '#4ECDC4',
  'Industry': '#95E1D3',
  'Residential': '#FFD93D'
};

const onNodeRendering = (args) => {
  const category = extractCategory(args.node.id);
  args.node.color = categoryColors[category] || '#999';
};
```

### Interactive Styling

Apply different styles for hover and focus states:

```typescript
const onNodeEnter = (args) => {
  // Highlight node on hover
  args.node.highlightOpacity = 1;
};

const onNodeLeave = (args) => {
  // Reset to normal state
  args.node.highlightOpacity = 0.3;
};
```

## Performance Optimization

### Large Dataset Customization

For charts with many nodes and links, optimize rendering performance:

1. **Use Global Styles**: Apply global `nodeStyle` and `linkStyle` instead of individual customization
2. **Minimize Calculations**: Reduce complex calculations in rendering events
3. **Conditional Rendering**: Only customize visible elements in viewport
4. **Cache Results**: Cache computed styles and colors

## Customization Best Practices

### Key Considerations

1. **Consistency**
   - Maintain consistent color schemes across nodes and links
   - Use meaningful colors that represent data categories
   - Apply visual hierarchy through size and opacity

2. **Performance**
   - Avoid complex calculations in rendering events
   - Use global styles when possible
   - Optimize for large datasets

3. **Accessibility**
   - Don't rely solely on color for information
   - Ensure sufficient contrast ratios
   - Provide alternative representations

4. **User Experience**
   - Use intuitive color mapping
   - Provide clear visual feedback for interactions
   - Maintain visual consistency with your application

5. **Maintainability**
   - Document custom styling logic
   - Use reusable style functions
   - Separate styling from business logic

## Example: Comprehensive Customization

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/comprehensive-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Comprehensive-customization.cs" %}
{% include code-snippet/sankey/customization/comprehensive-customization/comprehensive-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/customization/comprehensive-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Comprehensive-customization.cs" %}
{% include code-snippet/sankey/customization/comprehensive-customization/comprehensive-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Related Topics

- [Appearance](appearance.md)
- [Nodes](nodes.md)
- [Links](links.md)
- [Labels](labels.md)
- [Legend](legend.md)
- [Events](events.md)
