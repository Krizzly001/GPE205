using UnityEngine;

[System.Serializable]
public class HealthPowerup : Powerup
{
    //VARIABLES
    public float healthToAdd;

    //Apply heal
    public override void Apply(PowerupManager target)
    {
        Health health = target.GetComponent<Health>();
        if (health != null)//if my health has somthing in it/ exists...
        {
            //heal has (amount to be healed, and who to heal/users tank)
            health.Heal(healthToAdd, target.GetComponent<Pawn>());

        }

    }
    public override void Remove(PowerupManager target)
    {
        Health health = target.GetComponent<Health>();
        if (health != null)//if my health has somthing in it/ exists...
        {
            //heal has (amount to be healed, and who to heal/users tank)
            health.TakeDamage(healthToAdd, target.GetComponent<Pawn>());

        }
        

    }
}
