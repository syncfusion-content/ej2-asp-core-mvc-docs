@model Grid_Columns.Pages.DialogTemplateModel
<div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="OrderID" name="OrderID" value=@Model.OrderID.ToString() disabled type='text' />
                <span class="e-float-line"></span>
                <label asp-for="OrderID" class="e-float-text e-label-top">Order ID</label>
            </div>
        </div>
        <div class="form-group col-md-6">
            <div class="e-float-input e-control-wrapper">
                <input asp-for="CustomerID" name="CustomerID" value=@Model.CustomerID />
                <span class="e-float-line"></span>
                <label asp-for="CustomerID" class="e-float-text e-label-top">Customer Name</label>
            </div>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <ejs-numerictextbox id="Freight" value=@Model.Freight format="C2" placeholder="Freight" floatLabelType="Always"></ejs-numerictextbox>
        </div>
        <div class="form-group col-md-6">
            <ejs-datepicker id="OrderDate" value=@Model.OrderDate placeholder="Order Date" floatLabelType="Always"></ejs-datepicker>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <ejs-dropdownlist id="ShipCountry" value=@Model.ShipCountry dataSource="@ViewBag.datasource" placeholder="Ship Country" floatLabelType="Always" popupHeight="300px">
                <e-dropdownlist-fields text="ShipCountry" value="ShipCountry"></e-dropdownlist-fields>
            </ejs-dropdownlist>

        </div>
        <div class="form-group col-md-6">
            <ejs-dropdownlist id="ShipCity" value=@Model.ShipCity dataSource="@ViewBag.DataSource" placeholder="Ship City" floatLabelType="Always" popupHeight="300px">
                <e-dropdownlist-fields text="ShipCity" value="ShipCity"></e-dropdownlist-fields>
            </ejs-dropdownlist>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-12">
            <div class="e-float-input e-control-wrapper">
                <textarea asp-for="ShipAddress">@Model.ShipAddress</textarea>
                <span class="e-float-line"></span>
                <label asp-for="ShipAddress" class="e-float-text e-label-top">Ship Address</label>
            </div>
        </div>
    </div>
</div>
<ejs-scripts></ejs-scripts>