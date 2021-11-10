using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLevelCollider : MonoBehaviour
{
    public GameObject Endscrn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Square")
        {
            Debug.Log("Hi");
            Endscrn.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
    