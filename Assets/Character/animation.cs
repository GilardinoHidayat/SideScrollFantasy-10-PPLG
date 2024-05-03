using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    if(Input.GetKey(KeyCode.A) | (Input.GetKey(KeyCode.D) | (Input.GetKey(KeyCode.LeftArrow) | (Input.GetKey(KeyCode.RightArrow)))))
    {
        anim.SetBool("isMove" , true);
    }
    else
    {
        anim.SetBool("isMove" , false);
    }
    if(Input.GetKeyDown(KeyCode.Space))
    {
        anim.SetTrigger("isJump");
    }

    
}}