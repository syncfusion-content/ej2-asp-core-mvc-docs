# EJ2 Documentation aspcore and aspmvc

The EJ2 documentation for aspcore and aspmvc structure, settings and build processes.

## Gitbook Configuration

We need to install `gitbook-cli` package with global access to configure the documentation build settings.

```cmd
npm install gitbook-cli -g
```
## Document Structure

The component's document should be placed inside the `src` location with separate folder. The documents should have written in `markdown(.md)`
format.

Refer the below folder structure for further details.

    --> src
        --> ComponentName
            --> aspcore
				--> index.md
				--> summary.md
			--> aspmvc
				--> index.md
				--> summary.md
    --> templates
		-->ComponentName
			-->aspcore
				-->templates component
			-->aspmvc
				-->templates component

The component's document structure is defined as per the below criteria.

1. Feature wise documents can be splitted in the corresponding component's folder.
2. Component's overview file should have name as `index.md`.
3. Component's TOC file should have name as `summary.md`. It should have the list of feature document references from the current folder.

The common document structure is declared as per the below criteria.

1. The root `src/summary.md` TOC file will dynamically change while compiling documentation. So it cannot be editable.
2. `src/readme.md` file is the overview document for EJ2.
3. The documents `src/top.md` and `src/bottom.md` are used to append common document references in the tree view. These files should have
    the list of common document references.
	
## Gulp Tasks

The below gulp tasks can be used to build and test the documentation.

Compile md file into html files for aspcore

```cmd
    gulp aspcore-build
```
Compile md file into html files for aspmvc
```cmd
    gulp aspmvc-build
```
Run lint, typo,broken-link-validation,aspcore-build at single tasks for aspcore
```cmd
    gulp aspcore-test
```
Run lint, typo,broken-link-validation,aspcore-build at single tasks for aspmvc
```cmd
    gulp aspmvc-test
```
Run the aspcore Documentation 
```cmd
    gulp aspcore-serve
```
Run the aspmvc Documentation 
```cmd
    gulp aspmvc-serve
```
## Settings and Configurations

We can install `markdownlint` extension in the VSCode to check lint errors while drafting documentation via VSCode editor.

The md files which are listed in the `.bookignore` will be ignored on document compilation.

The markdown lint rules are listed in the `markdownlint.json` file.

The technical words which are defined in the `.spelling` file will skip the spelling error while running `gulp typo` task.

The file `book.json` contains the `gitbook` configuration settings.

## Component Name Mapping

You can change the component name of your docs main header from config.json file with `mapping` option.

All unmapped components will display its folder name as main header.

Example: `numerictextbox` can be mapped with `NumericTextBox`.

The docs will display you the mapped name in all anchor link.

## Adding code snippet for TagHelper and Razor syntax

We can add the code snippet for the TagHelper and Razor code snippets with `aspCodeBlock` block.
Each aspCodeBlock must have a razorTemplate file  reference in its the name of the razor sample Template file needs to be specified in the settings.

```md

{% aspCodeBlock razorTemplate="razortemplate-file-name" %}

    ```Cs

        // TagHelper code snippet here

    ```

{% aspCodeBlock %}

```
Sample `aspCodeBlock` reference
https://gitlab.syncfusion.com/essential-studio/ej2-aspcore-docs/commit/8ff79231f9dc0a5f1f963bde5467278e5b9ae895#7aed13c54fb6d1e98d12f4177d4d24b705071001_0_1
Refer the example razor file below link
https://gitlab.syncfusion.com/essential-studio/ej2-aspcore-docs/commit/8ff79231f9dc0a5f1f963bde5467278e5b9ae895#7aed13c54fb6d1e98d12f4177d4d24b705071001_0_14 
Note: Do not use `tab` syntax in asp core docs.
## Adding TabViewer snippet for TagHelper and Razor syntax
We can add the TabViewer code snippet for the TagHelper and Razor code snippets with `aspTab` block.
Each aspTab must have a template file reference and sourceFiles reference
```md
{% aspTab template="templatePath", sourceFiles="FileName.cs" %}


{% endaspTab %}


```