using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    float hp;
    public virtual void OnInit(float hp)
    {
        this.hp = hp;    
    }

    public virtual void OnHit(float damage)
    {
        if (hp > 0)
        {
            hp -= damage;
            if (hp <= 0)
            {
                OnDeath();
            }
        }
        
    }

    public virtual void OnDeath()
    {
        
    }
}
