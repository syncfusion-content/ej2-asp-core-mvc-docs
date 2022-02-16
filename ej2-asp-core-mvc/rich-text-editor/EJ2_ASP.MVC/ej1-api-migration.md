---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Rich Text Editor control from Essential JS 1 to Essential JS 2.

## Accessibility

<!-- markdownlint-disable MD033 -->
<!-- markdownlint-disable MD038 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Keyboard Navigation | **Property:** AllowKeyboardNavigation <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").AllowKeyboardNavigation(true).Render();}` | No separate Property for enable/disable keyboard navigation.  Its enabled by default. |
| Localization | **Property:** Locale <br/> <br/>` @{Html.EJ().RichTextEditor("rteSample").Locale("en-US").Render();}` | **Property:** Locale <br/> <br/>`@Html.EJS().RichTextEditor("default").Locale("en-US").Render()` |
| RTL | **Property:** EnableRtl<br/> <br/>` @{Html.EJ().RichTextEditor("rteSample").EnableRTL(true).Render();}` | **Property:** EnableRtl <br/> <br/>`@Html.EJS().RichTextEditor("rtl").EnableRtl(true).Render()` |
| Key Config | Not Applicable | **Property:**  KeyConfig<br/> <br/>`@Html.EJS().RichTextEditor("default").KeyConfig((object)ViewBag.keyConfig).Render()` |
| Tab Key Navigation | **Property:** EnableTabKeyNavigation <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").EnableTabKeyNavigation(true).Render();}` | **Property:** EnableTabKey<br/> <br/>`@Html.EJS().RichTextEditor("default").EnableTabKey(true).Render()` |
| Key Down | **Event:**  KeyDown<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.KeyDown("onKeydown")).Render();}` | Not Applicable |
| Key Up | **Event:**  keyUp<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.keyUp("keyUp")).Render();}` | Not Applicable |

## Toolbar

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| showToolbar | **Property:**  ShowToolbar<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowToolbar(true).Render();}` | **Property:** Enable <br/> <br/>`@Html.EJS().RichTextEditor("types").Value((string)ViewBag.value).Height("720px").ToolbarSettings(e => e.Enable(true)).Render()` |
| Tools item | **Property:** Tools <br/> <br/>`List<String> lists = new List<string>() { "unorderedList", "orderedList" };` <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Tools(tool => tool.Lists(lists)).Render();}` | **Property:** Items<br/> <br/>`@Html.EJS().RichTextEditor("customtool").ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Tools-list | **Property:** ToolsList<br/> <br/>` @{    List<String> toolsList = new List<string>() { "style", "lists", "doAction", "links", "images" };`<br/> <br/>` @{Html.EJ().RichTextEditor("rteSample").ToolsList(toolsList).Render();}` | **Property:**  Items<br/> <br/>`@Html.EJS().RichTextEditor("customtool").ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Toolbar Overflow Mode | **Property:** ToolbarOverflowMode <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ToolbarOverflowMode(ToolbarOverflowMode.Inline).Render();}` | **Property:**  Type <br/> <br/>`1.Expand`<br/> <br/>` 2.MultiRow`<br/> <br/>`@Html.EJS().RichTextEditor("types").ToolbarSettings(e => e.Type(Syncfusion.EJ2.RichTextEditor.ToolbarType.Expand)).Render()` |
| Floating Toolbar | Not Applicable | **Property:**  EnableFloating <br/> <br/>`@Html.EJS().RichTextEditor("types").ToolbarSettings(e =>e.EnableFloating(true)).Render()`  |
| Floating Toolbar Offset | Not Applicable | **Property:**  FloatingToolbarOffset <br/> <br/>`@Html.EJS().RichTextEditor("types").ToolbarSettings(e =>e.EnableFloating(true)).FloatingToolbarOffset(50).Render()`  |
| Inline toolbar | Not Applicable | **Property:** InlineMode<br/> <br/>` @Html.EJS().RichTextEditor("defaultRTE").Value((string)ViewBag.value).InlineMode(e=>e.Enable(true).OnSelection(true)).ToolbarSettings(e => e.Items((object)ViewBag.items)).Render()` |
| Quick Toolbar | Not Applicable | **Property:**  Quicktoolbarsettings<br/> <br/>`1.image`<br/> <br/>`2.link`<br/> <br/>`3.table`<br/> <br/>`4.clipboard`<br/> <br/>` @Html.EJS().RichTextEditor("inline").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e =>e.Image((object)ViewBag.image)).Format(t=>t.Width("40px")).Value((string)ViewBag.value).Render()` |
| Enable Toolbar Item | **Method:** enableToolbarItem()<br/> <br/>`var rteObj = $("#rte ").data("ejRTE "); `<br/> <br/>`rteObj.enableToolbarItem()` | **Method:**  enableToolbarItem() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj.enableToolbarItem();` |
| Disable Toolbar Item | **Method:**  disableToolbarItem() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/><br/>`rteObj.disableToolbarItem()` | **Method:**  disableToolbarItem() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj.disableToolbarItem();` |
| Remove Toolbar Item | **Method:**  removeToolbarItem() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.removeToolbarItem()` | **Method:**  removeToolbarItem() <br/> <br/>` var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>` rteObj.removeToolbarItem()` |
| Toolbar Click | Not Applicable | **Event:** ToolbarClick <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarClick("onClick").Render()` |
| Show Full Screen | Not Applicable | **Method:**  showFullScreen()<br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>` rteObj. showFullScreen()` |

