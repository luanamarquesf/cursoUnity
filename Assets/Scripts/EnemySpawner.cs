using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;


    List<GameObject> enemysAlive;
    public int positionX = 26;
    public int positionY = -3;
    public int positionZ = 28;
    // Start is called before the first frame update
    void Start()
    {
        enemysAlive = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < enemysAlive.Count; i++)
        {
            if(enemysAlive[i] == null)
            {
                enemysAlive.RemoveAt(i);
                break;
            }
        }
    }

    public void SpawnEnemy()
    {
        Vector3 enemyPosition = new Vector3(26,
            -3, 28);

        GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);

        enemysAlive.Add(newEnemy);
    }
}
