# Add and Remove List Items from the ListView

You can add or remove list items from the ListView component using the
[`addItem`](https://ej2.syncfusion.com/documentation/api/list-view/#additem) and
[`removeItem`](https://ej2.syncfusion.com/documentation/api/list-view/#removeitem) methods.
Refer to the following steps to add or remove a list item.

* Render the ListView with data source, and use the
[template](https://ej2.syncfusion.com/documentation/api/list-view/#template) property to append the delete icon
for each list item. Also, bind the click event for the delete icon using the
[actionComplete](https://ej2.syncfusion.com/documentation/api/list-view/#actioncomplete) handler.

* Render the Add Item button, and bind the click event. On the click event handler, pass data with random id to
the [`addItem`](https://ej2.syncfusion.com/documentation/api/list-view/#additem) method to add a
new list item on clicking the Add Item button.

* Bind the click handler to the delete icon created in step 1. Within the click event, remove the list item by passing the
delete icon list item to
[`removeItem`](https://ej2.syncfusion.com/documentation/api/list-view/#removeitem) method.

{% aspTab template="listview/add-item", sourceFiles="list.cs" %}

{% endaspTab %}