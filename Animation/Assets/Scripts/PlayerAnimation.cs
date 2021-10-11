using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
             //if press A, change to kick animation
            animator.SetBool("isKick", true);
            // animator.SetFloat("animation", 1);
        }
        if (Input.GetKey(KeyCode.S)){
             //if press A, change to kick animation
            // animator.SetFloat("animation", 2);
        }
        if (Input.GetKey(KeyCode.D)){
             //if press A, change to kick animation
            // animator.SetFloat("animation", 3);
            animator.SetBool("isKick", false);
        }

    }
}
