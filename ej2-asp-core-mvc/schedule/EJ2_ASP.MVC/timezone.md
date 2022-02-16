---
layout: post
title: Timezone in ##Platform_Name## Schedule Component
description: Learn here all about Timezone in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Timezone
publishingplatform: ##Platform_Name##
documentation: ug
---


# Timezone

The Scheduler makes use of the current system time zone by default. If it needs to follow some other user-specific time zone, then the `Timezone` property needs to be used. Apart from the default action of applying specific timezone to the Scheduler, it is also possible to set different time zone values for each appointments through the properties `StartTimezone` and `EndTimezone` which can be defined as separate fields within the event fields collection.

## Understanding date manipulation in JavaScript

The `new Date()` in JavaScript returns the exact current date object with complete time and timezone information. For example, it may return value such as `Wed Dec 12 2018 05:23:27 GMT+0530 (India Standard Time)` which indicates that the current date is December 12, 2018 and the current time is 5.23 AM on browsers following the IST timezone.

## Scheduler with no timezone

When no specific time zone is set to Scheduler, appointments will be displayed based on the client system's timezone which is the default behavior. Here, the same appointment when viewed from different timezone will have different start and end times.

The following code example displays an appointment from 9.00 AM to 10.00 AM when you open the Scheduler from any of the timezone. This is because, we are providing the start and end time enclosing with `new Date()` which works based on the client browser's timezone.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/no-timezone/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/no-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/no-timezone/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/no-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Scheduler set to specific timezone

When a time zone is set to Scheduler through `Timezone` property, the appointments will be displayed exactly based on the Scheduler timezone regardless of its client timezone. In the following code example, appointments will be displayed based on Eastern Time (UTC -05:00).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/schedule-timezone/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/schedule-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/schedule-timezone/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/schedule-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Display events on same time everywhere with no time difference

Setting `Timezone` to UTC for Scheduler will display the appointments on same time as in the database for all the users in different time zone.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/sametime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/sametime/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/sametime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/sametime/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Set specific timezone for events

It is possible to set different timezone for Scheduler events by setting `StartTimezone` and `EndTimezone` properties within the `EventSettings` option. It allows each appointment to maintain different timezone and displays on Scheduler with appropriate time differences.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/specific-timezone/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/specific-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/specific-timezone/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/specific-timezone/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add or remove timezone names to/from the timezone collection

Instead of displaying all the timezone names within the timezone collection (more than 200 are displayed on the editor window timezone fields by default), you can customize the timezone collection at application end as shown in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/timezone-collection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/timezone-collection/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/timezone/timezone-collection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/timezone/timezone-collection/data.cs %}
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
| `Date` | Date | UTC time as date object.|
| `fromOffset` | number/string | Timezone from which date need to be converted.|
| `toOffset` | number/string | Timezone to which date need to be converted.|

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

### add

This method is used to add the time difference between passed UTC date and timezone.

| Parameters | Type | Description |
|------------|------|-------------|
| Date | Date | UTC time as date object.|
| Timezone | String | Timezone.|

Returns `Date`

```sh
    // Assume your local timezone as IST/UTC+05:30
    var timezone = new ej.schedule.Timezone();
    var date = new Date(2018,11,5,15,25,11);
    var convertedDate = timezone.add(date, "Europe/Paris");
    console.log(convertedDate); //2018-12-05T05:25:11.000Z
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

### removeLocalOffset

This method is used to remove the local offset time from the date passed.

| Parameters | Type | Description |
|------------|------|-------------|
| Date | Date | UTC as date object.|

Returns `Date`

```sh
    // Assume your local timezone as IST/UTC+05:30
    var timezone = new ej.schedule.Timezone();
    var date = new Date(2018,11,5,15,25,11);
    var convertedDate = timezone.removeLocalOffset(date);
    console.log(convertedDate); //2018-12-05T15:25:11.000Z
```

> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.
