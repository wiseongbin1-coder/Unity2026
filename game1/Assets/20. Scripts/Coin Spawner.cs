using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public int coinCount = 10; // 총 생성 개수
    public Vector3 spawnArea = new Vector3(20, 1, 20);

    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    IEnumerator SpawnCoins()
    {
        for (int i = 0; i < coinCount; i++)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                spawnArea.y,
                Random.Range(-spawnArea.z, spawnArea.z)
            );

            Instantiate(coinPrefab, randomPos, Quaternion.identity);

            yield return new WaitForSeconds(5f); // 5초 대기
        }
    }
}