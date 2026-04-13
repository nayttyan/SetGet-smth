using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private string charName;
    [SerializeField] private Sprite characterSprite;

    public Sprite CharacterSprite
    {
        get { return characterSprite; }
    }

    public float Health
    {
        get { return health; }
        set
        {
            health = value;
            if (health < 0)
            {
                health = 0;
            }
        }
    }

    public string CharName
    {
        get { return charName; }
        set { charName = value; }
    }

    public abstract void Attack(Character toHit);

    public virtual void TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log(charName + " got hit for " + damage + " damage! Current health: " + Health);
    }

    public void TakeDamage(Weapon weapon)
    {
        float damage = weapon.GetDamage();
        TakeDamage(damage);
    }
}