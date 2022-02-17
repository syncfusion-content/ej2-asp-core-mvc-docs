---
layout: post
title: Data Binding in ##Platform_Name## Diagram Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

* Diagram can be populated with the `nodes` and `connectors` based on the information provided from an external data source.

* Diagram exposes its specific data-related properties allowing you to specify the data source fields from where the node information has to be retrieved from.

* The [`dataManager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html#Syncfusion_EJ2_Diagrams_DiagramDataSource_DataManager) property is used to define the data source either as a collection of objects or as an instance of `DataManager` that needs to be populated in the diagram.

* The [`ID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html#Syncfusion_EJ2_Diagrams_DiagramDataSource_Id) property is used to define the unique field of each JSON data.

* The [`parentId`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html#Syncfusion_EJ2_Diagrams_DiagramDataSource_ParentId) property is used to defines the parent field which builds the relationship between ID and parent field.

* The [`root`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html#Syncfusion_EJ2_Diagrams_DiagramDataSource_Root) property is used to define the root node for the diagram populated from the data source.

* To explore those properties, see [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html).

* Diagram supports two types of data binding. They are:

    1. Local data
    2. Remote data

## Local data

Diagram can be populated based on the user defined JSON data (Local Data) by mapping the relevant data source fields.

To map the user defined JSON data with diagram, configure the fields of [`dataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDataSource.html). The following code example illustrates how to bind local data with the diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/data-binding/local/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/diagram/data-binding/local/local.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/diagram/data-binding/local/local.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function diagramCreated() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
            diagram.tool = ej.diagrams.DiagramTools.ZoomPan;
            diagram.dataBind();
        }

 function getNodeDefaults(obj, data, diagram) {
     //Initialize shape
     obj.annotations = [{
            /* tslint:disable:no-string-literal */
            content: obj.data.Name, margin: { top: 10, left: 10, right: 10, bottom: 0 },
            style: { color: 'black' }
        }];
        obj.style =

            {
                fill: '#ffeec7', strokeColor: '#f5d897', strokeWidth: 1
            }

            ; obj.shape = {
                type: 'Basic', shape: 'Rectangle'
            }

            ; obj.width = 95; obj.height = 30; return obj;
        }

        function getConnectorDefaults(connector, diagram) {
            connector.type = 'Orthogonal';
            connector.style.strokeColor = '#4d4d4d';
            connector.targetDecorator.shape = 'None';
            return connector;
        }
```

## CRUD

This feature allows you to read the data source and perform add or edit or delete the data in data source at runtime.

## Read DataSource

* This feature allows you to define the nodes and connectors collection in the data source and connectionDataSource respectively.

* You can set the data collection in the model’s dataSourceSettings [`dataManager`](https://ej2.syncfusion.com/documentation/api/diagram/connectionDataSourceModel/#datamanager) property. The nodes will be generated based on the data specified in the data source.

* You can set the connector collection in the model’s dataSourceSettings [`connectionDataSource`](https://ej2.syncfusion.com/documentation/api/diagram/connectionDataSourceModel) property.

* The dataSourceSettings connectionDataSource [`dataManager`](https://ej2.syncfusion.com/documentation/api/diagram/connectionDataSourceModel/#datamanager) property is used to set the data source for the connection data source items.

* If you have a data (data will be set in the dataSource property) with parent relationship in the database and also defined the connector in the connectionDataSource simultaneously, then the connectors set in the connectionDataSource will be considered as a priority to render the connector.

* The dataSourceSettings [`crudAction’s`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#crudaction) [`read`](https://ej2.syncfusion.com/documentation/api/diagram/crudActionModel#read) property specifies the method, which is used to read the data source and its populate the nodes in the diagram.

* The connectionDataSource crudAction’s [`read`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#read) specifies the method, which is used to read the data source and its populates the connectors in the diagram.

* The dataSourceSettings’s [`id`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/) and connectionDataSource’s [`id`](https://ej2.syncfusion.com/documentation/api/diagram/connectionDataSourceModel#id) properties are used to define the unique field of each JSON data.

* The connectionDataSource’s [`sourceID`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/) and [`targetID`](https://ej2.syncfusion.com/documentation/api/diagram/connectionDataSourceModel#targetid) properties are used to set the sourceID and targetID for connection data source item.

* The connectionDataSource’s [`sourcePointX`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/), [`sourcePointY`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/), [`targetPointX`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/), and [`targetPointY`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/) properties are used to define the sourcePoint and targetPoint values for connector from data source.

* The dataSourceSettings crudAction’s [`customFields`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#crudaction) property is used to maintain the additional information for nodes.

* Similarly, connectionDataSource’s crudAction’s [`customFields`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#crudaction) is used to maintain the additional information for connectors.

## How to perform Editing at runtime

* The dataSourceSettings crudAction object allows you to define the method, which is used to get the changes done in the data source defined for shapes from the client-side to the server-side.

* Similarly, the connectionDataSource crudAction object allows you to define the method, which is used to get the changes done in the data source defined for connectors from the client-side to the server-side.

## InsertData

* The dataSourceSettings crudAction’s [`create`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#crudaction) property specifies the method, which is used to get the nodes added from the client-side to the server-side.

* The connectionDataSource crudAction’s  [`create`](https://ej2.syncfusion.com/documentation/api/diagram/crudActionModel/) specifies the method, which is used to get the connectors added from the client-side to the server-side.

* The following code example illustrates how to send the newly added or inserted data from the client to server-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/data-binding/insertdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insertdata.cs" %}
{% include code-snippet/diagram/data-binding/insertdata/insertdata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Insertdata.cs" %}
{% include code-snippet/diagram/data-binding/insertdata/insertdata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
//Sends the newly added nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.insertData();

```

## UpdateData

* The dataSourceSettings crudAction’s [`update`](https://ej2.syncfusion.com/documentation/api/diagram/dataSourceModel/#crudaction) property specifies the method, which is used to get the modified nodes from the client-side to the server-side.

* The connectionDataSource crudAction’s [`update`](https://ej2.syncfusion.com/documentation/api/diagram/crudActionModel/) specifies the method, which is used to get the modified connectors from the client-side to the server-side.

* The following code example illustrates how to send the updated data from the client to the server side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/data-binding/updatedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Updatedata.cs" %}
{% include code-snippet/diagram/data-binding/updatedata/updatedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Updatedata.cs" %}
{% include code-snippet/diagram/data-binding/updatedata/updatedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
//Sends the updated nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.updateData();

```

## DeleteData

* The dataSourceSettings crudAction’s [`destroy`](https://ej2.syncfusion.com/documentation/api/diagram/crudActionModel/) property specifies the method, which is used to get the deleted nodes from the client-side to the server-side.

* The connectionDataSource crudAction’s [`destroy`](https://ej2.syncfusion.com/documentation/api/diagram/crudActionModel/) specifies the method, which is used to get the deleted connectors from the client-side to the server-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/data-binding/deletedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Deletedata.cs" %}
{% include code-snippet/diagram/data-binding/deletedata/deletedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Deletedata.cs" %}
{% include code-snippet/diagram/data-binding/deletedata/deletedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



 ```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
//Sends the deleted nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.removeData();

```

## See Also

* [How to arrange the diagram nodes and connectors using varies layout](./automatic-layout)
