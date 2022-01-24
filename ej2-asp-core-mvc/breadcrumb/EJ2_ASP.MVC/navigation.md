---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Navigation of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons in Breadcrumb

## Navigation

The Breadcrumb item navigates to the path while clicking the item. To enable navigation, `url`property was bound to the items.

## URL

In the Breadcrumb, the item represents the url. The breadcrumb items can be provided with either relative or absolute URL.

### Relative URL

The Breadcrumb items with relative URL contain only the path but do not locate the path or server. The following example represents the breadcrumb items with relative url.

{% aspTab template="breadcrumb/url/relative-url", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/relative-url.PNG)

### Absolute URL

The Breadcrumb items with absolute URL contain the path and locate to the resource if the static url is bound to the breadcrumb item. The following example represents the breadcrumb items with static url.

{% aspTab template="breadcrumb/url/absolute-url", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/relative-url.PNG)

## Enable navigation for last Breadcrumb item

The feature enables the last item of the Breadcrumb component by setting the `enableActiveItemNavigation` property to true. In the following example, the last item of the `Breadcrumb` was enabled.

{% aspTab template="breadcrumb/url/enable-navigation", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/enable-navigation.PNG)

## Open URL in new page or tab

To open the Breadcrumb item in a new page or tab, set the target property of the required item url to blank in the Breadcrumb component. In the following example, the target property of `All Component` item url was set to blank by using the `beforeItemRender` event which locates to the path in the new tab.

{% aspTab template="breadcrumb/url/open-url", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/enable-navigation.PNG)