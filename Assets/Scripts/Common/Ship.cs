using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private ShipSettingSO shipSetting;
    [SerializeField] private ShipWeaponSystem shipWeapon;

    private IShipInput shipInput;
    private IShipAttack shipAttack;

    private ShipMotor shipMoto;

    private void Awake()
    {
        shipInput = shipSetting.IsAI ? new AIInputController() : new PlayerInputController();
        shipAttack = shipSetting.IsAI ? new AIAttackController() : new PlayerAttackController();

        shipMoto = new ShipMotor(shipInput, shipAttack, transform, shipSetting, shipWeapon);
        shipWeapon.EquipWeapon(shipSetting.StartingWeaponPrefab);
    }

    private void Update()
    {
        shipInput.ReadInput();
        shipMoto.Tick();
    }
}
