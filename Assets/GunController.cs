using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject OriginalProjectile;
    public float ProjectileLifetime;
    public float ProjectileSpeed;

    private Vector3 xAxis = new Vector3(1, 0, 0);
    private Vector3 zAxis = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnProjectile();
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(zAxis, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(xAxis, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(zAxis, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(xAxis, -1);
        }
    }

    private void SpawnProjectile()
    {
        var projectile = Instantiate(OriginalProjectile, this.transform.position, this.transform.rotation);
        var body = projectile.GetComponent<Rigidbody>();
        var angle = this.transform.forward;
        body.velocity = new Vector3(angle.y, angle.z, angle.x) * ProjectileSpeed;
        Destroy(projectile.gameObject, ProjectileLifetime);
    }
}
