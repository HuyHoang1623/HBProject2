using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCar : TowerBase
{
    public override void OnDeath()
    {
        base.OnDeath();
        LevelManager.Ins.OnLose();
    }
}
