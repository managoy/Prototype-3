using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerMovement playerMovementScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovementScript.isGameover == false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
