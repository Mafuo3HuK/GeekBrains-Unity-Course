using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(true)
        {
            Destroy(gameObject, 2);
        }
    }

}
