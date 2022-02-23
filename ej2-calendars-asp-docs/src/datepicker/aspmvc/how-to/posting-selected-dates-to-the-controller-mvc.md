---
title: "How To"
component: "DatePicker"
description: "Miscellaneous aspects of customizing the date picker"
---

# Posting the selected dates to the controller

Post back is the action of posting the data back to the submitting page. In the following example, value
for the DatePicker from the `change` event is sent through `Ajax` post to the controller.

In this example, the content type is "application/json" and the request body is a JSON object. In the
action method, you can pass a model as the parameter. The `POST` method determines how data is sent from
the client via the form, to the server.

{% aspTab template="datepicker/how-to/postback-selected-dates", sourceFiles="postback-selected-dates-mvc.cs" %}

{% endaspTab %}