using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public int speed = 7;
    public float jumpForce = 8.0f;
    Rigidbody rb;
    public bool jumping = false;
    public bool isDead = false;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead == false) 
      {    
        Vector3 rot = new Vector3(0, transform.rotation.eulerAngles.y, 0);
        transform.rotation = Quaternion.Euler(rot);

        // if(Input.GetKey(KeyCode.W)){
        //     transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // }
        // if(Input.GetKey(KeyCode.A)){
        //     transform.Translate(Vector3.left * speed * Time.deltaTime);
        // }
        // if(Input.GetKey(KeyCode.D)){
        //     transform.Translate(Vector3.right * speed * Time.deltaTime);
        // }

        // if(Input.GetKey(KeyCode.S)){
        //     transform.Translate(Vector3.back * speed * Time.deltaTime);
        // }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        horizontal *= speed * Time.deltaTime;
        vertical *= speed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
        
        if (Input.GetButtonDown("Jump") && !jumping)
        {
            jumping = true;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
      }
    }

    
    private void OnCollisionEnter(Collision collision) //If objects supposed to be bouncing off when colliding, isTrigger unchecked
    {

        if(collision.gameObject.CompareTag("Ground")){
            jumping = false;
        }

        if (collision.gameObject.name == "BeachBall")
        {
            
            Debug.Log("Good kick!");

            
        }
    }

    void OnTriggerEnter(Collider other) //If going one object goes through other, isTrigger checked
    { 
       
        if(other.gameObject.CompareTag("Coin")) 
        { 
            Destroy(other.gameObject); 

            score ++;
            Debug.Log("Your score is " + score + "!");
            
        
        } 

        if(other.gameObject.CompareTag("Enemy")) 
        { 
        GameOver(); 
        } 
    } 

    void GameOver(){
        isDead = true;
     } 
    
}
