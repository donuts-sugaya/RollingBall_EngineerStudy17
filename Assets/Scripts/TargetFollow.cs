using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ターゲットとの距離を一定に保つ
/// </summary>
public class TargetFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 distanceVector3;

    private void Start()
    {
        distanceVector3 = transform.position - target.position;
    }

    void Update()
    {
        transform.position = target.position + distanceVector3;
    }
}