using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            canons();

            fBoostCounter();
        }
        else
        {
            theRB.velocity = Vector2.zero;
        }
    }

    void HandleTouch()
    {

        Touch touch = Input.GetTouch(0);

        theRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0.0f));

        if (touch.position.x < Screen.width / 2 && transform.position.x > -3.5f)
            transform.position = Vector3.Lerp(transform.position, new Vector3(touchPosition.x, touchPosition.y, 0.0f), Time.deltaTime * 1.0f);

        if (touch.position.x > Screen.width / 2 && transform.position.x < 3.5f)
            transform.position = Vector3.Lerp(transform.position, new Vector3(touchPosition.x, touchPosition.y, 0.0f), Time.deltaTime * 1.0f);

        if (touch.position.y < Screen.height / 2 && transform.position.y > -3.5f)
            transform.position = Vector3.Lerp(transform.position, new Vector3(touchPosition.x, touchPosition.y, 0.0f), Time.deltaTime * 1.0f);

        if (touch.position.y > Screen.height / 2 && transform.position.y < 3.5f)
            transform.position = Vector3.Lerp(transform.position, new Vector3(touchPosition.x, touchPosition.y, 0.0f), Time.deltaTime * 1.0f);

        fBoostCounter();

        if (Input.touchCount > 1)
        {
            canons();
        }
    }

    void canons()
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
    void fBoostCounter()
    {
        if (boostCounter > 0)
        {
            boostCounter -= Time.deltaTime;
            if (boostCounter <= 0)
            {
                moveSpeed = normalSpeed;
            }
        }
    }
    public void ActivateSpeedBoost()
    {
        boostCounter = boostLength;
        moveSpeed = boostSpeed;
    }
}