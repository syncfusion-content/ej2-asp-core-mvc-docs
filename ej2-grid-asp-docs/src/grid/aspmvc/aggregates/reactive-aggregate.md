# Reactive Aggregate

## Auto update aggregate value in batch editing

When using batch editing, the aggregate values will be refreshed on every cell save. The footer, group footer, and group caption aggregate values will be refreshed.

> Adding a new record to the grouped grid will not refresh the aggregate values.

{% aspTab template="grid/aggregate/reactive-agg-batch-edit", sourceFiles="reactive-agg-batch-edit.cs" %}

{% endaspTab %}

## Refresh aggregate values in inline editing

By default, reactive aggregate update is not supported by inline and dialog edit modes as it is not feasible to anticipate the value change event for every editor. But, you can refresh the aggregates manually in the inline edit mode using the refresh method of aggregate module.

In the following code, the input event for the Freight column editor has been registered and the aggregate value has been refreshed manually.

{% aspTab template="grid/aggregate/reactive-agg-inline-edit", sourceFiles="reactive-agg-inline-edit.cs" %}

{% endaspTab %}