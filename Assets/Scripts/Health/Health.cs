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
    //amount: the amount of damage being taken
    //Pawn source: The Pawn that attacked
    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth = currentHealth - amount;
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Sets the max health

        if (currentHealth <= 0)
        {
            Die(source);
        }
    }

    public void Heal(float amount, Pawn source)
    {
        currentHealth = currentHealth + amount;
        Debug.Log(source.name + " did " + amount + " healing to " + gameObject.name);

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Sets the max health
        
    }

    public void Die(Pawn source)
    {
        Destroy(gameObject);
   
    }
}
