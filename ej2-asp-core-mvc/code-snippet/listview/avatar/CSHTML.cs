public class TemplateModel : PageModel
{
    public List<ContactModel>? ListData { get; set; }
    public string? Template { get; set; }

    public void OnGet()
    {
        ListData = new List<ContactModel>
    {
        new ContactModel { Text = "Jenifer", Contact = "(206) 555-985774", Id = "1", Avatar = "J", Pic = "pic01" },
        new ContactModel { Text = "Amenda", Contact = "(206) 555-3412", Id = "2", Avatar = "A", Pic = "" },
        new ContactModel { Text = "Isabella", Contact = "(206) 555-8122", Id = "4", Avatar = "", Pic = "pic02" },
        new ContactModel { Text = "William ", Contact = "(206) 555-9482", Id = "5", Avatar = "W", Pic = "" },
        new ContactModel { Text = "Jacob", Contact = "(71) 555-4848", Id = "6", Avatar = "", Pic = "pic04" },
        new ContactModel { Text = "Matthew", Contact = "(71) 555-7773", Id = "7", Avatar = "M", Pic = "" },
        new ContactModel { Text = "Oliver", Contact = "(71) 555-5598", Id = "8", Avatar = "", Pic = "pic03" },
        new ContactModel { Text = "Charlotte", Contact = "(206) 555-1189", Id = "9", Avatar = "C", Pic = "" }
    };

        Template = @"<div class='e-list-wrapper e-list-multi-line e-list-avatar'>
        ${if(Avatar!=='')}
        <span class='e-avatar e-avatar-circle'>${Avatar}</span>
        ${else}
        <span class='${Pic} e-avatar e-avatar-circle'> </span>
        ${/if}
        <span class='e-list-item-header'>${Text}</span>
        <span class='e-list-content'>${Contact}</span>
        </div>";
    }
}

public class ContactModel
{
    public string? Text { get; set; }
    public string? Contact { get; set; }
    public string? Id { get; set; }
    public string? Avatar { get; set; }
    public string? Pic { get; set; }
}