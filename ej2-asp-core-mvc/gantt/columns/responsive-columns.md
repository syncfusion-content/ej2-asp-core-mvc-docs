# Responsive columns

You can toggle the column visibility based on media queries, which are defined in the [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia). The [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia) accepts valid [Media Queries](http://cssmediaqueries.com/what-are-css-media-queries.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change tree/expander column

The tree/expander column is a column in the Gantt control, that has icons to expand or collapse the parent records. You can define the tree column index in the Gantt control by using the [`TreeColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TreeColumnIndex) property and the default value of this property is `0`. The following code example shows how to use this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/treeColumnIndex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TreeColumnIndex.cs" %}
{% include code-snippet/gantt/columns/treeColumnIndex/treeColumnIndex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/treeColumnIndex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TreeColumnIndex.cs" %}
{% include code-snippet/gantt/columns/treeColumnIndex/treeColumnIndex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/treeColumnIndex.png)

## Show or Hide columns Dynamically

You can show or hide gantt columns dynamically using external buttons by invoking the `showColumn` or `hideColumn` method. The **Progress** column is hidden and shown on button clicking.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/showHide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/gantt/columns/showHide/showHide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/showHide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/gantt/columns/showHide/showHide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/showhidecol.png)