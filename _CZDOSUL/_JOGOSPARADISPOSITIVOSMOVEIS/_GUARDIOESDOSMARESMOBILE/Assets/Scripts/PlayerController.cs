using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public float moveSpeed;
    public Rigidbody2D theRB;

    public Transform bottomLeftLimit, topRightLimit;

    public Transform shotPoint;
    public GameObject shot;

    public float timeBetweenShots = .1f;
    private float shotCounter;

    private float normalSpeed;
    public float boostSpeed;
    public float boostLength;
    private float boostCounter;

    public bool doubleShotActive;
    public float doubleShotOffset;

    public bool stopMovement;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        normalSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
        {
            HandleTouch();
        }
        else
        {
            HandleMouse();
        }
    }

    void HandleMouse()
    {
        if (!stopMovement)
        {
            theRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightLimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightLimit.position.y), transform.position.z);

            if (Input.GetButtonDown("Fire1"))
            {
                if (!doubleShotActive)
                {
                    Instantiate(shot, shotPoint.position, shotPoint.rotation);
                }
                else
                {
                    Instantiate(shot, shotPoint.position + new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                    Instantiate(shot, shotPoint.position - new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                }

                shotCounter = timeBetweenShots;
            }

            if (Input.GetButton("Fire1"))
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    if (!doubleShotActive)
                    {
                        Instantiate(shot, shotPoint.position, shotPoint.rotation);
                    }
                    else
                    {
                        Instantiate(shot, shotPoint.position + new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                        Instantiate(shot, shotPoint.position - new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                    }
                    shotCounter = timeBetweenShots;
                }
            }

            if (boostCounter > 0)
            {
                boostCounter -= Time.deltaTime;
                if (boostCounter <= 0)
                {
                    moveSpeed = normalSpeed;
                }
            }
        }
        else
        {
            theRB.velocity = Vector2.zero;
        }
    }

    void HandleTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                theRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightLimit.position.x),
                    Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightLimit.position.y),
                    transform.position.z

                    );

                if (touch.position.x < Screen.width / 2 && transform.position.x > -3.75f)
                    transform.position = new Vector2(transform.position.x - 0.4f, transform.position.y);

                if (touch.position.x > Screen.width / 2 && transform.position.x < 3.75f)
                    transform.position = new Vector2(transform.position.x + 0.4f, transform.position.y);

                if (touch.position.y < Screen.height / 2 && transform.position.y > -3.75f)
                    transform.position = new Vector2(transform.position.x, transform.position.y - 0.4f);

                if (touch.position.y > Screen.height / 2 && transform.position.y < 3.75f)
                    transform.position = new Vector2(transform.position.x, transform.position.y + 0.4f);

                if (boostCounter > 0)
                {
                    boostCounter -= Time.deltaTime;
                    if (boostCounter <= 0)
                    {
                        moveSpeed = normalSpeed;
                    }
                }
            }
        }

        if (Input.touchCount > 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (!doubleShotActive)
                {
                    Instantiate(shot, shotPoint.position, shotPoint.rotation);
                }
                else
                {
                    Instantiate(shot, shotPoint.position + new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                    Instantiate(shot, shotPoint.position - new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                }

                shotCounter = timeBetweenShots;
            }

            if (Input.GetButton("Fire1"))
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    if (!doubleShotActive)
                    {
                        Instantiate(shot, shotPoint.position, shotPoint.rotation);
                    }
                    else
                    {
                        Instantiate(shot, shotPoint.position + new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                        Instantiate(shot, shotPoint.position - new Vector3(0f, doubleShotOffset, 0f), shotPoint.rotation);
                    }
                    shotCounter = timeBetweenShots;
                }
            }
        }

    }

    public void ActivateSpeedBoost()
    {
        boostCounter = boostLength;
        moveSpeed = boostSpeed;
    }
}