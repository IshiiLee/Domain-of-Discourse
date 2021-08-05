using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerOnClick : MonoBehaviour
{
    public Animator anim;
    public int KeyNum = 1;
    private object KeyPress;


    // https://forum.unity.com/threads/start-animation-on-mouse-click.442023/

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha0 + KeyNum))

        {


            anim.SetTrigger("OnClick");

        }
    }

}


  
