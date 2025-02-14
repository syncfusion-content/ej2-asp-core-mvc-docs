---
layout: post
title: Server vs Standalone Mode in ##Platform_Name## Pdfviewer Component| Syncfusion
description: Explore the differences between Server Mode and Standalone Mode in ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Comparing Server Mode and Standalone Mode
publishingplatform: ##Platform_Name##
documentation: ug
---
# Comparing Server Mode and Standalone Mode in ASP.NET Core PDF Viewer control

When choosing between **EJ2 PDF Viewer server mode rendering** and **standalone mode** (client-side rendering), your decision will depend on the specific use case, performance requirements, and overall application architecture. Below is a comparison to guide your decision-making process:

## Server Mode Rendering

In server mode, the rendering and manipulation of PDFs occur on the server, and only the processed images or data are sent to the client for further rendering.

### Advantages:

- **Performance for Large PDFs:** Server mode is more efficient for rendering large PDFs because intensive processing is offloaded to the server. This reduces the load on the client, which is particularly beneficial for lower-powered devices like mobile phones or older desktops.

- **Reduced Client-Side Resource Usage:** Since the client is responsible only for displaying pre-rendered images, server-side mode offloads the majority of processing to the server. This decreases memory and CPU consumption on the client side.

- **Security:** Sensitive documents are not fully downloaded to the client. The server controls what information is sent, ensuring secure access and usage of the PDF content.

- **Handling Complex PDFs:** Complex PDFs, such as those with extensive annotations, forms, or fonts, often perform better in server mode due to the server's superior computing resources.

### Disadvantages:

- **Requires Server Infrastructure:** A dedicated server component is needed to manage rendering, adding complexity to the setup.

- **Latency:** Network latency between the client and server could impact the user experience, particularly if the server is geographically distant from the user or operating under heavy load.

- **Maintenance:** Managing and scaling the server infrastructure can be complex.
## Standalone Mode (Client-Side Rendering)

In standalone mode, the entire PDF is rendered on the client side using JavaScript.

### Advantages:

- **No Server Dependency:** The complete PDF processing occurs in the browser, removing the need for a server-side rendering engine.

- **Faster Interaction for Simple PDFs:** For smaller or simpler PDFs, this can result in quicker rendering and more immediate interaction since there's no need for server communication.

- **Reduced Costs:** With no server involvement, there are fewer infrastructure costs, and no server-side scaling is required.

- **Offline Support:** Standalone mode enables the application to work offline, as all rendering is performed in the browser without requiring a network connection.

### Disadvantages:

- **Performance on Large/Complex PDFs:** The client's browser might struggle to efficiently handle large or complex PDFs, especially on devices with limited processing power.

- **Resource Intensive:** This method can consume more memory and CPU on the client side, potentially leading to browser performance issues.

- **Limited Security:** Since the entire PDF is downloaded to the client, there is less control over document access and manipulation compared to server-side rendering.

## When to Choose:

### Choose Server Mode:

- When handling large or complex PDFs.

- If security is a high concern and you need to control access to the content.

- When targeting a wide range of devices with varied performance capabilities.

### Choose Standalone Mode:

- When simplicity is preferred, and there's no server infrastructure available.

- If your PDFs are small, straightforward, or do not require intensive processing.

- When offline support is needed, or low-latency access is a priority.

Ultimately, this decision should be based on your project's needs, expected usage patterns, and the available infrastructure.