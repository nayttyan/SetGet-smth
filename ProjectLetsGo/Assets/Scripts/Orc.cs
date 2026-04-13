using UnityEngine;

public class Orc : Character
{
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(12f, 20f);
        toHit.TakeDamage(damage);
    }
}