using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [Header("Health Stuff")]
    public Image healthBar;
    public float startHealth = 100f;
    private float health;

    public Text texto;

    public MoveScript moveScript;

	// Use this for initialization
	void Start () {
        health = startHealth;
        healthBar.color = Color.green;

    }
	
	// Update is called once per frame
	void Update () {
        if (health <= (20/startHealth)*100)
        {
            healthBar.color = Color.red;
        } else if (healthBar.color != Color.green && health > 20f)
        {
            healthBar.color = Color.green;
        }
        healthBar.fillAmount = health / startHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Wall")
        {
            texto.color = Color.blue;
            texto.text = collision.collider.name + " +001 speed";
            moveScript.moveSpeed += .001f;
        } else if (collision.collider.tag == "Instrument")
        {
            texto.color = Color.red;
            texto.text = collision.collider.name + " 05 damage";
            health -= 10f;
        }
    }
}
