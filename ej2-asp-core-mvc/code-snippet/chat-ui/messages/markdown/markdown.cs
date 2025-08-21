using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.InteractiveChat;

namespace EJ2MVCSampleBrowser.Controllers.ChatUI
{
    public partial class ChatUIController : Controller
    {
        public ActionResult Markdown()
        {
            ViewBag.CurrentUserModel = new ChatUIUser { Id = "user1", User = "Albert" };
            ViewBag.MichaleUserModel = new ChatUIUser { Id = "user2", User = "Michale Suyama" };
            ViewBag.Suggestions = new List<SuggestionModel>
            {
                new SuggestionModel
                {
                    DisplayText = "Share quick link",
                    MarkdownText = "Check out our [project dashboard](https://dashboard.example.com) for updates!"
                },
                new SuggestionModel
                {
                    DisplayText = "Emphasize priority",
                    MarkdownText = "This is **high priority** and needs _immediate attention_."
                }
            };
            ViewBag.ChatMessagesData = new List<ChatUIMessage>
            {
                new ChatUIMessage
                {
                    Text = "Hey Michale, did you review the _new API documentation_?",
                    Author = (ChatUIUser)ViewBag.CurrentUserModel,
                    TimeStamp = new DateTime(2024, 1, 15, 9, 30, 0)
                },
                new ChatUIMessage
                {
                    Text = "Yes! The **endpoint specifications** look great. Check the [integration guide](https://api.example.com/docs) when you get a chance.",
                    Author = (ChatUIUser)ViewBag.MichaleUserModel,
                    TimeStamp = new DateTime(2024, 1, 15, 9, 32, 0)
                }
            };
            return View();
        }

        public class SuggestionModel
        {
            public string DisplayText { get; set; } = string.Empty;
            public string MarkdownText { get; set; } = string.Empty;
        }
    }
}