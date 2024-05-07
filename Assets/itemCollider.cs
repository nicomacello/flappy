using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class itemCollider : MonoBehaviour
{
    [SerializeField] public scriptbird bird;

    private void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            bird.powerUp();
            Debug.Log("item Delted");
            Destroy(gameObject);
        }
    }
}
