using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectHUD : MonoBehaviour
{
    public Animator anim;
    private bool weaponWheelSelected = false;
    public Image selectedItem;
    public Sprite noImage;
    public static int weaponID;

    void Update()
    {
        // toggle weaponSelectHUD
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weaponWheelSelected = !weaponWheelSelected;
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
                selectedItem.sprite = noImage;
                break;
            case 1: // Rifle
                Debug.Log("Rifle");
                // bring out weapon
                // animation
                // sound
                break;
            case 2: // Shotgun
                Debug.Log("Shotgun");
                // animation
                // sound
                break;
            case 3: // SMG
                Debug.Log("SMG");
                // animation
                // sound
                break;
            case 4: // Sniper
                Debug.Log("Sniper");
                // animation
                // sound
                break;
            case 5: // Grenade
                Debug.Log("Grenade");
                // animation
                // sound
                break;
            case 6: // nothing is selected
                Debug.Log("");
                // animation
                // sound
                break;
            case 7: // nothing is selected
                Debug.Log("");
                // animation
                // sound
                break;
            case 8: // nothing is selected
                Debug.Log("");
                // animation
                // sound
                break;
        }
    }
}
