using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawn : MonoBehaviour
{
    public int WaveSize;
    public GameObject Enemy1;
    public float EnemyInterval = 2f;
    public Transform SpawnPoint;
    public float StartTime;
    public string gateTag;
    public Transform[] WayPoints;
    int enemyCount = 0;
    bool Wave = true;
    public GameObject Controller;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", StartTime, EnemyInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (enemyCount == WaveSize)
        {
            CancelInvoke("SpawnEnemy");
            
            Wave = false;
            
        }
        if (Wave == false)
        {
            StartTime = 10f;
            Controller.GetComponent<GameController>().Times = StartTime;
            enemyCount = 0;
            WaveSize++;
            InvokeRepeating("SpawnEnemy", StartTime, EnemyInterval);
            Wave = true;
        }

    }
    void SpawnEnemy()
    {
        enemyCount++;
        GameObject enemy = GameObject.Instantiate(Enemy1, SpawnPoint.position, Quaternion.identity) as GameObject;
        enemy.GetComponent<MoveTowayPoints>().waypoints = WayPoints;
    }
}
