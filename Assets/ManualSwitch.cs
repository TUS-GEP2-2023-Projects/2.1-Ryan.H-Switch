using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualSwitch : MonoBehaviour
{
    public Animator theAnimator;
    public Animator BulbAnimator;
    public bool KeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();
        theAnimator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            KeyPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            KeyPressed = false;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && KeyPressed == true) 
            {
                theAnimator.SetBool("IsTouching", true);
                BulbAnimator.SetBool("BulbOn", true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            theAnimator.SetBool("IsTouching", false);
            BulbAnimator.SetBool("BulbOn", false);
            KeyPressed = false;
        }
    }

}