## Custom Formats and Fonts

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Format | **Property:**  Format <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Format(format).Render();}` | **Property:** Format <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").Format(t=>t.Width("70px").Default("Paragraph").Types("items")).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Font Size | **Property:** FontSize <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").FontSize(size).Render();}` | **Property:** FontSize<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").FontSize(t=>t.Width("70px").Default("Paragraph").Types("items")).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Font Family | **Property:** FontName<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").FontName(fontname).Render();}` | **Property:** FontFamily<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").FontFamily(t=>t.Width("70px").Default("Paragraph").Types("items")).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Show Font Option | **Property:** ShowFontOption<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowFontOption(true).Render();}` | **Property:** FontFamily<br/> <br/>`viewBag.fontFamily = new {default= "0", types = "items", width = "70px"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").FontFamily(f=>e.Items((object)ViewBag.fontFamily)).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |

## Custom Font Colors

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Font Color | **Property:** ColorCode <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ColorCode(colorCode).Render();}` | **Property:** FontColor<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").FontColor(t=>t.columns("10").default("'#fff).modeSwitcher(false)).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Background Color | Not Applicable | **Property:** BackgroundColor<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").BackgroundColor(t=>t.columns("10").Default("'#fff).ModeSwitcher(false).Mode("Palette")).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Color Palette  Columns | **Property:** ColorPaletteColumns <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ColorPaletteColumns(10).Render();}` | **Property:** BackgroundColor<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").BackgroundColor(b=>b.Columns(10)).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Color Palette Rows | **Property:** ColorPaletteRows <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ColorPaletteRows(6).Render();}` | Not Applicable |
| Color Picker Type | **Method:**  setColorPickerType () <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>` rteObj.setColorPickerType("picker")` | **Property:** ColorModeType <br/> <br/>` @Html.EJS().RichTextEditor("defaultRTE").BackgroundColor(b=>b.Mode("Palette")).ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |

## Link

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Link | Not Applicable | **Property:** CreateLink<br/> <br/>` viewBag.item = new[] {"CreateLink"}`<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Quick Toolbar | Not Applicable | **Property:** Link<br/> <br/>`viewBag.link = new [] {Open, Edit, UnLink}`<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e => e.Link((object)ViewBag.link)).Render()` |

