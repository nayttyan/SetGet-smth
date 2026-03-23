using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Character enemy;

    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP, playerWeapon;
    void Start()
    {
        /*Debug.Log("player: " + player.CharName);
        player.TakeDamage(3);
        enemy.TakeDamage(5);*/
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");
        playerWeapon.text = player.ActiveWeaponName;
    }

    public void SwitchWeapon()
    {
        player.SwitchWeapon();
        UpdateUI();
    }
    public void AttackButton()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
