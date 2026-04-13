using UnityEngine;

public class Skeleton : Character
{
    public override void Attack(Character toHit)
    {
        float damage1 = Random.Range(4f, 7f);
        float damage2 = Random.Range(4f, 7f);

        toHit.TakeDamage(damage1);
        toHit.TakeDamage(damage2);
    }
}