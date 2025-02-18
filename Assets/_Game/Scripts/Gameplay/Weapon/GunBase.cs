using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : WeaponBase
{
    [SerializeField] protected Transform bulletPoint;
    [SerializeField] protected Bullet bulletPrefab;
}
