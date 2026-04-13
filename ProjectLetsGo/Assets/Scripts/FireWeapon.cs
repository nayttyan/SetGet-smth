using UnityEngine;

public class FireWeapon : Weapon
{
    public float fireBonusDamage;

    public override float GetDamage()
    {
        float damage = base.GetDamage();
        damage += fireBonusDamage;
        return damage;
    }

    public override string GetWeaponType()
    {
        return "Fire";
    }
}