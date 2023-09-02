using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Working");
        if (other.gameObject.tag.Equals("Armour"))
        {
            //Instantiate(particle,transform.position, Quaternion.identity);
        }
    }
}
