using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadinggame : MonoBehaviour
{
    public RawImage image;
    void Start()
    {
        image = GetComponent<RawImage>();
        StartCoroutine(loop());
    }
    IEnumerator loop()
    {
        for (int i = 0; i > -1; i++)
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            yield return new WaitForSeconds(1);
            tempColor.a = 0.5f;
            image.color = tempColor;
            yield return new WaitForSeconds(1);
        }
    }
}
