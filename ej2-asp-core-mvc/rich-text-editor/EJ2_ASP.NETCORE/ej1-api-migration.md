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
| Keyboard Navigation | **Property:** allow-keyboard-navigation <br/> <br/>`<ej-rte allow-keyboard-navigation="true"></ej-rte>` | No separate Property for enable/disable keyboard navigation.  Its enabled by default. |
| Localization | **Property:** locale <br/> <br/>` <ej-rte locale="en-US"></ej-rte>` | **Property:** locale <br/> <br/>` <ejs-richtexteditor locale="en-US"></ejs-richtexteditor>` |
| RTL | **Property:** enable-rtl<br/> <br/>` <ej-rte enable-rtl="true "></ej-rte>` | **Property:** enableRtl <br/> <br/>`<ejs- Rich Text Editor enableRtl="true" ></ejs- richtexteditor>` |
| Key Config | Not Applicable | **Property:**  keyConfig<br/> <br/>`<ejs-richtexteditor keyConfig="@ViewBag.keyConfig"></ejs-richtexteditor>` |
| Tab Key Navigation | **Property:** enable-tab-Key-navigation <br/> <br/>`<ej-rte enable-tab-Key-navigation ="true"></ej-rte>` | **Property:** enableTabKey<br/> <br/>`<ejs-richtexteditor enableTabKey = "true"></ejs-richtexteditor>` |
| Key Down | **Event:**  key-down<br/> <br/>`<ej-rte key-down="onKeydown"></ej-rte>` | Not Applicable |
| Key Up | **Event:**  key-up<br/><br/>`<ej-rte key-up="onKeyup"></ej-rte>` | Not Applicable |

