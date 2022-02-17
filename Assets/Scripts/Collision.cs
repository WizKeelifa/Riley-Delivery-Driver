using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
       Debug.Log("I have squirrels in my pants!"); 
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Butter Nut!");
    }
}
