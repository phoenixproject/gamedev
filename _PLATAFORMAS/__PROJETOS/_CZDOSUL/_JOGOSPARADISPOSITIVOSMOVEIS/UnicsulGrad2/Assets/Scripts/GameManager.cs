using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public CharacterController2D controller;

    public AudioSource audioSource;

    private float speed = 40.0f;

    private float axisH = 0f;

    private bool isJumping = false;

    private bool isCrouching = false;

    private bool isAttacking = false;
    
    private bool isPaused = false;

    void Start()
    {

    }

    public void PausePressed()
    {
        isPaused = !(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void AttackPressed()
    {
        isAttacking = true;
    }

    public void JumpPressed()
    {
        isJumping = true;
    }

    void Update()
    {
#if UNITY_ANDROID
        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x < Screen.width / 2)
            {
                axisH = -1;
            }
            else if (touch.position.x > Screen.width / 2)
            {
                axisH = 1;

            }
            else
            {
                axisH = 0;
            }
        }
#endif

#if UNITY_EDITOR
        axisH = Input.GetAxisRaw("Horizontal") * speed;

        if(Input.GetButtonDown("Jump")){
            isJumping = true;
        }
#endif
     
    }

    void FixedUpdate(){
         
         controller.Move(axisH * Time.fixedDeltaTime, isCrouching, isJumping);
         isJumping = false;
    }
}
