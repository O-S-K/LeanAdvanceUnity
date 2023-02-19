using UnityEngine;

public class GunLauncher : WeaponBase
{
    public override void Shoot()
    {
        BulletCtrl _bullet = Instantiate(bullet, PointSpawnBullet.position, PointSpawnBullet.rotation);
        _bullet.SetMoveBehavior(new AccelerateMove(_bullet.RigbodyBullet, speedBullet));
        Destroy(_bullet.gameObject, 10);
    }
}
