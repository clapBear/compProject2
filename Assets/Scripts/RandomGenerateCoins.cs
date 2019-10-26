using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerateCoins : MonoBehaviour
{
    public Collider boxCollider;
    public Vector3 center;
    public Vector3 size;
    public GameObject CoinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        center = boxCollider.bounds.center;
        size = boxCollider.bounds.size;
        int random = Random.Range(10, 20);
        for(int i = 0; i<=random; i++)
        {
            Debug.Log("generated");
            SpawnCoin();
        }
        
    }
    public void SpawnCoin()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2), 1.05f*-size.y, Random.Range(-size.z / 2, size.z / 2));

        Instantiate(CoinPrefab, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
