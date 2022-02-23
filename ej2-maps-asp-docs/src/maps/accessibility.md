# Accessibility

Maps provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications. The WAI-ARIA accessibility support is achieved through the attribute like `aria-label` in the SVG element. It helps to provide information about elements in a document for assistive technology. This attribute sets the text label with some default description for the following elements in Maps.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>Maps container</td>
<td>Specifies the Maps component.</td>
</tr>
<tr>
<td>Maps title</td>
<td>Specifies the title of the Maps.</td>
</tr>
<tr>
<td>Maps subtitle</td>
<td>Specifies the sub-title of the Maps.</td>
</tr>
<tr>
<td>Legend title</td>
<td>Specifies the title of legend in the Maps.</td>
</tr>
</table>

To change this default description, use the `Description` property available in `MapsCommonTitleSettings`, `MapsTitleSettings`, `MapsSubTitleSettings` and `Maps`. It helps the screen reader to read for an assistive purpose.