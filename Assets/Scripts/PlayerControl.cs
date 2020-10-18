﻿using UnityEngine;
using System;
using System.Collections;

public class PlayerControl : MonoBehaviour {

      public float speed = 0.2f ;
      public string axisName = "Horizontal";
      public float jump = 1;

      void Update () {
            //movement code
            transform.position += transform.right * Input.GetAxis(axisName)* speed;

            //jump code
            if (Input.GetKey(KeyCode.UpArrow)){
                  Vector3 position = this.transform.position;
                  position.y += jump / 4;
                  this.transform.position = position;
            }

            //flip character based on movement direction
            if (Input.GetAxis (axisName) < 0){
                  Vector3 newScale = transform.localScale;
                  newScale.x = 1.0f;
                  transform.localScale = newScale;
            }
            else if (Input.GetAxis (axisName) > 0){
                  Vector3 newScale =transform.localScale;
                  newScale.x = -1.0f;
                  transform.localScale = newScale;
           }
     }

     private void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.CompareTag("NormalMushroom")){
                  GameObject.Destroy(other.gameObject);
            }
     }


}