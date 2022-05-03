
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int currentWeapon = 0;

    void Start()
    {
        SelectWeapon();
    }


    public void SelectWeapon()
    {
        int i = 0;

        foreach (Transform weapon in transform)
        {
            if (i == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            } else
            {
                weapon.gameObject.SetActive(false);
            }

            i++;

        }
    }
}
