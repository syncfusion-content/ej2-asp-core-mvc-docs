---
layout: post
title: Enable Disable Grid And Its Actions in ##Platform_Name## Grid Component
description: Learn here all about Enable Disable Grid And Its Actions in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Enable Disable Grid And Its Actions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Enable disable grid and its actions in ASP.NET Core Grid component

You can enable or disable the Syncfusion ASP.NET Core Grid and its actions by applying or removing specific CSS styles. This functionality is particularly useful in scenarios where interactions need to be restricted. Follow the steps below to implement this feature.

**Step 1**: Create CSS class with custom style to override the default style of Grid.

```css
        .disablegrid {
            pointer-events: none;
            opacity: 0.4;
        }
        .wrapper {
            cursor: not-allowed;
        }

```

**Step 2**: Add/Remove the CSS class to the Grid in the click event handler of Button.

```typescript
    <script>
        document.getElementById('element').onclick = function () {
            var grid = document.getElementById("grid").ej2_instances[0];
            if (grid.element.classList.contains('disablegrid')) {
                grid.element.classList.remove('disablegrid');
                document.getElementById("gridParent").classList.remove('wrapper');
            }
            else {
                grid.element.classList.add('disablegrid');
                document.getElementById("gridParent").classList.add('wrapper');
            }
        }
    </script>

```

In the below demo, the button click will enable/disable the Grid and its actions.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disablegrid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disablegrid.cs" %}
{% include code-snippet/grid/how-to/disablegrid/disablegrid.cs %}
{% endhighlight %}
{% endtabs %}