using UnityEngine;

public class itemCollider : MonoBehaviour
{
    [SerializeField] public scriptbird bird;
    //public GameObject item;

    private void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<scriptbird>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird" && bird.birdIsAlive == true)
        {
            bird.powerUp();
            //Debug.Log("item Delted");
            Destroy(gameObject);
        }
    }
}
