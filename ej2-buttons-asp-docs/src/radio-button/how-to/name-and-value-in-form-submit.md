---
title: "Name and Value in form submit"
component: "RadioButton"
description: "RadioButton how to section, name and value in form submit, customize RadioButton appearance."
---

# Name and Value in form submit

The name attribute of the RadioButton is used to group RadioButton. When the RadioButton are grouped in form, the checked items value attribute
will be post to server on form submit that can be retrieved through the name. The disabled RadioButton
value will not be sent to the server on form submit.

In the following code snippet, Credit and Debit card is in checked state.
Now, the value that is in checked state will be sent on form submit.

{% aspTab template="radio-button/howto/form", sourceFiles="form.cs" %}

{% endaspTab %}