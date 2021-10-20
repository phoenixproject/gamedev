using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject bullet;

    public float repeatRate;
    public float jumpForce;

    void Start()
    {
        InvokeRepeating("Shoot", 3.0f, repeatRate);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            ScoreManager.score += 10;
            Destroy(collision.gameObject);
            StartCoroutine("EnemyDeath");
        }
    }

    void Shoot()
    {
        GameObject bulletClone;
        bulletClone = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
        bulletClone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-200, 0));
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    IEnumerator EnemyDeath()
    {
        GetComponent<Animator>().Play("Explosion");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        yield return null;
    }
}
