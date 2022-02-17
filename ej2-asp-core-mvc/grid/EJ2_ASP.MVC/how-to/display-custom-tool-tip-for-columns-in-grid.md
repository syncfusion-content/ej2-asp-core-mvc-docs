---
layout: post
title: Display Custom Tool Tip For Columns In Grid in ##Platform_Name## Grid Component
description: Learn here all about Display Custom Tool Tip For Columns In Grid in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Display Custom Tool Tip For Columns In Grid
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display custom ToolTip for columns in Grid

To display a custom ToolTip (**EJ2 Tooltip**), you can render the Grid control inside the Tooltip component and set the target as “.e-rowcell”. The tooltip is displayed when hovering the grid cells.

Change the tooltip content for the grid cells by using the following code in the  (**beforeRender**) event.

```typescript

function beforeRender(args) {
        // event triggered before render the tooltip on target element.
        var tooltip = document.getElementById("Tooltip").ej2_instances[0]
        tooltip.content = args.target.closest("td").innerText;
}

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/grid/how-to/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/grid/how-to/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


