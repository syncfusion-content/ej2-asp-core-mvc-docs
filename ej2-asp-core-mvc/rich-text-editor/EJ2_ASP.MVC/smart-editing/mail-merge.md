---
layout: post
title: Mail merge in ##Platform_Name## RichTextEditor | Syncfusion
description: Learn about Mail merge in Syncfusion ##Platform_Name## RichTextEditor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mail merge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mail merge in ##Platform_Name## Rich Text Editor control

The Rich Text Editor can be customized to implement **Mail Merge** functionality by inserting placeholders into the editor using custom toolbar items. These placeholders are later replaced with actual data to generate personalized content such as letters, invoices, and reports.

This feature simplifies the creation of dynamic documents by allowing users to insert merge fields that are automatically populated with real data during content generation.

## Adding custom toolbar items for inserting merge fields

To enable mail merge functionality, the Rich Text Editor toolbar is extended with two custom buttons: `Insert Field` and `Merge Data`. These buttons are added using the `template` property in [ToolbarSettings.Items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items), which points to custom HTML elements (#insertField and #merge_data).

- **Insert Field:** Opens a dropdown list of merge fields for inserting placeholders like `{{FirstName}}` into the editor.
- **Merge Data:** Replaces all placeholders in the editor with actual values from a predefined data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var tools = new object[]
    {
        "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|",
        new { tooltipText = "Merge Data", template = "#merge_data", command = "Custom" },
        new { tooltipText = "Insert Field", template = "#insert_Field", command = "Custom" },
        "SourceCode", "|", "Undo", "Redo",
    };
}
<ejs-richtexteditor id="mailMergeEditor">
    <e-richtexteditor-toolbarsettings items="@tools"><e-richtexteditor-toolbarsettings>                    
</ejs-richtexteditor>

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var tools = new object[]
    {
        "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|",
        new { tooltipText = "Merge Data", template = "#merge_data", command = "Custom" },
        new { tooltipText = "Insert Field", template = "#insert_Field", command = "Custom" },
        "SourceCode", "|", "Undo", "Redo",
    };
}

@Html.EJS().RichTextEditor("mailMergeEditor").ToolbarSettings(e => e.Items(tools)).Value(rteValue).Render()
        
{% endhighlight %}
{% endtabs %}

{% endif %}

## Using DropDownButton for selecting placeholders

The **DropDownButton** component displays a list of merge fields such as First Name, Last Name, and Company Name. When a user selects an item, the corresponding placeholder (e.g., {{FirstName}}) is inserted at the current cursor position using the `insertHTML` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var items = new List<object>
    {
        new { text = "First Name" },
        new { text = "Last Name" },
        new { text = "Support Email" },
        new { text = "Company Name" },
        new { text = "Promo Code" },
        new { text = "Support Phone Number" },
        new { text = "Customer ID" },
        new { text = "Expiration Date" },
        new { text = "Subscription Plan" }
    };
}

<ejs-dropdownbutton id="insert_Field" select="onItemSelect" content="Insert Field" items="items" cssClass="e-rte-dropdown-btn e-rte-dropdown-popup e-rte-dropdown-items e-rte-elements e-rte-dropdown-menu"></ejs-dropdownbutton>             

