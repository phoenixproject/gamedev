using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start()
    {

    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void AudioPressed()
    {

    }

    public void RankingPressed()
    {

    }
}
