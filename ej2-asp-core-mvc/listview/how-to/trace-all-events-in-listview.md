---
layout: post
title: Trace All Events In Listview in ##Platform_Name## Listview Component
description: Learn here all about Trace All Events In Listview in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Trace All Events In Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Trace all events in ListView

The ListView component triggers events based on its actions. The events can be used as extension points to perform
custom operations. Refer to the following steps to trace the ListView events:

1. Render the ListView with
[dataSource](https://ej2.syncfusion.com/documentation/api/list-view/#datasource), and
bind the [`actionBegin`](https://ej2.syncfusion.com/documentation/api/list-view/#actionbegin),
[`actionComplete`](https://ej2.syncfusion.com/documentation/api/list-view/#actioncomplete),
and [`select`](https://ej2.syncfusion.com/documentation/api/list-view/#select) events.

2. Perform custom operations in actionBegin, actionComplete, and select events.

3. Provide event log details for actionBegin and actionComplete events, and they will be displayed in the event trace panel
when the ListView action starts and the dataSource bound successfully.

4. Get the selected item details from the
[`SelectEventArgs`](https://ej2.syncfusion.com/documentation/api/list-view/selectEventArgs/) in the
select event, and display the selected list item text in the event trace panel while selecting list items.

5. Use clear button to remove event trace information.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/events/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/events/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

