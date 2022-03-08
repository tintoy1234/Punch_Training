using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public int numObjects = 0;
    public GameObject enemy;
    float next_spawn;
    public float rate_spawn = 1;
    void Update()
    {
        if (Time.time > next_spawn)
        {
            numObjects += 1;
            Vector3 center = transform.position;
            for (int i = 0; i < numObjects; i++)
            {
                Vector3 pos = RandomCircle(center, 12f);
                Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center);
                Instantiate(enemy, pos, Quaternion.identity);
                numObjects = 0;
            }
            next_spawn = Time.time + rate_spawn;
        }

    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 100;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + 1;
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }




    /*float theta_scale = 0.01f;          //Set lower to add more points
    public int size;                    //Total number of points in circle
    public float radius = 3f;
    public GameObject enemy;
    public float next_spawn_time;

    void Awake()
    {
        next_spawn_time = Time.time + 0.5f;
    }

    void Update()
    {
        if (Time.time > next_spawn_time) 
        {
            float sizeValue = (Random.Range(0, 2) * Mathf.PI) / theta_scale;
            size = (int)sizeValue;
        }
        Vector3 pos;
        float theta = 0f;
        for (int i = 0; i < size; i++)
        {
                theta += (2f * Mathf.PI * theta_scale);
                float x = radius * Mathf.Cos(theta);
                float z = radius * Mathf.Sin(theta);
                x += gameObject.transform.position.x;
                z += gameObject.transform.position.y;
                pos = new Vector3(x, 0, z);
                Instantiate(enemy, pos, Quaternion.identity);
                next_spawn_time += 0.5f;
        }
    }
            /*if (Time.time > next_spawn_time)
        {
            size++;
        }*/
}
