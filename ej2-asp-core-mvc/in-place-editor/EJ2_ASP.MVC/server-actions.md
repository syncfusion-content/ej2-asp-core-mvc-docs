---
layout: post
title: Server Actions in ##Platform_Name## In Place Editor Component
description: Learn here all about Server Actions in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Server Actions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Server actions

By passing In-place Editor control value to the server, the [`PrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PrimaryKey) property value must require, otherwise action not performed for remote data.

If the [`Url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Url) property value is empty, data passing will handled at local and also the [`ActionSuccess`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ActionSuccess) event will trigger with `null` as argument value.

> The following arguments are passed to the server when submit actions perform.

| Arguments  | Explanations                                              |
|------------|-----------------------------------------------------------|
| value      | For processing edited value, like DB value updating.      |
| primaryKey | For value mapping to the server, like selecting DB.            |
| name       | For field mapping to the server, like DB column field mapping. |

Find the following sample server codes for defining models and controller functions to configure processing data.

```csharp
    public class SubmitModel
    {
        public string Name { get; set; }
        public string PrimaryKey { get; set; }
        public string Value { get; set; }
    }
```

```csharp

    public void UpdateData([FromBody]SubmitModel model)
    {
        // User can process data here
    }

```

* Server actions successfully done, the `ActionSuccess` event will be fired with returned server data.

* If the server is not responding, the [`ActionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ActionFailure) event will be fired with data, but value not updated in the Editor.

In the following sample, the `ActionSuccess` event will trigger once the value submitted successfully into the server. In this sample, both `ActionSuccess` and `ActionFailure` were configured and resulted value will be converted to chips.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/server-actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/server-actions/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/server-actions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/server-actions/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![server-actions](./images/server-actions.PNG)

## See Also

* [Indicate the server actions in the editor](./how-to/custom-indication/)