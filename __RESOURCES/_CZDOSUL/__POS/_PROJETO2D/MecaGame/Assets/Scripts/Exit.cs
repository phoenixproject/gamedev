using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public bool isDoorOpened = false;

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.name == "Player")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine("ExitAnimation");
        }
    }

    IEnumerator ExitAnimation()
    {
        GetComponent<Animator>().Play("DoorOpen");
        yield return new WaitForSeconds(1.0f);
        isDoorOpened = true;
        yield return null;
    }
}
