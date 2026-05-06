using UnityEngine;
using UnityEngine.SubsystemsImplementation;

public class TargetController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Bamsongi"))
        {
            Destroy(gameObject);
        }
    }
}
