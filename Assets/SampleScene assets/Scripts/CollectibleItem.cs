using UnityEngine;
using System.Collections;
public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string AmmoBox;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + AmmoBox);
        Destroy(gameObject);
    }
}