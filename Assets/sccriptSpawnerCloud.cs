using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class sccriptSpawnerCloud : MonoBehaviour
{
    public GameObject cloud;
    public float heightOffset = 10;
    public float spawnRate = 3;
    public float timer;
    public float moveSpeed = 4;
    public float deadZone= -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {

            Debug.Log("Cloud Delted");
            Destroy(gameObject);

        }
    }
    public void spawnCloud(){

    float lowestPoint = transform.position.y - heightOffset;
    float heighestpoint = transform.position.y + heightOffset;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestpoint), 0), transform.rotation);
    }
}
