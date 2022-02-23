# Data Binding

The TreeMap control supports data binding using the dataSource property.

## Populate data

The `dataSource` property accepts collection values as input. For example, a list of objects can be provided as input. Data can be given as either flat or hierarchical collection to the `dataSource` property.

<!-- markdownlint-disable MD036 -->

### Flat collection

The following code shows, how to bind a flat collection as data source to the TreeMap control.

{% aspTab template="treemap/databind/flat", sourceFiles="flat.cs" %}

{% endaspTab %}

![TreeMap with flat data](./images/Databinding/flatcollection.png)

### Hierarchical collection

The following code shows, how to bind a hierarchical collection as data source to the TreeMap control.

<!-- markdownlint-disable MD010 -->

{% aspTab template="treemap/databind/hierachical", sourceFiles="hierachical.cs" %}

{% endaspTab %}

![TreeMap with hierarchical data](./images/Databinding/Hierarchical.png)