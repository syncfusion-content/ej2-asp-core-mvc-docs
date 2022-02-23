# Custom Tooltip with dynamic HTML

Tooltip loads HTML pages via HTML tags such as iframe, video, and map using the [`content`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#content) property, which supports both string and HTML tags.

To load an `iframe` element in tooltip, set the required iframe in the `content` of tooltip while initializing the tooltip component. Refer to the following code.

```typescript

content: '<iframe src="https://www.syncfusion.com/products/essential-js2"></iframe>

```

{% aspTab template="tooltip/html-page", sourceFiles="html-page.cs" %}

{% endaspTab %}