<script>
    function onItemSelect(args) {
        if (args.item.text != null) {
            const value = textToValueMap[args.item.text];
            const trimmedValue = value.trim();
            mailMergeEditor.formatter.editorManager.nodeSelection.restore();
            mailMergeEditor.executeCommand(
                'insertHTML',
                `<span contenteditable="false" class="e-mention-chip"><span>{{${trimmedValue}}}</span></span>&nbsp;`,
                { undo: true }
            );
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var items = new List<object>
    {
        new { text = "First Name" },
        new { text = "Last Name" },
        new { text = "Support Email" },
        new { text = "Company Name" },
        new { text = "Promo Code" },
        new { text = "Support Phone Number" },
        new { text = "Customer ID" },
        new { text = "Expiration Date" },
        new { text = "Subscription Plan" }
    };
}

@Html.EJS().DropDownButton("insert_Field").Content("Insert Field").Select("onItemSelect").Items(items).CssClass("e-rte-dropdown-btn e-rte-dropdown-popup e-rte-dropdown-items e-rte-elements e-rte-dropdown-menu").Render()

<script>
    function onItemSelect(args) {
        if (args.item.text != null) {
            const value = textToValueMap[args.item.text];
            const trimmedValue = value.trim();
            mailMergeEditor.formatter.editorManager.nodeSelection.restore();
            mailMergeEditor.executeCommand(
                'insertHTML',
                `<span contenteditable="false" class="e-mention-chip"><span>{{${trimmedValue}}}</span></span>&nbsp;`,
                { undo: true }
            );
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

{% endif %}

## Populating merge fields using Mention

The **Mention** control provides an alternative way to insert placeholders by typing the <code>&#123;&#123;</code> character inside the editor. A popup list of merge fields appears, allowing quick selection without using the toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var mergeData = new List<object>
    {
        new { text = "First Name", value = "FirstName" },
        new { text = "Last Name", value = "LastName" },
        new { text = "Support Email", value = "SupportEmail" },
        new { text = "Company Name", value = "CompanyName" },
        new { text = "Promo Code", value = "PromoCode" },
        new { text = "Support Phone Number", value = "SupportPhoneNumber" },
        new { text = "Customer ID", value = "CustomerID" },
        new { text = "Expiration Date", value = "ExpirationDate" },
        new { text = "Subscription Plan", value = "SubscriptionPlan" }
    };
    char mentionChar = <code>&#123;&#123;</code>;

}
<ejs-mention id="mentionField" target="#mailMergeEditor_rte-edit-view" mentionChar="@mentionChar" created="onMentionCreate" dataSource="@mergeData" popupHeight="200px" popupWidth="250px" allowSpaces="true" displayTemplate="<span> {{${value}}} </span>">
        <e-mention-fields text="text"></e-mention-fields>
</ejs-mention>

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var mergeData = new List<object>
    {
        new { text = "First Name", value = "FirstName" },
        new { text = "Last Name", value = "LastName" },
        new { text = "Support Email", value = "SupportEmail" },
        new { text = "Company Name", value = "CompanyName" },
        new { text = "Promo Code", value = "PromoCode" },
        new { text = "Support Phone Number", value = "SupportPhoneNumber" },
        new { text = "Customer ID", value = "CustomerID" },
        new { text = "Expiration Date", value = "ExpirationDate" },
        new { text = "Subscription Plan", value = "SubscriptionPlan" }
    };
    char mentionChar = <code>&#123;&#123;</code>;
}

@Html.EJS().Mention("mentionField").MentionChar(mentionChar).Created("onMentionCreate").Target("#mailMergeEditor_rte-edit-view").DataSource(mergeData).AllowSpaces(true).Fields(new MentionFieldSettings { Text = "Text" }).DisplayTemplate("<span> {{${Value}}} </span>").Render()
        
{% endhighlight %}
{% endtabs %}

{% endif %}

## Replacing placeholders with actual data dynamically

When the **Merge Data** button is clicked, the editor content is processed to replace all placeholders with actual values from the `placeholderData` object. This is done using a regular expression in the `replacePlaceholders()` function.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-button id="merge_data" content="Merge Data" onclick="onClickHandler()" cssClass="e-tbar-btn e-btn" tabindex="-1" style="width: 100%"></ejs-button>

<script>
    function onClickHandler() {
        if (mailMergeEditor) {
            let editorContent = mailMergeEditor.value;
            let mergedContent = replacePlaceholders(editorContent, placeholderData);
            if (mailMergeEditor.formatter.getUndoRedoStack().length === 0) {
                mailMergeEditor.formatter.saveData();
            }
            mailMergeEditor.value = mergedContent;
            mailMergeEditor.formatter.saveData();
        } else {
            console.log('MailMergeEditor is not initialized.');
        }
    }
    function replacePlaceholders(template, data) {
        return template.replace(/{{\s*(\w+)\s*}}/g, (match, key) => {
            var value = data[key.trim()];
            var result = value !== undefined ? value : match;
            return result;
        });
    }
</script> 

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().Button("merge_data").Content("Merge Data").Click("onClickHandler").CssClass("e-tbar-btn e-btn").Render()

<script>
    function onClickHandler() {
        if (mailMergeEditor) {
            let editorContent = mailMergeEditor.value;
            let mergedContent = replacePlaceholders(editorContent, placeholderData);
            if (mailMergeEditor.formatter.getUndoRedoStack().length === 0) {
                mailMergeEditor.formatter.saveData();
            }
            mailMergeEditor.value = mergedContent;
            mailMergeEditor.formatter.saveData();
        } else {
            console.log('MailMergeEditor is not initialized.');
        }
    }
    function replacePlaceholders(template, data) {
        return template.replace(/{{\s*(\w+)\s*}}/g, (match, key) => {
            var value = data[key.trim()];
            var result = value !== undefined ? value : match;
            return result;
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mail-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mail-merge/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mail-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mail-merge/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
