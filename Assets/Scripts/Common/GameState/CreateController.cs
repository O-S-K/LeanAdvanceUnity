using UnityEngine;
using OSK;

public class CreateController : OSK.SingletonMono<CreateController>
{
    [SerializeField] private BulletCtrl bulletPrefab;

    public BulletCtrl CreateBullet(Transform trans, Transform rot)
    {
        var _bullet = ObjectPooling.CreatePooling(bulletPrefab);
        _bullet.gameObject.SetActive(true); 
        _bullet.transform.position = trans.position;
        _bullet.transform.rotation = rot.rotation;
        return _bullet;
    }
}
