using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;

    // Update is called once per frame
    public void DecreaseHP()
    {
        hpGauge.fillAmount -= 0.1f;
    }
}
