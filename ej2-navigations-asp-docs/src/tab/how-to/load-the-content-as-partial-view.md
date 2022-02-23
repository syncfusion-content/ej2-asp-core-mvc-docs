---
title: "Load the content as partial view to Tab"
component: "Tab"
description: "This example demonstrates how to load the content as partial view to Essential JS 2 Tab component."
---

# Load the content as partial view to Tab

Since Tab is a Navigation control, it doesn't have support to load any content directly or using any DataAdaptor. But it is provided with the items support. So to load the content as partial view, you would need to make use of the AJAX or EJ2 Datamanager as described in our [How-To](./load-tab-with-data-source) section help document.

In the below demo, we have explained on how to create the Tab items dynamically and then to load the other Syncfusion controls in it from partial views.

{% aspTab template="tab/partial-view", sourceFiles="partialview.cs" %}

{% endaspTab %}

Output be like the below.

![Alt text](../images/grid1.png)

![Alt text](../images/grid2.png)
