using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public void Q()
    {
        Application.Quit();
        Debug.Log("tu as quitter le jeu");
    }
    public void LoadingScene()
    {
        StartCoroutine(laisserlepunch());
    }
    IEnumerator laisserlepunch()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
