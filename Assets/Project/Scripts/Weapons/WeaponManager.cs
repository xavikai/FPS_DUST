using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon currentWeapon;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("S�est� prement el bot� de disparar");
            currentWeapon?.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("S�est� prement R per recarregar");
            currentWeapon?.Reload();
        }
    }
}
