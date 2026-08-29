---
layout: post
title: How to use mail merge in ##Platform_Name## Document Editor Component
description: Learn here all about how to use mail merge in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mail Merge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mail Merge Operation Challenges with SFDT Documents ##Platform_Name## Document editor control

Mail merge is a feature commonly used in our document editor to create personalized documents, such as letters, envelopes, labels, or emails, by merging a template with a data source. This process automates the creation of multiple documents with similar content but personalized information for each recipient.

## Challenges Faced on the Client Side

### Structure Collapse

SFDT documents are structured using ranges to store document content, including paragraphs and formatting. These ranges divide the document text into manageable segments, allowing for efficient storage and manipulation. Due to the structure of SFDT documents, which utilize ranges to organize document content, performing mail merge operations by manually replacing merge field values in the template SFDT directly on the client side is not advisable.

>Note: A collapsed structure results in formatting loss, rendering errors, and unpredictable behavior when viewing or editing the document, significantly impacting document usability.

###  Rendering Errors

The manual replacement of merge field values on the client side can introduce rendering errors, especially with complex SFDT structures containing tables, lists, or nested elements.

>Note: Rendering errors distort document appearance, making it challenging to interpret or edit. This undermines the quality and consistency of the merged documents.

## Perform Mail Merge operations 

The following example code illustrates how to perform Mail Merge operations in Document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/mail-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/mail-merge/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/mail-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/mail-merge/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Perform Mail Merge operations on server side using Syncfusion DocIO

The following example code illustrates how to perform mail merge on server-side using c#.

