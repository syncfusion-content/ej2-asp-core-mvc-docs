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