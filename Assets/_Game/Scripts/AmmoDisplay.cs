using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    public int maxAmmo = 50;
    public int currentAmmo = 10;
    [SerializeField] public TextMeshProUGUI ammoDisplay;

    private void Start()
    {
        ammoDisplay.text = currentAmmo + "/" + maxAmmo;
    }
}
