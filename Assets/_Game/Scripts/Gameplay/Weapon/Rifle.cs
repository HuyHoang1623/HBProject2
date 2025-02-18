using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : GunBase
{
    public override void Fire(CharacterBase character)
    {
        base.Fire(character);
        //ban 2 vien dan
    }
    
    private IEnumerator IEFire(CharacterBase character) 
    {
        yield return null;
    }
}         

