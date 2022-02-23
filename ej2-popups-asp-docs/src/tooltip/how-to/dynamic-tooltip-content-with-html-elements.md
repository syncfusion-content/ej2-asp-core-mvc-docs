# Dynamic Tooltip content with HTML elements

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