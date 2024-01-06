using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6f;
    [SerializeField]
    private float _fireRate = 0.15f;
    private int _power = 0;

    [SerializeField]
    private GameObject[] bullets;


    private float canFire = 0;

    void Update()
    {
        MovePlayer();

        if(Input.GetKey(KeyCode.Space) && Time.time > canFire)
        {
            Fire();
        }
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        Vector3 newPosition = transform.position + movement * _speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -8.6f, 8.6f);
        newPosition.y = Mathf.Clamp(newPosition.y, -4.8f, 4.8f);
        transform.position = newPosition;
    }

    void Fire()
    {
        canFire = Time.time + _fireRate;

        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + 0.5f);
        GameObject bulletPrefab = bullets[_power];
        Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
    }
}
