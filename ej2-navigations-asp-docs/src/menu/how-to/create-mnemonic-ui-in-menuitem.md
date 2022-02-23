# Create mnemonic UI in menu item

A particular character in a text can be underlined in the [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeItemRender.html) event by
adding `<u>` tag in between the text and assign the innerHTML to the `li` element.

In the following example, the first character in `File`, `Open`, and `Save` menu items are underlined.

In the below example, `File`, `Open` and `Save` items are underlined with first character in menu items.

{% aspTab template="menu/how-to/underline", sourceFiles="Underline.cs" %}

{% endaspTab %}
