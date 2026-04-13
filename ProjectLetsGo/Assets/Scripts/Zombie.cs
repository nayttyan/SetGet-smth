using UnityEngine;

public class Zombie : Character
{
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(8f, 14f);
        toHit.TakeDamage(damage);
    }
}