using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth playerHealth;
    [SerializeField] float damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            playerHealth.GetComponent<DisplayDamage>().ShowHitEffect();
        }
    }
}
