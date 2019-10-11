using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChooseManager : MonoBehaviour {

    public static CharacterChooseManager instance;

    public int currentWeapon = 0;
    public GameObject[] weapons;

    public Text weaponTitle;
    public Text weaponTitle2;
    public Text weaponText;

    public GameObject[] weapons2;

	// Use this for initialization
	void Start () {
		if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            this.updateWeaponText();
        } else
        {
            Destroy(this.gameObject);
        }
	}
	
	public void ChangeWeapon()
    {
        if (currentWeapon < weapons.Length - 1) {
            weapons[currentWeapon].SetActive(false);
            weapons2[currentWeapon].SetActive(false);
            currentWeapon += 1;
            weapons[currentWeapon].SetActive(true);
            weapons2[currentWeapon].SetActive(true);
            this.updateWeaponText();
        } else
        {
            weapons[currentWeapon].SetActive(false);
            weapons2[currentWeapon].SetActive(false);
            currentWeapon = 0;
            weapons[currentWeapon].SetActive(true);
            weapons2[currentWeapon].SetActive(true);
            this.updateWeaponText();
        }
    }

    void updateWeaponText()
    {
        switch (this.currentWeapon)
        {
            case 0:
                this.weaponTitle.text = "Gavel";
                this.weaponTitle2.text = "Gavel";
                this.weaponText.text = "The hammer of the great Celtic warrior had been found on the wreck of the Roman castle by young Owen. There are rumors that the hammer has been turned into a sacred battle weapon ...";
                break;
            case 1:
                this.weaponTitle.text = "Cracked Helm";
                this.weaponTitle2.text = "Cracked Helm";
                this.weaponText.text = "Battle weapon built with the remains of a broken helmet ... There is no information from the former owner.";
                break;
            case 2:
                this.weaponTitle.text = "Ice Golem";
                this.weaponTitle2.text = "Ice Golem";
                this.weaponText.text = "Legend has it that a Jewish alchemist built an ice golem to protect his family as he set out to find ingredients to fulfill the dream of building the philosopher's stone. When he returned home, he found only the pieces of the golem on the ground, to find his wife and children he joined with some wizards to build a divine weapon with the remains of his creation.";
                break;
            case 3:
                this.weaponTitle.text = "Zombie Raisen";
                this.weaponTitle2.text = "Zombie Raisen";
                this.weaponText.text = "The drug that transforms thousands of people into zombies in Haiti was being studied by scientists. Although today, it's not common to find the drug, rumors that some sacred weapons are bathed in it...";
                break;
            case 4:
                this.weaponTitle.text = "Volcano Spirit";
                this.weaponTitle2.text = "Volcano Spirit";
                this.weaponText.text = "This weapon was always weak until a beggar decided to bathe it on the volcano Kilauea ... How did he get there? Nobody knows!";
                break;
        }
    }
}
