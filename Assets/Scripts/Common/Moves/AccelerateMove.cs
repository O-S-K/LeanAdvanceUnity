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

    public void Move(Vector3 direction)
    {
        currentSpeed += accelerateSpeed * Time.fixedDeltaTime;
        direction.y = 0;
        rigidbody.AddForce(direction.normalized * currentSpeed, ForceMode.Acceleration);
    }
}
