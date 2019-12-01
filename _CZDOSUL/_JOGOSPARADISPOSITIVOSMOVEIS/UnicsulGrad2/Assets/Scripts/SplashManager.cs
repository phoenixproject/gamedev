using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("MenuScene");
        yield return null;
    }
}
