---
layout: post
title: Code Block in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Code Block with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Code Blocks in ##Platform_Name## Block Editor control

You can render Code blocks by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as `Code`. By setting the `Props` property, you can configure the languages available for syntax highlighting and the default language. The default language is `javascript`.

## Configure code properties

For Code blocks, you can configure syntax highlighting and language options using the [Props](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html) property.

The code [Props](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html) property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| languages | Array of language options for syntax highlighting | [] |
| defaultLanguage | The default language to use for syntax highlighting | 'javascript' |

Each language object in the `languages` array should have:
- `language`: The language value used for syntax highlighting
- `label`: The display name shown in the language selector

#### Type & Props
```typescript
// Adding Code block
{
    Type = BlockType.Code,
    Content = new List<object>()
    {
            new 
            {
                    type = "Text",
                    content = "function greeting() {\n  console.log(\"Hello, world!\");\n}"
            }
    },
    Props = new
    {
            defaultLanguage = "javascript",
            languages = new List<object>()
            {
                    new
                    {
                            label = "JavaScript",
                            language = "javascript"
                    },
                    new
                    {
                            label = "TypeScript",
                            language = "typescript"
                    }
            }
    }
    }
```

Below example illustrates how to render the different code block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Code.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/code-block/code.cs %}
{% endhighlight %}
{% endtabs %}

![Code Block](images/block-code.png)