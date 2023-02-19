using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeaponSystem : MonoBehaviour
{
    [SerializeField] private Transform pointSpawnWeapon;
    private WeaponBase equippedWeapon;

    public void EquipWeapon(WeaponBase newWeapon)
    {
        if (equippedWeapon != null)
        {
            Destroy(equippedWeapon.gameObject);
        }

        equippedWeapon = Instantiate(newWeapon, pointSpawnWeapon.position, pointSpawnWeapon.rotation);
        equippedWeapon.InitWeapon();
        equippedWeapon.transform.SetParent(pointSpawnWeapon);
    }

    public void CheckShoot()
    {
        equippedWeapon.CanShoot();
    }
}
