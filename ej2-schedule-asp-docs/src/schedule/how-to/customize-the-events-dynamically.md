# Customize the Events Dynamically Before it Renders on UI

The `eventRendered` event will be triggered before rendering the appointments on Schedule where it can be customized. In the below demo, custom field **CategoryColor** is added to the appointment collection and based on certain condition, appointment background color is changed with **CategoryColor** field value.

{% aspTab template="schedule/how-to/dynamic-appointments", sourceFiles="data.cs"  %}

{% endaspTab %}