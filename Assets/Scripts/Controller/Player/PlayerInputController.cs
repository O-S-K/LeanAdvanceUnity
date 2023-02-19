using UnityEngine;

public class PlayerInputController : IShipInput
{
    public float Rotation { get; private set; }

    public float Vetical { get; private set; }

    public bool InputAttack { get; private set; }
     

    public void ReadInput()
    {
        Rotation = Input.GetAxis("Horizontal");
        Vetical = Input.GetAxis("Vertical");
        InputAttack = Input.GetMouseButtonDown(0);
    }
}
