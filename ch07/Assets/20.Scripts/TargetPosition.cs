using UnityEngine;

public class TargetPosition : MonoBehaviour
{
    public float size = 1f;
    public Color color = Color.red;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnDrawGizmos()
    {
        Gizmos.color = color;  
        Gizmos.DrawSphere(transform.position, 1f);        
    }

}

