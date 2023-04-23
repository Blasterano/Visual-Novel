using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TMP_InputField countryNameInput;
    public TMP_InputField ageInput;
    public TextMeshProUGUI outputText;

    public void OnSubmit()
    {
        string countryName = countryNameInput.text.Trim();

        if (countryName.ToLower() != "india")
        {
            outputText.text = "You are not an Indian.";
        }
        else
        {
            if (int.TryParse(ageInput.text.Trim(), out int age))
            {
                if (age >= 18)
                {
                    outputText.text = "You are eligible for voting. You are " + age + " years old.\n";

                    string countryName2 = countryNameInput.text.Trim();
                    if (countryName2.ToLower() == "india")
                    {
                        outputText.text += "You are an Indian and your country name is " + countryName2 + ".";
                    }
                    else
                    {
                        outputText.text += "You are not an Indian and your country name is " + countryName2 + ".";
                    }
                }
                else
                {
                    outputText.text = "You are not eligible for voting because you are " + age + " years old.";
                }
            }
            else
            {
                outputText.text = "Invalid age input.";
            }
        }
    }
}
