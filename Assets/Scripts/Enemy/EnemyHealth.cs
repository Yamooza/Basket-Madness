using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Health Bar Settings")]
    public Image healthBarFill; // Reference to the fill Image of the health bar

    [Header("Sprites")]
    public Sprite aliveSprite; // Sprite when enemy is alive
    public Sprite deadSprite; // Sprite when enemy dies

    private SpriteRenderer spriteRenderer;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer && aliveSprite)
        {
            spriteRenderer.sprite = aliveSprite;
        }

        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar()
    {
        if (healthBarFill)
        {
            healthBarFill.fillAmount = (float)currentHealth / maxHealth;
        }
    }

    private void Die()
    {
        isDead = true;
        if (spriteRenderer && deadSprite)
        {
            spriteRenderer.sprite = deadSprite;
        }

        // Optional: Disable enemy behavior or add additional death logic here
        Debug.Log("Enemy has died!");
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
}