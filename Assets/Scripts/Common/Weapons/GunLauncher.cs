using UnityEngine;

public class GunLauncher : WeaponBase
{
    public override void Shoot()
    {
        var _bullet = CreateController.Instance.CreateBullet(PointSpawnBullet, PointSpawnBullet);
        _bullet.Init();
        _bullet.SetMoveBehavior(new AccelerateMove(_bullet.RigbodyBullet, speedBullet), _bullet.transform.forward);
    }
}
