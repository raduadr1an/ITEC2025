using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Outro_Text : MonoBehaviour
{
    private SceneChanger sceneChanger;
    private TextMeshProUGUI tmpText;
    private List<string> textSequences = new List<string>
    {
        "Congratulations you were able to escape the temple!",
        "Now the two of you are finally free!",
        "The Tralalero Tralala vs Bombardiro Crocodilo team thanks you for playing the game!"
    };
    public float charactersPerSecond = 10f;

    private int currentTextIndex = 0;
    private Coroutine typingCoroutine;
    private bool isTyping = false;

    void Start()
    {
        tmpText = GetComponent<TextMeshProUGUI>();
        sceneChanger = FindFirstObjectByType<SceneChanger>();

        DisplayNextText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                StopCoroutine(typingCoroutine);
                tmpText.maxVisibleCharacters = tmpText.text.Length;
                isTyping = false;
            }
            else
            {
                if (currentTextIndex < textSequences.Count)
                {
                    DisplayNextText();
                }
                else
                {
                    sceneChanger.ChangeScene("MainMenu");
                }
            }
        }
    }

    void DisplayNextText()
    {
        if (currentTextIndex < textSequences.Count)
        {
            typingCoroutine = StartCoroutine(Typetext(textSequences[currentTextIndex]));
            currentTextIndex++;
        }
    }

    IEnumerator Typetext(string text)
    {
        isTyping = true;
        tmpText.text = text;
        tmpText.maxVisibleCharacters = 0;

        foreach (char c in text)
        {
            tmpText.maxVisibleCharacters++;
            yield return new WaitForSeconds(1f / charactersPerSecond);
        }

        isTyping = false;
    }
}
