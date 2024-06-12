using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tag
    {
        public string Text { get; set; }
        public bool State { get; set; }
        public List<Tag> TagDataList()
        {
            List<Tag> tag = new List<Tag>();
            tag.Add(new Tag() { Text = "Add to KB", State= false });
            tag.Add(new Tag() { Text = "Crisis", State= false });
            tag.Add(new Tag() { Text = "Enhancement", State= true });
            tag.Add(new Tag() { Text = "Presale", State= false });
            tag.Add(new Tag() { Text = "Needs Approval", State= false });
            tag.Add(new Tag() { Text = "Approved", State= true });
            tag.Add(new Tag() { Text = "Internal Issue", State= true });
            tag.Add(new Tag() { Text = "Breaking Issue", State= false });
            tag.Add(new Tag() { Text = "New Feature", State= true });
            tag.Add(new Tag() { Text = "New Component", State= false });
            tag.Add(new Tag() { Text = "Mobile Issue", State= false });
            return tag;
        }
    }
}
