using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    private Rigidbody rigidBody;
    public Rigidbody RigbodyBullet
    {
        get { return rigidBody ?? GetComponent<Rigidbody>(); }
    }

    private IMoveAble moveBehavior;
    private Vector3 direction;

    private void OnEnable()
    {
        Invoke(nameof(OnDeactive), 3);
    }

    public void OnDeactive()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision -> " + other.name);
        //gameObject.SetActive(false);
        //TODO check for damageable
        //Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        moveBehavior.Move(direction);
    }

    public void SetMoveBehavior(IMoveAble newMoveBehavior,Vector3 direction)
    {
        Debug.Log("IMoveAble -> " + newMoveBehavior);
        moveBehavior = newMoveBehavior;
        this.direction = direction;
    }
}
