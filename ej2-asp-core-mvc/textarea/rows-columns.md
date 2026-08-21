---
layout: post
title: Rows and Columns in ##Platform_Name## TextArea | Syncfusion
description: Set the Syncfusion ##Platform_Name## TextArea dimensions using the `Rows` and `Cols` properties to control vertical lines and horizontal character width.
platform: ej2-asp-core-mvc
control: Rows and Columns Count
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Rows and Columns in ##Platform_Name## TextArea

Two essential attributes, `rows` and `columns`, play a pivotal role in customizing the TextArea's appearance and layout.
The `rows`attribute determines the initial visible number of lines within the TextArea, controlling its vertical size. Conversely, the `columns` attribute specifies the visible width of the TextArea in characters per line, determining its initial width.


* You can customize the TextArea control by setting the number of rows using the [Rows](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Rows) property and the number of columns using the [Cols](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Cols) property. These properties allow precise control over the dimensions of the TextArea, ensuring it fits seamlessly within the layout of the application.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/rows-cols/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/rows-cols/rows-cols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/rows-cols/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/rows-cols/rows-cols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textarea](./images/textarea-rowscols.png)
