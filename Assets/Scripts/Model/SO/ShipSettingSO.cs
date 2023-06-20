using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
public class ShipSettingSO : ScriptableObject
{
    [SerializeField] private int id;
    [SerializeField] private float turnSpeed = 25;
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private bool isAI = false;
    [SerializeField] private WeaponBase startingWeaponPrefab;

    public int ID { get => id; }
    public bool IsAI { get => isAI; }
    public float TurnSpeed { get => turnSpeed; }
    public float MoveSpeed { get => moveSpeed; }

    public WeaponBase StartingWeaponPrefab { get => startingWeaponPrefab; }

}
