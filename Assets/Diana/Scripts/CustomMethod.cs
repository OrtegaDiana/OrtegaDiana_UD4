using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMethod : MonoBehaviour
{
    public bool shouldInitialize = false;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }
    // Update is called once per frame
    void Update()
    {
        if (shouldInitialize)
        {
            shouldInitialize = false;
            Initialize();
        }
    }
    void Initialize()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }
}