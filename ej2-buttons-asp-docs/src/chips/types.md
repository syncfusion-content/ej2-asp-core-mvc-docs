# Types

The ChipList control has the following types.

* Input Chip
* Choice Chip
* Filter Chip
* Action Chip

## Input Chip

Input Chip holds information in compact form. It converts user input into chips.

{% aspTab template="chips/input", sourceFiles="default.cs" %}

{% endaspTab %}

## Choice Chip

Choice Chip allows you to select a single chip from the set of ChipList/ChipCollection. It can be enabled by setting the `selection` property to `Single`.

{% aspTab template="chips/choice", sourceFiles="default.cs" %}

{% endaspTab %}

## Filter Chip

Filter Chip allows you to select a multiple chip from the set of ChipList/ChipCollection. It can be enabled by setting the `selection` property to `Multiple`.

{% aspTab template="chips/filter", sourceFiles="default.cs" %}

{% endaspTab %}

## Action Chip

The Action Chip triggers the event like click or delete, which helps doing action based on the event.

{% aspTab template="chips/action", sourceFiles="default.cs" %}

{% endaspTab %}

### Deletable Chip

Deletable Chip allows you to delete a chip from ChipList/ChipCollection. It can be enabled by setting the `enableDelete` property to `true`.

{% aspTab template="chips/delete", sourceFiles="default.cs" %}

{% endaspTab %}