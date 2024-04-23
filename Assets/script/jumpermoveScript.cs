using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpermoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public GameObject gameOverScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
           
        }
        if (Input.GetKeyDown("right"))
        {
            myRigidbody.velocity = Vector2.right * jumpStrength;

        }
        if (Input.GetKeyDown("left"))
        {
            myRigidbody.velocity = Vector2.left * jumpStrength;

        }

        if(transform.position.y < -5.7)
        {
            Destroy(myRigidbody);
            gameOverScreen.SetActive(true);
        }




    }
}
