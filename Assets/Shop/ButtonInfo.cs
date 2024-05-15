using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TextMeshProUGUI PriceTXT;
    public TextMeshProUGUI QuantityTXT;
    public GameObject ShopManager;
    public GameObject icon;
    
    void Update()
    {
        PriceTXT.text = "Price: $" + ShopManager.GetComponent<ShopManger>().shopItems[2, ItemID].ToString();
        QuantityTXT.text = ShopManager.GetComponent<ShopManger>().shopItems[3, ItemID].ToString();
    }
}
