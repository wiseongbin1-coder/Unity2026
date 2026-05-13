using UnityEngine;

public class TargetPosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;  
        Gizmos.DrawSphere(transform.position, 1f);        
    }

}

