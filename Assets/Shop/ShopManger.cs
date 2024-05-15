using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using Button = UnityEngine.UIElements.Button;

public class ShopManger : MonoBehaviour
{
    public int[,] shopItems = new int [7,7];
    public float coins;
    public TextMeshProUGUI CoinsTXT;
    

    private void Start()
    {
        CoinsTXT.text = "Coins:" + coins;
        
        //Items
        
        //bowl
        shopItems[1, 1] = 1;
        //vegetables
        shopItems[1, 2] = 2;
        //protein
        shopItems[1, 3] = 3;
        //instant ramen noodles
        shopItems[1, 4] = 4;
        //stock cube
        shopItems[1, 5] = 5;
        //chopsticks
        shopItems[1, 6] = 6;
       
        
        //Price
        shopItems[2, 1] = 45;
        shopItems[2, 2] = 26;
        shopItems[2, 3] = 55;
        shopItems[2, 4] = 18;
        shopItems[2, 5] = 5;
        shopItems[2, 6] = 12;
      
        
        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
     
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>()
            .currentSelectedGameObject;
        if (coins >= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            
            CoinsTXT.text = "Coins:" + coins;

            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text =
                shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
    }

   // public void Sell() {}
}
