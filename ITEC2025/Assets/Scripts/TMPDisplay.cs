using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class TMPDisplay: MonoBehaviour
{
    private TextMeshProUGUI tmpText;
    private List<string> textSequences;
    public float charactersPerSecond = 10f;
    public float delayBetweenTexts = 1f;

    private int currentTextIndex = 0;

    void Start()
    {
        tmpText = GetComponent<TextMeshProUGUI>();
        textSequences = new List<string>
        {
            "First line of text.",
            "Second line of text.",
            "Third line of text."
        };

        if (tmpText == null)
            tmpText = GetComponent<TextMeshProUGUI>();

        if (textSequences.Count > 0)
            StartCoroutine(DisplayTextsSequentially());
    }

    IEnumerator DisplayTextsSequentially()
    {
        while (currentTextIndex < textSequences.Count)
        {
            yield return StartCoroutine(TypeText(textSequences[currentTextIndex]));
            yield return new WaitForSeconds(delayBetweenTexts);
            currentTextIndex++;
        }
    }

    IEnumerator TypeText(string text)
    {
        tmpText.text = text;
        tmpText.maxVisibleCharacters = 0;
        int totalVisibleCharacters = text.Length;
        int counter = 0;

        while (counter < totalVisibleCharacters)
        {
            counter++;
            tmpText.maxVisibleCharacters = counter;
            yield return new WaitForSeconds(1f / charactersPerSecond);
        }
    }
}
