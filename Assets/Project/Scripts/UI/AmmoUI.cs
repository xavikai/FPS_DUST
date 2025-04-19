using UnityEngine;
using TMPro;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ammoText;

    public void UpdateAmmo(int current, int max)
    {
        ammoText.text = $"{current} / {max}";
    }
}
