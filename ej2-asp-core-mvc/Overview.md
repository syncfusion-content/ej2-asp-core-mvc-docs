---
layout: post
title: Welcome to Syncfusion Essential ASP.NET Core
description: Learn here all about overview of Syncfusion Essential ASP.NET Core widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Introduction
publishingplatform: ##Platform_Name##
documentation: ug
---


## How to best read this user guide

* The best way to get started would be to read the "Getting Started" section of the documentation for the component that you would like to start using first. The "Getting Started" guide gives just enough information that you need to know before starting to write code. This is the only section that we recommend reading end-to-end before starting to write code, all other information can be referred as needed.

* Now that you are familiar with the basics of using the component, the next step would be to start integrating the component into your application. A good starting point would be to refer to the code snippets in the [online sample browser](https://aspnetcore.syncfusion.com/) which contains hundreds of code samples, it is very likely that you will find a code sample that resembles your intended usage scenario. 

* After you have integrated the component into your application using one of the sample code snippets as a starting point, it is likely that you would want additional information on specific features and API. The best option would be to search a the specific topic using the search box that is available at the top of the user guide.

* Another valuable resource is the [API reference](https://help.syncfusion.com/cr/aspnet-core) which provides detailed information on the object hierarchy as well as the settings available on every object.




{% if page.publishingplatform == "aspnet-core" %}

## Auto wrap 

The auto wrap enables the Grid to wrap cell content or header content to next line when the content exceeds the boundary of the cell width. To enable auto wrap, set the `allow-text-wrap` property as `true`. 

The mode of auto wrap can be specified using the `wrap-mode` property of `e-text-wrap-settings`. 

The three types of `wrap-mode` available are as follows.
  
 1. Both
 2. Header
 3. Content 
 
N> 1. The `wrap-mode` by default  will be set as `Both`. 
N> 2. While using the `e-text-wrap-settings` then it is must to set the `allow-text-wrap` as `true`.
N> 3. For the `wrapMode` property you can assign `enum` value (`Syncfusion.JavaScript.WrapMode.Both`).
 
## Both

When the `wrap-mode` of `e-text-wrap-settings` property is set as `Both` then the auto wrap will be enabled for both the Grid content and header. 

The following code example describes the previous behavior.

{% tabs %}
{% highlight razor %}

   <ej-grid id="FlatGrid" allow-paging="true" allow-text-wrap="true" datasource="ViewBag.DataSource">
       <e-text-wrap-settings wrap-mode="Both"></e-text-wrap-settings>
        <e-columns>
            <e-column field="OrderID" header-text="OrderID" width="90"></e-column>
            <e-column field="EmployeeID" header-text="EmployeeID" width="100"></e-column>
            <e-column field="Freight" header-text="Freight" width="100"></e-column>
            <e-column field="ShipCity" header-text="ShipCity"  width="90"></e-column>
            <e-column field="ShipAddress" header-text="Ship Address" width="110"></e-column>
        </e-columns>
   </ej-grid>

{% endhighlight  %}
{% highlight c# %}

      namespace MVCSampleBrowser.Controllers
          {
            public class GridController : Controller
              { 
                public IActionResult GridFeatures()
                 {
                   var DataSource = new NorthwindDataContext().OrdersViews.ToList();
                   ViewBag.DataSource = DataSource;
                   return View();
                 }
             }
        } 
{% endhighlight  %}    
{% endtabs %}  

The following output is displayed as a result of the previous code example.

![Both Wrap Mode](Cell_images/Cell_img1.png)


{% elsif page.publishingplatform == "aspnet-mvc" %}

## Data Binding

The Grid `datasource` property or `e-datamanager` child tag allows to bind datasource as the instance of one of the following types.
   
*	Collection that implements IEnumerable or IEnumerable&lt;T&gt;.
*	REST Service URL as string.
*	Table – Allows to bind HTML Table and it accepts table template script "ID".
*	ORM components such as Entity Framework/Linq to SQL.

N> 1. To update the dataSource after Grid rendered, use `dataSource` method of grid.
N> 2. DateTime values, retrieved from server-end or database, will be converted based on the local time zone. To avoid the local time zone conversion, refer this knowledge base [link](https://www.syncfusion.com/kb/8613/how-to-convert-dates-to-utc-format).

## IEnumerable
 
The grid can be bound with either non-generic collection or generic collection that implements [IEnumerable](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) interface. It can be assigned to the grid’s `datasource` property.
    
N> The IEnumerable datasource can be passed as either directly to the datasource property or to the json property of the child tag.
  
The following code example describes the previous behavior.
  
{% tabs %} 
{% highlight razor %}

<ej-grid id="Grid" datasource="ViewBag.datasource">
    <e-columns>
        <e-column field="FirstName" header-text="First Name" text-align="Left" ></e-column>
        <e-column field="LastName" header-text="Last Name" text-align="Left"></e-column>
        <e-column field="Email" text-align="Left"></e-column>
    </e-columns>
</ej-grid>
{% endhighlight  %}
{% highlight c# %}
namespace samplebrowser.Controllers.Grid
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public partial class GridController : Controller
    {
        // GET: /<controller>/
        public ActionResult DataBinding()
        {
            List<Person> Persons = new List<Person>();
            Persons.Add(new Person() { FirstName = "John", LastName = "Beckett", Email = "john@syncfusion.com" });
            Persons.Add(new Person() { FirstName = "Ben", LastName = "Beckett", Email = "ben@syncfusion.com" });
            Persons.Add(new Person() { FirstName = "Andrew", LastName = "Beckett", Email = "andrew@syncfusion.com" });
            ViewBag.datasource = Persons;
            return View();
        }
    }
}


{% endhighlight  %}
{% endtabs %} 

The following output is displayed as a result of the previous code example.

![](Data-Binding_images/Data-Binding_img1.png)

{% endif %}

