using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimatino : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayAnimation()
    {
        GetComponent<Animator>().SetBool("Run", true);
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
