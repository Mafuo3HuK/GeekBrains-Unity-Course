using UnityEngine;
using System.Collections;
public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string _ammoBox;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + _ammoBox);
        Destroy(gameObject);
    }
}