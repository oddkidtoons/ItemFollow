using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLAYERTWO.PlatformerProject;



public class followNoTrigger : MonoBehaviour
{
    private GameObject thingToFollow;
    public float StartSpeed = 45;
    public float EndSpeed = 35;
     public string tag;
 

    Vector3 _velocity = Vector3.zero;

    bool _isFollowing = false;
   

    void Start()
    {
      thingToFollow = GameObject.FindGameObjectWithTag(tag);
            StartCoroutine(IsFollowing());
    }

  IEnumerator IsFollowing()
        {

            yield return null;

            _isFollowing = true;

            Debug.Log("move");
        }

        public void Update()
        {
            if (_isFollowing)
            {
                this.gameObject.transform.position = Vector3.SmoothDamp(this.gameObject.transform.position, thingToFollow.transform.position, ref _velocity, Time.deltaTime * Random.Range(EndSpeed, StartSpeed));
            }
        }
}
