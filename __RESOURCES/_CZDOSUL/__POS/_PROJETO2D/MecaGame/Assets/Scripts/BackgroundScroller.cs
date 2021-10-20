using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

    public float speed = 0;
    public static BackgroundScroller current;

    float pos = 0;

    public GameObject gmObject;
    GameManager gameManager;

	void Start () {
        current = this;

        gameManager = gmObject.GetComponent<GameManager>();
	}

    void Update()
    {
        if (!gameManager.isPaused)
        {
            pos += speed;

            if (pos > 1.0f)
                pos -= 1.0f;

            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos, 0);
        }
    }

}