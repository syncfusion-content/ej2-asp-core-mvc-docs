# Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}