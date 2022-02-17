---
layout: post
title: Fancy Tooltip Customization in ##Platform_Name## Tooltip Component
description: Learn here all about Fancy Tooltip Customization in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Fancy Tooltip Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Fancy Tooltip Customization

The arrow of the tooltip can be customized as needed by customizing CSS in the sample-side.
The EJ2 tooltip component is achieved through CSS3 format and positioned the tip arrow according to the tooltip positions like `TopCenter`, `BottomLeft`, `RightTop`, and more.

Here, the tip arrow is customized as Curved tooltip and Bubble tooltip.

## Curved tip

The content for the tip pointer arrow has been added. To customize the curved tip arrow, override the following CSS class of tip arrow.

```typescript
    cssClass = 'curvetips e-tooltip-css',
```

```css
    .e-arrow-tip-outer.e-tip-bottom,
    .e-arrow-tip-outer.e-tip-top {
        border-left: none !important;
        border-right: none !important;
        border-top: none !important;
    }
    .e-arrow-tip.e-tip-top {
        transform: rotate(170deg);
    }

```

## Bubble tip

The two `divs`(inner div and outer div) have been added to achieve the bubble tip arrow. To customize the bubble tip arrow, override the following CSS class of tip arrow.

```js
    cssClass: 'bubbletip e-tooltip-css'
```

```css
    .e-arrow-tip-outer.e-tip-bottom, .e-arrow-tip-outer.e-tip-top
    {
        border-radius: 50px;
        height: 10px;
        width: 10px;
    }

    .e-arrow-tip-inner.e-tip-bottom, .e-arrow-tip-inner.e-tip-top
    {
        border-radius: 50px;
        height: 10px;
        width: 10px;
    }
```

These tip arrow customizations have been achieved through CSS changes in the sample level. The tooltip position can be changed by using the radio button click event.

The arrow tip pointer can also be disabled by using the [`showTipPointer`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#showtippointer) property in a tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/tooltip/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/custom-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/tooltip/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

