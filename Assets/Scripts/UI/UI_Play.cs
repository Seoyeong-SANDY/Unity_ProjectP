using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Play : MonoBehaviour
{
    [SerializeField]
    GameObject HpSlider;

    int maxHP = QueenController._hp;

    void Start()
    {
        Slider _hpSlider = HpSlider.GetComponent<Slider>();

    }

    void Update()
    {
        
    }
}
