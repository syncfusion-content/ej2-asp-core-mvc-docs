---
layout: post
title: Globalization in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Globalization in ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chat UI
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Chat UI control

## Localization

The Chat UI can be localized to any culture by defining the text of the Chat UI in the corresponding culture. The default locale of the Chat UI is `en` (English). The following table represents the default text of the Chat UI in `en` culture.

|KEY|Text|
|----|----|
|oneUserTyping|{0} is typing|
|twoUserTyping|{0} and {1} are typing|
|threeUserTyping|{0}, {1}, and {2} other are typing|
|multipleUsersTyping|{0}, {1}, and {2} others are typing|

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/globalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/chat-ui/globalization/localization/timestamp.cs %}
{% endhighlight %}
{% endtabs %}

![Localization](images/localization.png)

## RTL

RTL provides an option to switch the text direction and layout of the Chat UI control from right to left by setting the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_EnableRtl) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/chat-ui/globalization/rtl/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![RTL](images/rtl.png)
