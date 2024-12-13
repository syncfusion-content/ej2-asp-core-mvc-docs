---
layout: post
title: Prevent Content Swipe Selection in Syncfusion ##Platform_Name## Tab Component
description: Learn here all about Prevent Content Swipe Selection in Syncfusion ##Platform_Name## Tab component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Prevent Content Swipe Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent content swipe selection


{% if page.publishingplatform == "aspnet-core" %}

The [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode)  property in the Tab component allows users to navigate between tabs using swipe gestures, improving the overall navigation experience. It supports both touch and mouse inputs, enabling intuitive tab switching.

However, in certain cases, such as when a tab contains critical elements like a form, accidental swipes can disrupt the user's workflow. For example, if a user is filling out a form and mistakenly swipes, the tab might change unexpectedly, potentially leading to unsaved data or interruptions.

To address this, you can customize the [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) property based on the needs of the application. By adjusting this setting, you can balance smooth, intuitive navigation with protecting the user experience and safeguarding against accidental tab switches.

The following are the available [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) options for the Tab component:

* Both - By default, this option allows the user to swipe between tabs using both touch and mouse actions.
* Touch - This option allows users to swipe between tabs using touch gestures only.
* Mouse - This option allows users to swipe between tabs using mouse gestures only.
* None - This disables both touch and mouse swipe actions, preventing any unintended tab switches.


{% elsif page.publishingplatform == "aspnet-mvc" %}

The [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode)  property in the Tab component allows users to navigate between tabs using swipe gestures, improving the overall navigation experience. It supports both touch and mouse inputs, enabling intuitive tab switching.

However, in certain cases, such as when a tab contains critical elements like a form, accidental swipes can disrupt the user's workflow. For example, if a user is filling out a form and mistakenly swipes, the tab might change unexpectedly, potentially leading to unsaved data or interruptions.

To address this, you can customize the [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) property based on the needs of the application. By adjusting this setting, you can balance smooth, intuitive navigation with protecting the user experience and safeguarding against accidental tab switches.

The following are the available [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) options for the Tab component:

* Both - By default, this option allows the user to swipe between tabs using both touch and mouse actions.
* Touch - This option allows users to swipe between tabs using touch gestures only.
* Mouse - This option allows users to swipe between tabs using mouse gestures only.
* None - This disables both touch and mouse swipe actions, preventing any unintended tab switches.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/swipe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Swipe.cs" %}
{% include code-snippet/tab/swipe/swipe.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/swipe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Swipe.cs" %}
{% include code-snippet/tab/swipe/swipe.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

