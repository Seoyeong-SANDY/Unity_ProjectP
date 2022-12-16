using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PetController : MonoBehaviour
{
    public GameObject target;
    public float _rotateSpeed = 3;

    void Start()
    {

    }

    void Update()
    {
        target.transform.Rotate(0, 0, 1);

    }
}
