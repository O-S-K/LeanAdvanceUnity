public class GunStraight : WeaponBase
{
    public override void Shoot()
    {
        var _bullet = CreateController.Instance.CreateBullet(PointSpawnBullet, PointSpawnBullet);
        _bullet.SetMoveBehavior(new LinearMove(_bullet.transform, speedBullet), bullet.transform.forward);
    }
}
