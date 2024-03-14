---
layout: post
title: Undo Redo in Syncfusion ##Platform_Name## Gantt Component
description: Learn all about Undo Redo in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Undo Redo
publishingplatform: ##Platform_Name##
documentation: ug
---

# Undo Redo in Gantt component

The Undo feature enables users to revert the most recent action performed in the Gantt Chart. It helps undo changes made to tasks, dependencies, or other actions within the Gantt Chart.

The Redo feature can reapply an action that was previously undone using the Undo feature. This allows users to revert their decision to undo an action.

The undo redo feature can be enabled in Gantt by using the [EnableUndoRedo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableUndoRedo) property.

## Configure the feature set for undo redo actions

The actions to be restored can be specified using [UndoRedoActions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_UndoRedoActions) property.

By default, the following table shows the list of gantt feature for undo redo actions.

| Built-in Undo Redo Items | Actions |
|------------------------|---------|
| Edit | Undo redo actions can be performed for edited record.|
| Delete | Undo redo actions can be performed for deleted record.|
| Add | Undo redo actions can be performed for newly added record.|
| ColumnReorder | Undo redo actions can be performed for reordered column.|
| Indent | Undo redo actions can be performed for indented record.|
| Outdent | Undo redo actions can be performed for outdented record.|
| ColumnResize | Undo redo actions can be performed for resized column.|
| Sorting | Undo redo actions can be performed for sorted column.|
| Filtering | Undo redo actions can be performed for filtered record.|
| Search | Undo redo actions can be performed for searched value.|
| ZoomIn | Undo redo actions can be performed for zoomIn action.|
| ZoomOut | Undo redo actions can be performed for zoomOut action.|
| ZoomToFit | Undo redo actions can be performed for zoomToFit action.|
| ColumnState | Undo redo actions can be performed for hided or shown columns.|
| RowDragAndDrop | Undo redo actions can be performed for row drag and drop.|
| TaskbarDragAndDrop |  Undo redo actions can be performed for taskbar drag and drop.|
| PreviousTimeSpan | Undo redo actions can be performed for previous time span acton.|
| NextTimeSpan | Undo redo actions can be performed for next time span action.|

In the following code example, `Edit` and `Delete` actions are specified in `UndoRedoActions` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/undoActions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/undoActions/undoActions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/undoActions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/undoActions/undoActions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Configure the storage step count for undo redo actions

The number of actions to be restored can be specfified using [UndoRedoStepsCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_UndoRedoStepsCount) property.

By default `UndoRedoStepsCount` value is 10.

When the number of actions performed exceeds the `UndoRedoStepsCount`, then the undo collection gets popped and latest action performed will be pushed in the collection.

In the following example, `UndoRedoStepsCount` value is set to 5.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/stepsCount/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/stepsCount/stepsCount.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/stepsCount/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/stepsCount/stepsCount.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Perform undo redo actions programatically

You can perform undo and redo actions programatically using [undo](https://ej2.syncfusion.com/react/documentation/api/gantt/#undo) and [redo](https://ej2.syncfusion.com/react/documentation/api/gantt/#redo) methods.The following code example demonstrates how to invoke the `undo` and `redo` method by clicking the external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/dynamic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/dynamic/dynamic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/dynamic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/dynamic/dynamic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Retrieve undo and redo stack collection

By default, when undo or redo action is performed, the performed action will be pushed to respective `getUndoActions` or `getUndoActions` collection. So, you can retrieve undo and redo collection using [getUndoActions](https://ej2.syncfusion.com/react/documentation/api/gantt/#getundoactions) and [getRedoActions](https://ej2.syncfusion.com/react/documentation/api/gantt/#getredoactions) methods.

The following code example demonstrates how to retrieve the undo and redo collection using method by clicking the external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/retrieve/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/retrieve/dynamic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/retrieve/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/retrieve/dynamic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Clear undo and redo collection

You can clear undo and redo collection at anytime using [clearUndoCollection](https://ej2.syncfusion.com/react/documentation/api/gantt/#clearundocollection) and [clearRedoCollection](https://ej2.syncfusion.com/react/documentation/api/gantt/#clearredocollection) methods.

The following code example demonstrates how to clear the undo and redo collection using method by clicking the external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/clear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/clear/dynamic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/undo-redo/clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/undo-redo/clear/dynamic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
