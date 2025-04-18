using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon currentWeapon;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("S’està prement el botó de disparar");
            currentWeapon?.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("S’està prement R per recarregar");
            currentWeapon?.Reload();
        }
    }
}
