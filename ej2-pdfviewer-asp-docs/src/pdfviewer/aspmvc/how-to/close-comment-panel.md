---
title: "Close the comment panel"
component: "PDF Viewer"
description: "Learn how to close the comment panel programmatically in PDF Viewer server library"
---

# Close the comment panel

The PDF Viewer server library allows you to close the comment panel programmatically using the external button event.

The following steps are used to close the comment panel programmatically in PDF Viewer,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Add the following code snippet to close the comment panel using button click event

```html

<button type="button" onclick="closeCommentPanel()">CloseCommentPanel</button>

<script>
        function closeCommentPanel() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.viewerBase.navigationPane.closeCommentPanelContainer();
        }

</script>

```

Download the sample [how to close comment panel](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVC_SAMPLE1299715828)