## Image

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Image | Not Applicable | **Property:** Image <br/> <br/>` viewBag.item = new[] {"Image"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e =>  e.Items((object)ViewBag.items)).Render()` |
| Quick Toolbar | Not Applicable | **Property:** Image <br/> <br/>`viewBag.link = new [] {"Replace", "Align", "Caption", "Remove", "-", "InsertLink","OpenImageLink", "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e => e.Image((object)ViewBag.image)).Render()` |
| Image Setting | **Property:** Images<br/> <br/>` List<String> images = new List<string>() { "image" };` <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Tools(tool=>tool.Image(image)).Render();}` | **Property:** InsrtImageSettings <br/> <br/>`@Html.EJS().RichTextEditor("image").ToolbarSettings(e => e.Items((object)ViewBag.items)).InsertImageSettings(obj=>obj.Display("inline")).Value((string)ViewBag.value).Render()`  |

## Table

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Table | Not Applicable | **Property:** CreateTable<br/> <br/>` viewBag.item = new[] {"CreateTable"}` <br/> <br/>`@Html.EJS().RichTextEditor("table").ToolbarSettings(e => e.Items((object)ViewBag.items)).Render()` |
| Quick Toolbar | Not Applicable | **Property:** Table<br/> <br/>`viewBag.table = new [] {"TableHeader", "TableRows", "TableColumns", "BackgroundColor", "-", "TableRemove", "Alignments", "TableCellVerticalAlign", "Styles" }`<br/><br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e => e.Table((object)ViewBag.table)).Render()` |
| Table Setting | **Property:** TableColumns, TableRows<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").TableColumns(10).Render();}` <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").TableRows(10).Render();}`  | **Property:** TableSettings<br/> <br/>`@Html.EJS().RichTextEditor("image").ToolbarSettings(e => e.Items((object)ViewBag.items)).TableSettings(obj=>obj.width("80%")).Render()` |
| Custom table | **Property:** ShowCustomTable<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowCustomTable(true).Render();}` | Not Applicable |
| Insert Column | **Method:**  insertColumn([before],[cell])<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.insertColumn(true, "<td></td>")` | **Property:**  TableColumns <br/> <br/>` viewBag.table = new [] {"TableColumns"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e =>  e.Table((object)ViewBag.table)).Render()` |
| Insert Row | **Method:**  insertRow([before],[cell]) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.insertRow(true, "<tr></tr>")` | **Property:**  <br/> <br/>`TableRows viewBag.table = new [] {"TableRows"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e => e.Table((object)ViewBag.table)).Render()` |
| Remove Table | **Method:**  removeTable([table])<br/> <br/>` var rteObj = $("#rte").data("ejRTE ");` <br/> <br/>` rteObj.removeTable("table")` | **Property:**  TableRemove <br/> <br/>`viewBag.table = new [] {"TableRemove"}` <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).QuickToolbarSettings(e => e.Table((object)ViewBag.table)).Render()` |

## Counts

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Character Count | **Property:** ShowCharCount<br/><br/>`@{Html.EJ().RichTextEditor("rteSample").ShowCharCount(true).Render();}` | **Property:** ShowCharCount<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ToolbarSettings(e => e.Items((object)ViewBag.items)).ShowCharCount(true).Render()`  |
| Word Count | **Property:** ShowWordCount<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowWordCount(true).Render();}` | Not Applicable |
| Maximum Length | **Property:**  MaxLength <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").MaxLength(1000).Render();}` | **Property:** MaxLength<br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").MaxLength(1000).Render()` |

