---
title: "How To For Tooltip"
component: "Tooltip"
description: "Tooltip how to section, show tooltip for disabled target, load HTML page into tooltip, show tooltip for SVG/Canvas element, show tooltip on multiple targets."
---

# How To

## Show Tooltip on disabled elements

By default, Tooltips will not be displayed on disabled elements. However, it is possible to enable this behavior by following the steps below.
1. Add a disabled element like the `button` element into a div whose display style is set to `inline-block`.
2. Set the pointer event as `none` for the disabled element (button) through CSS.
3. Now, initialize the Tooltip for outer div element that holds the disabled button element.

{% tab template="layout/tooltip/disabled-elements", isDefaultActive=true, sourceFiles="index.ts,index.html,index.css", es5Template="disabled-template" %}

{% aspTab template="tooltip/tooltip-disabed", sourceFiles="disabled.cs" %}

{% endaspTab %}

## Load HTML tags into tooltip

The Tooltip component loads HTML tags using the [content](https://ej2.syncfusion.com/documentation/tooltip/content.html?lang=typescript) template.

The HTML tags such as `<div>`, `<span>`, `bold`, `italic`, `underline`, etc., can be used. Style attributes can also be applied with HTML tags.

Here, Bold, Italic, Underline, and Anchor tags are used.

When using HTML elements as content to `Tooltip` make the content element `display: none`, then from the
[`beforeRender`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#beforerender)
event we can make the element visible again using below code.

```typescript
    document.getElementById('content').style.display = 'block';
```

{% aspTab template="tooltip/html-content", sourceFiles="html-content.cs" %}

{% endaspTab %}

## Load HTML pages into tooltip

Tooltip loads HTML pages via HTML tags such as iframe, video, and map using the [`content`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#content) property, which supports both string and HTML tags.

To load an `iframe` element in tooltip, set the required iframe in the `content` of tooltip while initializing the tooltip component. Refer to the following code.

```typescript

content: '<iframe src="https://www.syncfusion.com/products/essential-js2"></iframe>

```

{% aspTab template="tooltip/html-page", sourceFiles="html-page.cs" %}

{% endaspTab %}

## Define tooltip open mode property

The open mode property of tooltip can be defined on a target that is hovering, focusing, or clicking.
Tooltip component have the following types of open mode:
    * Auto
    * Hover
    * Click
    * Focus
    * Custom

** Auto **

Tooltip appears when you hover over the target or when the target element receives the focus.

** Hover **

Tooltip appears when you hover over the target.

** Click **

Tooltip appears when you click a target element.

** Focus **

Tooltip appears when you focus (say through tab key) on a target element.

** Custom **

Tooltip is not triggered by any default action. So, bind your own events and use either open or close public methods.

{% aspTab template="tooltip/open-custom", sourceFiles="open-custom.cs" %}

{% endaspTab %}

## Customize tooltip

The arrow of the tooltip can be customized as needed by customizing CSS in the sample-side.
The EJ2 tooltip component is achieved through CSS3 format and positioned the tip arrow according to the tooltip positions like `TopCenter`, `BottomLeft`, `RightTop`, and more.

Here, the tip arrow is customized as Curved tooltip and Bubble tooltip.

** Curved tip **

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

** Bubble tip **

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

{% aspTab template="tooltip/custom-tooltip", sourceFiles="custom-tooltip.cs" %}

{% endaspTab %}

## Display tooltip on SVG and canvas elements

Tooltip can be displayed on both SVG and Canvas elements. You can directly attach the `<svg>` or `<canvas>` elements to show tooltips on data visualization elements.

{% aspTab template="tooltip/svg-canvas", sourceFiles="svg-canvas.cs" %}

{% endaspTab %}

## Create and show tooltip on multiple targets

Tooltip can be created and shown on multiple targets within a container by defining the specific target elements to the target property. So, the tooltip is initialized only on matched targets within a container.

{% aspTab template="tooltip/multi-target", sourceFiles="multi-target.cs" %}

{% endaspTab %}

## Change tooltip content dynamically

The tooltip content can be changed dynamically using the [AJAX](https://ej2.syncfusion.com/documentation/base/api-ajax.html?lang=typescript) request.

The AJAX request should be made within the [`beforeRender`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#beforerender) event of the tooltip. On every success, the corresponding retrieved data will be set to the [content](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#content) property of the tooltip.

When you hover over the icons, its respective data will be retrieved dynamically and then assigned to the tooltip’s content.

Refer to the following code snippet to change the tooltip content dynamically.

```js
function onBeforeRender(args): void {
    this.content = 'Loading...';
    this.dataBind();
    var ajax = new Ajax('./tooltip.json', 'GET', true);
    ajax.send().then(
        (result: any) => {
            result = JSON.parse(result);
            for (var i: number = 0; i < result.length; i++) {
                if (result[i].Id == args.target.id) {
                    /* tslint:disable */
                    this.content = result[i].Sports;
                    /* tslint:enable */
                }
            }
            this.dataBind();
        },
        (reason: any) => {
            this.content = reason.message;
            this.dataBind();
        });
}
```

{% aspTab template="tooltip/dynamic-content", sourceFiles="dynamic-content.cs" %}

{% endaspTab %}