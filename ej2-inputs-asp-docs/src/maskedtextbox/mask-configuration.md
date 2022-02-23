---
title: "Mask Configuration"
component: "MaskedTextBox"
description: "Different mask configuration in masked textbox"
---

# Mask Configuration

The mask is a combination of standard and custom mask elements that validates the user input based on its behavior.

> When the mask value is empty, the MaskedTextBox behaves as an input element with text type.

## Standard mask elements

The following table shows the list of mask elements and its behavior based on [MSDN](https://msdn.microsoft.com/en-us/library/system.windows.forms.maskedtextbox.mask.aspx) standard.

The mask can be formed by combining any one or more of these mask elements.

| Mask Element | Description |
| ------------- | ------------- |
| 0 | Digit required. This element will accept any single digit from **0** to **9**. |
| 9 | Digit or space, optional. |
| # | Digit or space, optional, Plus(**+**) and minus(**-**) signs are allowed. |
| L | Letter required. It will accept letters **a-z** and **A-Z**. |
| ? | Letter or space, optional. |
| & | Requires a character. |
| C | Character or space, optional. |
| A | Alphanumeric **(A-Za-z0-9)** required.|
| a | Alphanumeric **(A-Za-z0-9)** or space, optional. |
| < | Shift down. Converts all characters to lower case. |
| > | Shift up. Converts all characters to upper case. |
| &#124; | Disable a previous shift up or shift down. |
| \\\\ | Escapes a mask character, turning it into a literal. |
| All other characters | Literals. All non-mask elements (literals) will appear as themselves within MaskedTextBox. |

The following example demonstrates the usage of standard mask elements.

{% aspTab template="maskedtextbox/standardmasks", sourceFiles="standardmasks.cs" %}

{% endaspTab %}

Output be like the below.

![MaskedTextBox Sample](./images/stdMask.png)

## Custom mask elements

Other than the above standard mask elements, the mask can be configured with the custom characters or regular expression to define a custom behavior.

### Custom characters

You can define any of the non-mask element as the mask element
and its behavior through the [customCharacters](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.MaskedTextBox.html#Syncfusion_EJ2_Inputs_MaskedTextBox_CustomCharacters) property.

In the following example, non-mask element `P` accepts the values `P, A, p, a`, and `M` accepts the values `M, m`  as mentioned in the custom characters collection.

{% aspTab template="maskedtextbox/custom-mask", sourceFiles="custom-mask.cs" %}

{% endaspTab %}

Output be like the below.

![MaskedTextBox Sample](./images/customMask.png)

### Regular expression

Instead of the mask element, you can define your own regular expression to validate the input of a particular input place.
The regular expressions should be wrapped by the square brackets (e.g., [`Regex`]).

In the following example, regular expression has been set for each input places.

{% aspTab template="maskedtextbox/regularExpression", sourceFiles="regularExpression.cs" %}

{% endaspTab %}

Output be like the below.

![MaskedTextBox Sample](./images/regExp.png)

## Prompt character

The Prompt character is a prompting symbol in the MaskedTextBox for the mask elements. The symbol is used to show the input positions in the MaskedTextBox. You can customize the prompt character of MaskedTextBox
by using the [promptChar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.MaskedTextBox.html#Syncfusion_EJ2_Inputs_MaskedTextBox_PromptChar) property.

The following example demonstrates the MaskedTextBox with customized prompt character as `#`.

{% aspTab template="maskedtextbox/promptmask", sourceFiles="prompt.cs" %}

{% endaspTab %}

Output be like the below.

![MaskedTextBox Sample](./images/promptmask.png)
