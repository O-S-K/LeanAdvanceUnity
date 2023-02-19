using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Weapon", fileName = "WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    [SerializeField] private float speedBullet = 10;
    public float SpeedBullet { get => speedBullet; }

    [SerializeField] private float fireRate = 1;
    public float FireRate { get => fireRate; }

    [SerializeField] protected BulletCtrl bullet;
    public BulletCtrl Bullet { get => bullet; }


}
