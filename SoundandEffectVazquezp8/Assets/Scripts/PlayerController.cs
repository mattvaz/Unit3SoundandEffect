using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public bool doubleSpeed = false;
    public float gravityModifier;
    public AudioClip jumpSound;
    public AudioSource playerAudio;
    public bool gameover = false;
    private Animator PlayerAnis;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public bool doubleJumpUsed = false;
    public float doubleJumpForce;



    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        PlayerAnis = GetComponent<Animator>();

    }
    public bool isONGround = true;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            doubleSpeed = true;
            PlayerAnis.SetFloat("speed_Multiplier", 2.0f);
        }
        else if (doubleSpeed)
        {
            doubleSpeed = false;
            PlayerAnis,SetFloat("Speed_Multiplier", 1.0f);



        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.CompareTag("Ground"))
            {
                isONGround = true;
            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Game Over");
            }
        }
    } 