## IFrame

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Enable Iframe | By Default, enabled | **Property:** IframeSettings<br/> <br/>`@Html.EJS().RichTextEditor("iframe").Value((string)ViewBag.value).IframeSettings(iframeSettings => iframeSettings.Enable(true)).Render()`  |
| Attributes | **Property:** IFrameAttributes<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Width("800px").IFrameAttributes(new Dictionary<string, object> { { "style", "background-color:#e0ffff color:#6495ed;" } }).Render();}` | **Property:** Attributes <br/> <br/>`@Html.EJS().RichTextEditor("iframe").Value((string)ViewBag.value).Height("500").IframeSettings(iframeSettings => iframeSettings.Enable(true)).Render()` <br/> <br/>`<script>var iframeRTE; function created() {`<br/><br/>` iframeRTE = this; `<br/> <br/>`this.setProperties({`<br/> <br/>`iframeSettings: { enable: true, attributes: { readonly: "readonly"} } }, false); }`<br/><br/>`</script>` |
| Resource | **Property:** external-CSS<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ExternalCSS("/Content/Css/iframe-custom.css").Render();}` | **Property:** Attributes<br/> <br/>`@Html.EJS().RichTextEditor("iframe").Value((string)ViewBag.value).Height("500").IframeSettings(iframeSettings => iframeSettings.Enable(true)).Render()`<br/> <br/>`<script>`<br/> <br/> `var iframeRTE;`<br/> <br/>`function created() {`<br/> <br/>`iframeRTE = this;`<br/> <br/>`this.setProperties({  iframeSettings: { enable: true, resources: { styles: ["myStyle.css"]}}}, false);}`<br/> <br/>`</script>` |

## Editor Mode

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Editor Mode | Not Applicable | **Property:** EditorMode <br/> <br/>1.HTML<br/> <br/> 2.Markdown <br/> <br/>`@Html.EJS().RichTextEditor("types").Value((string)ViewBag.value).EditorMode(EditorMode.Html).Render()` |

