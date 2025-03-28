---
layout: post
title: Disable ContentControl ##Platform_Name## DocumentEditor |Syncfusion
description: Learn here all about disable Content Control in Syncfusion ##Platform_Name## Document Editor component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Disable Content Control in document editor 
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable Content Control in ##Platform_Name## Document editor control

Document Editor content control can be disable using the ContentControlInfo properties If you want the content control can not be editable.

The following example illustrates to disable the content control after inserting the content control in DocumentEditorContainer.


Content control properties can be set using the **`ContentControlInfo`**

{% highlight ts %}
container.documentEditor.editor.insertContentControl('RichText','{{product_code}}');
var contentControlInfo = container.documentEditor.selection.getContentControlInfo();
//Specifies whether the content control can be Edited.
contentControlInfo.canEdit = true;
//Specifies whether the content control can be Deleted.
contentControlInfo.canDelete = true;
container.documentEditor.editor.setContentControlInfo(contentControlInfo);
{% endhighlight %}

