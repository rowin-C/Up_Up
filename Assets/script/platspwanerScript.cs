using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platspwanerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2;
    private float timer = 0;
    public float gapOffset = 10;

    void Start()
    {
        spwanPipe();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;

        }

    }

    void spwanPipe()
    {
        float lowestPoint = transform.position.x - gapOffset;
        float highestPoint = transform.position.x + gapOffset;

        Instantiate(pipe, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 0), transform.rotation);

    }
}
