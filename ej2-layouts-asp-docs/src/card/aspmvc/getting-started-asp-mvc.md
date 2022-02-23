---
title: "Getting Started"
component: "Card"
description: "This section explains how to create a Card component in the ASP.NET MVC application with its basic features."
---

# Getting Started

  This section briefly explains about how to include a simple Card in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Adding a simple Card

* Add the HTML `div` element with `e-card` class into your sample file.

```html
    <div class = "e-card">
        Sample Card
    </div>
```

## Adding a header and content

You can create Card with a header in a specific structure. For adding header you need to create a `div` element with `e-card-header` class added.

* You can include heading inside the Card header by adding a `div` element with `e-card-header-caption` class, and also content will be added by adding element with `e-card-content`. For detailed information, refer to the [Header and Content](./header-content/).

```html
    <div class = "e-card">                    --> Root Element
        <div class="e-card-header">           --> Root Header Element
            <div class="e-card-header-caption">    --> Root Heading Element
                <div class="e-card-header-title"></div>   --> Heading Title Element
            </div>
            <div class="e-card-content"></div>         --> Card content Element
        </div>
    </div>
```

{% aspTab template="card/demo", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![getting started](../../card/images/gettingstarted.PNG)

## See Also

* [How to add a header and content](./header-content/)