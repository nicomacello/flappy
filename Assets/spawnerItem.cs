using UnityEngine;

public class spawnerItem : MonoBehaviour
{
    public GameObject item;
    public float heightOffset = 5;
    [SerializeField] public scriptbird bird;
    public float timer;
    public float spawnRate = 60;
    
    //[SerializeField] public itemMoveScript itemMove;
    // Start is called before the first frame update
    void Start()
    {
        spawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        /*if ((StartPosition - transform.position).magnitude > 0.5f)
        {
            transform.position = StartPosition;
        }*/
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;       
        }
        else
        {
            spawnItem();
            timer = 0;
        }
    }

    private void spawnItem()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestpoint = transform.position.y + heightOffset;

        Instantiate(item, new Vector3 (transform.position.x, Random.Range(lowestPoint, heighestpoint), 0), transform.rotation);
        //item.SetActive(true);
    }
}
