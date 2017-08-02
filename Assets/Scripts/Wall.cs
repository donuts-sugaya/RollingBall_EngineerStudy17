using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 動く壁
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rigidbody;

    void Start()
    {
        var rBody = rigidbody.velocity;
        rBody.x = speed;
        rigidbody.velocity = rBody;
    }
}