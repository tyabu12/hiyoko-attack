using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange = 5.5f;
    public float power = 1000f;
    public GameObject cannonBall;
    public Transform spawnPoint;

    // Update is called once per frame
    private void Update() {
        // プレイヤー入力による移動
        var newPosX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(newPosX, 0, 0);

        // 移動制限
        var clampedPosX = Mathf.Clamp(
            transform.position.x,
            -moveableRange,
            moveableRange
        );
        transform.position = new Vector2(clampedPosX, transform.position.y);

        // 砲弾発射
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shot();
        }
    }

    private void Shot() {
        var newBullet = Instantiate(
            cannonBall,
            spawnPoint.position,
            Quaternion.identity
        );

        // 砲弾に上向きに外力を加える
        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
    }
}
