using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBarier : TowerBase
{
    public override void OnDeath()
    {
        base.OnDeath();
        LevelManager.Ins.OnWin();
    }
}
