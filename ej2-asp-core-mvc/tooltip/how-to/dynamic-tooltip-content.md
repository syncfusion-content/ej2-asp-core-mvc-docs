---
layout: post
title: Dynamic Tooltip Content in ##Platform_Name## Tooltip Component
description: Learn here all about Dynamic Tooltip Content in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Dynamic Tooltip Content
publishingplatform: ##Platform_Name##
documentation: ug
---

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/dynamic-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-content.cs" %}
{% include code-snippet/tooltip/dynamic-content/dynamic-content.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/dynamic-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-content.cs" %}
{% include code-snippet/tooltip/dynamic-content/dynamic-content.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

