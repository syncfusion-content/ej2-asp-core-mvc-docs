---
layout: post
title: Accessibility in Syncfusion ##Platform_Name## control
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility support with ADA compliance in ASP.NET Core controls

All the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls follow the WAI-ARIA accessibility standard by default. This enables to build accessible web applications, which are fully navigable by users with disabilities.

## Accessibility overview

Accessibility in components refers to the practice of designing and building user interface elements in a way that makes them accessible to users with disabilities. This can include a variety of things, such as making sure that text is high-contrast and easy to read, providing alternative text for images, and designing controls and interactions that can be used with a keyboard or assistive technology.

## Accessibility standards

The component is said to be accessible when it is constructed in accordance with certain standards that are required to make it accessible.

The accessibility of the components consists of the following standards and aspects:

[ADA](https://www.ada.gov) - A law to ensure that people with disabilities have the same opportunities and access as people without disabilities.

[WCAG 2.2](https://www.w3.org/WAI/standards-guidelines/wcag/) - The Web Content Accessibility Guidelines (WCAG) provide guidelines developed by the World Wide Web Consortium (W3C) to ensure web content is accessible to people with disabilities. WCAG 2.2 establishes a framework of accessibility principles and their associated success criteria. The level of accessibility conformance achieved by a web application is determined by the extent to which it meets these success criteria, categorized into three levels: A, AA, and AAA.

[Section 508](https://www.section508.gov/) - It is a set of guidelines for making electronic and information technology (EIT) accessible to people with disabilities. These standards apply to federal agencies in the United States, and they are based on the Web Content Accessibility Guidelines (WCAG).

[WAI-ARIA](https://www.w3.org/WAI/about/groups/ariawg/) - WAI-ARIA stands for “Web Accessibility Initiative - Accessible Rich Internet Applications.” It is a set of technical specifications and guidelines developed by the World Wide Web Consortium (W3C) as part of the Web Accessibility Initiative (WAI). WAI-ARIA is designed to enhance the accessibility of dynamic web content, particularly web applications and rich internet applications (RIAs), for people with disabilities. WAI-ARIA provides a set of roles, states, and properties that can be added to HTML elements to provide additional context and information about the purpose and behavior of those elements. This can help assistive technologies better understand and interpret web content and interact with web applications.

[Keyboard navigation](https://www.w3.org/TR/WCAG22/#keyboard-accessible) - It refers to the ability to use a keyboard to interact with and navigate through a user interface. It is an important aspect of web accessibility, as it allows people who cannot use a mouse or other pointing device to access and use web content and applications.

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls adhere to these established standards.

## Accessibility compliance

The accessibility support provided by Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls is based on a collection of methodologies for adhering to and [applying recognized standards and technical specifications](#accessibility-standards) to ensure an intuitive experience for people with disabilities.

There are several methodologies of accessibility validation that can be performed on the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls, such as:

The [WAI-ARIA patterns](https://www.w3.org/WAI/ARIA/apg/patterns/) are followed by the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls to enable appreciable accessibility.

Each ASP.NET Core controls is subjected to manual testing with a screen reader and also automated test cases to ensure the component’s required attributes.

Attributes are allocated and updated correctly during interaction as well. Each component has been assigned a distinct `Role` attribute and its own set of ARIA attributes defined by the [WCAG 2.2](https://www.w3.org/TR/WCAG22/) specification.

In addition to the methodologies mentioned above, Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are constructed to support the following accessibility aspects.

### Screen reader support

A screen reader allows people who are blind or visually impaired to use a computer by reading aloud the text that is displayed on the screen. Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls followed the [WAI-ARIA](https://www.w3.org/WAI/about/groups/ariawg/) standards to work properly in the screen readers such as [Narrator](https://support.microsoft.com/en-US/accessibility/windows/narrator/complete-guide-to-narrator) for Windows and [Embedded VoiceOver](https://support.apple.com/en-in/guide/voiceover/vo2706/mac) for MAC.

### Right-To-Left support

Right-to-Left (RTL) support allows applications to effectively communicate with users who use languages that are written from right to left, such as Arabic, Hebrew, etc. Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls support the Right-to-Left feature. Refer to the [Right-to-Left documentation](https://ej2.syncfusion.com/aspnetcore/documentation/common/right-to-left) to learn more about this support.

### Color contrast

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls come equipped with [predefined themes](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) that guarantee the presence of satisfactory color contrast, benefiting individuals with visual impairments.

### Mobile device support

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are more user-friendly and accessible to individuals using mobile devices, including those with disabilities. These are designed to be responsive, adaptable to various screen sizes and orientations, and touch-friendly.

### Keyboard navigation support

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls support keyboard navigation, allowing users who rely on alternate methods to effortlessly navigate and interact with the component.

## Ensuring accessibility

Ensuring the accessibility of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls is crucial for making the product inclusive and user-friendly for individuals with disabilities. This process involves various types of accessibility testing, including:

* **Automated testing**: The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools.

* **Manual testing**: This type of testing involves manually evaluating the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls. During manual accessibility testing, testers will ensure accessibility using the screen readers such as [Narrator](https://support.microsoft.com/en-US/accessibility/windows/narrator/complete-guide-to-narrator) for Windows and [Embedded VoiceOver](https://support.apple.com/en-in/guide/voiceover/vo2706/mac) for MAC.

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls will keep improving when there is anything required. It also involves client feedback to make the component more accessible.

## Voluntary Product Accessibility Template

The [Voluntary Product Accessibility Template (VPAT)](https://www.itic.org/policy/accessibility/vpat) provides a structured format to document how information and communication technology (ICT) products and services comply with accessibility standards. This template helps organizations clearly and effectively communicate their conformance with standards such as **Section 508**, **WCAG 2.2**, and **EN 301 549**.

[Download the Latest VPAT Document](https://www.itic.org/dotAsset/0d397438-611d-47da-861a-be9ee508da51.docx)

To review the accessibility conformance of Syncfusion products, you can download the latest version of the **Syncfusion VPAT document** here: [VPAT Document](https://ej2.syncfusion.com/accessibility/Syncfusion-VPAT2.5.docx)

This document provides detailed information on how Syncfusion products meet accessibility requirements, ensuring they are inclusive and usable for all individuals, including those with disabilities.

## Accessibility support for specific components

Syncfusion ASP.NET Core components are designed to ensure compliance with key accessibility standards, including **Section 508**, **WAI-ARIA**, **WCAG 2.2**, and **keyboard navigation**. Below, you’ll find control-specific documentation that provides detailed guidance on how each control meets these standards.
<style>
#table
{
width: 100%;
line-height: 2 !important;
}

#table th {
    border-bottom:1px solid #dedede !important;
    font-weight: bold;
}

#table tr
{
border:1px solid #dedede !important;
}

#table td
{
border:0 !important;
vertical-align: top;
}
</style>

<table id="table">
    <thead>
        <tr>
            <th>Component</th>
            <th>Section 508</th>
            <th>WCAG 2.2</th>
            <th>Keyboard Navigation</th>
            <th>Accessibility Documentation</th>
        </tr>
    </thead>
<tbody>
    <tr>
        <td>DataGrid</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/grid/accessibility" aria-label="Grid Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Pivot Table</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/accessibility" aria-label="Pivot Table Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Tree Grid</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/accessibility" aria-label="Tree Grid Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>In-place Editor</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/in-place-editor/accessibility" aria-label="In-place Editor Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>RichTextEditor</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://help.syncfusion.com/rich-text-editor-sdk/asp-net-core/rich-text-editor/accessibility" aria-label="RichTextEditor Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>MarkdownEditor</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/markdown-editor/accessibility" aria-label="MarkdownEditor Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Mention</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/mention/accessibility" aria-label="Mention Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>MultiSelect</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/multi-select/accessibility" aria-label="MultiSelect Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>MultiColumn ComboBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/multicolumn-combobox/accessibility" aria-label="MultiColumn ComboBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>OTP Input</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/otp-input/accessibility" aria-label="OTP Input Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>AIAssistView</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/ai-assistview/accessibility" aria-label="AIAssistView Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>ChatUI</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/chart/accessibility" aria-label="ChatUI Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Image Editor</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/image-editor/accessibility" aria-label="Image Editor Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Dialog</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/dialog/accessibility" aria-label="Dialog Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>ListBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/list-box/accessibility" aria-label="ListBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>ListView</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/listview/accessibility" aria-label="ListView Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Tooltip</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/tooltip/accessibility" aria-label="Tooltip Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Splitter</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/splitter/accessibility" aria-label="Splitter Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Dashboard Layout</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/dashboard-layout/accessibility" aria-label="Dashboard Layout Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Accumulation Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/accumulation-chart/accessibility" aria-label="Accumulation Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Charts</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/chart/accessibility" aria-label="Charts Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Stock Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/stock-chart/accessibility" aria-label="Stock Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Circular Gauge</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/circular-gauge/accessibility" aria-label="Circular Gauge Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Diagram</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://help.syncfusion.com/diagram-sdk/asp-net-core/accessibility" aria-label="Diagram Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>HeatMap Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/heatmap-chart/accessibility" aria-label="HeatMap Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Linear Gauge</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/linear-gauge/accessibility" aria-label="Linear Gauge Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Maps</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/maps/accessibility" aria-label="Maps Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Range Selector</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/range-navigator/accessibility" aria-label="Range Selector Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Smith Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/smithchart/accessibility" aria-label="Smith Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Sparkline Charts</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/sparkline/accessibility" aria-label="Sparkline Charts Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>TreeMap</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/treemap/accessibility" aria-label="TreeMap Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Bullet Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/bullet-chart/accessibility" aria-label="Bullet Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Kanban</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://help.syncfusion.com/gantt-sdk/asp-net-core/kanban/accessiblility" aria-label="Kanban Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/button/accessibility" aria-label="Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Button Group</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/button-group/accessibility" aria-label="Button Group Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>DropdownList</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-button/accessibility" aria-label="DropdownList Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>DropdownButton</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-button/accessibility" aria-label="DropdownButton Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Progress Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/progress-button/accessibility" aria-label="Progress Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Split Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/split-button/accessibility" aria-label="Split Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Chips</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/chips/accessibility" aria-label="Chips Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Floating Action Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/floating-action-button/accessibility" aria-label="Floating Action Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Speed Dial</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/speeddial/accessibility" aria-label="Speed Dial Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Calendar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/calendar/accessibility" aria-label="Calendar Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>DatePicker</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/datepicker/accessibility" aria-label="DatePicker Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>DateRangePicker</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/daterangepicker/accessibility" aria-label="DateRangePicker Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>DateTime Picker</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/datetimepicker/accessibility" aria-label="DateTime Picker Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>TimePicker</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/timepicker/accessibility" aria-label="TimePicker Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Gantt Chart</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/accessibility" aria-label="Gantt Chart Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Schedule</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://help.syncfusion.com/scheduler-sdk/asp-net-core/schedule/accessibility" aria-label="Schedule Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>SpeechToText</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/accessibility" aria-label="SpeechToText Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Timeline</td>
        <td>Yes</td>
        <td>AA</td>
        <td>N/A</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/timeline/accessibility" aria-label="Timeline Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>TextBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/textbox/accessibility" aria-label="TextBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Masked TextBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/maskedtextbox/accessibility" aria-label="Masked TextBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Numeric TextBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/numerictextbox/accessibility" aria-label="Numeric TextBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Radio Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/radio-button/accessibility" aria-label="Radio Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>CheckBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/check-box/accessibility" aria-label="CheckBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Color Picker</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/color-picker/accessibility" aria-label="Color Picker Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>ComboBox</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/combo-box/accessibility" aria-label="ComboBox Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>File Upload</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/uploader/wai-aria-accessibility" aria-label="File Upload Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Range Slider</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/range-slider/accessibility" aria-label="Range Slider Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Toggle Switch Button</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/switch/accessibility" aria-label="Toggle Switch Button Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Signature</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/signature/accessibility" aria-label="Signature Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Rating</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/rating/accessibility" aria-label="Rating Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Query Builder</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/query-builder/accessibility" aria-label="Query Builder Accessibility Documentation">Documentation</a></td>
    </tr> 
    <tr>
        <td>Accordion</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/accordion/accessibility" aria-label="Accordion Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>AutoComplete</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/auto-complete/accessibility" aria-label="AutoComplete Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>AppBar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/appbar/accessibility" aria-label="AppBar Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Breadcrumb</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/breadcrumb/accessibility" aria-label="Breadcrumb Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Carousel</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/carousel/accessibility" aria-label="Carousel Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Context Menu</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/context-menu/accessibility" aria-label="Context Menu Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Menu Bar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/menu/accessibility" aria-label="Menu Bar Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Sidebar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td>---</td>
    </tr>
    <tr>
        <td>Tabs</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/tab/accessibility" aria-label="Tabs Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Toolbar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/toolbar/accessibility" aria-label="Toolbar Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Ribbon</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/ribbon/accessibility" aria-label="Ribbon Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>TreeView</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/treeview/accessibility" aria-label="TreeView Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>File Manager</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/accessibility" aria-label="File Manager Accessibility Documentation">Documentation</a></td>
    </tr> 
    <tr>
        <td>Stepper</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/stepper/accessibility" aria-label="Stepper Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Message</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/message/accessibility" aria-label="Message Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Toast</td>
        <td>Yes</td>
        <td>AA</td>
        <td>NA</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/toast/accessibility" aria-label="Toast Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Progress Bar</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/progress-bar/accessibility" aria-label="Progress Bar Accessibility Documentation">Documentation</a></td>
    </tr>
    <tr>
        <td>Skeleton</td>
        <td>Yes</td>
        <td>AA</td>
        <td>Yes</td>
        <td><a target="_self" href="https://ej2.syncfusion.com/aspnetcore/documentation/skeleton/accessibility" aria-label="Skeleton Accessibility Documentation">Documentation</a></td>
    </tr>
</tbody>
</table>
