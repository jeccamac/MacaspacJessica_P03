using System.Collections;
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

    void Update()
    {
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
                Debug.Log("SMG");
                // bring out weapon
                
                // animation
                // ui sprite
                selectedWeapon.sprite = SMG;
                // sound
                break;
            case 2: // Shotgun
                Debug.Log("Shotgun");
                // animation
                // ui sprite
                selectedWeapon.sprite = Shotgun;
                // sound
                break;
            case 3: // Rifle
                Debug.Log("Rifle");
                // animation
                // ui sprite
                selectedWeapon.sprite = Rifle;
                // sound
                break;
            case 4: // Sniper
                Debug.Log("Sniper");
                // animation
                // ui sprite
                selectedWeapon.sprite = Sniper;
                // sound
                break;
            case 5: // RPG
                Debug.Log("RPG");
                // animation
                // ui sprite
                selectedWeapon.sprite = RPG;
                // sound
                break;
            case 6: // Grenade
                Debug.Log("Grenade");
                // animation
                // ui sprite
                selectedWeapon.sprite = Grenade;
                // sound
                break;
            case 7: // Knife
                Debug.Log("Knife");
                // animation
                // ui sprite
                selectedWeapon.sprite = Knife;
                // sound
                break;
            case 8: // Pistol
                Debug.Log("Pistol");
                // animation
                // ui sprite
                selectedWeapon.sprite = Pistol;
                // sound
                break;
        }
    }
}
