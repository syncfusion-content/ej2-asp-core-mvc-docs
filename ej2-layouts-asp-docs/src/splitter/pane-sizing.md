---
title: "Pane sizing"
component: "Splitter"
description: "This section explains about user can feed pane sizes."
---

# Pane sizing

Splitter allows you to provide pane sizes either in pixel or percentage formats.

{% aspTab template="splitter/panesizing", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Pane Sizing](./images/panesizing.png)

{% aspTab template="splitter/panesizing-percentage", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Pane Sizing](./images/panesizing-percentage.png)

## Auto size panes

You can render the split panes without providing the size values. It will split up the sizes automatically.

{% aspTab template="splitter/layouts", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Auto size panes](./images/layouts.png)

## Fixed pane

You can render the split panes with fixed sizes. Since last pane is a flexible pane, fixed size will not be applied.

{% aspTab template="splitter/fixed-pane", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Fixed pane](./images/fixed-pane.png)