---
layout: post
title: Organization Chart in ##Platform_Name## Diagram Component
description: Learn here all about Organization Chart in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Organization Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# HTML Template and CSS in the Organization chart

An organizational chart is a diagram that displays the structure of an organization and relationships. To create an organizational chart, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) of layout should be set as an `OrganizationalChart`.
The following code example illustrates how to use HTML Templates and CSS in the organization chart by using the HTML node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/customizedOrganizational/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizedOrganization.cs" %}
{% include code-snippet/diagram/layout/customizedOrganizational/customizedOrganization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="CustomizedOrganization.cs" %}
{% include code-snippet/diagram/layout/customizedOrganizational/customizedOrganization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

        function getLayoutInfo(node, tree) {
            if (!tree.hasSubTree) {
                tree.orientation = 'Vertical';
                tree.type = 'Right';
            }
        }
        function getNodeDefaults(obj, diagram) {
            obj.height = 100;
            obj.width = 250;
            obj.style = { fill: 'transparent', strokeWidth: 2 };
            obj.shape = {
                type: 'HTML',
                content:
                    `<div><div style=" width: 250px;background-color: #6BA5D7;height:100px; border: 2px solid darkblue; "><img src="https://ej2.syncfusion.com/angular/demos/` +
                    (obj.data).Image.replace('./', '') +
                    `"   style="width: 100px;height: 100px;border-radius: 50%;background-color: whitesmoke "/></div><div style=" margin-left: 125px; margin-top: -74px; font-size: 15px;">` +
                    (obj.data).Name +
                    `</div><div style=" margin-left: 125px; margin-top: 20px; font-size: 15px;">` +
                    (obj.data).Designation +
                    `</div></div>`
            };
        }
        function getConnectorDefaults(connector, diagram) {
            connector.targetDecorator.shape = 'None';
            connector.type = 'Orthogonal';
            connector.style.strokeColor = 'gray';
            return connector;
        }
```