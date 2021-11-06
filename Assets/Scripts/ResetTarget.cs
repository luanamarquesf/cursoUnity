using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTarget : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Inimigo"){
            Destroy(other.gameObject);
        }
    }
}
