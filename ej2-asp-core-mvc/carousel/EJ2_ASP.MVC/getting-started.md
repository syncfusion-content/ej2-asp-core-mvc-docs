---
layout: post
title: Getting Started with ##Platform_Name## Carousel Control
description: Checkout and learn about getting started with ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

This section briefly explains about how to include a `Carousel` in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/visual-studio-2017) page for introduction part of the system requirements and configure the common specifications.

## Add carousel to the project

We are going to render `Carousel` component in **Index.cshtml** page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
    <div class="col-lg-12 control-section default-carousel-section">
        <div class="e-sample-resize-container carousel-sample">
            @(Html.EJS().Carousel("defaultCarousel").CssClass("default-carousel")
                .Items(new List<CarouselItem> {
                    new CarouselItem { Template = "#itemTemplate1"  },
                    new CarouselItem { Template = "#itemTemplate2"  },
                    new CarouselItem { Template = "#itemTemplate3"  },
                    new CarouselItem { Template = "#itemTemplate4"  },
                    new CarouselItem { Template = "#itemTemplate5"  }
                })
                .Render()
            )
        </div>
    </div>
    <script id="itemTemplate1" type="text/x-template">
        <figure class="img-container">
            <img src="@Url.Content("https://ej2.syncfusion.com/aspnetmvc/Content/carousel/images/bridge.jpg")" alt="bridge" style="height:100%; width: 100%;" />
            <figcaption class="img-caption">Golden Gate Bridge, San Francisco</figcaption>
        </figure>
    </script>
    <script id="itemTemplate2" type="text/x-template">
        <figure class="img-container">
            <img src="@Url.Content("https://ej2.syncfusion.com/aspnetmvc/Content/carousel/images/trees.jpg")" alt="spring_trees" style="height:100%; width: 100%;" />
            <figcaption class="img-caption">Spring Flower Trees</figcaption>
        </figure>
    </script>
    <script id="itemTemplate3" type="text/x-template">
        <figure class="img-container">
            <img src="@Url.Content("https://ej2.syncfusion.com/aspnetmvc/Content/carousel/images/waterfall.jpg")" alt="waterfall" style="height:100%; width: 100%;" />
            <figcaption class="img-caption">Oddadalen Waterfalls, Norway</figcaption>
        </figure>
    </script>
    <script id="itemTemplate4" type="text/x-template">
        <figure class="img-container">
            <img src="@Url.Content("https://ej2.syncfusion.com/aspnetmvc/Content/carousel/images/sea.jpg")" alt="sea" style="height:100%; width: 100%;" />
            <figcaption class="img-caption">Anse Source d'Argent, Seychelles</figcaption>
        </figure>
    </script>
    <script id="itemTemplate5" type="text/x-template">
        <figure class="img-container">
            <img src="@Url.Content("https://ej2.syncfusion.com/aspnetmvc/Content/carousel/images/rocks.jpeg")" alt="rocks" style="height:100%; width: 100%;" />
            <figcaption class="img-caption">Stonehenge, England</figcaption>
        </figure>
    </script>
}

<style>
    .default-carousel-section .carousel-sample {
        margin: 0 auto 2em;
        max-width: 500px;
        height: 300px;
    }

    .default-carousel .e-carousel-items .e-carousel-item .img-container {
        height: 100%;
    }

    .default-carousel .e-carousel-items .e-carousel-item .img-caption {
        bottom: 4em;
        color: #fff;
        font-size: 12pt;
        height: 2em;
        position: relative;
        padding: 0.3em 1em;
        text-align: center;
        width: 100%;
    }
</style>
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Carousel control will be rendered in the default web browser.

![ASP.NET MVC Carousel Control](images/carousel-control.png)
