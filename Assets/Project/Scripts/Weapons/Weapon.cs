using UnityEngine;

public class Weapon : MonoBehaviour, IWeapon
{
    [Header("Stats")]
    public float damage = 25f;
    public float range = 100f;
    public int maxAmmo = 30;
    public float fireRate = 0.2f;

    [Header("References")]
    public Camera playerCamera;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource shootAudio;
    [SerializeField] private AmmoUI ammoUI;

    private int currentAmmo;
    private float nextTimeToFire = 0f;

    private void Start()
    {
        currentAmmo = maxAmmo;
        ammoUI?.UpdateAmmo(currentAmmo, maxAmmo);
    }

    public void Shoot()
    {
        if (Time.time < nextTimeToFire || currentAmmo <= 0)
        {
            Debug.Log("No puc disparar ara");
            return;
        }

        nextTimeToFire = Time.time + fireRate;

        currentAmmo--;  // ⬅️ RESTEM MUNI
        Debug.Log($"Munició després de disparar: {currentAmmo} / {maxAmmo}");

        ammoUI?.UpdateAmmo(currentAmmo, maxAmmo);

        muzzleFlash?.Play();
        //shootAudio?.Play();

        Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * range, Color.red, 1.5f);

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out RaycastHit hit, range))
        {
            Debug.Log($"Impacte a: {hit.collider.name}");

            if (impactEffect != null)
                Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }


    public void Reload()
    {
        currentAmmo = maxAmmo;
        ammoUI?.UpdateAmmo(currentAmmo, maxAmmo);
    }
}