## Toolbar

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| showToolbar | **Property:**  show-toolbar<br/> <br/>`<ej-rte show-toolbar="true"></ej-rte>` | **Property:** enable <br/> <br/>`<ejs-richtexteditor id="defaultRTE"><e-richtexteditor-toolbarsettings enable = "true"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Tools item | **Property:** tools <br/> <br/>`List<String> lists = new List<string>() { "unorderedList", "orderedList" };` <br/> <br/>`<ej-rte id="rteSample"><e-tools lists="lists"></e-tools></ej-rte>` | **Property:** items<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items="@ViewBag.items"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Tools-list | **Property:** tools-list<br/> <br/>` @{    List<String> toolsList = new List<string>() { "style", "lists", "doAction", "links", "images" };`<br/> <br/>` <ej-rte tools-list="toolsList"></ej-rte>` | **Property:**  items<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items="@ViewBag.items"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Toolbar Overflow Mode | **Property:** toolbar-overflow-mode <br/> <br/>`<ej-rte toolbar-overflow-mode="popup"></ej-rte>` | **Property:**  type <br/> <br/>`1.Expand`<br/> <br/>` 2.MultiRow`<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings type="Expand"></e-richtexteditor-toolbarsettings></ejs-richtexteditor><ejs-richtexteditor><e-richtexteditor-toolbarsettings type="MultiRow"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Floating Toolbar | Not Applicable | **Property:**  enableFloating <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings enableFloating = "true"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>`  |
| Floating Toolbar Offset | Not Applicable | **Property:**  floatingToolbarOffset <br/> <br/>`<ejs-richtexteditor floatingToolbarOffset = "50"><e-richtexteditor-toolbarsettings enableFloating = "true"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>`  |
| Inline toolbar | Not Applicable | **Property:** inlineMode<br/> <br/>`<ejs-richtexteditor ><e-richtexteditor-toolbarsettings items = "@ViewBag.items" ><e-richtexteditor-inlinemode enable="true" onSelection="true"></e-richtexteditor-inlinemode></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Quick Toolbar | Not Applicable | **Property:**  quicktoolbarsettings<br/> <br/>`1.image`<br/> <br/>`2.link`<br/> <br/>`3.table`<br/> <br/>`4.clipboard`<br/> <br/>` <ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items" ></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings image="@ViewBag.image"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Enable Toolbar Item | **Method:** enableToolbarItem()<br/> <br/>`var rteObj = $("#rte ").data("ejRTE "); `<br/> <br/>`rteObj.enableToolbarItem()` | **Method:**  enableToolbarItem() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj.enableToolbarItem();` |
| Disable Toolbar Item | **Method:**  disableToolbarItem() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/><br/>`rteObj.disableToolbarItem()` | **Method:**  disableToolbarItem() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj.disableToolbarItem();` |
| Remove Toolbar Item | **Method:**  removeToolbarItem() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.removeToolbarItem()` | **Method:**  removeToolbarItem() <br/> <br/>` var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>` rteObj.removeToolbarItem()` |
| Toolbar Click | Not Applicable | **Event:**  toolbar-click <br/> <br/>`<ejs-richtexteditor toolbarClick= "onToolbarClick"></ejs-richtexteditor>` |
| Show Full Screen | Not Applicable | **Method:**  showFullScreen()<br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>` rteObj. showFullScreen()` |

## Custom Formats and Fonts

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Format | **Property:**  format <br/> <br/>`<ej-rte format="viewBag.format"></ej-rte>` | **Property:** format <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-format default="pPragraph" width="70px" types="items"></e-richtexteditor-format><e-richtexteditor-toolbarsettings items = "@ViewBag.items"><e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Font Size | **Property:**  font-size <br/> <br/>`<ej-rte font-size="viewBag.fontSize"></ej-rte>` | **Property:** fontSize<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-fontsize width="40px" default="10", types="items"></e-richtexteditor-fontsize><e-richtexteditor-toolbarsettings items = "@ViewBag.items" ></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Font Family | **Property:** font-name<br/> <br/>`<ej-rte font-name="viewBag.fontName"></ej-rte>` | **Property:** fontFamily<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-fontfamily width="100px" default="0" types="items"></e-richtexteditor-fontfamily><e-richtexteditor-toolbarsettings items = "@ViewBag.items" ></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Show Font Option | **Property:** show-font-option<br/> <br/>`<ej-rte show-font-option = "true"></ej-rte>` | **Property:** fontFamily<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-fontfamily width="70px" default="0", types="items"></e-richtexteditor-fontfamily><e-richtexteditor-toolbarsettings items = "@ViewBag.items" ></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |

## Custom Font Colors

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Font Color | **Property:** color-code <br/> <br/>`<ej-rte color-code="viewBag.colorCode"></ej-rte>` | **Property:** fontColor<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-fontcolor modeSwitcher="true" default="#fff"></e-richtexteditor-fontcolor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Background Color | Not Applicable | **Property:** BackgroundColor<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-backgroundcolor modeSwitcher="true" default= "#fff" mode= "Palette" columns="10" ></e-richtexteditor-backgroundcolor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Color Palette  Columns | **Property:** color-code <br/> <br/>`<ej-rte color-palette-columns="10"></ej-rte>` | **Property:** BackgroundColor<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-backgroundcolor columns="10" ></e-richtexteditor-backgroundcolor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Color Palette Rows | **Property:** color-palette-rows <br/> <br/>`<ej-rte color-palette-rows="6"></ej-rte>` | Not Applicable |
| Color Picker Type | **Method:**  setColorPickerType () <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>` rteObj.setColorPickerType("picker")` | **Property:** Mode <br/> <br/>` <ejs-richtexteditor ><e-richtexteditor-backgroundcolor mode="Palette" ></e-richtexteditor-backgroundcolor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |

## Link

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Link | Not Applicable | **Property:** CreateLink<br/> <br/>` viewBag.item = new[] {"CreateLink"}`<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Quick Toolbar | Not Applicable | **Property:** link<br/> <br/>`viewBag.link = new [] {Open, Edit, UnLink}`<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings link="@ViewBag.link"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |

## Image

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Image | Not Applicable | **Property:** Image <br/> <br/>` viewBag.item = new[] {"Image"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings tems="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Quick Toolbar | Not Applicable | **Property:** image <br/> <br/>`viewBag.link = new [] {"Replace", "Align", "Caption", "Remove", "-", "InsertLink","OpenImageLink", "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings image="@ViewBag.image"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Image Setting | **Property:** Images<br/> <br/>` List<String> images = new List<string>() { "image" };` <br/> <br/>`<ej-rte><e-tools images="images"></e-tools></ej-rte>` | **Property:** insrtImageSettings <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-insertimagesettings display="inline"></e-richtexteditor-insertimagesettings><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings image="@ViewBag.image"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>`  |

## Table

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Table | Not Applicable | **Property:** CreateTable<br/> <br/>` viewBag.item = new[] {"CreateTable"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>` |
| Quick Toolbar | Not Applicable | **Property:** table<br/> <br/>`viewBag.table = new [] {"TableHeader", "TableRows", "TableColumns", "BackgroundColor", "-", "TableRemove", "Alignments", "TableCellVerticalAlign", "Styles" }`<br/><br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings table="@ViewBag.table"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Table Setting | **Property:** table-columns, table-rows<br/> <br/>`<ej-rte table-columns="10"></ej-rte>` <br/> <br/>`<ej-rte table-rows = "10"></ej-rte>`  | **Property:** tableSettings<br/> <br/>`<ejs-richtexteditor><e-richtexteditor-tableSettings width="80%"></e-richtexteditor-tableSettings><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings table="@ViewBag.table"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Custom table | **Property:** show-custom-table<br/> <br/>`<ej-rte show-custom-table="true"></ej-rte>` | Not Applicable |
| Insert Column | **Method:**  insertColumn([before],[cell])<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.insertColumn(true, "<td></td>")` | **Property:**  TableColumns <br/> <br/>` viewBag.table = new [] {"TableColumns"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings table ="@ViewBag.table "></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Insert Row | **Method:**  insertRow([before],[cell]) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.insertRow(true, "<tr></tr>")` | **Property:**  <br/> <br/>`TableRows viewBag.table = new [] {"TableRows"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings table ="@ViewBag.table"></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |
| Remove Table | **Method:**  removeTable([table])<br/> <br/>` var rteObj = $("#rte").data("ejRTE ");` <br/> <br/>` rteObj.removeTable("table")` | **Property:**  TableRemove <br/> <br/>`viewBag.table = new [] {"TableRemove"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items = "@ViewBag.items"></e-richtexteditor-toolbarsettings><e-richtexteditor-quicktoolbarsettings table ="@ViewBag.table "></e-richtexteditor-quicktoolbarsettings></ejs-richtexteditor>` |

## Counts

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Character Count | **Property:** show-char-count<br/><br/>`<ej-rte show-char-count="true"></ej-rte>` | **Property:** showCharCount<br/> <br/>`<ejs-richtexteditor showCharCount = "true"><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>`  |
| Word Count | **Property:** show-word-count<br/> <br/>`<ej-rte show-word-count="true"></ej-rte>` | Not Applicable |
| Maximum Length | **Property:**  max-length <br/> <br/>`<ej-rte max-length ="1000"></ej-rte>` | **Property:** maxLength<br/> <br/>` <ejs-richtexteditor maxLength = "1000"></ejs-richtexteditor>` |

## Iframe

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Enable Iframe | By Default, enabled | **Property:** iframeSettings<br/> <br/>`<ejs-richtexteditor id="iframe" value="@ViewBag.value"><e-richtexteditor-iframesettings enable="true"></e-richtexteditor-iframesettings></ejs-richtexteditor>`  |
| Attributes | **Property:** iframe-attributes<br/> <br/>`<ej-rte iframe-attributes="viewBag.attribute"></ej-rte>` | **Property:** attributes <br/> <br/>`<ejs-richtexteditor id="iframe" value="@ViewBag.value"><e-richtexteditor-iframesettings enable="true"></e-richtexteditor-iframesettings></ejs-richtexteditor>` <br/> <br/>`<script>var iframeRTE; function created() {`<br/><br/>` iframeRTE = this; `<br/> <br/>`this.setProperties({`<br/> <br/>`iframeSettings: { enable: true, attributes: { readonly: "readonly"} } }, false); }`<br/><br/>`</script>` |
| Resource | **Property:** external-CSS<br/> <br/>`<ej-rte external-CSS ="defult.css"></ej-rte>` | **Property:** attributes<br/> <br/>`<ejs-richtexteditor id="iframe" value="@ViewBag.value"><e-richtexteditor-iframesettings enable="true"></e-richtexteditor-iframesettings></ejs-richtexteditor>`<br/> <br/>`<script>`<br/> <br/> `var iframeRTE;`<br/> <br/>`function created() {`<br/> <br/>`iframeRTE = this;`<br/> <br/>`this.setProperties({  iframeSettings: { enable: true, resources: { styles: ["myStyle.css"]}}}, false);}`<br/> <br/>`</script>` |

## Editor Mode

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Editor Mode | Not Applicable | **Property:** editorMode <br/> <br/>1.HTML<br/> <br/> 2.Markdown <br/> <br/>`<ejs-richtexteditor editorMode = "HTML"></ejs-richtexteditor>` |

## Undo

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Undo Stack Limit | **Property:** undo-stack-limit <br/> <br/>`<ej-rte undo-stack-limit ="50"></ej-rte>` | **Property:** undoRedoSteps <br/> <br/>`<ejs-richtexteditor undoRedoSteps = "30"></ejs-richtexteditor>` |
| Undo Redo Timer | Not Applicable | **Property:** undoRedoTimer<br/> <br/>`<ejs-richtexteditor undoRedoTimer = "300"></ejs-richtexteditor>` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Allow Editing | **Property:** allow-editing <br/> <br/>`<ej-rte allow-editing="true"></ej-rte>` | **Property:** readonly<br/> <br/>`<ejs-richtexteditor readonly = "true"></ejs-richtexteditor>` |
| Auto Focus | **Property:** auto-focus <br/> <br/>`<ej-rte auto-focus="false"></ej-rte>` | Not Applicable |
| Auto Height | **Property:** auto-height <br/> <br/>`<ej-rte auto-height="true"></ej-rte>` | Not Applicable  |
| Paste Clean Up | **Property:** paste-cleanup-settings <br/><br/>`<ej-rte><e-paste-cleanup-settings clean-css="true" list-conversion="true" remove-styles="true" clean-elements="true" /></ej-rte>` | Not Applicable |
| Css Class | **Property:** css-class <br/> <br/>`<ej-rte css-class="customStyle"></ej-rte>` | **Property:** cssClass <br/> <br/>`<ejs-richtexteditor cssClass = "customStyle"></ejs-richtexteditor>` |
| Enabled | **Property:** enabled <br/> <br/>`<ej-rte enabled="true"></ej-rte>` | **Property:** enabled<br/> <br/>`<ejs-richtexteditor enabled = "true"></ejs-richtexteditor>` |
| Html Encode | **Property:** enable-html-encode <br/> <br/>`<ej-rte enable-html-encode="true"></ej-rte>` | **Property:** enableHtmlEncode<br/> <br/>`<ejs-richtexteditor enableHtmlEncode = "true"></ejs-richtexteditor>` |
| Persistence | **Property:** enable-persistence <br/> <br/>`<ej-rte enable-persistence ="true"></ej-rte>` | **Property:** enablePersistence<br/> <br/>`<ejs-richtexteditor enablePersistence = "true"></ejs-richtexteditor>` |
| Resize | **Property:** enable-resize <br/> <br/>`<ej-rte enable-resize ="true"></ej-rte>` | Not Applicable |
| XHTML | **Property:** enable-XHTML <br/> <br/>`<ej-rte enable-XHTML ="true"></ej-rte>` | Not Applicable |
| Height | **Property:** height <br/> <br/>`<ej-rte height="350px"></ej-rte>` | **Property:** height<br/> <br/>`<ejs-richtexteditor height = "350px"></ejs-richtexteditor>` |
| Width | **Property:** width  <br/> <br/>`<ej-rte width="500px"></ej-rte>` | **Property:** width  <br/> <br/>`<ejs-richtexteditor width = "500px"></ejs-richtexteditor>` |
| Html Attributes | **Property:** html-attributes <br/> <br/>`<ej-rte html-attributes="viewBag.htmlAttr"></ej-rte>` | **Property:** htmlAttributes<br/> <br/>`<ejs-richtexteditor htmlAttributes = "viewBag.htmlAttr"></ejs-richtexteditor>` |
| Is Responsive | **Property:** is-responsive <br/> <br/>`<ej-rte is-responsive ="true"></ej-rte>`   | No separate Property for responsive, provided default. |
| Maximum Height | **Property:** max-height <br/> <br/>`<ej-rte max-height="500px"></ej-rte>` | Not Applicable |
| Maximum Width | **Property:** max-width <br/> <br/>`<ej-rte max-width="700px"></ej-rte>` | Not Applicable |
| Minimum Height | **Property:** min-height <br/> <br/>`<ej-rte min-height="300px"></ej-rte>` | Not Applicable |
| Minimum Width | **Property:** min-width <br/> <br/>`<ej-rte min-width ="300px"></ej-rte>` | Not Applicable |
| name | **Property:** name <br/> <br/>`<ej-rte name = "commentBlog"></ej-rte>` | Not Applicable |
| Clear All | **Property:** show-clear-all <br/> <br/>`<ej-rte show-clear-all = "true"></ej-rte>` | Not Applicable |
| Clear Format | **Property:** show-clear-format <br/> <br/>`<ej-rte show-clear-format = "true"></ej-rte>` | No separate Property for clear Format. Its Provided in toolbar command.<br/> <br/>` viewBag.item = new[] {"ClearFormat"}` <br/> <br/>`<ejs-richtexteditor><e-richtexteditor-toolbarsettings items="viewBag.item"></e-richtexteditor-toolbarsettings></ejs-richtexteditor>`  |
| Place holder | Not Applicable | **Property:** placeholder<br/> <br/>`<ejs-richtexteditor placeholder="Enter Text"></ejs-richtexteditor>` |
| Context Menu | **Property:** show-context-menu<br/> <br/>`<ej-rte show-context-menu = "true"></ej-rte>` | Not Applicable |
| Dimensions | **Property:** show-dimensions<br/> <br/>`<ej-rte show-dimensions = "true"></ej-rte>` | Not Applicable |
| Show Footer | **Property:** show-footer<br/> <br/>`<ej-rte show-footer = "true"></ej-rte>` | Not Applicable |
| Html Source | **Property:** show-html-source<br/> <br/>`<ej-rte show-html-source = "true"></ej-rte>` | **Method:** showSourceCode() <br/> <br/>` var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>`rteObj.showSourceCode();` |
| Html Tag Info | **Property:** show-html-tag-info<br/> <br/>`<ej-rte show-html-tag-info = "true"></ej-rte>` | Not Applicable |
| Rounded Corner | **Property:** show-rounded-corner<br/> <br/>`<ej-rte show-rounded-corner = "true"></ej-rte>` | Not Applicable |
| Tooltip | **Property:** tooltip-settings<br/> <br/>`<ej-rte tooltip-settings = "viewBag.tooltip"></ej-rte>` | Not Applicable |
| value | **Property:** value<br/> <br/>`<ej-rte value = "ViewBag.value"></ej-rte>` | **Property:** value<br/> <br/>`<ejs-richtexteditor value="ViewBag.value"></ejs-richtexteditor>`  |
| Validation Rules | **Property:** validation-rules<br/> <br/>`<ej-rte validation-rules= "ViewBag.validation"></ej-rte>` | Achieved in sample level. <br/> <br/>[https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/validation.html#validation-rules](https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/validation.html#validation-rules) |
| Validation Message | **Property:** validation-message<br/> <br/>`<ej-rte validation-message= "ViewBag.validation ></ej-rte>` | Achieved in sample level.<br/> <br/>[https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/validation.html#validation-message](https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/validation.html#validation-message) |
| Zoom Step | **Property:** zoom-step<br/> <br/>`<ej-rte zoom-step = "0.5"></ej-rte>` | Not Applicable |
| Disable | **Method:**  disable() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.disable()` | **Property:** enabled<br/> <br/>`<ejs-richtexteditor enabled = "false"></ejs-richtexteditor>` |
| Enable | **Method:**  enable()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.enable()` | **Property:** enabled<br/> <br/>`<ejs-richtexteditor enabled = "true"></ejs-richtexteditor>` |
| Focus | **Method:**  focus() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj. focus()` | **Method:**  focusIn() <br/> <br/>` var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj. focusIn();` |
| Focus Out | Not Applicable | **Method:**  focusOut() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj. focusOut();` |
| Command Status | **Method:** getCommandStatus() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.getCommandStatus()` | Not Applicable |
| Get Document | **Method:** getDocument()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.getDocument()` | Not Applicable |
| Get Html | **Method:** getHtml() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.getHtml()` | **Method:** getHtml() <br/> <br/>` var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj. getHtml();` |
| Get Text | **Method:** getText() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.getText()` | **Method:** getContent() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj. getContent();` |
| Get Selected Html | **Method:** getSelectedHtml()<br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.getSelectedHtml()` | **Method:** getSelection() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>` rteObj. getSelection();` |
| Get Range | Not Applicable | **Method:** getRange() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>`rteObj. getRange();` |
| Hide | **Method:** hide() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>` rteObj.hide()` | Not Applicable |
| Show | **Method:** show() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.show()` | Not Applicable |
| Insert Menu Option | **Method:** insertMenuOption() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.insertMenuOption( {newItem:"Show Table Details",targetItem:"Table Properties", insertType:("insertAfter"), menuType:{text:false,image:false,hyperlink:false,table:true},spriteCssClass:"e-rte-toolbar-icon tableProperties"} )` | Not Applicable |
| Paste Content | **Method:** pasteContent(html) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.pasteContent("Rich Text Editor content")` | Not Applicable |
| refresh | **Method:** refresh() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.refresh()` | **Method:** refresh() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];` <br/> <br/>` rteObj.refresh();` |
| Select All | **Method:** selectAll() <br/> <br/>` var rteObj = $("#rte ").data("ejRTE ");` <br/> <br/>`rteObj.selectAll()` | **Method:** selectAll() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>`rteObj.selectAll();` |
| Select Range | **Method:** selectRange() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>` rteObj.selectRange()` | **Method:** selectRange() <br/> <br/>` var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>`rteObj.selectRange();` |
| Set Html | **Method:** setHtml() <br/> <br/>`var rteObj = $("#rte ").data("ejRTE ");`<br/> <br/>`rteObj.setHtml("rictexteditor content")` | Not Applicable |
| Destroy | Not Applicable | **Method:** destroy() <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>`rteObj.destroy();` |
| Change | **Event:** change<br/> <br/>`<ej-rte change = "onChange"></ej-rte>` | **Event:** change <br/> <br/>`<ejs-richtexteditor change = "onChange"></ejs-richtexteditor>` |
| create | **Event:** create<br/> <br/>`<ej-rte create = "onCreate"></ej-rte>` | **Event:** created <br/> <br/>`<ejs-richtexteditor change = "onCreated"></ejs-richtexteditor>` |
| Context Menu Click | **Event:** contextMenuClick<br/> <br/>`<ej-rte contextMenuClick = "onClick"></ej-rte>` | Not Applicable |
| destroy | **Event:** destroy<br/> <br/>`<ej-rte destroy = "onDestroy"></ej-rte>` | **Event:** destroyed <br/> <br/>`<ejs-richtexteditor destroyed = "onDestroy"></ejs-richtexteditor>` |
| Pre Render | **Event:** preRender<br/> <br/>`<ej-rte preRender = "onPreRender"></ej-rte>` | Not Applicable |
| Select | **Event:** select<br/> <br/>`<ej-rte select = "onSelect"></ej-rte>` | Not Applicable |
| Focus | Not Applicable | **Event:** focus <br/> <br/>`<ejs-richtexteditor focus = "onFocus"></ejs-richtexteditor>` |

## Execute Command

<!-- markdownlint-disable MD033 -->
| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Execute Command | **Method:**  executeCommand(cmdName, args, [textnodeType]) <br/> <br/>`var rteObj = $("#rte ").data("ejRTE "); `<br/> <br/>` rteObj.executeCommand("bold", true)` | **Method:** executeCommand(cmdName, value) <br/> <br/>`var rteObj = document.getElementById('richtexteditor').ej2_Instances[0];`<br/> <br/>`rteObj. executeCommand("Bold" );` |
| Execute events | **Event:** execute<br/> <br/>`<ej-rte execute = "onExecute"></ej-rte>` | **Event:** actionComplete <br/> <br/>`<ejs-richtexteditor actionComplete = "onActionComplete"></ejs-richtexteditor>` |
| Before Execute | Not Applicable | **Event:**  actionBegin <br/> <br/>`<ejs-richtexteditor actionBegin = "onActionBegin"></ejs-richtexteditor>` |