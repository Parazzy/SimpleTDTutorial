using UnityEngine;

public class Health : MonoBehaviour {

    [Header("Atributtes")]
    [SerializeField] private int hitPoints = 2;
    [SerializeField] private int currencyWorth = 50;

    // Avoid the enemy count to go negative when hitted simultaneusly
    private bool isDestroyed = false;

    public void TakeDamage(int dmg) {
        hitPoints -= dmg;
        if (hitPoints <= 0 && !isDestroyed) {
            EnemySpawner.onEnemyDestroy.Invoke();
            LevelManager.main.IncreaseCurrency(currencyWorth);
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
