# Render ListView with hyper-link navigation

We can use `anchor` tag along with `href` attribute in our ListView [`template`](https://ej2.syncfusion.com/documentation/api/list-view/#template) property for navigation.

```typescript

var anchor_template = "<a target='_blank' href='${url}'>${name}</a>";

```

In the below sample, we have rendered `ListView` with search engines URL.

{% aspTab template="listview/navigation", sourceFiles="list.cs" %}

{% endaspTab %}