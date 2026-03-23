User: I already have the Getting Started guide for the ASP.NET MVC Chart control. I have newly included the ASP.NET MVC Sankey Getting Started page. Please compare both files and check if there are any issues or if anything is missing in the Sankey Getting Started page compared to the Chart Getting Started page. 

GitHub Copilot: I'll add a short TODO plan to track the comparison steps, then I'll compare the two files and list gaps and recommendations.

Created 3 todos

Progress: plan created and comparison in progress — next I'll list concise differences and fixes.

**Summary**
- **Files compared:** getting-started.md and getting-started.md.

**Differences / Missing Items in Sankey guide**
- **Explicit example:** Chart guide contains an explicit inline CSHTML example (`@Html.EJS().Chart("container").Render()`); the Sankey guide only references includes (`{% include ... %}`) — recommend adding at least one inline CSHTML/snippet example directly in the page (or ensure the include renders correctly).
- **Data example for Sankey:** The Sankey page's "Add data to Sankey Chart" repeats the include blocks but does not show an explicit nodes/links data example. Add a concrete example showing `nodes` and `links` (C#/Razor or tag-helper) so users can see how to define flows.
- **Screenshot / visual:** Chart guide includes a screenshot of the rendered control; Sankey guide lacks an illustrative image. Add a screenshot of the Sankey output (optional but helpful).
- **Sample repository link:** Chart guide ends with a "View Sample in GitHub" link; Sankey guide does not. Add a GitHub/sample link (if a sample exists).
- **Promotional block:** Chart includes an AI Coding Assistant promo paragraph; Sankey does not — this is optional; keep consistent across guides if desired.
- **Redundant content:** Sankey repeats the same include block under both "Add ASP.NET MVC Sankey Chart control" and "Add data to Sankey Chart". Replace repetition with distinct snippets: one for control initialization, another for concrete data-binding.
- **Front-matter/title consistency:** Sankey front-matter uses "Getting started with ##Platform_Name## Sankey Chart Component" while Chart uses a slightly different title format; verify front-matter fields (title/description/control) match site conventions.
- **Verify includes exist:** The Sankey page depends on include files (e.g., `code-snippet/sankey/getting-started/initial/initial.cs`). Confirm those include files exist and contain both `initial.cs` and CSHTML/tag-helper variants for both `aspnet-core` and `aspnet-mvc` platforms.

**Recommended quick edits**
- **Add inline CSHTML example** under "Add ASP.NET MVC Sankey Chart control" similar to chart page.
- **Add a C# (Initial.cs) example** showing nodes/links and how to pass them to the view.
- **Replace duplicate include under "Add data..."** with a clear data example.
- **Add screenshot and GitHub sample link** if available.
- **Confirm include file presence** and that `page.publishingplatform` renders expected variants.

Do you want me to:
- A) Patch the Sankey `getting-started.md` to include an explicit CSHTML example and a nodes/links data snippet (I can apply a minimal edit now), or
- B) Just produce exact content snippets for you to paste (CSHTML + C# nodes/links + optional image/GitHub link)?

User: I referred to the Chart Getting Started page and used it to create the Sankey Getting Started page. In that page, the image and the ‘View Sample on GitHub’ section are missing—please ignore those. Other than that, I have included all the necessary changes.
Can I publish the Sankey Getting Started page live?

GitHub Copilot: I'll check whether the included code-snippet files referenced by the Sankey page exist in the repo.

Searching for text `code-snippet/sankey/getting-started/initial`

Searching for text `code-snippet/sankey/getting-started/initial` (`**/ej2-asp-core-mvc/**`)

Searched for files matching `**/code-snippet/**`, 200 matches

Searched for files matching `**/sankey/getting-started/**`, 9 matches

Completed: *Compare `chart` and `sankey` Getting Started files* (2/3)

Short answer: not yet — the page references non-existent include paths. Fix the include folder name and you can publish.

What I found (concise):
- Issue: the Sankey page uses includes at `code-snippet/sankey/getting-started/initial/...` but the repository directory is `code-snippet/sankey/getting-started/initialize/...`. The include names must match exactly, so the snippets won't render on the site.
- Other items you asked to ignore (image and GitHub link) are intentionally missing — that's fine.
- Optional (not blocking): consider adding an inline data example or screenshot, but not required if your includes provide the code.

Next steps I can take:
- A) I can patch getting-started.md to replace each `initial` include with `initialize` so includes resolve — do you want me to apply that change now?
- B) You can manually replace `initial` → `initialize` in the two include blocks.

