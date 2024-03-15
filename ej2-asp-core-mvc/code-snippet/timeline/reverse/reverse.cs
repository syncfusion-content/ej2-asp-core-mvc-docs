public ActionResult Demo()
{
    List<TimelineItem> careerProgress = new List<TimelineItem>();
    careerProgress.Add(new TimelineItem { Content = "June 2022", OppositeContent = "Graduated \n Bachelors in Computer Engineering" });
    careerProgress.Add(new TimelineItem { Content = "Aug 2022", OppositeContent = "Software Engineering Internship \n ABC Software and Technology" });
    careerProgress.Add(new TimelineItem { Content = "Feb 2023", OppositeContent = "Associate Software Engineer \n ABC Software and Technology" });
    careerProgress.Add(new TimelineItem { Content = "Mar 2024", OppositeContent = "Software Level 1 Engineer \n XYZ Solutions" });

    ViewBag.careerProgress = careerProgress;
    
    return View();
}