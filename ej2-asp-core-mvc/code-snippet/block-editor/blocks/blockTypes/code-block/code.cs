using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Code()
{
        BlocksData.Add(new Block()
        {
                Type = "Code",
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "function greeting() {\n  console.log(\"Hello, world!\");\n}"
                        }
                },
                CodeSettings = new
                {
                        defaultLanguage = "javascript",
                        languages = new List<object>()
                        {
                                new
                                {
                                        label = "JavaScript",
                                        language = "javascript"
                                },
                                new
                                {
                                        label = "TypeScript",
                                        language = "typescript"
                                },
                                new
                                {
                                        label = "HTML",
                                        language = "html"
                                },
                                new
                                {
                                        label = "CSS",
                                        language = "css"
                                }
                        }
                }
        });
        ViewBag.BlocksData = BlocksData;
        return View();
}