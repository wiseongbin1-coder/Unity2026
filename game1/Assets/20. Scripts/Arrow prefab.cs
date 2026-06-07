using UnityEngine;

public class Arrowprefab : MonoBehaviour
{
    public GameObject arrowPrefab;

    void Start()
    {
        InvokeRepeating(nameof(SpawnArrow), 1f, 0.2f);
    }

    void SpawnArrow()
    {
        float randomX = Random.Range(-20f, 20f);
        float randomZ = Random.Range(-20f, 20f);
        Vector3 spawnPos = new Vector3(randomX, 50f, randomZ);
        Instantiate(arrowPrefab, spawnPos, arrowPrefab.transform.rotation);
    }
}
