using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyA;
    [SerializeField]
    private GameObject EnemyB;
    [SerializeField]
    private GameObject EnemyC;



    [SerializeField]
    private float SpawnIntervalA = 10.5f;
    [SerializeField]
    private float SpawnIntervalB = 14.5f;
    [SerializeField]
    private float SpawnIntervalC = 14.5f;
    [SerializeField]


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(SpawnIntervalA, EnemyA));
        StartCoroutine(SpawnEnemy(SpawnIntervalB, EnemyB));
        StartCoroutine(SpawnEnemy(SpawnIntervalC, EnemyC));

    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-20f, 20), Random.Range(-3f, 6f), 0), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
