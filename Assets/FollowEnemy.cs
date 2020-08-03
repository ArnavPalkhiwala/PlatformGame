using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    public int speed = 4;
    public GameObject player;
    public float radius = 5f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= radius)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
