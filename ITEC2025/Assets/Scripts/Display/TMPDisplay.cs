using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class TMPDisplay : MonoBehaviour
{
    private SceneChanger sceneChanger;
    private TextMeshProUGUI tmpText;
    private List<string> textSequences = new List<string>
    {
        "Welcome to the Chains of the Ancient.",
        "The two of you are curently blocked in this temple. But do not despair! I will tell you of a way to get out of here.",
        "Try your best and you two will succeed, I know it!"
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
                    sceneChanger.ChangeScene("Level1");
                }
            }
        }
    }

    void DisplayNextText()
    {
        if (currentTextIndex < textSequences.Count)
        {
            typingCoroutine = StartCoroutine(TypeText(textSequences[currentTextIndex]));
            currentTextIndex++;
        }
    }

    IEnumerator TypeText(string text)
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
