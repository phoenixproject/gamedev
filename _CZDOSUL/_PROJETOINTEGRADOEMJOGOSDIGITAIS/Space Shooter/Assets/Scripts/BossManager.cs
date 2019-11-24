using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public static BossManager instance;
    public string bossName;

    public int currentHealth = 100;

    //public BattleShot[] shotsToFire;

    public BattlePhase[] phases;
    public int currentPhase;
    public Animator bossAnim;

    public GameObject endExplosion;
    public bool battleEnding;
    public float timeToExplosionEnd;
    public float waitToEndLevel;

    public Transform theBoss;

    public int scoreValue = 5000;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UIManager.instance.bossName.text = bossName;
        UIManager.instance.bossHealthSlider.maxValue = currentHealth;
        UIManager.instance.bossHealthSlider.value = currentHealth;
        UIManager.instance.bossHealthSlider.gameObject.SetActive(true);

        MusicController.instance.PlayBoss();
    }

    // Update is called once per frame
    void Update()
    {
        /* for(int i = 0; i < shotsToFire.Length; i++ )
        {
            shotsToFire[i].shotCounter -= Time.deltaTime;

            if(shotsToFire[i].shotCounter <= 0)
            {
                shotsToFire[i].shotCounter = shotsToFire[i].timeBetweenShots;
                Instantiate(shotsToFire[i].theShot, shotsToFire[i].firePoint.position, shotsToFire[i].firePoint.rotation);
            }
        } */
        if (!battleEnding)
        {
            if (currentHealth <= phases[currentPhase].healthToEndPhase)
            {
                phases[currentPhase].removeAtPhaseEnd.SetActive(false);
                Instantiate(phases[currentPhase].addAtPhaseEnd, phases[currentPhase].newSpawnPoint.position, phases[currentPhase].newSpawnPoint.rotation);

                currentPhase++;

                bossAnim.SetInteger("Phase", currentPhase + 1);
            }
            else
            {
                for (int i = 0; i < phases[currentPhase].phaseShots.Length; i++)
                {
                    phases[currentPhase].phaseShots[i].shotCounter -= Time.deltaTime;

                    if (phases[currentPhase].phaseShots[i].shotCounter <= 0)
                    {
                        phases[currentPhase].phaseShots[i].shotCounter = phases[currentPhase].phaseShots[i].timeBetweenShots;
                        Instantiate(phases[currentPhase].phaseShots[i].theShot, phases[currentPhase].phaseShots[i].firePoint.position, phases[currentPhase].phaseShots[i].firePoint.rotation);
                    }
                }
            }
        }
    }

    public void HurtBoss()
    {
        currentHealth--;
        UIManager.instance.bossHealthSlider.value = currentHealth;

        if (currentHealth <= 0 && !battleEnding)
        {
            /* Destroy(gameObject);
            UIManager.instance.bossHealthSlider.gameObject.SetActive(false); */

            battleEnding = true;
            StartCoroutine(EndBattleCo());
        }
    }

    public IEnumerator EndBattleCo()
    {
        UIManager.instance.bossHealthSlider.gameObject.SetActive(false);
        Instantiate(endExplosion, theBoss.position, theBoss.rotation);
        bossAnim.enabled = false;
        GameManager.instance.AddScore(scoreValue);

        yield return new WaitForSeconds(timeToExplosionEnd);

        theBoss.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitToEndLevel);
        StartCoroutine(GameManager.instance.EndLevelCo());
    }
}

[System.Serializable]
public class BattleShot
{
    public GameObject theShot;
    public float timeBetweenShots;
    public float shotCounter;
    public Transform firePoint;
}

[System.Serializable]
public class BattlePhase
{
    public BattleShot[] phaseShots;
    public int healthToEndPhase;
    public GameObject removeAtPhaseEnd;
    public GameObject addAtPhaseEnd;
    public Transform newSpawnPoint;
}
