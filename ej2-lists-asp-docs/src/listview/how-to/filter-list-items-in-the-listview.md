# Filter List Items in the ListView

The filtered data can be displayed in the ListView component depending upon on user inputs using the
[`DataManager`](https://ej2.syncfusion.com/documentation/data/getting-started/). Refer to the
following steps to render the ListView with filtered data.

* Render a textbox to get input for filtering data.

* Render ListView with
[`dataSource`](https://ej2.syncfusion.com/documentation/api/list-view/#datasource), and set
the [`sortOrder`](https://ej2.syncfusion.com/documentation/api/list-view/#sortorder) property.

* Bind the `keyup` event for textbox to perform filtering operation. To filter list data, pass the list data source to the
`DataManager`, manipulate the data using the
[`executeLocal`](https://ej2.syncfusion.com/documentation/api/data/query/#executelocal) method,
and then update filtered data as ListView dataSource.

{% aspTab template="listview/filter", sourceFiles="list.cs" %}

{% endaspTab %}

> In this demo, data has been filtered with starting character of the list items. You can also filter list items with ending
character by passing the `endswith` in
[where](https://ej2.syncfusion.com/documentation/api/data/query/#where)
clause instead of `startswith`.