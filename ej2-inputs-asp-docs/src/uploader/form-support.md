---
title: "Forms Support"
component: "Uploader"
description: "Explains how to integrate the file upload control in an HTML form (synchronous mode) and submit a form with selected files."
---

# Forms Support (Synchronous Upload)

The Uploader control works with HTML form like default file input. The following configuration is must to make the Uploader work inside the form.

    *   `saveUrl` and `removeUrl` must be null.
    *   `autoUpload` must be disabled.
    *   `name` attribute must be added in input element.

The selected or dropped files are received as a collection in form action when the form is submitted.
The form action handles the server-side operations that manage the file upload process.
When you reset the form, the file list and data will be cleared.

{% aspTab template="/uploader/form-support", sourceFiles="formsupport.cs,index.css" %}

{% endaspTab %}
