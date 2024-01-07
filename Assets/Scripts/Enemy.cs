using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 4f;

    void Update()
    {
        EnemyMovement();
    }

    void EnemyMovement()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
        if (transform.position.y < -7f)
        {

            float xPos = Random.Range(-8f, 8f);
            Vector2 newPosition = new Vector2(xPos, 7f);

            transform.position = newPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            DestroyEnemy();
        }

        if (col.tag == "Bullet")
        {
            DestroyEnemy();
        }
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
