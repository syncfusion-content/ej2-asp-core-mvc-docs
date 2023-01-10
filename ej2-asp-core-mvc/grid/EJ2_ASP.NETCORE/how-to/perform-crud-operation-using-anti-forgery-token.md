---
layout: post
title: Perform Crud Operation Using Anti Forgery Token in ##Platform_Name## Grid Component
description: Learn here all about Perform Crud Operation Using Anti Forgery Token in Syncfusion ##Platform_Name## Grid component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Perform Crud Operation Using Anti Forgery Token
publishingplatform: ##Platform_Name##
documentation: ug
---


# Perform CRUD operation using anti-forgery token

Anti-forgery token is used between the client and server to prevent cross-site request forgery (CSRF) attack. For more information on preventing CSRF attack, please refer to the [link]( https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-2.1#authentication-fundamentals).

While performing grid save operation, you can send anti-forgery token along with the save request using the below custom adaptor.

This custom adaptor will read the anti-forgery token from the hidden element and send it along with the request. Also content type is set to **application/x-www-form-urlencoded; charset=UTF-8** since the **ValidateAntiForgeryToken** will look for the token in the form encoded data.

```javascript
<script>

    window.customAdaptor = new ej.data.RemoteSaveAdaptor();

    customAdaptor = ej.base.extend(customAdaptor, {
        insert(dm, data, tableName) {
            this.updateType = 'add';
            return {
                url: dm.dataSource.insertUrl || dm.dataSource.crudUrl || dm.dataSource.url,
                data: $.param({
                    //Added the anti-forgery token.
                    __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
                    value: data,
                    table: tableName,
                    action: 'insert'
                }),
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
            };
        },
        update(dm, keyField, value, tableName) {
            debugger;
            this.updateType = 'update';
            this.updateKey = keyField;
            return {
                type: 'POST',
                url: dm.dataSource.updateUrl || dm.dataSource.crudUrl || dm.dataSource.url,
                data: $.param({
                    //Added the anti-forgery token.
                    __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
                    value: value,
                    action: 'update',
                    keyColumn: keyField,
                    key: value[keyField],
                    table: tableName
                }),
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
            };
        },

        remove(dm, keyField, value, tableName) {
            ej.data.JsonAdaptor.prototype.remove(dm, keyField, value);
            return {
                type: 'POST',
                url: dm.dataSource.removeUrl || dm.dataSource.crudUrl || dm.dataSource.url,
                data: $.param({
                    //Added the anti-forgery token.
                    __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
                    key: value,
                    keyColumn: keyField,
                    table: tableName,
                    action: 'remove'

                }),
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8'
            };
        }
    });
</script>

```

Now assign the custom adaptor to the grid as follows.

```javascript

<script>
    function load(args) {
        this.dataSource.adaptor = customAdaptor;
    }
</script>

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/anti-forgery-token/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Anti-forgery-token.cs" %}
{% include code-snippet/grid/how-to/anti-forgery-token/anti-forgery-token.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/anti-forgery-token/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Anti-forgery-token.cs" %}
{% include code-snippet/grid/how-to/anti-forgery-token/anti-forgery-token.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can find the full sample at our [GitHub repository](https://github.com/SyncfusionSamples/ej2-mvc-grid-antiforgerytoken).
