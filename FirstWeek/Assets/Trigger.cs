using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other!=null)
        {
            anim.Play();
        }
    }   
}
