using UnityEngine;

public class AccelerateMove : IMoveAble
{
    private readonly Rigidbody rigidbody;
    private readonly float accelerateSpeed;
    private float currentSpeed;
 
    public AccelerateMove(Rigidbody rigidbody, float accelerateSpeed)
    {
        this.currentSpeed = 0;
        this.rigidbody = rigidbody;
        this.accelerateSpeed = accelerateSpeed;
    }

    public void Move()
    {
        currentSpeed += accelerateSpeed;
        rigidbody.velocity = rigidbody.transform.forward * currentSpeed * Time.fixedDeltaTime;
    }
}
