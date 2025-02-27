---
layout: post
title: Introduction to the Figma UI Kit in ##Platform_Name## Component | Syncfusion
description: Check out and learn about the introduction to the Figma UI Kit in Syncfusion ##Platform_Name## component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Figma UI Kits for Syncfusion<sup>&reg;</sup> Controls

Syncfusion<sup style="font-size:70%">&reg;</sup> offers [Figma UI kits](https://www.figma.com/@syncfusion) to facilitate effective collaboration between designers and developers. The Figma UI kits are available in four themes: [Material 3](https://www.figma.com/community/file/1454123774600129202/syncfusion-ui-kit-material-3-theme), [Fluent](https://www.figma.com/community/file/1385969120047188707/syncfusion-ui-kit-fluent-theme), [Tailwind](https://www.figma.com/community/file/1385969065626384098/syncfusion-ui-kit-tailwind-theme), and [Bootstrap 5](https://www.figma.com/community/file/1385968977953858272/syncfusion-ui-kit-bootstrap-5-theme). These kits match the themes used in Syncfusion<sup style="font-size:70%">&reg;</sup> controls.

The kits contain reusable design controls with various possible states and variants, along with detailed figures, measurements, and icons, representing the Syncfusion<sup style="font-size:70%">&reg;</sup> controls.

![Material 3](./images/material3.png)

## Advantages of UI kits

The Syncfusion<sup style="font-size:70%">&reg;</sup> Figma UI kit offers the following key advantages:
- The UI kit includes detailed information about Syncfusion<sup style="font-size:70%">&reg;</sup> controls, such as available control lists, their states, and variants. This facilitates a quick understanding of Syncfusion<sup style="font-size:70%">&reg;</sup> controls.
- Design controls are developed using the [atomic design methodology](https://atomicdesign.bradfrost.com/chapter-2/), making customization straightforward and efficient.
- Developers can seamlessly match Syncfusion<sup style="font-size:70%">&reg;</sup> controls with your design requirements, ensuring alignment and accuracy.
- By using standardized controls and themes, the UI kit ensures consistency in your designs, maintaining a uniform look and feel across projects.

## Downloading the UI kits

Syncfusion<sup style="font-size:70%">&reg;</sup> Figma UI kits are available in the [Figma community](https://www.figma.com/@syncfusion). You can download the Syncfusion<sup style="font-size:70%">&reg;</sup> theme-specific Figma UI kits from the following links:

- [Material 3](https://www.figma.com/community/file/1454123774600129202/syncfusion-ui-kit-material-3-theme)
- [Fluent](https://www.figma.com/community/file/1385969120047188707/syncfusion-ui-kit-fluent-theme)
- [Tailwind](https://www.figma.com/community/file/1385969065626384098/syncfusion-ui-kit-tailwind-theme)
- [Bootstrap 5](https://www.figma.com/community/file/1385968977953858272/syncfusion-ui-kit-bootstrap-5-theme)

## Structure of the UI kits

Syncfusion’s Figma UI kit is structured to offer a comprehensive and user-friendly layout, facilitating easy navigation and exploration of various controls. It includes the following pages:

- **Thumbnail**: This page serves as the cover page for the UI kit.
- **Index**: Here, users can find a detailed list of all control names, making it simple to identify and locate specific controls within the UI kit.
- **Icons**: Contains a collection of all icons used in the design controls.
- **UI Controls**: At the core of the UI kit, this section features a wide range of essential UI controls. Each control is meticulously designed with detailed figures, measurements, and icons, showcasing various states and variants.

![Layout](./images/layout.png)

## Customizing the UI kits

The Syncfusion<sup style="font-size:70%">&reg;</sup> Figma UI kits are easily customizable to meet your specific needs, allowing you to create unique designs and adjust colors to match your brand guidelines. The [atomic design methodology](https://atomicdesign.bradfrost.com/chapter-2/) used in developing these controls, your customizations will be seamlessly reflected across multiple controls and their variants.

Here's how to customize the primary button color of the Material 3 theme within your layout:

1. Visit our [UI kits](#downloading-the-ui-kits) and choose your preferred theme, such as the Material 3 theme.
2. Open the selected theme in the Figma web application by clicking the **Open in Figma** button.
3. For the desktop application, click the **Import** button in the top-right corner of the page. Select the downloaded Syncfusion<sup style="font-size:70%">&reg;</sup> fig file you want to import and click the **Open** button.
4. Identify the button you wish to customize within your layout.
5. On the right side of the Figma interface, find the color variable options listed. For example, the variable for a particular button color might be labeled as `$primary-bg-color`, derived from the primary color variable.
6. To customize this primary button control color, click outside the button to see the **Local variables** option on the right side of the Figma interface. It contains the design token for the color variables. Click the **Local variables** option.
7. A popup will show the design token list. You can change the primary color using a color palette.
8. Once you've selected the new color (e.g., pink) for the primary variable, the button's color pattern will be updated accordingly. You'll see the changes reflected in real-time within your design.

![Customization](./images/customize.png)

In addition to changing the button color, you can also customize other aspects like font, spacing, shadows, etc., of the UI controls:

Feel free to experiment with these customization options to create a design that perfectly matches your requirements.

## Downloading the customized styles

Effortlessly download customized style changes as tokens and CSS variables using the `Syncfusion Design Tokens` plugin. This plugin bridges the gap between design and development by converting Figma design variables into Syncfusion tokens for direct use in your applications to ensure a smooth transition from design to implementation.

### Exporting design tokens

Follow these steps to download the customized styles from the Figma UI Kit:

- First, open a [Syncfusion Figma UI Kit](https://www.figma.com/@syncfusion).
- Navigate to the `Plugins & widgets` section in Figma and search for the `Syncfusion Design Tokens`.
- Once found, run the plugin. A popup will appear with an `Export` button.
- Click the `Export` button. This action will generate a zip file containing your design tokens.
- Select a directory to save the exported files.
- Extract the downloaded zip file to access its contents.

![export-design-tokens](./images/syncfusion-design-tokens.png)

### Utilizing design tokens

The exported zip file includes the following files:
  - `css-variables.css`: The css-variables.css file contains CSS variables for both light and dark themes, directly derived from your Figma designs. You can easily import this file into your application alongside the component styles to reflect your custom designs. For more detailed usage instructions, consult the [CSS variables](./css-variables) documentation.
  - `<theme-name>-tokens.json`: This file (e.g., material3-tokens.json) contains style variables and values in a JSON format compatible with [Theme Studio](./theme-studio). This file, prefixed with the corresponding theme name, can be [imported](./theme-studio#import-previously-changed-settings-into-the-theme-studio) into [Theme Studio](./theme-studio) for further customization. After processing in [Theme Studio](./theme-studio), you can [download](./theme-studio#download-the-customized-theme) the updated styles file and integrate it into your application, bringing your custom themes to life.

This streamlined process ensures that your unique design vision, crafted in Figma, is accurately translated into your final application, maintaining consistency between design and implementation.

## Upgrading the UI kits

To upgrade your UI kits, download the latest version from the provided links. Follow these guidelines for a seamless upgrade process:

- Keep track of updates or new versions of UI kits from Syncfusion.
- Before upgrading, back up your ongoing projects to prevent data loss or compatibility issues.
- Share your experience with Syncfusion<sup style="font-size:70%">&reg;</sup> regarding the upgraded UI kits, including any issues encountered or suggestions for improvement.

## See also

* [Available themes](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme)
* [Customizing themes](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme-studio#customizing-theme-color-from-theme-studio)