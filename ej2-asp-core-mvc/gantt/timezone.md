---
layout: post
title: Timezone in ##Platform_Name## Gantt Component
description: Learn here all about Timezone in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Timezone
publishingplatform: ##Platform_Name##
documentation: ug
---


# Timezone

The Gantt makes use of the current system time zone by default. If it needs to follow some other user-specific time zone, then the `timezone` property needs to be used.

## Understanding date manipulation in JavaScript

The `new Date()` in JavaScript returns the exact current date object with complete time and timezone information. For example, it may return value such as `Wed Dec 12 2018 05:23:27 GMT+0530 (India Standard Time)` which indicates that the current date is December 12, 2018 and the current time is 5.23 AM on browsers following the IST timezone.

## Display same time everywhere with no time difference

Setting `timezone` to UTC for Gantt will display the same time as in the database for all the users in different time zone.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timezone/same-time/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Same-time.cs" %}
{% include code-snippet/gantt/timezone/same-time/same-time.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timezone/same-time/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Same-time.cs" %}
{% include code-snippet/gantt/timezone/same-time/same-time.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## CRUD operations with timezone

CRUD operations can be performed with timezone, and the gantt is rendered based on the timezone specified in the load time. All the editing actions will be done based on the user timezone, but on database save action, we have reversed this conversion to local time and provided data to client side events for better understanding purpose. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/timezone/timezone-CRUD/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timezone-CRUD.cs" %}
{% include code-snippet/gantt/timezone/timezone-CRUD/timezone-CRUD.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/timezone/timezone-CRUD/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timezone-CRUD.cs" %}
{% include code-snippet/gantt/timezone/timezone-CRUD/timezone-CRUD.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Timezone methods

### offset

This method is used to calculate the difference between passed UTC date and timezone.

| Parameters | Type | Description |
|------------|------|-------------|
| Date | Date | UTC time as date object.|
| Timezone | String | Timezone.|

Returns `number`

```sh
    // Assume your local timezone as IST/UTC+05:30
    var timezone = new ej.schedule.Timezone();
    var date = new Date(2018,11,5,15,25,11);
    var timeZoneOffset = timezone.offset(date,"Europe/Paris");
    console.log(timeZoneOffset); //-60
```

### convert

This method is used to convert the passed date from one timezone to another timezone.

| Parameters | Type | Description |
|------------|------|-------------|
| Date | Date | UTC time as date object.|
| fromOffset | number/string | Timezone from which date need to be converted.|
| toOffset | number/string | Timezone to which date need to be converted.|

Returns `Date`

```sh
    // Assume your local timezone as IST/UTC+05:30
    var timezone = new ej.schedule.Timezone();
    var date = new Date(2018,11,5,15,25,11);
    var convertedDate = timezone.convert(date, "Europe/Paris", "Asia/Tokyo");
    var convertedDate1 = timezone.convert(date, 60, -360);
    console.log(convertedDate); //2018-12-05T17:55:11.000Z
    console.log(convertedDate1); //2018-12-05T16:55:11.000Z
```

### remove

This method is used to remove the time difference between passed UTC date and timezone.

| Parameters | Type | Description |
|------------|------|-------------|
| Date | Date | UTC as date object.|
| Timezone | String | Timezone.|

Returns `Date`

```sh
    // Assume your local timezone as IST/UTC+05:30
    var timezone = new ej.schedule.Timezone();
    var date = new Date(2018,11,5,15,25,11);
    var convertedDate = timezone.remove(date, "Europe/Paris");
    console.log(convertedDate); //2018-12-05T14:25:11.000Z
```