---
title: "Setting maximum height to the Dialog | Syncfusion"
component: "Dialog"
description: "This section explains how to set maximum height to the Dialog in ASP.NET Core Dialog"
---

# Setting maximum height to the Dialog

By default, the maxHeight for the Dialog is calculated based on the target. If the target is not specified externally, the Dialog consider the body as target and will calculate the maxHeight based on it. We have an option to set the maxHeight of the Dialog in the [beforeOpen](../../api/dialog/#beforeOpen) event.

{% aspTab template="dialog/how-to/max-height", sourceFiles="controller.cs" %}

{% endaspTab %}
