using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isEnemyTwo = false;
    float speed = 4f;

    void Update()
    {
        if (isEnemyTwo)
        {
            // EnemyTwo moves side to side while going down
            float xMove = Mathf.Sin(Time.time * 3f);
            transform.Translate(new Vector3(xMove, -1, 0) * Time.deltaTime * speed);
        }
        else
        {
            // EnemyOne moves straight down
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        // Destroy if off-screen
        if (transform.position.y < -6.5f)
        {
            Destroy(gameObject);
        }
    }
}