using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class HeathBarUI : Health
{
    public float Width, Height;
    [SerializeField]

    private RectTransform healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        newH(currentHealth);
    
        
    }
    public void newH(float currentHealth)
    {
        float ADDIT = maxHealth - currentHealth;
        
        float newWidth = Width - ADDIT;
        healthBar.sizeDelta = new Vector2(newWidth, Height);
    }
}
