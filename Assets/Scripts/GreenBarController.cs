using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBarController : MonoBehaviour
{

    public GameObject redBar;
    public float range;
    Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        range = Random.Range((float)redBar.transform.position.y + (redBar.transform.localScale.y / 2), (float)redBar.transform.position.y - (redBar.transform.localScale.y/2));
        //Manually set the limits the greenBar can move in
        //range = Random.Range((float)-2.5, (float)2.5);
    }

    //Moves the greenBar somewhere within the redBar
    public void Move()
    {
        transform.position = new Vector3(transform.position.x, range, transform.position.z);
    }

    //The size of the greenBar changes
    public void Resize()
    {
        //Lowest I can drop scale is 0.5
        //Highest I can take scale is 2.3

        float random = Random.Range(0.5f, 2.3f);
        transform.localScale = new Vector3(transform.localScale.x, random, transform.localScale.z);
    }
}
