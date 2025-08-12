using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Code()
{
        BlocksData.Add(new Block()
        {
                Type = BlockType.Code,
                Content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "function greeting() {\n  console.log(\"Hello, world!\");\n}"
                        }
                },
                Props = new
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