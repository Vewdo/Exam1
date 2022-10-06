using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ClubController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Renderer renderer;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        animator = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            animator.enabled = true;
            animator.Play("pull_back");
        }
        
        if (Input.GetKeyUp(KeyCode.Space)){
            animator.Play("push_front");
        }
    }
}
