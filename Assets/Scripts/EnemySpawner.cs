using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;

    List<GameObject> enemysAlive;
    int positionX = 26;
    int positionY = 1;
    int positionZ = 28;

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

        if(EnemyCounter.inimigosMortos > 20) {
            EnemyCounter.victory = true;
        }
        if(EnemyCounter.inimigosMortos > 4 && EnemyCounter.inimigosMortos < 10 && positionX < 40){
            positionX += 3;
        }
        if(EnemyCounter.inimigosMortos > 10 && EnemyCounter.inimigosMortos < 15 && positionX > 26){
            positionX -= 3;
        } 
        if(EnemyCounter.inimigosMortos > 15 && positionX < 64){
            positionX += 5;
        }
    }

    public void SpawnEnemy()
    {
        Vector3 enemyPosition = new Vector3(positionX, positionY, positionZ);

       
        if(enemysAlive.Count > 1){
            return;
        }

        GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
        enemysAlive.Add(newEnemy);
    }
}
