using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float angle=2.5f;                //angle is half the scale of red bar
    private float move;                     //allows the arrow to move up and down in red bar
    public int count = 0;                   //keeps a track of score
    public bool isGame = true;              //if you mess up, ends the game
    public GameObject greenBar;             //moves the greenBar on the bases of some change in the code
    private GreenBarController script;      //access the script of the attached gameObject

    public GameObject hammer;
    Animator hammerAnimator;


    // Start is called before the first frame update
    void Start()
    {
        greenBar = GameObject.Find("GreenBar");
        script=greenBar.GetComponent<GreenBarController>();

        hammerAnimator=hammer.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //Condition that once count is 3 or you press in redBar the game ends
        if (isGame && count!=3)
        {

            move = Mathf.Sin(Time.time) * angle;

            //Moves the arrow
            transform.position = new Vector3(transform.position.x, move, transform.position.z);


            if (Input.GetButtonDown("Jump"))
            {
                hammerAnimator.SetTrigger("Input");

                //if (Mathf.Abs(transform.position.y) <= 0.75)

                //if (Mathf.Abs(transform.position.y) <= Mathf.Abs(greenBar.transform.position.y+greenBar.transform.localScale.y))

                //if (Mathf.Abs(move)<=0.3)

                if (transform.position.y <= (greenBar.transform.position.y + (greenBar.transform.localScale.y) / 2) &&
                        transform.position.y >= (greenBar.transform.position.y - (greenBar.transform.localScale.y) / 2))

                {

                    count++;

                    script.Resize();
                    script.Move();
                }

                else
                {
                    isGame = false;
                    Debug.Log(move);
                }
            }
        }
    }
}
