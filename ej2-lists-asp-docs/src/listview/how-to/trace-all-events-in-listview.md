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

{% aspTab template="listview/events", sourceFiles="list.cs" %}

{% endaspTab %}