---
title: " Rich text editor restricts the image uploading while uploading with large size"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET MVC platform Rich Text Editor control explains about, how to restrict the image to upload, when the given image size is greater than the allowed size"
---

# Restrict the image uploading while uploading with large size

By using the Rich text editor's `ImageUploading` event, you can get the image size before uploading and restrict the image to upload, when the given image size is greater than the allowed size.

In the following, we have validated the image size before uploading and determined whether the image has been uploaded or not.

{% aspTab template="rich-text-editor/how-to/check-image-size", sourceFiles="controller.cs" %}

{% endaspTab %}