## Undo

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Undo Stack Limit | **Property:** UndoStackLimit <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").UndoStackLimit(50).Render();}` | **Property:** UndoRedoSteps <br/> <br/>`@Html.EJS().RichTextEditor("types").Value((string)ViewBag.value).UndoRedoSteps(30).Render()` |
| Undo Redo Timer | Not Applicable | **Property:** UndoRedoTimer<br/> <br/>`@Html.EJS().RichTextEditor("types").Value((string)ViewBag.value).UndoRedoTimer(300).Render()` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Allow Editing | **Property:** AllowEditing <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").AllowEditing(true).Render();}` | **Property:** Readonly<br/> <br/>`@Html.EJS().RichTextEditor("default").Readonly(true).Render()` |
| Auto Focus | **Property:** AutoFocus <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").AutoFocus(true).Render();}` | Not Applicable |
| Auto Height | **Property:** AutoHeight <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").AutoHeight(true).Render();}` | Not Applicable  |
| Paste Clean Up | **Property:** paste-cleanup-settings <br/><br/>`@{Html.EJ().RichTextEditor("rteSample").PasteCleanupSettings(c=>c.CleanCSS(true).CleanElements(true).ListConversion(true).RemoveStyles(true)).Render();}` | Not Applicable |
| Css Class | **Property:** CssClass <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").CssClass("customstyles").Render();}` | **Property:** CssClass <br/> <br/>`@Html.EJS().RichTextEditor("default").CssClass("customStyle").Render()` |
| Enabled | **Property:** Enabled <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Enabled(true).Render();}` | **Property:** Enabled<br/> <br/>`@Html.EJS().RichTextEditor("default").Enabled(true).Render()` |
| Html Encode | **Property:** EnableHtmlEncode <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").EnableHtmlEncode(true).Render();}` | **Property:** EnableHtmlEncode<br/> <br/>`@Html.EJS().RichTextEditor("default").EnableHtmlEncode(true).Render()` |
| Persistence | **Property:** EnablePersistence <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").EnablePersistence(true).Render();}` | **Property:** EnablePersistence<br/> <br/>`@Html.EJS().RichTextEditor("default").EnablePersistence(true).Render()` |
| Resize | **Property:** EnableResize <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").EnableResize(true).Render();}` | Not Applicable |
| XHTML | **Property:** EnableXHTML <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").EnableXHTML(true).Render();}` | Not Applicable |
| Height | **Property:** Height <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Height("350px").Render();}` | **Property:** Height<br/> <br/>`@Html.EJS().RichTextEditor("default").Height("300px").Render()` |
| Width | **Property:** Width  <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Width("500px").Render();}` | **Property:** Width  <br/> <br/>`@Html.EJS().RichTextEditor("default").Width("500px").Render()` |
| Html Attributes | **Property:** HtmlAttributes <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Width("800px").HtmlAttributes(htmlattr).Render();}` | **Property:** HtmlAttributes<br/> <br/>`@Html.EJS().RichTextEditor("default").HtmlAttributes((object)ViewBag.attr)).Render()` |
| Is Responsive | **Property:** IsResponsive <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").IsResponsive(true).Render();}`   | No separate Property for responsive, provided default. |
| Maximum Height | **Property:** MaxHeight <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").MaxHeight("500px").Render();}` | Not Applicable |
| Maximum Width | **Property:** MaxWidth <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").MaxWidth("500px").Render();}` | Not Applicable |
| Minimum Height | **Property:** MinHeight <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").MinHeight("300px").Render();}` | Not Applicable |
| Minimum Width | **Property:** MinWidth <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").MinWidth("300px").Render();}` | Not Applicable |
| name | **Property:** name <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").name("commentBlog").Render();}` | Not Applicable |
| Clear All | **Property:** ShowClearAll <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowClearAll(true).Render();}` | Not Applicable |
| Clear Format | **Property:** ShowClearFormat <br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowClearFormat(true).Render();}` | No separate Property for clear Format. Its Provided in toolbar command.<br/> <br/>` viewBag.item = new[] {"ClearFormat"}` <br/> <br/>`@Html.EJS().RichTextEditor("default").ToolbarSettings(e => e.Items((object)ViewBag.item)).Render()`  |
| Place holder | Not Applicable | **Property:** Placeholder<br/> <br/>`@Html.EJS().RichTextEditor("default").Placeholder("Enter the text").Render()` |
| Context Menu | **Property:** ShowContextMenu<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowContextMenu(true).Render();}` | Not Applicable |
| Dimensions | **Property:** ShowDimensions<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowDimensions(true).Render();}` | Not Applicable |
| Show Footer | **Property:** ShowFooter<br/> <br/>`<@{Html.EJ().RichTextEditor("rteSample").ShowFooter(true).Render();}` | Not Applicable |
| Html Source | **Property:** ShowHtmlSource<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowHtmlSource(true).Render();}` | **Method:** showSourceCode() <br/> <br/>` var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>`rteObj.showSourceCode();` |
| Html Tag Info | **Property:** ShowHtmlTagInfo<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowHtmlTagInfo(true).Render();}` | Not Applicable |
| Rounded Corner | **Property:** ShowRoundedCorner<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ShowRoundedCorner(true).Render();}` | Not Applicable |
| Tooltip | **Property:** TooltipSettings<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").TooltipSettings(tooltip=>tooltip.ShowShadow(false)).Render();}` | Not Applicable |
| value | **Property:** Value<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").Value("The Rich Text Editor (RichTextEditor) control is an easy to render in client side.").Render();}` | **Property:** Value<br/> <br/>`@Html.EJS().RichTextEditor("types").Value((string)ViewBag.value).Height("720px").ToolbarSettings(e => { e.Enable(true); }).Render()`  |
| Validation Rules | **Property:** ValidationRules<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ValidationRules(new Dictionary<string, object> { { "required", "true" }, { "minWordCount", 15 } }).Render();}` | Achieved in sample level. <br/> <br/>[https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/validation.html#validation-rules](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/validation.html#validation-rules) |
| Validation Message | **Property:** ValidationMessage<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ValidationMessage(new Dictionary<string, object> { { "minWordCount", "A minimum of {10} words is required here" }, { "Required", "Please enter the content" } }).Render();}` | Achieved in sample level.<br/> <br/>[https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/validation.html#validation-message](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/validation.html#validation-message) |
| Zoom Step | **Property:** ZoomStep<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ZoomStep("0.5").Render();}` | Not Applicable |
| Disable | **Method:**  disable() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.disable()` | **Property:** Enabled<br/> <br/>`@Html.EJS().RichTextEditor("default").Enabled(false).Render()` |
| Enable | **Method:**  enable()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.enable()` | **Property:** Enabled<br/> <br/>`@Html.EJS().RichTextEditor("default").Enabled(true).Render()` |
| Focus | **Method:**  focus() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj. focus()` | **Method:**  focusIn() <br/> <br/>` var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj. focusIn();` |
| Focus Out | Not Applicable | **Method:**  focusOut() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj. focusOut();` |
| Command Status | **Method:** getCommandStatus() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.getCommandStatus()` | Not Applicable |
| Get Document | **Method:** getDocument()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.getDocument()` | Not Applicable |
| Get Html | **Method:** getHtml() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.getHtml()` | **Method:** getHtml() <br/> <br/>` var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj. getHtml();` |
| Get Text | **Method:** getText() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.getText()` | **Method:** getContent() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj. getContent();` |
| Get Selected Html | **Method:** getSelectedHtml()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.getSelectedHtml()` | **Method:** getSelection() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>` rteObj. getSelection();` |
| Get Range | Not Applicable | **Method:** getRange() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>`rteObj. getRange();` |
| Hide | **Method:** hide() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>` rteObj.hide()` | Not Applicable |
| Show | **Method:** show() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.show()` | Not Applicable |
| Insert Menu Option | **Method:** insertMenuOption() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.insertMenuOption( {newItem:"Show Table Details",targetItem:"Table Properties", insertType:("insertAfter"), menuType:{text:false,image:false,hyperlink:false,table:true},spriteCssClass:"e-rte-toolbar-icon tableProperties"} )` | Not Applicable |
| Paste Content | **Method:** pasteContent(html) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.pasteContent("Rich Text Editor content")` | Not Applicable |
| refresh | **Method:** refresh() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.refresh()` | **Method:** refresh() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];` <br/> <br/>` rteObj.refresh();` |
| Select All | **Method:** selectAll() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.selectAll()` | **Method:** selectAll() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>`rteObj.selectAll();` |
| Select Range | **Method:** selectRange() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.selectRange()` | **Method:** selectRange() <br/> <br/>` var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>`rteObj.selectRange();` |
| Set Html | **Method:** setHtml() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.setHtml("rictexteditor content")` | Not Applicable |
| Destroy | Not Applicable | **Method:** destroy() <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>`rteObj.destroy();` |
| Change | **Event:** Change<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.Change("onChange")).Render();}` | **Event:** Change <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").Change("onChange").Render()` |
| create | **Event:** Create<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.Create("onCreate")).Render();}` | **Event:** Created <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").Created("onCreated").Render()` |
| Context Menu Click | **Event:** ContextMenuClick<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.ContextMenuClick("onContextMenuClick")).Render();}` | Not Applicable |
| destroy | **Event:** Destroy<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.Destroy("onDestroy")).Render();}` | **Event:** Destroyed <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").Destroyed("onDestroyed").Render()` |
| Pre Render | **Event:** PreRender<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.PreRender("onPreRender")).Render();}` | Not Applicable |
| Select | **Event:** Select<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.Select("onSelect")).Render();}` | Not Applicable |
| Focus | Not Applicable | **Event:** Focus <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").Focus("onFocus").Render()` |

## Execute Command

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Execute Command | **Method:**  executeCommand(cmdName, args, [textnodeType]) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE "); `<br/> <br/>` rteObj.executeCommand("bold", true)` | **Method:** executeCommand(cmdName, value) <br/> <br/>`var rteObj = document.getElementById("richtexteditor").ej2_Instances[0];`<br/> <br/>`rteObj. executeCommand("Bold" );` |
| Execute events | **Event:** Execute<br/> <br/>`@{Html.EJ().RichTextEditor("rteSample").ClientSideEvents(evt => evt.Execute("onExecute")).Render();}` | **Event:** ActionComplete <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ActionComplete("onActionComplete").Render()` |
| Before Execute | Not Applicable | **Event:**  ActionBegin <br/> <br/>`@Html.EJS().RichTextEditor("defaultRTE").ActionBegin("onActionBegin").Render()` |