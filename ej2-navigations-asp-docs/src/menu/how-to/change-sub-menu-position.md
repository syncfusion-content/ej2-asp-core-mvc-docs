# Change sub menu position

The submenu position can be changed by using the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event. Assign the top and left position where you want to open the submenu to the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event arguments `args.top` and `args.left` respectively.

In the below sample, the sub menu opens above the parent menu item.

{% aspTab template="menu/how-to/position", sourceFiles="Position.cs" %}

{% endaspTab %}

>> For custom positioning, set both `top` and `left` position in the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event.