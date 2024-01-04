using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult scrolling()
        {  List<object> listdata = new List<object>();
            listdata.Add(new
    {
        text= "Hi Guys, Good morning! \uD83D\uDE0A, I'm very delighted to share with you the news that our team is going to launch a new mobile application",
        positionClass= "right"
    });
    listdata.Add(new
    {
        text= "Oh! That's great \uD83D\uDE42",
        positionClass= "left"
    });
    listdata.Add(new
    {
        text= "That is a good news \uD83D\uDE00",
        positionClass= "right"
    });
    listdata.Add(new
    {
        text="What kind of application we are gonna launch? \uD83E\uDD14",
        positionClass= "left"
    });
    listdata.Add(new
    {
        text= "A kind of 'Emergency Broadcast App' like being able to just invite someone to teams without it impacting how many people have official access",
        positionClass= "right"
    });
    listdata.Add(new
        {
        text= "Who will be the client users for our applications? ",
        positionClass= "left"
        });
    listdata.Add(new
        {
        text= "Is currently the only way to invite someone through 0365? Just wondering down the road how organization would want to handle that with freelancers, like being able to just invite someone to teams without it impacting how many people have official access \uD83D\uDE14",
        positionClass= "right"
        });
    listdata.Add(new
        {
        text= "Yes, however, that feature of inviting someone from outside your organization is planned - expected closer to GA next year \uD83D\uDC4D",
        positionClass= "left",
        });
    listdata.Add(new
        {
        text= "I guess we should switch things over to hear for a while. How long does the trial last? \uD83E\uDD14",
        positionClass= "right",
        });
    listdata.Add(new
        {
        text = "I think the trial is 30 days. \uD83D\uDE03",
        positionClass = "left"
        });
    listdata.Add(new
        {
        text = "Only 0365 only members of your organization. They said that they are listening to customer feedback and hinted that guest users would be brought in down the road \uD83D\uDE09",
        positionClass = "right"
        });
    listdata.Add(new
        {
        text = "Cool thanks! \uD83D\uDC4C",
        positionClass = "left"
        });
        var initialData = listdata.Take(5).ToList();
            ViewBag.dataSource = initialData;
            return View();
        }
    }
}
