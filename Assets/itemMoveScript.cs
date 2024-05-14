using UnityEngine;


public class itemMoveScript : MonoBehaviour
{
    public float speedMove = 1f;
    public float deadZone = -100;
    [SerializeField] public scriptbird bird;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speedMove) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            //Debug.Log("Item Delted");
            Destroy(gameObject); 
        }
    }
}
