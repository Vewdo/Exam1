using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rigidbody;
    private Renderer renderer;
    private float maxSpeedRatio = 1.3f;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip rollingClip;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnCollisionStay(Collision other){
        if (other.gameObject.name == "Floor"){
            if (!audioSource.isPlaying){
                audioSource.PlayOneShot(rollingClip);
            }
        }
    }
}
