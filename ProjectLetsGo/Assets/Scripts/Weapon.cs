using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private float minDamage;
    [SerializeField] private float maxDamage;
    public string weaponName;
    [SerializeField] private Sprite weaponSprite;

    public Sprite WeaponSprite
    {
        get { return weaponSprite; }
    }

    public virtual float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }

    public abstract string GetWeaponType();
}