---
layout: post
title: Mentions in ##Platform_Name## AI AssistView | Syncfusion®
description: Checkout and learn about mentions in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: AI AssistView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mentions in ##Platform_Name## AI AssistView

The Syncfusion AI AssistView supports mentions in the prompt editor, allowing users to select and reference items from a configured data source. When users type the configured mention character, a suggestion popup displays matching items, and they can select an item to insert it into the prompt.

Use the `mentions` property to configure the mention trigger character, data source, field mappings, filtering behavior, popup dimensions, and templates.

## Configure the mentions

The following example demonstrates a basic mention configuration using the `@` character as the trigger and a local data source.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/basic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Basic.cs" %}
{% include code-snippet/ai-assistview/mentions/basic/basic.cs %}
{% endhighlight %}
{% endtabs %}

![Mentions](images/basic.webp)

## Configure mention settings

The `mentions` property accepts an array of mention settings. Each mention setting supports the following properties.

| Property | Type | Default | Description |
|---|---|---|---|
| `mentionChar` | `string` | `''` | Specifies the trigger character that opens the mention suggestion popup |
| `dataSource` | `string[] \| DataManager \| { [key: string]: Object; }[] \| number[] \| boolean[]` | `[]` | Specifies the data source used to populate the mention suggestion popup. You can provide a local collection or a `DataManager` instance for local or remote data. |
| `fields` | `FieldSettingsModel` | `{ text: 'text', value: 'id' }` | Specifies the field mappings used to display and identify mention items. |
| `query` | `Query` | `null` | Specifies the `Query` used to retrieve and process data from the configured data source. |
| `filterType` | `FilterType` | `Contains` | Specifies how the typed text is matched against mention items. |
| `highlight` | `boolean` | `false` | Specifies whether the matching text is highlighted in the mention suggestion popup. |
| `showMentionChar` | `boolean` | `true` | Specifies whether the mention trigger character is displayed with the selected mention in the prompt editor. |
| `popupWidth` | `string \| number` | `'auto'` | Specifies the width of the mention suggestion popup. |
| `popupHeight` | `string \| number` | `'300px'` | Specifies the height of the mention suggestion popup. |
| `displayTemplate` | `string \| Function` | `''` | Specifies the template used to customize the appearance of a selected mention in the prompt editor. |
| `itemTemplate` | `string` | `''` | Specifies the template used to customize the appearance of items in the mention suggestion popup. |
| `noRecordsTemplate` | `string` | `'No records found'` | Specifies the template displayed in the mention suggestion popup when no matching items are available. |

### Configure the mention trigger

Use the `mentionChar` property inside [`mentions`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Mentions) to configure the characters such as `@` or `/`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/mention-char/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MentionChar.cs" %}
{% include code-snippet/ai-assistview/mentions/mention-char/mention-char.cs %}
{% endhighlight %}
{% endtabs %}

![MentionChar](images/mention-char.webp)

### Configure the mention data source

Use the `dataSource` property inside [`mentions`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Mentions) to provide a local collection, such as a string array or an object array, or use a `DataManager` instance to retrieve data locally or from a remote data source.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/data-source/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DataSource.cs" %}
{% include code-snippet/ai-assistview/mentions/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}

![DataSource](images/data-source.webp)

### Configure mention fields

Use the `fields` property inside [`mentions`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Mentions) to map object-based data sources, specify the property names that contain the display text and value.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fields.cs" %}
{% include code-snippet/ai-assistview/mentions/fields/fields.cs %}
{% endhighlight %}
{% endtabs %}

![Fields](images/fields.webp)

### Configure the query

Use the `query` property to apply additional data operations to the configured mention data source. It accepts a Syncfusion `Query` object. The default value is `null`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/query/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/ai-assistview/mentions/query/query.cs %}
{% endhighlight %}
{% endtabs %}

![Query](images/query.webp)

### Configure the filter type

Use the `filterType` property to specify how the text typed after the mention trigger character is matched against the items in the data source. The default value is `Contains`.

The following filter types are supported:

| Filter type | Description |
|---|---|
| `Contains` | Matches items whose display text contains the typed text. |
| `StartsWith` | Matches items whose display text starts with the typed text. |
| `EndsWith` | Matches items whose display text ends with the typed text. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/filter-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FilterType.cs" %}
{% include code-snippet/ai-assistview/mentions/filter-type/filter-type.cs %}
{% endhighlight %}
{% endtabs %}

![FilterType](images/filter-type.webp)

### Configure highlighting

Use the `highlight` property to specify whether the matching text is highlighted in the mention suggestion popup. The default value is `false`. When set to `true`, the portion of the suggestion item that matches the typed text is highlighted.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/ai-assistview/mentions/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}

![Highlight](images/highlight.webp)

### Configure the mention character in selected mentions

Use the `showMentionChar` property to specify whether the configured mention trigger character is displayed with the selected mention. The default value is `true`. When set to `false`, the trigger character is omitted from the displayed mention.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/show-mention-char/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowMentionChar.cs" %}
{% include code-snippet/ai-assistview/mentions/show-mention-char/show-mention-char.cs %}
{% endhighlight %}
{% endtabs %}

![ShowMentionChar](images/show-mention-char.webp)

### Configure the display template

Use the `displayTemplate` property to customize the appearance of a selected mention in the prompt editor. The template receives the selected item's data, allowing you to customize the rendered mention content.

For example, you can display an icon, avatar, or additional information along with the item's display text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/display-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayTemplate.cs" %}
{% include code-snippet/ai-assistview/mentions/display-template/display-template.cs %}
{% endhighlight %}
{% endtabs %}

![DisplayTemplate](images/display-template.webp)

### Configure the mention popup size

Use the `popupWidth` and `popupHeight` properties to customize the dimensions of the mention suggestion popup.

- `popupWidth` - Specifies the popup width. It accepts CSS width values such as `'400px'` or `'50%'`, or a numeric value representing pixels. The default value is `'auto'`.
- `popupHeight` - Specifies the popup height. It accepts CSS height values such as `'300px'` or `'50%'`, or a numeric value representing pixels. The default value is `'300px'`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/popup-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PopupSize.cs" %}
{% include code-snippet/ai-assistview/mentions/popup-size/popup-size.cs %}
{% endhighlight %}
{% endtabs %}

![PopupSize](images/popup-size.webp)

### Configure the item template

Use the `itemTemplate` property to customize the appearance of items in the mention suggestion popup. You can use it to display additional information or visual elements, such as an avatar, icon, or description, along with the mention item's display text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemTemplate.cs" %}
{% include code-snippet/ai-assistview/mentions/item-template/item-template.cs %}
{% endhighlight %}
{% endtabs %}

![ItemTemplate](images/item-template.webp)

### Configure the no records template

Use the `noRecordsTemplate` property to customize the content displayed when no mention items match the text entered by the user. The default value is `'No records found'`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/no-records-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NoRecordsTemplate.cs" %}
{% include code-snippet/ai-assistview/mentions/no-records-template/no-records-template.cs %}
{% endhighlight %}
{% endtabs %}

![NoRecordsTemplate](images/no-records-template.webp)

## Handle mention selection

The `mentionSelect` event is triggered when a user selects an item from the mention suggestion popup. Use this event to access the selected mention data and perform custom actions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/mentions/mention-select/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MentionSelect.cs" %}
{% include code-snippet/ai-assistview/mentions/mention-select/mention-select.cs %}
{% endhighlight %}
{% endtabs %}

![MentionSelect](images/mention-select.webp)