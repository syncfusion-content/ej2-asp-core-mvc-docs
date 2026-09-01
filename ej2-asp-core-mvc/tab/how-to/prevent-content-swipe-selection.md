---
layout: post
title: Prevent Content Swipe Selection in ##Platform_Name## Tabs | Syncfusion
description: Prevent accidental Tab changes in Syncfusion ##Platform_Name## Tabs by configuring the `swipeMode` property to disable touch or mouse swipe navigation.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to prevent content swipe selection in ##Platform_Name## Tabs

{% if page.publishingplatform == "aspnet-core" %}

The [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode)  property in the Tabs control allows users to navigate between tabs using swipe gestures, improving the overall navigation experience. It supports both touch and mouse inputs, enabling intuitive Tab switching.

However, in certain cases, such as when a Tab contains critical elements like a form, accidental swipes can disrupt the user's workflow. For example, if a user is filling out a form and mistakenly swipes, the Tab might change unexpectedly, potentially leading to unsaved data or interruptions.

To address this, you can customize the [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) property based on the needs of the application. By adjusting this setting, you can balance smooth, intuitive navigation with protecting the user experience and safeguarding against accidental Tab switches.

The following are the available [swipeMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) options for the Tabs control:

* [Both](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Both) - By default, this option allows the user to swipe between tabs using both touch and mouse actions.
* [Touch](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Touch) - This option allows users to swipe between tabs using touch gestures only.
* [Mouse](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Mouse) - This option allows users to swipe between tabs using mouse gestures only.
* [None](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_None) - This disables both touch and mouse swipe actions, preventing any unintended Tab switches.


{% elsif page.publishingplatform == "aspnet-mvc" %}

The [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode)  property in the Tabs control allows users to navigate between tabs using swipe gestures, improving the overall navigation experience. It supports both touch and mouse inputs, enabling intuitive Tab switching.

However, in certain cases, such as when a Tab contains critical elements like a form, accidental swipes can disrupt the user's workflow. For example, if a user is filling out a form and mistakenly swipes, the Tab might change unexpectedly, potentially leading to unsaved data or interruptions.

To address this, you can customize the [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) property based on the needs of the application. By adjusting this setting, you can balance smooth, intuitive navigation with protecting the user experience and safeguarding against accidental Tab switches.

The following are the available [swipeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_SwipeMode) options for the Tabs control:

* [Both](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Both) - By default, this option allows the user to swipe between tabs using both touch and mouse actions.
* [Touch](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Touch) - This option allows users to swipe between tabs using touch gestures only.
* [Mouse](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_Mouse) - This option allows users to swipe between tabs using mouse gestures only.
* [None](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabSwipeMode.html#Syncfusion_EJ2_Navigations_TabSwipeMode_None) - This disables both touch and mouse swipe actions, preventing any unintended Tab switches.

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

