using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private Weapon activeWeapon;

    [SerializeField] private float shieldHP;
    [SerializeField] private bool shieldOn;

    private int selectedWeaponID = 0;

    public Sprite GetActiveWeaponSprite()
    {
        return activeWeapon.WeaponSprite;
    }
    public string ActiveWeaponName
    {
        get { return activeWeapon.weaponName + " / " + activeWeapon.GetWeaponType(); }
    }

    public float ShieldHP
    {
        get { return shieldHP; }
        set
        {
            shieldHP = value;
            if (shieldHP < 0)
            {
                shieldHP = 0;
            }
        }
    }

    public bool ShieldOn
    {
        get { return shieldOn; }
    }

    void Awake()
    {
        activeWeapon = weapons[0];
    }

    public override void Attack(Character toHit)
    {
        toHit.TakeDamage(activeWeapon);
    }

    public override void TakeDamage(float damage)
    {

        if (shieldOn && ShieldHP > 0)
        {
            damage = damage / 2f;

            ShieldHP -= Random.Range(8f, 15f);

            if (ShieldHP <= 0)
            {
                ShieldHP = 0;
                shieldOn = false;
            }
        }

        base.TakeDamage(damage);
    }

    public void SwitchWeapon()
    {
        selectedWeaponID++;
        selectedWeaponID = selectedWeaponID % weapons.Length;
        activeWeapon = weapons[selectedWeaponID];
    }

    public void ToggleShield()
    {
        if (ShieldHP > 0)
        {
            shieldOn = !shieldOn;
        }
    }

    public void AddHP(float amount)
    {
        Health += amount;
    }

    public void RepairShield(float amount)
    {
        ShieldHP += amount;
    }
}