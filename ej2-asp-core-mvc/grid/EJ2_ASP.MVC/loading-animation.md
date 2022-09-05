# Loading Animation

When performing the grid actions(like sorting, filtering, grouping, etc) loading placeholder indicator was displayed while the new data was loaded. By default, the spinner indicator was displayed while the grid was loading and refreshing. Now, Grid has an option to display the Shimmer indicator when the new data is loaded. This can be achieved by setting the `loadingIndicator.indicatorType` property to Spinner or Shimmer.

In the following sample, the Shimmer indicator is displayed while the grid is loading and refreshing when using remote data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-Animation.cs" %}
{% include code-snippet/grid/data-binding/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Loading-Animation.cs" %}
{% include code-snippet/grid/data-binding/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}