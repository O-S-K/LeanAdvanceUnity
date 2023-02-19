using UnityEngine;

public class AIInputController : IShipInput
{
    public float Rotation { get; private set; }

    public float Vetical { get; private set; }

    public bool InputAttack { get; private set; }

    private float timeMoveUpdate = 0;

    public void ReadInput()
    {
        if (timeMoveUpdate > 0)
        {
            timeMoveUpdate -= Time.deltaTime;
        }
        else
        {
            Rotation = Random.Range(-1, 1);
            Vetical = Random.Range(0, 3);
            timeMoveUpdate = Random.Range(1, 3);
        }
    }
}