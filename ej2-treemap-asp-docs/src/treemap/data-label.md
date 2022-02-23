# Data Label

Data Labels are used to identify the name of items or groups in the TreeMap component. Data Labels will be shown by specifying the data source properties in the `labelPath` of the `leafItemSettings`.

## Format

Customize the labels for each item using the `labelFormat` property in the `leafItemSettings`.

{% aspTab template="treemap/datalabel/format", sourceFiles="format.cs" %}

{% endaspTab %}

![TreeMap with data label format](images/datalabel/Format.png)

## Template

The template supports customizing labels of each leaf node using the `labelTemplate` property. It uses Essential JS2 template engine to render elements and the position of templates can be customize using the `templatePosition` property.

{% aspTab template="treemap/datalabel/template", sourceFiles="template.cs" %}

{% endaspTab %}

![TreeMap label with template](images/datalabel/template.png)

## InterSectAction

When the label size in each item exceeds the actual size, use the `interSectAction` property in the `leafItemSettings` to customise the labels.

{% aspTab template="treemap/datalabel/intersectaction", sourceFiles="intersectaction.cs" %}

{% endaspTab %}

![TreeMap label with intersect options](images/datalabel/IntersectAction.png)