using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponSelectButton : MonoBehaviour
{
    public int Id;
    private Animator anim;
    public string itemName;
    public TextMeshProUGUI itemText;
    public Sprite ammo;
    public Image itemAmmo;
    public Image selectedItem;
    private bool selected = false;
    public Sprite icon;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // check if button is selected
        if (selected)
        {
            selectedItem.sprite = icon;
            itemText.text = itemName;
            itemAmmo.sprite = ammo;
        }
    }

    public void Selected()
    {
        selected = true;
        anim.SetBool("Select", true);
        WeaponSelectHUD.weaponID = Id;
    }

    public void Deselected()
    {
        selected = false;
        anim.SetBool("Select", false);
        WeaponSelectHUD.weaponID = 0;
    }

    public void HoverEnter()
    {
        anim.SetBool("Hover", true);
        itemText.text = itemName;
        itemAmmo.sprite = ammo;
    }

    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        itemText.text = "";
        itemAmmo.sprite = null;
    }
}
