using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon currentWeapon;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            currentWeapon?.Shoot();

        if (Input.GetKeyDown(KeyCode.R))
            currentWeapon?.Reload();
    }
}
