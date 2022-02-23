---
title: " ProgressBar States | ASP.NET MVC "

component: "ProgressBar"

description: "Visualize progress in different states."
---

# States

Visualize progress in different states.

## Determinate

<!-- markdownlint-disable MD033 -->

This is the default state. You can use it when the progress estimation is known.

{% aspTab template="progress-bar/modes/determinate" %}

{% endaspTab %}

## Indeterminate

By enabling the **IsIndeterminate** property, the state of the progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with determinate mode to know that the application is estimating progress before the actual progress starts.

{% aspTab template="progress-bar/modes/indeterminate" %}

{% endaspTab %}

## Buffer

<!-- markdownlint-disable MD033 -->
You can use a secondary progress indicator when the primary progress depends on the secondary progress. This will allow users to visualize both primary and secondary progress simultaneously.

{% aspTab template="progress-bar/modes/buffer" %}

{% endaspTab %}