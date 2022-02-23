# Dynamically Add, Edit and Remove Events

CRUD actions can be manually performed on appointments using `addEvent`, `saveEvent` and `deleteEvent` methods as shown below.

## Normal event

{% aspTab template="schedule/how-to/dynamic-appointments", sourceFiles="data.cs"  %}

{% endaspTab %}

## Recurrence event

{% aspTab template="schedule/how-to/dynamic-recurrence-appointments", sourceFiles="data.cs"  %}

{% endaspTab %}

> When a single occurrence of the recurrence appointment is edited, `recurrenceID` field will be added which holds the `id` value of its parent recurrence appointment. It is applicable only for the edited occurrence appointments. Therefore the collection passing to the `saveEvent` with action as **EditOccurrence** should have `RecurrenceID` field as shown above.