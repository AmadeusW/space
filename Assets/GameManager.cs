using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int EnemyCount;
    public int EnemyDistance;
    public float EnemySeparation;
    public GameObject OriginalEnemy;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < EnemyCount; i++)
        {
            SpawnEnemy(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy(int i)
    {
        var projectile = Instantiate(OriginalEnemy, new Vector3(0, (float)EnemyDistance, 0), Quaternion.identity);
        var enemy = projectile.GetComponent<EnemyMovement>();
        enemy.SpawnDistance = EnemyDistance;
        enemy.PhaseShift = i * EnemySeparation;
    }
}
