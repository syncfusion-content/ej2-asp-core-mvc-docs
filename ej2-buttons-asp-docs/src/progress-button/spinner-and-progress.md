---
title: "ProgressButton Spinner and Progress"
component: "ProgressButton"
description: "ProgressButton allows the user to change size & position of the spinner, customize spinner using template and to change the progress."
---

<!-- markdownlint-disable MD002 MD022 -->
## Spinner

### Change spinner position

Spinner position can be changed by modifying the `position` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings). By default, the spinner is positioned at the left of the ProgressButton. You can position it at the `left`, `right`, `top`, `bottom`, or `center` of the text content.

### Change spinner size

Spinner size can be changed by modifying the `width` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings). In this demo, the `width` is set to `20` to change the spinner size.

### Spinner template

You can use custom spinner by specifying the `template` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings) with custom styles.

The following sample demonstrates the above functionalities of the spinner.

{% aspTab template="progress-button/spinner/demo", sourceFiles="default.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD025 MD022 -->
## Progress

### Content animation

The [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_Content) of the ProgressButton can be animated during progress using the `effect` property
of [`animationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_AnimationSettings). You can also set custom duration and timing function using the `duration` and `easing` properties. The possible `effect` values are `None`, `SlideLeft`, `SlideRight`, `SlideUp`, `SlideDown`, `ZoomIn`, and `ZoomOut`.

{% aspTab template="progress-button/animation/demo", sourceFiles="default.cs" %}

{% endaspTab %}

### Change step of the ProgressButton

The progress state can be visualized to the specified interval by changing the `step` property in the [`begin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_Begin) event of the ProgressButton. In this demo, the `step` property is set to `20` to show progress at every 20% increment.

{% aspTab template="progress-button/step/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> The class `e-hide-spinner` hides the spinner in the ProgressButton, For more information, see [hide spinner](./how-to/hide-spinner) section

### Changing progress state dynamically

The progress state can be changed dynamically by modifying the `percent` property in the progress events. In this demo, on 40% completion of progress, the `percent` property is set to `90` to show dynamic change of the progress state.

{% aspTab template="progress-button/state/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> The method `dataBind` applies the property changes immediately to the component.

### Start and stop methods

You can pause and resume the progress using the `stop` and `start` methods, respectively. In this demo, clicking the ProgressButton will pause and resume the progress.

{% aspTab template="progress-button/methods/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## See Also

* [How to hide spinner](./how-to/hide-spinner)
* [Customize ProgressButton using cssClass](how-to/customize-progress-using-cssclass)