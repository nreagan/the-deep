﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorHandler : MonoBehaviour {

    public GameObject torpedoPrefab;
    public bool unleashTheBoi;

    //detect a collision (use rigid body, no triggers)
    private void OnCollisionEnter2D(Collision2D collision) {

        //if key collides with player
        if (collision.gameObject.layer == 9 && KeyCount.Keys > 0) {

            //kys
            Die();
        }
    }

    //destroy door
    private void Die() {

        if (unleashTheBoi == true) {
            GameObject t = (GameObject)Instantiate(torpedoPrefab, transform.position, Quaternion.identity);
            t.transform.position = new Vector3(-1.6f, -70, 0);
        }
        Destroy(gameObject);
    }
}