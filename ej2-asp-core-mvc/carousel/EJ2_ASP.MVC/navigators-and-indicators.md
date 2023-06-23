---
layout: post
title: Navigations and Indicators in Syncfusion ##Platform_Name## Carousel Control
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

In navigators, the previous and next slide transition buttons are used to perform slide transitions manually. You can show/hide the navigators using the [ButtonsVisibility](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ButtonsVisibility) property. The possible property values are as follows:

* `Hidden` – the navigator’s buttons are not visible.
* `Visible` – the navigator’s buttons are visible.
* `VisibleOnHover` – the navigator’s buttons are visible only when hovering over the carousel.

The following example depicts the code to hide the navigators in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/hidden/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/hidden/hidden.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel hidden navigators](images/navigators_hidden.png)

### Show previous and next button on hover

In the carousel, you can show the previous and next buttons only on mouse hover using the [ButtonsVisibility](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ButtonsVisibility) property. The following example depicts the code to show the navigators on mouse hover in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/visible-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/visible-hover/visible-hover.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel visible on hover navigators](images/navigators_onhover.gif)

### Previous and next button template

Template options are provided to customize the previous button using [PreviousButtonTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_PreviousButtonTemplate) and the next button using [NextButtonTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_NextButtonTemplate). The following example depicts the code for applying the template to previous and next buttons in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/button-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/button-template/button-template.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel navigators template](images/navigators_template.png)

## Indicators

### Show or hide indicators

In indicators, the total slides and current slide state have been depicted. You can show/hide the indicators using the [ShowIndicators](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ShowIndicators) property. The following example depicts the code to hide the indicators in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/show-indicators/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/show-indicators/show-indicators.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel hidden indicators](images/hidden_indicators.png)

### Indicators template

Template option is provided to customize the indicators by using the [IndicatorsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsTemplate) property. The following example depicts the code for applying a template to indicators in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-template/indicator-template.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators template](images/indicators_template.png)

### Showing preview of slide in indicator

You can customize the indicators by showing the preview image of each slide using the [IndicatorsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsTemplate) property. The following example depicts the code for showing the preview image using a template for indicators in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-preview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-preview.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators template preview](images/indicators_preview.png)

### Indicator Types

Choose different types of indicators available using the [`indicatorsType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsType) property. The indicator types are categorized as follows:

* [Default Indicator](#default-indicator-type)
* [Dynamic Indicator](#dynamic-indicator-type)
* [Fraction Indicator](#fraction-indicator-type)
* [Progress Indicator](#progress-indicator-type)

#### Default Indicator Type

A default indicator in a carousel is a set of dots that indicate the current position of the slide in the carousel. The Default indicator can be achieved by setting the [`indicatorsType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsType) to `Default`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-default.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators type default preview](images/indicator-type-default.gif)
#### Dynamic Indicator Type

A dynamic indicator in a carousel provides visual cues or markers that dynamically change or update to indicate the current position. The Dynamic indicator can be achieved by setting the [`indicatorsType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsType) to `Dynamic`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-type-dynamic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-dynamic.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators type dynamic preview](images/indicator-type-dynamic.gif)

#### Fraction Indicator Type

The fraction indicator type displays the current slide index and total slide count as a fraction. The Fraction indicator can be achieved by setting the [`indicatorsType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsType) to `Fraction`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-type-fraction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-fraction.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators type fraction preview](images/indicator-type-fraction.gif)

#### Progress Indicator Type

The Progress Indicator type displays the current slide as a progress bar. The Progress indicator can be achieved by setting the [`indicatorsType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_IndicatorsType) to `Progress`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/indicator-type-progress/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/indicator-preview/indicator-progress.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel indicators type progress preview](images/indicator-type-progress.gif)


## Play button

### Show or hide the play button

In the carousel, [AutoPlay](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_AutoPlay) actions have been controlled by using the [ShowPlayButton](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ShowPlayButton) property in the user interface. When you enable this property, the slide transitions are controlled using this play and pause button. This property depends on the [ButtonsVisibility](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_ButtonsVisibility) property. The following example depicts the code to show the play button in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button/play-button.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel play button](images/play_button.png)

### Play button template

Template option is provided to customize the play button by using the [PlayButtonTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_PlayButtonTemplate) property. The following example depicts the code for applying a template to play Button in the carousel.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/navigators/play-button-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/navigators/play-button-template/play-button-template.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel play button template](images/play_button_template.png)