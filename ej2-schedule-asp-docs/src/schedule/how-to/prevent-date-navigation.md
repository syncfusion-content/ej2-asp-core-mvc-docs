# Prevent Date Navigation while Clicking on the Date Header

We can prevent navigation while clicking on the date header by simply removing `e-navigate` class from header cells which can be achieved in the `renderCell` event.

{% aspTab template="schedule/how-to/navigating", sourceFiles="data.cs"  %}

{% endaspTab %}