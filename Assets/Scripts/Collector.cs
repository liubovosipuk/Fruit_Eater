using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    /*
     *      Collector will collect of fruits and bombs 
     *      and make them inactive in scene
     */

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb" || target.tag == "Fruit")
        {
            target.gameObject.SetActive(false);
        }
    }



} // class 






































