using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PopupResizeData
    {
        public string Status { get; set; }
        public bool State { get; set; }
        public List<PopupResizeData> ResizeDataList()
        {
            List<PopupResizeData> status = new List<PopupResizeData>();
            status.Add(new PopupResizeData() { Status = "Open", State = false });
            status.Add(new PopupResizeData() { Status = "Waiting for Customer", State = false });
            status.Add(new PopupResizeData() { Status = "On Hold", State = true });
            status.Add(new PopupResizeData() { Status = "Follow-up", State = false });
            status.Add(new PopupResizeData() { Status = "Closed", State = true });
            status.Add(new PopupResizeData() { Status = "Solved", State = false });
            status.Add(new PopupResizeData() { Status = "Feature Request", State = false });
            status.Add(new PopupResizeData() { Status = "In Progress", State = false });
            status.Add(new PopupResizeData() { Status = "Pending", State = true });
            status.Add(new PopupResizeData() { Status = "Escalated", State = true });
            status.Add(new PopupResizeData() { Status = "New", State = false });
            status.Add(new PopupResizeData() { Status = "Under Review", State = true });
            status.Add(new PopupResizeData() { Status = "Reopened", State = false });
            status.Add(new PopupResizeData() { Status = "Approved", State = true });
            status.Add(new PopupResizeData() { Status = "Awaiting Approval", State = false });
            status.Add(new PopupResizeData() { Status = "Scheduled", State = false });
            status.Add(new PopupResizeData() { Status = "Canceled", State = true });
            status.Add(new PopupResizeData() { Status = "Completed", State = true });
            status.Add(new PopupResizeData() { Status = "Acknowledged", State = false });

            return status;
        }
    }
}
