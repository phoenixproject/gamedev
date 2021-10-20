using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool isPaused = false;
    bool isAudioMute = false;

    public Button audioButton;
    public AudioSource audioSource;

    public GameObject boss;
    private Boss script;
    public GameObject winPanel;

    public GameObject player;
    private Meca playerScript;

    public GameObject gameOverPanel;

    void Awake()
    {
        DontDestroyOnLoad(audioSource);
    }

	void Start () {
        
        audioSource.Play();

        script = boss.GetComponent<Boss>();

        playerScript = player.GetComponent<Meca>();
	}
    
    public void PauseGame()
    {
        Debug.Log("Paused");
        isPaused = !(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
            audioSource.Stop();
        }
        else
        {
            Time.timeScale = 1;
            audioSource.Play();
        }
    }

    public void SoundToggle()
    {
        isAudioMute = !(isAudioMute);

        if(isAudioMute)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }
	
	void Update () {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Boss"))
        {
            script.healthBar.gameObject.SetActive(true);
        }

         if (script.isDead)
         {
            winPanel.SetActive(true);
         }else if (playerScript.isDefeated)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
