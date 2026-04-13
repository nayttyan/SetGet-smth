using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Character[] enemies;
    private Character enemy;

    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text playerHP;
    [SerializeField] private TMP_Text playerShield;

    [SerializeField] private TMP_Text enemyName;
    [SerializeField] private TMP_Text enemyHP;

    [SerializeField] private TMP_Text playerWeapon;
    [SerializeField] private TMP_Text gameText;

    [SerializeField] private TMP_InputField nameInput;

    [SerializeField] private Image playerImage;
    [SerializeField] private Image enemyImage;
    [SerializeField] private Image weaponImage;
    [SerializeField] private Image shieldImage;

    private bool gameEnded = false;

    void Start()
    {
        SpawnEnemy();
        UpdateUI();
    }

    void SpawnEnemy()
    {
        int randomID = Random.Range(0, enemies.Length);
        enemy = enemies[randomID];

        enemy.Health = Random.Range(40f, 80f);
    }

    void UpdateUI()
    {
        playerName.text = "Player";
        playerHP.text = "Current HP: " + player.Health.ToString("F1");
        playerShield.text = "Current Shield: " + player.ShieldHP.ToString("F1") + "\nIs shield on? " + player.ShieldOn;

        if (enemy != null)
        {
            enemyName.text = enemy.CharName;
            enemyHP.text = "Current HP: " + enemy.Health.ToString("F1");
        }

        playerWeapon.text = "Current weapon: " + player.ActiveWeaponName;
        playerName.text = player.CharName;

        if (playerImage != null)
        {
            playerImage.sprite = player.CharacterSprite;
        }

        if (enemyImage != null && enemy != null)
        {
            enemyImage.sprite = enemy.CharacterSprite;
        }

        if (weaponImage != null)
        {
            weaponImage.sprite = player.GetActiveWeaponSprite();
        }

        if (shieldImage != null)
        {
            shieldImage.gameObject.SetActive(player.ShieldOn && player.ShieldHP > 0);
        }
    }

    public void SetPlayerName()
    {
        if (nameInput.text == "")
        {
            player.CharName = "Player";
        }
        else
        {
            player.CharName = nameInput.text;
        }

        UpdateUI();
    }

    public void SwitchWeapon()
    {
        if (gameEnded)
        {
            return;
        }

        player.SwitchWeapon();
        UpdateUI();
    }

    public void AttackButton()
    {
        if (gameEnded)
        {
            return;
        }

        player.Attack(enemy);

        if (enemy.Health <= 0)
        {
            SpawnEnemy();
            UpdateUI();
            return;
        }

        enemy.Attack(player);

        if (player.Health <= 0)
        {
            gameEnded = true;
            Debug.Log("GAME OVER WORKED");
            gameText.text = "Game Over";
        }

        UpdateUI();
    }

    public void ToggleShield()
    {
        if (gameEnded)
        {
            return;
        }

        player.ToggleShield();
        UpdateUI();
    }

    public void AddHP()
    {
        if (gameEnded)
        {
            return;
        }

        player.AddHP(15f);
        UpdateUI();
    }

    public void RepairShield()
    {
        if (gameEnded)
        {
            return;
        }

        player.RepairShield(20f);
        UpdateUI();
    }
}