Which option do you want?

User: Now again check this file

GitHub Copilot: I'll reopen the Sankey getting-started file and scan the include lines for correctness.

Read [](file:///d%3A/EJ2%20UG/MVC%20and%20Core%20-%20Vol2026/ej2-asp-core-mvc-docs/ej2-asp-core-mvc/sankey/EJ2_ASP.MVC/getting-started.md)

Next I'll open the `initialize` and `data` snippet files referenced by the Sankey page to confirm they exist.

Read [](file:///d%3A/EJ2%20UG/MVC%20and%20Core%20-%20Vol2026/ej2-asp-core-mvc-docs/ej2-asp-core-mvc/code-snippet/sankey/getting-started/initialize/initialize.cs)

Read [](file:///d%3A/EJ2%20UG/MVC%20and%20Core%20-%20Vol2026/ej2-asp-core-mvc-docs/ej2-asp-core-mvc/code-snippet/sankey/getting-started/data/data.cs)

Scan complete.

- Checked page: getting-started.md — includes now reference `initialize` and `data`.
- Verified snippets exist and contain usable examples:
  - code-snippet/sankey/getting-started/initialize/initialize.cs
  - code-snippet/sankey/getting-started/data/data.cs

Conclusion: the include paths are correct and the page is ready to publish (image/GitHub link omission is acceptable per your note). Want me to (A) apply any final edits, or (B) mark this ready for publish?

User: Shall I publish this page now?

GitHub Copilot: Yes — publish it.

- Why: getting-started.md includes resolve to existing snippets (`code-snippet/sankey/getting-started/initialize` and `.../data`) and those snippets contain valid examples.
- Optional (not required): add a screenshot or GitHub sample link later if you want richer content.
- Quick preview (optional): run your site build (example):
```
bundle exec jekyll serve
```
Want me to (A) commit/prepare a PR, or (B) make any final edits before you publish?

User: I referred to the Chart Getting Started page and used it to create the Sankey Getting Started page. In that page, the image and the ‘View Sample on GitHub’ section are missing—please ignore those. Other than that, I have included all the necessary changes.
Can I publish the Sankey Getting Started page live?

GitHub Copilot: I'll confirm the ASP.NET Core tag-helper snippet files referenced by the Sankey page exist.

Read [](file:///d%3A/EJ2%20UG/MVC%20and%20Core%20-%20Vol2026/ej2-asp-core-mvc-docs/ej2-asp-core-mvc/code-snippet/sankey/getting-started/initialize/tagHelper)

Read [](file:///d%3A/EJ2%20UG/MVC%20and%20Core%20-%20Vol2026/ej2-asp-core-mvc-docs/ej2-asp-core-mvc/code-snippet/sankey/getting-started/data/tagHelper)

Created 3 todos

All snippet includes resolve and contain valid examples — you can publish.

- Confirmed files: getting-started.md and getting-started.md reference existing snippet folders:
  - `code-snippet/sankey/getting-started/initialize/*` (has tagHelper, razor, initialize.cs)
  - `code-snippet/sankey/getting-started/data/*` (has tagHelper, razor, data.cs)
- Missing image/GitHub link is intentional per your note — not blocking.
- Quick optional check before publishing: build the docs site locally, e.g.:
  ```
  bundle exec jekyll serve
  ```
Would you like me to (A) commit and create a PR for this change, or (B) go ahead and publish (you will push/merge)?