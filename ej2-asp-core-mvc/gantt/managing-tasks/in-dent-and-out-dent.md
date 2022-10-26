# Indent and Outdent

Indent and Outdent of a task are used to update the level of the task in hierarchical order of the task. It can be performed bu enabling the [`editSettings.allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettingsBuilder.html#Syncfusion_EJ2_Gantt_GanttEditSettingsBuilder_AllowEditing_System_Boolean_) property.

`Indent` - Selected task can be indented to the level of task to the hierarchical order. It can be performed by using in-built context menu or toolbar items. It can also be invoked by using the `indent` method dynamically on any action like external button click. The following code example shows how to enable indent option in the Gantt chart.

`Outdent` - Selected task can be outdented to the level of task from the hierarchical order. It can be performed by using in-built context menu or toolbar items. It can also be invoked by using the `outdent` method dynamically on any action like external button click. The following code example shows how to enable outdent option in the Gantt chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/indent-outdent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indentoutdent.cs" %}
{% include code-snippet/gantt/editing/indent-outdent/indentoutdent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/indent-outdent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indentoutdent.cs" %}
{% include code-snippet/gantt/editing/indent-outdent/indentoutdent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Read-only Gantt

In Gantt, all create, update, delete operations can be disabled by set `readOnly` property as `true`. The following sample demonstrates, render Gantt chart as read only.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/readOnly.PNG)

![Alt text](images/readOnlyEdit.png)