# Column template

A column template is used to customize the column’s look. The following code example explains how to define the custom template in Gantt using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Template) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnTemplate.cs" %}
{% include code-snippet/gantt/columns/columnTemplate/columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnTemplate.cs" %}
{% include code-snippet/gantt/columns/columnTemplate/columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/columnTemplate.png)