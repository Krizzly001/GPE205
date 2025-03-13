using UnityEngine;

public abstract class Powerup //Will have multiple powerups
{
    public float duration;
    public bool isPermanent;
    //Decide when it can be used
    public abstract void Apply(PowerupManager target);
    public abstract void Remove(PowerupManager target);
    

}
