using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;
    public float minPower = 100f;

    float startY;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            
            
            float power = Input.mousePosition.y - startY;
            if (power < minPower) return;

            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;

            Vector3 dir = transform.forward + transform.up * 0.5f;
             bamsongi.GetComponent<BamsongiController>().Shoot(dir * power * throwForce);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //bamsongi.GetComponent<BamsongiController>().Shoot(ray.direction * 2000);
        }
    }
}
