# Load limited data in member editor

In the filter dialog, you can set the limit to display the field values while loading large data. Based on this limit, the initial loading will complete quickly without any performance constraint. You can use the search option to refine the field values from the exceeded limit and refine the data further. A message with the remaining data count will be displayed in the member editor. The data limit can be set in the `maxNodeLimitInEditor` property.

By default, the property holds the value 1000.

> The property is available in both pivot table and Field List components.

In the below example, the data in the member editor limits to 100. So, the member editor of the field `ProductID` shows only its first 100 members from its 1000 members.

{% aspTab template="pivot-table/limit-data/limit-data", sourceFiles="LimitData.cs" %}

{% endaspTab %}
