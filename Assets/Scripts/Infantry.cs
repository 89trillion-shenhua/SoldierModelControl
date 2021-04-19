using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infantry : MonoBehaviour
{
    private Animation animation;
        
    void Start(){
        animation = GetComponent<Animation>();
    }

    void Update () {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animation.wrapMode = WrapMode.Loop;
            animation.Play("Attack");
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            animation.wrapMode = WrapMode.Loop;
            animation.Play("Run");
        }
        else if(Input.GetKeyDown(KeyCode.I))
        {
            animation.wrapMode = WrapMode.Loop;
            animation.Play("Wait");
        }
    }
}