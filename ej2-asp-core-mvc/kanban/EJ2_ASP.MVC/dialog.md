---
layout: post
title: Dialog in ##Platform_Name## Kanban Component
description: Learn here all about Dialog in Syncfusion ##Platform_Name## Kanban component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# Card Editing in ASP.NET MVC Kanban control

The Kanban provides built-in support to add, edit and delete a card using dialog module. User can edit a card using the following ways.

* Built-in dialog module
* Custom Fields
* Dialog template

## Default Dialog

When double-click on the cards, the dialog is opened with below fields to edit a card. This dialog contains `Delete`, `Save` and `Cancel` buttons.

* To edit a card, modify the card details and click the `Save` button.
* To delete a card, click `Delete` button.
* Click on the `Cancel` button to cancel the editing action.

The dialog displays with the following fields which mapped to dialog fields by default.

|Key|Type|Text|
|---|----|----|
cardSettings.headerField | Input | ID
keyField | DropDown | -
cardSettings.contentField | TextArea | -
cardSettings.priority(If applicable) | Numeric | -
swimlaneSettings.keyField(If applicable) | DropDown | -

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/default/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/default/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/default/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/dialog-default.PNG)

## Custom Fields

You can change the default fields of dialog using `Fields` property inside the `DialogSettings` property. The `Key` property used to map the DataSource value and rendered the corresponding component based on specified `Type` property.

The following types are available in dialog fields.

* String
* Numeric
* TextArea
* DropDown
* TextBox
* Input

> If `Type` is not defined in the fields, then it renders as the HTML input element in dialog.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/custom-fields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/custom-fields/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/custom-fields/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/custom-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/custom-fields/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/custom-fields/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/custom-fields.PNG)

### Custom Fields label

By default, the fields `Key` mapping value is considered as a `Label` and you can change this label by using `Text` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/custom-field-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/custom-field-label/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/custom-field-label/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/custom-field-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/custom-field-label/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/custom-field-label/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/custom-fields-label.PNG)

### Fields Validation

The dialog fields can be validated while click on the `Save` button. This can be achieved by using `ValidationRules` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/fields-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/fields-validation/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/fields-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/fields-validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/fields-validation/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/fields-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dialog Template

Using the dialog template, you can render your own dialog by defining the `Template` property. Initialize the template as SCRIPT element Id or HTML string which holds the template and map it to the template property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/template/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/template/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/dialog-template.PNG)

## Prevent Dialog

The Kanban allows to prevent to open a dialog on card double-click by enabling `args.cancel` in `DialogOpen` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/prevent-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/prevent-dialog/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/prevent-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/prevent-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/prevent-dialog/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/prevent-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Persisting data in server

The modified card data can be persisted in the database using the RESTful web services. All the CRUD operations in the Kanban are done through `DataManager`. The `DataManager` has an option to bind all the CRUD related data in server-side.

> For your information, the ODataAdaptor persists data in the server as per OData protocol.

In the below section covers how to get the edited data details on the server-side using the `UrlAdaptor`.

### URL adaptor

You can use the `UrlAdaptor` of `DataManager` when binding data source for remote data. In the initial load of Kanban, data are fetched from remote data and bound to the Kanban using `Url` property of `DataManager`.

You can map the CRUD operation in Kanban can be mapped to server-side controller actions using the properties `InsertUrl`, `RemoveUrl`, `UpdateUrl`, and `CrudUrl`.

* `InsertUrl` – You can perform single insertion operation on server-side.
* `UpdateUrl` – You can update single data on server-side.
* `RemoveUrl` – You can remove single data on server-side.
* `CrudUrl` – You can perform bulk data operation on server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/url-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/url-adaptor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/url-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/url-adaptor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The server-side controller code to handle the CRUD operations are as follows.

