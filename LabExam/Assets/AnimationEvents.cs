using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip swingClip;
    [SerializeField]
    AudioClip HitClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void HitBall(){
        GameObject ball = GameObject.Find("GolfBall");
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        BallController ballController = ball.GetComponent<BallController>();
        audioSource.PlayOneShot(HitClip);
        ballRigidbody.isKinematic = false;
        // 12 is a constant multiplier. (it can be any value, this is used to keep things in perspective in terms of physics)
        Vector3 forwardForce = new Vector3(0f,-8f, -ballController.speed * 10);
        ballRigidbody.AddForce(forwardForce, ForceMode.Impulse);
    }

     void PlaySwingSound(){
        audioSource.PlayOneShot(swingClip);
    }
}
