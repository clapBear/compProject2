using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerateObstacles : MonoBehaviour
{
    public Collider boxCollider;
    public Vector3 center;
    public Vector3 size;
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        center = boxCollider.bounds.center;
        size = boxCollider.bounds.size;

        int randomO = Random.Range(1,3);

        for (int i = 0; i <= randomO; i++)
        {
            SpawnObstacle();
        }
    }
    public void SpawnObstacle()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Prefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
