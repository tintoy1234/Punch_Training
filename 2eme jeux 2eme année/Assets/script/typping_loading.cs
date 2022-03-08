using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typping_loading : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    public GameObject othertext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
        othertext.SetActive(false);
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(3);
        othertext.SetActive(true);
    }
}
