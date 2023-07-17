using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devol_pan_ : MonoBehaviour
{
    public GameObject fpc;
    public GameObject tdc;
    public GameObject ui;
    public int sh = 1;
    public void tenHundredScore()
    {
        Score_money.money_scores += 10000; 
    }

    public void defScore()
    {
        Score_money.money_scores = 1500;
    }

    public void zeroScore()
    {
        Score_money.money_scores = 1;
    }

    public void InfinityH()
    {
        
    }

    public void InfinityAmmo()
    {

    }


    public void speedfrHDZ()
    {
        perks_.speed_prk_bl = true;
        Score_money.money_scores -= 1500;
    }

    public void clearPerk()
    {
        perks_.speed_prk_bl = false;
    }

    public void FPC()
    {
        fpc.gameObject.SetActive(true);
        tdc.gameObject.SetActive(false);
    }

    public void TDC()
    {
        fpc.gameObject.SetActive(false);
        tdc.gameObject.SetActive(true);
    }
    public void ShowHideHUD()
    {
        if (sh == 0)
        {
            ui.gameObject.SetActive(true);
            sh = 1;
        }
        else if (sh == 1)
        {
            ui.gameObject.SetActive(false);
            sh = 0;
        }
    }
}