```typescript

private NORTHWNDEntities db = new NORTHWNDEntities();
public ActionResult DataSource() {
    var DataSource = db.Tasks.ToList();
    return Json(DataSource, JsonRequestBehavior.AllowGet);
}
public ActionResult Insert(Params value) {
    //Insert card data into the database
    return Json(value, JsonRequestBehavior.AllowGet);
}
public ActionResult Update(Params value) {
    //Update card data into the database
    return Json(value, JsonRequestBehavior.AllowGet);
}
public void Delete(Params value) {
    //Delete card data from the database
}

public class Params {
    public int Id { get; set; }
    public string Status { get; set; }
    public string Summary { get; set; }
    public string Assignee { get; set; }
}

```

### Insert card

Using the `InsertUrl` property, you can specify the controller action mapping URL to perform insert operation on the server-side.

The following code example describes the above behavior.

```typescript
public ActionResult Insert(Params value)
{
    //Insert card in the database
}

```

The newly added record details are bound to the `value` parameter.

### Update card

Using the `UpdateUrl` property, the controller action mapping URL can be specified to perform save/update operation on the server-side.

The following code example describes the above behavior.

```typescript
public ActionResult Update(Params value)
{
    //Update card data in the database
}

```

The updated record details are bound to the `value` parameter.

### Delete card

Using the `RemoveUrl` property, the controller action mapping URL can be specified to perform delete operation on the server-side.

The following code example describes the above behavior.

```typescript
public void Delete(int key)
{
    //Delete card in the database
}

```

The deleted card primary key value is bound to the `key` parameter.

### CRUD URL

Using the `CrudUrl` property, the controller action mapping URL can be specified to perform all the CRUD operations at the server-side using a single method instead of specifying a separate controller action method for CRUD (insert, update and delete) operations.

The action parameter of `CrudUrl` is used to get the corresponding CRUD action.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/dialog/crud-url-adaptor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```typescript

private NORTHWNDEntities db = new NORTHWNDEntities();
public ActionResult DataSource() {
    var DataSource = db.Tasks.ToList();
    return Json(DataSource, JsonRequestBehavior.AllowGet);
}
public ActionResult UpdateData(EditParams param) {
    if (param.action == "insert" || (param.action == "batch" && param.added != null)) {
        if (param.action == "insert") {
            db.Tasks.Add(param.value);
        } else {
            foreach (var temp in param.added) {
                db.Tasks.Add(temp);
            }
        }
    }
    if (param.action == "update" || (param.action == "batch" && param.changed != null)) {
        if (param.action == "update") {
            Task old = db.Tasks.Where(o => o.Id == param.value.Id).SingleOrDefault();
            if (old != null) {
                db.Entry(old).CurrentValues.SetValues(param.value);
            }
        } else {
            foreach (var temp in param.changed) {
                Task old = db.Tasks.Where(o => o.Id == temp.Id).SingleOrDefault();
                if (old != null) {
                    db.Entry(old).CurrentValues.SetValues(temp);
                }
            }
        }
    }
    if (param.action == "remove" || (param.action == "batch" && param.deleted != null)) {
        if (param.action == "remove") {
            int key = Convert.ToInt32(param.key);
            db.Tasks.Remove(db.Tasks.Where(o => o.Id == key).SingleOrDefault());
        } else {
            foreach (var temp in param.deleted) {
                db.Tasks.Remove(db.Tasks.Where(o => o.Id == temp.Id).SingleOrDefault());
            }
        }
    }
    db.SaveChanges();
    return Json(param, JsonRequestBehavior.AllowGet);
}

public class EditParams {
    public string key { get; set; }
    public string action { get; set; }
    public List<Tasks> added { get; set; }
    public List<Tasks> changed { get; set; }
    public List<Tasks> deleted { get; set; }
    public Tasks value { get; set; }
}

```

> The `CrudUrl` is used to update the bulk data sent to the server-side. Multiple selections and `SortBy` as `Index` properties are used for `CrudUrl` properties to update the modified bulk data to the server-side.
