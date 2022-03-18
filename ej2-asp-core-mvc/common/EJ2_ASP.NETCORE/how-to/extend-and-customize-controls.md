---
layout: post
title: Extend and Customize ASP.NET Core Controls | Syncfusion
description: Checkout and learn about Extend and Customize ##Platform_Name## Controls.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Extend and Customize Syncfusion Controls

The AP provides the support to extend a component or customize it within another component for a strong composite model.

## Extend Syncfusion ASP.NET Core Control

The Syncfusion ASP.NET Core Controls can extend and customize the logic by creating a new new tag helper.

1. Right-click on the `~/Pages` folder in the Visual Studio and select `Add -> New Item -> Class` to create a new tag helper (SyncButton.cs).

2. Inherit any Syncfusion ASP.NET Core control and render your component based on your logic with Syncfusion ASP.NET Core API.

{% tabs %}
{% highlight c# tabtitle="~/SyncButton.cs" %}

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASPCore.Pages
{
    [HtmlTargetElement("SyncButton")]
    public class SyncButton : Syncfusion.EJ2.Buttons.Button
    {
        public string className = "e-control e-btn";
        public ButtonStyles Styles { get; set; }
        public enum ButtonStyles
        {
            Basic,
            Success,
            Info,
            Warning,
            Danger
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(Content);
            if(Disabled)
            {
                output.Attributes.SetAttribute("disabled", Disabled);
            }
            if (IsPrimary)
            {
                className += " e-primary";
            }
            else if (Styles == ButtonStyles.Success)
            {
                className += " e-success";
            }
            else if (Styles == ButtonStyles.Info)
            {
                className += " e-info";
            }
            else if (Styles == ButtonStyles.Warning)
            {
                className += " e-warning";
            }
            else
            {
                className += " e-danger";
            }
            output.Attributes.SetAttribute("Class", className);
        }
    }
}

{% endhighlight %}
{% endtabs %}

3.Open `~/Pages/_ViewImports.cshtml` file and import the project Name as TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, ASPCORE

{% endhighlight %}
{% endtabs %}

4.Render your new component in the view page `~/Pages/Index.cshtml` and run the application.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml" %}

 <SyncButton Content="Primary" IsPrimary="true" Disabled="true"></SyncButton>
 <SyncButton Content="Success" Styles="@ASPCore.Pages.SyncButton.ButtonStyles.Success"></SyncButton>
 <SyncButton Content="Info" Styles="@ASPCore.Pages.SyncButton.ButtonStyles.Info"></SyncButton>
 <SyncButton Content="Warning" Styles="@ASPCore.Pages.SyncButton.ButtonStyles.Warning"></SyncButton>
 <SyncButton Content="Danger" Styles="@ASPCore.Pages.SyncButton.ButtonStyles.Danger"></SyncButton>

{% endhighlight %}
{% endtabs %}

![Output of extending Syncfusion component](images/extend-sync-component.png)

## Use Syncfusion ASP.NET Core Control within Another view component

The Syncfusion ASP.NET Core control can be implemented within another view component.

1.Right-click on the `~/Pages` folder in the Visual Studio and select `Add -> Razor Component` to create a new Razor component (TodoList.razor).

2.Add any Syncfusion ASP.NET Core control to the newly created ASP.NET Core component.

{% tabs %}
{% highlight c# tabtitle="Default.cshtml" %}

<h3>Todo List</h3>

<div class="form-group">
    <ejs-textbox id="text" placeholder="Add new item" change="onchange"></ejs-textbox>

    <ejs-button id="add" content="Add"></ejs-button>
</div>

<ejs-listview id="list">
    <e-listview-fieldsettings text="text"></e-listview-fieldsettings>
</ejs-listview>

<script>
    var data;
    function onchange(e) {
        data = {
            text: e.value,
            id: (Math.random() * 100).toFixed(0).toString(),
        }
    }
    document.getElementById("add").addEventListener("click", function (e) {
        var listviewInstance = document.getElementById("list").ej2_instances[0];
        if (data.text != "") {
        listviewInstance.addItem([data]);
        listviewInstance.element.style.display = "block";
        }
    });
</script>

<style>
    #list {
        display: none;
    }
</style>

{% endhighlight %}
{% endtabs %}

3.Open `~/Pages/_ViewImports.cshtml` file and import the project Name as TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, ASPCORE

{% endhighlight %}
{% endtabs %}

4.Render your new component in the view page `~/Pages/Index.cshtml` and run the application.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml" %}

<vc:todo-list></vc:todo-list>

{% endhighlight %}
{% endtabs %}

![Render Syncfusion ASP.NET Core control inside another view component](images/todolist.gif)

## See also

* [ASP.NET Core view components](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-6.0#view-components) 