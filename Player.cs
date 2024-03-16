using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;

    public GameObject prefab;

    public float shootInterval;
    public float shootTimer;

    public Transform shootPoint;

    void Update()
    {
        Move();

        shootTimer -= Time.deltaTime;

        Shoot();
    }

    void Shoot()
    {
        if (shootTimer <= 0)
        {
            Instantiate(prefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}
