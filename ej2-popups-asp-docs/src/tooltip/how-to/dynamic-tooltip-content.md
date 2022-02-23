# Dynamic Tooltip content

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