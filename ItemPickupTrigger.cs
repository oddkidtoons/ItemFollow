using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace triggerFollow {
    public class ItemPickupTrigger : MonoBehaviour
    {

                [SerializeField] UnityEvent collectItem;

       
        // Start is called before the first frame update
        void Start()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                collectItem.Invoke();
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}