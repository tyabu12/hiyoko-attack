using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour
{
    public GameObject obj;
    public float interval = 3f;

    private void Start() {
        // 初回は 0.1sec 後、その後は interval 毎に SpawnObj 関数を呼び出す
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    private void SpawnObj() {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
