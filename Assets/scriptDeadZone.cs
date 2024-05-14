using UnityEngine;

public class scriptDeadZone : MonoBehaviour
{
    [SerializeField] public pipeMoveScript pipe;
    [SerializeField] public scriptbird bird;
    // Start is called before the first frame update
    void Start()
    {
        pipe = GameObject.FindGameObjectWithTag("Pipe").GetComponent<pipeMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)

        {
        if (collision.gameObject.name == "Pipe" && bird.birdIsAlive == false)
        {
            Destroy(gameObject);
        }
    }
}