```c#
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("MailMerge")]
public string MailMerge([FromBody] ExportData exportData)
{
    Byte[] data = Convert.FromBase64String(exportData.documentData.Split(',')[1]);
    MemoryStream stream = new MemoryStream();
    stream.Write(data, 0, data.Length);
    stream.Position = 0;
    try
    {
        Syncfusion.DocIO.DLS.WordDocument document = new Syncfusion.DocIO.DLS.WordDocument(stream, Syncfusion.DocIO.FormatType.Docx);
        document.MailMerge.RemoveEmptyGroup = true;
        document.MailMerge.RemoveEmptyParagraphs = true;
        document.MailMerge.ClearFields = true;
        document.MailMerge.Execute(CustomerDataModel.GetAllRecords());
        document.Save(stream, Syncfusion.DocIO.FormatType.Docx);
    }
    catch (Exception ex)
    { }
    string sfdtText = "";
    Syncfusion.EJ2.DocumentEditor.WordDocument document1 = Syncfusion.EJ2.DocumentEditor.WordDocument.Load(stream, Syncfusion.EJ2.DocumentEditor.FormatType.Docx);
    sfdtText = Newtonsoft.Json.JsonConvert.SerializeObject(document1);
    document1.Dispose();
    return sfdtText;
}
public class CustomerDataModel
{
    public static List<Customer> GetAllRecords()
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("9072379", "50%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "2000", "19072379", "Folk och fä HB", "100000", "440", "32.34", "472.34", "28023", "12000", "2020-11-07 00:00:00", "2020-12-07 00:00:00"));
        customers.Add(new Customer("9072378", "20%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "", "2", "19072369", "Maersk", "140000", "245", "20", "265", "28024", "12400", "2020-11-31 00:00:00", "2020-12-22300:00:00"));
        customers.Add(new Customer("9072377", "30%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "100", "19072879", "Mediterranean Shipping Company", "104000", "434", "50.43", "484.43", "28025", "10000", "2020-11-07 00:00:00", "2020-12-02 00:00:00"));
        customers.Add(new Customer("9072393", "10%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "2050", "19072378", "China Ocean Shipping Company", "175000", "500", "32", "532", "28026", "17000", "2020-09-23 00:00:00", "2020-10-09 00:00:00"));
        customers.Add(new Customer("9072377", "14%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "2568", "19072380", "CGM", "155000", "655", "20.54", "675.54", "28027", "13000", "2020-10-11 00:00:00", "2020-11-17 00:00:00"));
        customers.Add(new Customer("9072376", "0%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "1532", "19072345", " Hapag-Lloyd", "106500", "344", "30", "374", "28028", "14500", "2020-06-17 00:00:00", "2020-07-07 00:00:00"));
        customers.Add(new Customer("9072369", "05%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "4462", "190723452", "Ocean Network Express", "100054", "541", "50", "591", "28029", "16500", "2020-04-07 00:00:00", "2020-05-07 00:00:00"));
        customers.Add(new Customer("9072359", "4%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "27547", "190723713", "Evergreen Line", "124000", "800", "10.23", "810.23", "28030", "12500", "2020-03-07 00:00:00", "2020-04-07 00:00:00"));
        customers.Add(new Customer("9072380", "20%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "7582", "19072312", "Yang Ming Marine Transport", "1046000", "290", "10", "300", "27631", "12670", "2020-11-10 00:00:00", "2020-12-13 00:00:00"));
        customers.Add(new Customer("9072381", "42%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "862", "19072354", "Hyundai Merchant Marine", "145000", "800", "10.23", "810.23", "28032", "45000", "2020-10-17 00:00:00", "2020-12-23 00:00:00"));
        customers.Add(new Customer("9072391", "84%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "82", "19072364", "Pacific International Line", "10094677", "344", "30", "374", "28033", "16500", "2020-11-14 00:00:00", "2020-12-21 00:00:00"));
        customers.Add(new Customer("9072392", "92%", "C/ Araquil, 67", "Madrid", "22020-08-10 00:00:00", "Spain", "Brittania", "82", "19072385", "Österreichischer Lloyd", "104270", "500", "32", "532", "28034", "156500", "2020-06-07 00:00:00", "2020-07-07 00:00:00"));
        return customers;
    }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string ProductName { get; set; }
    public string Quantity { get; set; }
    public string ShipName { get; set; }
    public string UnitPrice { get; set; }
    public string Discount { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string OrderDate { get; set; }
    public string ShipCountry { get; set; }
    public string OrderId { get; set; }
    public string Subtotal { get; set; }
    public string Freight { get; set; }
    public string Total { get; set; }
    public string ShipPostalCode { get; set; }
    public string RequiredDate { get; set; }
    public string ShippedDate { get; set; }
    public string ExtendedPrice { get; set; }
    public Customer(string orderId, string discount, string shipAddress, string shipCity, string orderDate, string shipCountry, string productName, string quantity, string customerID, string shipName, string unitPrice, string subtotal, string freight, string total, string shipPostalCode, string extendedPrice, string requiredDate, string shippedDate)
    {
        this.CustomerID = customerID;
        this.ProductName = productName;
        this.Quantity = quantity;
        this.ShipName = shipName;
        this.UnitPrice = unitPrice;
        this.Discount = discount;
        this.ShipAddress = shipAddress;
        this.ShipCity = shipCity;
        this.OrderDate = orderDate;
        this.ShipCountry = shipCountry;
        this.OrderId = orderId;
        this.Subtotal = subtotal;
        this.Freight = freight;
        this.Total = total;
        this.ShipPostalCode = shipPostalCode;
        this.ShippedDate = shippedDate;
        this.RequiredDate = requiredDate;
        this.ExtendedPrice = extendedPrice;
    }
}

public class ExportData
{
    public string fileName { get; set; }
    public string documentData { get; set; }
}

```

## See Also

* [Mail merge using DocIO](https://help.syncfusion.com/file-formats/docio/working-with-mail-merge)
* [Mail merge demo](https://github.com/SyncfusionExamples/EJ2-Document-Editor-Web-Services/blob/master/ASP.NET%20Core/src/Controllers/DocumentEditorController.cs#L114)