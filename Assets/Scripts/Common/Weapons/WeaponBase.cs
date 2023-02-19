using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField]
    protected WeaponDataSO weaponData;
    protected float speedBullet;
    protected float fireRate;
    protected bool canAttack;
    protected BulletCtrl bullet;

    [SerializeField] protected Transform pointSpawnBullet;
    protected Transform PointSpawnBullet { get => pointSpawnBullet; }


    public void InitWeapon()
    {
        this.canAttack = true;
        this.bullet = weaponData.Bullet;
        this.speedBullet = weaponData.SpeedBullet;
        this.fireRate = weaponData.FireRate;
    }

    public void CanShoot()
    {
        if (canAttack)
        {
            canAttack = false;
            StartCoroutine(IE_CanShoot());
            Shoot();
        }
    }

    protected IEnumerator IE_CanShoot()
    {
        yield return new WaitForSeconds(fireRate);
        canAttack = true;
    }

    public abstract void Shoot();
}
