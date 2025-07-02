using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();

public ActionResult Code()
{
        BlocksData.Add(new Block()
        {
                type = "Code",
                content = new List<object>()
                {
                        new 
                        {
                                type = "Text",
                                content = "function greeting() {\n  console.log(\"Hello, world!\");\n}"
                        }
                },
                codeSettings = new CodeSettingsModel()
                {
                        defaultLanguage = "javascript",
                        languages = new List<CodeLanguageModel>()
                        {
                                new CodeLanguageModel()
                                {
                                        label = "JavaScript",
                                        language = "javascript"
                                },
                                new CodeLanguageModel()
                                {
                                        label = "TypeScript",
                                        language = "typescript"
                                },
                                new CodeLanguageModel()
                                {
                                        label = "HTML",
                                        language = "html"
                                },
                                new CodeLanguageModel()
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