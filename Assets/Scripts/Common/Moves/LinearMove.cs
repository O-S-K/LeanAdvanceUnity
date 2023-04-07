using UnityEngine;

public class LinearMove : IMoveAble
{
    private readonly float travelSpeed;
    private readonly Transform transform;

    public LinearMove(Transform transform, float travelSpeed)
    {
        this.travelSpeed = travelSpeed;
        this.transform = transform;
    }

    public void Move(Vector3 direction)
    {
        float moveSpeed = travelSpeed * Time.deltaTime;
        transform.Translate(direction * moveSpeed);
    }
}
