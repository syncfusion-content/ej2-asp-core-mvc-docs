# Leaf Item

A leaf item defines a visualized data element and does not contain child nodes but contains parent node if the levels are specified in the TreeMap.

## Leaf label

Label is represented by item name or value. Label will be appeared by specifying the `labelPath` property and customize the label style using the `labelStyle` property.

{% aspTab template="treemap/leafitem/leaflabel", sourceFiles="leaflabel.cs" %}

{% endaspTab %}

![TreeMap with leaf item](images/LeafItem/LeafLabel.png)

<!-- markdownlint-disable MD036 -->

### Label position and format

Positioning the leaf item label using the `labelPosition` property and the text format can be customized by specifying data source properties name in the `labelFormat` property.

{% aspTab template="treemap/leafitem/format", sourceFiles="format.cs" %}

{% endaspTab %}

![TreeMap with label position and format](images/LeafItem/LabelFormat.png)

<!-- markdownlint-disable MD036 -->

### Label template and position

Specifies the template of leaf item label and position of the template to be customized using `labelTemplate` and `templatePosition` properties.

{% aspTab template="treemap/leafitem/template", sourceFiles="template.cs" %}

{% endaspTab %}

![TreeMap with leaf item template](images/LeafItem/TemplatePosition.png)

<!-- markdownlint-disable MD036 -->

## Item gap

The `gap` property is used to separate an item from another item. Each item rectangle is split into equal space with specified gap.

{% aspTab template="treemap/leafitem/gap", sourceFiles="gap.cs" %}

{% endaspTab %}

![Gap in TreeMap item](images/LeafItem/itemgap.png)