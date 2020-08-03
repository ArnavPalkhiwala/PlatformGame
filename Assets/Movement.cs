using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public int speed = 5;
    public bool goingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <= -7.0f){
            goingRight = true;
        }

        if (transform.position.x >= 7.0f)
        {
            goingRight = false;
        }

        if(goingRight){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        else{
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
