---
title: "Load content through Ajax"
component: "Tab"
description: "This example demonstrates how to load external content into the Essential JS 2 Tab component through an AJAX post."
---

# Load content through Ajax

The Tab supports to load external contents through AJAX library. Refer to the following steps.

* Import the Ajax module from ej2-base and initialize with URL path.

* Get the data from Ajax Success event, then initialize the Tab with retrieved external path data.

{% aspTab template="tab/ajax", sourceFiles="ajax.cs" %}

{% endaspTab %}