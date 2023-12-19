using System;
using Unity.Entities;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class TextInfo : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        float fps = 1.0f / Time.deltaTime;
        int amount = GameObject.FindGameObjectsWithTag("Asteroid").Length;
        _text.SetText("\nFPS: " + math.round(fps) + "\nAsteroids: " + amount);
    }
}
