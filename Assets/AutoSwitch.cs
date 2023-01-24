using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSwitch : MonoBehaviour
{
    public Animator theAnimator;
    public Animator BulbAnimator;
    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();
        theAnimator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
        }
    }

}

