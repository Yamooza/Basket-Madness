using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   public float health;
   public float maxHealth;
    public Image HealthBar;
    private void Start()
    {
    maxHealth = health;
    }
    private void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
}