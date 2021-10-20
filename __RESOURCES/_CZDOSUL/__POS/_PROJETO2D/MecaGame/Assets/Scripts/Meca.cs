using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meca : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 40.0f;
    public float direction = 0;

    private bool isGrounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    public bool facingRight = true;

    public GameObject bullet;

    public GameObject exit;
    private Exit exitScript;

    Rigidbody2D rb;
    Animator animator;

    public Image lifebar;

    [SerializeField]
    private float lifeAmount;

    public bool isDefeated;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        exitScript = exit.GetComponent<Exit>();
    }

    void Flip()
    {
        facingRight = !(facingRight);
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Shoot()
    {
        GameObject bulletClone;
        bulletClone = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;

        if(facingRight)
            bulletClone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(400, 0));
        else
            bulletClone.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-400, 0));
    }

    IEnumerator FadeAndExit()
    {
        for (float f = 3.0f; f >= 0; f -= 0.1f)
        {
            var c = GetComponent<SpriteRenderer>().material.color;
            c.a = f;
            GetComponent<SpriteRenderer>().material.color = c;
            yield return new WaitForSeconds(1.0f);
            SaveGameStats();
            SceneManager.LoadScene("Boss");
        }
    }

    void SaveGameStats()
    {
        PlayerPrefs.SetInt("Score", ScoreManager.score);
        PlayerPrefs.Save();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "BossBullet(Clone)")
        {
            lifeAmount -= 1;
            Destroy(collision.gameObject);
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        float h = Input.GetAxisRaw("Horizontal");
        direction = h;

        if (isGrounded)
        {
            if (h != 0)
                animator.Play("Walk");
            else
                animator.Play("Idle");

            rb.velocity = new Vector2(h * speed, rb.velocity.y);
        }
        else
        {
            Vector3 vel = rb.velocity;
            vel.y -= 130 * Time.deltaTime;
            animator.Play("Jump");

            rb.velocity = vel;
        }

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.Play("Shoot");
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.Play("Attack");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot();
        }

        if (exitScript != null && exitScript.isDoorOpened)
        {
            speed = 0;
            StartCoroutine("FadeAndExit");
        }

        lifebar.fillAmount = lifeAmount / 100;
    }
}
