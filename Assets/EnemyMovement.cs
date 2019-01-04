using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float Radius;
    public float SpawnDistance;
    public float Speed;
    public float ApproachSpeed;
    public float PhaseShift;

    private float SpawnTime;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        var t = Time.time - SpawnTime;
        var x = Mathf.Sin(t * Speed + PhaseShift) * Radius;
        var z = Mathf.Cos(t * Speed + PhaseShift) * Radius;
        var y = SpawnDistance - t * ApproachSpeed;
        transform.position = new Vector3(x, y, z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player Projectile"))
        {
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
