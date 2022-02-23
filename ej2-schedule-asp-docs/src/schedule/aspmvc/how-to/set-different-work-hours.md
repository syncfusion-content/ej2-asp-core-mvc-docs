# Set Different Working Hours on Different Days

By default, the work hours of the Scheduler is highlighted based on the start and end values provided within the `WorkHours` property which remains same for all days. To highlight different work hours range for different days,`setWorkHours` method. You can pass date object/ multiple date objects collection as first argument and start and end time need to be added as work hours should be passed as second and third arguments respectively. In the following code example, on button click 11:00 AM to 08:00 PM of 15th and 17th February has been added in work hours.

{% aspTab template="schedule/how-to/different-workhours", sourceFiles="data.cs"  %}

{% endaspTab %}