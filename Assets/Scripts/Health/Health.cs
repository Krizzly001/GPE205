using UnityEngine;

public class Health : MonoBehaviour
{
    //VARIABLES
    public float currentHealth;
    public float maxHealth;

    //BLUEPRINTS
    
    void Start()
    {
        currentHealth = maxHealth;
        
    }
    void Update()
    {
        
    }

    //FUNCTIONS
    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth = currentHealth - amount;

        // The object did # damage to tankname
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);
        
        // Sets my min and max health limit
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if(currentHealth <= 0)
        {
            Die(source);//TankPawn
        }
    }
    public void Heal(float amount, Pawn source)
    {
        currentHealth = currentHealth + amount;
        Debug.Log(source.name + " did " + amount + " Healing to " + gameObject.name);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }


    public void Die(Pawn source)//What cause tank to die
    {
        Destroy(gameObject);

    }
}
