using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLAYERTWO.PlatformerProject;


namespace triggerFollow
{
    public class follow : MonoBehaviour
    {
        public GameObject player;
        public float StartSpeed = 45;
        public float EndSpeed = 35;



        Vector3 _velocity = Vector3.zero;


        bool _isFollowing = false;

        void Start()
        {
            player = FindObjectOfType<Player>().gameObject;
          
        }

        private void OnTriggerEnter(Collider collider)
        {
            StartCoroutine(IsFollowing());
            Debug.Log("trigger");
        }

        public void triggerMe()
        {
            StartCoroutine(IsFollowing());
            Debug.Log("trigger");
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
                this.gameObject.transform.position = Vector3.SmoothDamp(this.gameObject.transform.position, player.transform.position, ref _velocity, Time.deltaTime * Random.Range(EndSpeed, StartSpeed));
            }
        }
    }
}