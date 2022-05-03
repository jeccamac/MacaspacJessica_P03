﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectHUD : MonoBehaviour
{
    public Animator anim;
    private bool weaponWheelSelected = false;
    public Image selectedWeapon;
    public static int weaponID;

    public Sprite noImage;
    public Sprite SMG;
    public Sprite Shotgun;
    public Sprite Rifle;
    public Sprite Sniper;
    public Sprite RPG;
    public Sprite Grenade;
    public Sprite Knife;
    public Sprite Pistol;

    public GameObject weapons;
    public WeaponSwitch weaponSwitch;

    public void Start()
    {
        weapons = GameObject.Find("Weapons");
        weaponSwitch = weapons.GetComponent<WeaponSwitch>();
    }

    void Update()
    {
        int previousSelectedWeapon = weaponSwitch.currentWeapon;

        // toggle weaponSelectHUD
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weaponWheelSelected = !weaponWheelSelected;
            Cursor.lockState = CursorLockMode.None;
        }

        if (weaponWheelSelected)
        {
            anim.SetBool("OpenWeaponWheel", true);
        }
        else
        {
            anim.SetBool("OpenWeaponWheel", false);
        }

        switch (weaponID)
        {
            case 0: // nothing is selected
                selectedWeapon.sprite = noImage;
                break;
            case 1: // SMG
                //Debug.Log("SMG");
                weaponSwitch.currentWeapon = 0; // bring out weapon
                                                // animation
                selectedWeapon.sprite = SMG; // ui sprite
                                             // sound
                break;
            case 2: // Shotgun
                //Debug.Log("Shotgun");
                weaponSwitch.currentWeapon = 1; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Shotgun; // ui sprite
                                                 // sound
                break;
            case 3: // Rifle
                //Debug.Log("Rifle");
                weaponSwitch.currentWeapon = 2; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Rifle; // ui sprite
                                               // sound
                break;
            case 4: // Sniper
                //Debug.Log("Sniper");
                weaponSwitch.currentWeapon = 3; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Sniper; // ui sprite
                                                // sound
                break;
            case 5: // RPG
                //Debug.Log("RPG");
                weaponSwitch.currentWeapon = 4; // bring out weapon
                                                // animation
                selectedWeapon.sprite = RPG; // ui sprite
                                             // sound
                break;
            case 6: // Grenade
                //Debug.Log("Grenade");
                weaponSwitch.currentWeapon = 5; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Grenade; // ui sprite
                                                 // sound
                break;
            case 7: // Knife
                //Debug.Log("Knife");
                weaponSwitch.currentWeapon = 6; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Knife; // ui sprite
                                               // sound
                break;
            case 8: // Pistol
                //Debug.Log("Pistol");
                weaponSwitch.currentWeapon = 7; // bring out weapon
                                                // animation
                selectedWeapon.sprite = Pistol; // ui sprite
                                                // sound
                break;
        }

        if (previousSelectedWeapon != weaponSwitch.currentWeapon)
        {
            weaponSwitch.SelectWeapon();
        }
    }
}
