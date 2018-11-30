using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChHeAnimator : MonoBehaviour {

    public bool isExhaling;
    public bool hasExhaled;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetBool("isExhaling", true);
            anim.SetBool("hasExhaled", true);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("isExhaling", false);
            anim.SetBool("hasExhaled", false);
        }
    }

}
