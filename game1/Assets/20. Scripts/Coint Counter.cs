using UnityEngine;

public class CointCounter : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            gameManager.AddCoin(1);

            AudioSource.PlayClipAtPoint(coinSound, other.transform.position);

            Destroy(other.gameObject);
        }
    }
}