using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private Rigidbody rigidbody;

    [SerializeField] private Transform ground;

    private bool isGround;

    private void Start()
    {
        var rBody = rigidbody.velocity;
        rBody.x = speed;
        rigidbody.velocity = rBody;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && isGround) {
            // 一定量ジャンプさせる
            var rBody = rigidbody.velocity;
            rBody.y = jumpPower;
            rigidbody.velocity = rBody;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        // 地面についた
        if(other.transform == ground) {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        // 地面から離れた
        if(other.transform == ground) {
            isGround = false;
        }
    }
}