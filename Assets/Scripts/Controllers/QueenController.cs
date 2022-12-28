using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController : MonoBehaviour
{
    public double _maxHp = 30;
    public static double _hp = 30;
    public static double _score = 0;

    void Start()
    {
        _hp = _maxHp;
        _score = 0;
    }

    void Update()
    {
        _score += Time.fixedDeltaTime;
        _hp -= Time.fixedDeltaTime;
        if (_hp <= 0)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _hp -= 10;
            Debug.Log($"{_hp}");
        }
    }

    void GameOver()
    {
        Time.timeScale = 0.0f;
        // UI_EndPopup 
        // 
    }
}
