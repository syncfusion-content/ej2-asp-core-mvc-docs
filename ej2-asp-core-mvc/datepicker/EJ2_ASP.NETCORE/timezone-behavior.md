---
layout: post
title: Timezone Behavior in ##Platform_Name## Datepicker | Syncfusion
description: Learn here all about Timezone Behavior in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Timezone Behavior
publishingplatform: ##Platform_Name##
documentation: ug
---

# Timezone Behavior in DatePicker Control

The DatePicker component displays and maintains the selected date value based on the client system’s current time zone. When a user selects a value, it is stored and rendered using the local time zone of the system at the time of selection. This ensures that the value remains consistent and predictable during user interaction.

N> if the system time zone is changed dynamically after a value is selected, the DatePicker will **not update or shift** the selected value. The component preserves the original selection, ensuring a stable and reliable user experience.

## `serverTimezoneOffset`

The `serverTimezoneOffset` property allows you to specify the server's time zone offset from UTC in **hours** or **fractional hours**. This is useful when binding values from the server to ensure they are interpreted correctly on the client side.

- The value should be a number representing the offset from UTC.
- Examples:
  - `-5` → UTC-5 (Eastern Standard Time)
  - `-4.5` → UTC-4:30 (Afghanistan Time)
  - `5.5` → UTC+5:30 (India Standard Time)

N> The `serverTimezoneOffset` property is applicable **only for pre-bound values** (i.e., values set during initialization or data binding). It does **not affect** values selected by the user during runtime.

{% if page.publishingplatform == "aspnet-core" %}
 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/timezone-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="timezone.cs" %}
{% endhighlight %}{% endtabs %}
 
{% elsif page.publishingplatform == "aspnet-mvc" %}
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/timezone-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="timezone.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
