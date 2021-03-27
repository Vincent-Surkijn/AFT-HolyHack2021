using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePerson : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            bool isTalking = animator.GetBool("isTalking");
            animator.SetBool("isTalking", !isTalking);
        }

    }
}
