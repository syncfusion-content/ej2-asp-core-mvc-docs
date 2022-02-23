# Prioritize the Resource Color for Events

By default top level resource color will be applied for the events. If user wants to apply specific resource color to events irrespective of its parent resource color, it can be achieved by `resourceColorField` field within `eventSettings` property as shown below.

{% aspTab template="schedule/how-to/resource-color", sourceFiles="data.cs"  %}

{% endaspTab %}

> The `resourceColorField` field value should be as same as the `name` field value given with in `resources` property.