using System.Collections;
using System.Collections.Generic;
using GameDevTV.Inventories;
using UnityEngine;


namespace InventoryExample.Control
{
    public class RunOverPickUp : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var player = GameObject.FindGameObjectWithTag("Player");
                if(other.gameObject == player)
            {
                GetComponent<Pickup>().PickupItem();
            }
        }
    }

}

