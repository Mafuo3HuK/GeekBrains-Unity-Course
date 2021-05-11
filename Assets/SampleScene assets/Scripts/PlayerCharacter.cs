using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    public void Hurt(int damage)
    {
        _health = 5;
        _health -= damage;
        Debug.Log("Health: " + _health);
    }
}
