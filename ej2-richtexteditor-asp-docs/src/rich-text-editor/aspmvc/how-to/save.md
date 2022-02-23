---
title: "Rich Text Editor How To save content in server"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains on how to save content in server."
---

# Save Rich Text Editor content in a file in the server

Rich Text Editor content can be passed from view to controller through `XMLHttpRequest` post. Content
will be sent to the corresponding method into the controller and this value can be saved in a text
file or any other format using `streamWriter`. Refer to the following given code.

{% aspTab template="rich-text-editor/how-to/savefile", sourceFiles="savefile.cs" %}

{% endaspTab %}