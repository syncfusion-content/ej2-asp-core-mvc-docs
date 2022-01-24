---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Check Image Size of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Check Image Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict the image uploading while uploading with large size

By using the Rich text editor's `ImageUploading` event, you can get the image size before uploading and restrict the image to upload, when the given image size is greater than the allowed size.

In the following, we have validated the image size before uploading and determined whether the image has been uploaded or not.

{% aspTab template="rich-text-editor/how-to/check-image-size", sourceFiles="controller.cs" %}

{% endaspTab %}