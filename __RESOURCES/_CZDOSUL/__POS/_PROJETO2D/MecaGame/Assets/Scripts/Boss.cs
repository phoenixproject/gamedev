using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public float speed = 30.0f;
    private bool facingRight = false;
    public bool isDead = false;

    public Slider healthBar;

    public GameObject player;
    private Meca playerScript;

    public GameObject boundsLeft;
    public GameObject boundsRight;
    public GameObject bullet;

    private Animator anim;

    private BossStates currentState = BossStates.Idle;

    public enum BossStates
    {
        Idle,
        Moving,
        Shooting,
        Dashing,
        Dead
    }

	void Start () {
        healthBar.value = 100;

        anim = GetComponent<Animator>();
        playerScript = player.GetComponent<Meca>();
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            if (healthBar.value > 0)
            {
                ScoreManager.score += 10;
                StartCoroutine("CreateHitEffect");
            }
            else
            {
                StartCoroutine("BossDefeated");
            }

            healthBar.value -= 5;
            Destroy(collision.gameObject);
        }
    }

    IEnumerator Shoot()
    {
        GameObject bulletClone;
        bulletClone = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;

        if (facingRight)
            bulletClone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(300, 0));
        else
            bulletClone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-300, 0));

        anim.Play("BossShoot");
        yield return new WaitForSeconds(2.0f);
    }

    IEnumerator CreateHitEffect()
    {
        for (int n = 0; n < 5; n++)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(.1f);
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(.1f);
        }

        GetComponent<SpriteRenderer>().enabled = true;
    }

    IEnumerator BossDefeated()
    {
        Debug.Log("Boss Defeated");
        currentState = BossStates.Dead;
        GetComponent<BoxCollider2D>().enabled = false;
        anim.Play("BossDead");
        yield return new WaitForSeconds(1.5f);
        isDead = true;
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
        yield return null;
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Update () {

    }

    void FixedUpdate()
    {

    }
}
