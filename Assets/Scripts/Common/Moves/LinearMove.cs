using UnityEngine;

public class LinearMove : IMoveAble
{
    private readonly float travelSpeed;
    private readonly Rigidbody rigidbody;

    public LinearMove(Rigidbody rigidbody, float travelSpeed)
    {
        this.travelSpeed = travelSpeed;
        this.rigidbody = rigidbody;
    }

    public void Move()
    {
        rigidbody.velocity = rigidbody.transform.forward * travelSpeed * Time.fixedDeltaTime;
    }
}
