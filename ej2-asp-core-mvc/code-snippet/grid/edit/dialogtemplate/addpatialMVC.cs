@using Syncfusion.EJ2;
<div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="OrderID" name="OrderID" type='text' />
                <span class="e-float-line"></span>
                <label asp-for="OrderID" class="e-float-text e-label-top">Order ID</label>
            </div>
        </div>
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="CustomerID" name="CustomerID" />
                <span class="e-float-line"></span>
                <label asp-for="CustomerID" class="e-float-text e-label-top">Customer Name</label>
            </div>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.EJS().NumericTextBox("Freight").Format("C2").Placeholder("Freight").FloatLabelType(Syncfusion.EJ2.Inputs.FloatLabelType.Always).Render()
        </div>
        <div class="form-group col-md-6">
            @Html.EJS().DatePicker("OrderDate").Placeholder("Order Date").FloatLabelType(Syncfusion.EJ2.Inputs.FloatLabelType.Always).Render()
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.EJS().DropDownList("ShipCountry").DataSource(ViewBag.dataSource).Placeholder("Ship Country").Fields(new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings { Text = "ShipCountry", Value = "ShipCountry" }).FloatLabelType(Syncfusion.EJ2.Inputs.FloatLabelType.Always).Render()
        </div>
        <div class="form-group col-md-6">
            @Html.EJS().DropDownList("ShipCity").DataSource(ViewBag.dataSource).Placeholder("Ship City").Fields(new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings { Text = "ShipCity", Value = "ShipCity" }).FloatLabelType(Syncfusion.EJ2.Inputs.FloatLabelType.Always).Render()
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-12">
            <div class="e-float-input e-control-wrapper">
                @Html.TextArea("ShipAddress")
                <span class="e-float-line"></span>
                <label asp-for="ShipAddress" class="e-float-text e-label-top">Ship Address</label>
            </div>
        </div>
    </div>
</div>
@Html.EJS().ScriptManager()