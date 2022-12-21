using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Play : MonoBehaviour
{
    public GameObject HpSlider;
    public GameObject ScoreText;

    Slider _hpSlider;
    Text _scoreText;

    void Start()
    {
        _hpSlider = HpSlider.GetComponent<Slider>();
        _hpSlider.maxValue = 30;

        _scoreText = ScoreText.GetComponent<Text>();
    }

    void Update()
    {
        _hpSlider.value = (float)QueenController._hp;
        _scoreText.text = QueenController._score.ToString("N0");
    }
}
