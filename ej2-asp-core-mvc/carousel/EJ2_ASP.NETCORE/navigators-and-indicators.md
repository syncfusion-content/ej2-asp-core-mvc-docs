---
layout: post
title: Navigations and Indicators in ##Platform_Name## Carousel Control
description: Checkout and learn about Navigations and Indicators in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Navigations and Indicators
publishingplatform: ##Platform_Name##
documentation: ug
---

# Navigators and Indicators

The navigators and indicators are used to transition the slides manually.

## Navigators

### Show or hide previous and next button

In navigators, the previous and next slide transition buttons are used to perform slide transitions manually. We had provided options to show/hide the navigators using the `buttonsVisibility` property. The possible property values are as follows:

    1. Hidden – the navigator’s buttons are not visible.
    2. Visible – the navigator’s buttons are visible.
    3. VisibleOnHover – the navigator’s buttons are visible only when hovering over the carousel.

The following example depicts the code to show/hide the navigators in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/visible/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Show previous and next button on hover

In the carousel, we can able to show the previous and next buttons only on mouse hover using the `buttonsVisibility` property. The following example depicts the code to show the navigators on mouse hover in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/visible-hover/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/visible-hover/select-item-method.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/visible-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/visible-hover/visible-hover.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Previous and next button Template

We had provided template options to customize the previous button using `previousButtonTemplate` and the next button using `nextButtonTemplate`. The following example depicts the code for applying the template to previous and next buttons in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/button-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/button-template/button-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/button-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/button-template/button-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Indicators

### Show or hide indicators

In indicators, the total slides and current slide state has been depicted. We had provided options to show/hide the indicators using the `showIndicators` property. The following example depicts the code to show/hide the indicators in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/show-indicators/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/show-indicators/show-indicators.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/show-indicators/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/show-indicators/show-indicators.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Indicators Template

We had provided template options to customize the indicators by using the `indicatorTemplate` property. The following example depicts the code for applying a template to indicators in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-template/indicator-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-template/indicator-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Showing preview of slide in indicator

We can able to customize the indicators by showing the preview image of each slide using the `indicatorTemplate` property. The following example depicts the code for showing the preview image using a template for indicators in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-preview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-preview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-preview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-preview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Play button

### Show or hide the play button

In the carousel, `autoplay` actions have been controlled by using the `showPlayButton` property in the user interface. When we enable this property, the slide transitions have been controlled using this play and pause button. This property depends on the `buttonVisibility` property. The following example depicts the code to show the play button in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button/play-button.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button/play-button.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Play button template

We had provided template options to customize the play button by using the `playButtonTemplate` property. The following example depicts the code for applying a template to play Button in the carousel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button-template/play-button-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button-template/play-button-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}