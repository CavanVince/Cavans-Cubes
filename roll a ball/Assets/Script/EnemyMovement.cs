using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] Transform enemy;

    [SerializeField] Transform startTransform;

    [SerializeField] Transform endTransform;

    [SerializeField] float enemySpeed;

    Vector3 direction;
    Transform destination;

    private void Start()
    {
        SetDestination(startTransform);
    }
    private void FixedUpdate()
    {
        enemy.GetComponent<Rigidbody>().MovePosition(enemy.position + direction * enemySpeed * Time.deltaTime);

        if (Vector3.Distance(enemy.position, destination.position) < enemySpeed * Time.fixedDeltaTime)
        {
            SetDestination(destination == startTransform ? endTransform : startTransform);
        }
    }
    void SetDestination(Transform dest)
    {
        destination = dest;
        direction = (destination.position - enemy.position).normalized;
    }
}
