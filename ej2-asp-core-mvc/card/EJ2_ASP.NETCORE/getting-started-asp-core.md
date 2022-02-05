---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started Asp Core of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started Asp Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

  This section briefly explains about how to include a simple Card in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/demo/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/demo/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![getting started](../../card/images/gettingstarted.PNG)

## See Also

* [How to add a header and content](./header-content/)