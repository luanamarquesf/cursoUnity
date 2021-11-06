using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject target;

    public int vida = 10;

    public float velocity = 0.0001f;

    public float position_X = 1; //soma e subtrai
    public float position_Y = 0; //soma e subtrai
    public float position_Z = 1; //sub

    public float dificultLevel = 0.01f;

    private void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        position_Z += dificultLevel;
        //positionY += dificultLevel;
        Debug.Log(position_X);
        Vector3 step = new Vector3(26 + position_X, 1 + position_Y, 28 - position_Z);
        transform.position += step * velocity;
    }
}
