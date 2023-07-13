using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLAYERTWO.PlatformerProject;



public class followNoTrigger : MonoBehaviour
{
    public GameObject player;
    public float StartSpeed = 45;
    public float EndSpeed = 35;
    
 

    Vector3 _velocity = Vector3.zero;

    bool _isFollowing = false;
   

    void Start()
    {
     player = FindObjectOfType<Player>().gameObject;
        _isFollowing = true;
    }

 


       

        void Update()
    {
        if (_isFollowing)
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.transform.position, ref _velocity, Time.deltaTime * Random.Range(EndSpeed, StartSpeed));

        }
    }
}
