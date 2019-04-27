using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float deleteTime = 2f;

    private void Start()
    {
        Destroy(gameObject, deleteTime);
    }

    private void Update()
    {
    }
}
