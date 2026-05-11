using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SubsystemsImplementation;

public class TargetController : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bamsongi"))
        {
            Destroy(gameObject);
        }
    }
}