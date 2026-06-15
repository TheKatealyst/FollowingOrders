using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public float shakeAmount = 7.5f;
    public float shakeSpeed = 1f;

    private Vector3 initialPos;

    void Start()
    {
        initialPos = transform.localPosition;
    }

    void Update()
    {
        float y = Mathf.PerlinNoise(0, Time.time * shakeSpeed) * shakeAmount * 2 - shakeAmount;
        transform.localPosition = initialPos + new Vector3(0, y, 0);
    }
}