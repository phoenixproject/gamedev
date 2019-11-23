using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    public Vector2 startDirection;

    public bool shouldChangeDirection;
    public float changeDirectionXPoint;
    public Vector2 changedDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        
        if (!shouldChangeDirection)
        {
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
        }
        else
        {
            if(transform.position.x > changeDirectionXPoint)
            {
                transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
            }
            else
            {
                transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
