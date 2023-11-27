using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public List<Button> buttons;
    public List<TextMeshProUGUI> buttonTexts;
    private Button currentSelection;
    public Score score;
    public PopUpManager popup;

  

    public void OnButtonClick(Button clickedButton)
    {
        if (score.StarNum >= 20)
        {
            SoundManager.inst.PlaySound(SoundName.s2);
            PurchaseBomb(20);
            if (currentSelection != null)
            {
                currentSelection.interactable = true;
                int previousIndex = buttons.IndexOf(currentSelection);
                buttonTexts[previousIndex].text = "Select";
            }


            currentSelection = clickedButton;
            currentSelection.interactable = false;
            int currentIndex = buttons.IndexOf(currentSelection);
            buttonTexts[currentIndex].text = "Selected";
          

         
        }
        else
        {
            popup.ShowPopup();
           // Debug.Log("Not enough coins to purchase this item.");
          
        }
    }
    
   
    public void PurchaseBomb(int cost)
    {
        if (score.StarNum >= cost)
        {
            score.StarNum -= cost;
           
            score.UpdateScoreText();
         
        
        }
       
    }
}

