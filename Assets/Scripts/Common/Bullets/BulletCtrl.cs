using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    private Rigidbody rigidBody;
    public Rigidbody RigbodyBullet { get => rigidBody; }

    private IMoveAble moveBehavior;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision -> " + other.name);
        //TODO check for damageable
        //Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        moveBehavior.Move();
    }

    public void SetMoveBehavior(IMoveAble newMoveBehavior)
    {
        Debug.Log("IMoveAble -> " + newMoveBehavior);
        moveBehavior = newMoveBehavior;
    }
}
