using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
