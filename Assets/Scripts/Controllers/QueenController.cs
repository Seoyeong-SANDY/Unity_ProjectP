using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController : MonoBehaviour
{
    int _hp = 30;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _hp--;
            Debug.Log($"{_hp}");
        }
    }
}
