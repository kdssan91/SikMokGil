using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator anim;
    int count = 0; 

    private void Start()
    {
        anim = GetComponent<Animator>();     
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetTrigger("Open"); 
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("Close");
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (count == 0)
    //        {
    //            anim.SetTrigger("Open");
    //        }
    //        count++; 
            
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        count--;
    //        if(count == 0)
    //        {
    //            anim.SetTrigger("Close");
    //        }
    //    }
    //}
    
    
}
