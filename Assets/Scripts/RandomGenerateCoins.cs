using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerateCoins : MonoBehaviour
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

        int randomC = Random.Range(10, 20);


        for (int i = 0; i<=randomC; i++)
        {
            SpawnCoin();
        }
      

    }
    public void SpawnCoin()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2), -size.y, Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Prefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
