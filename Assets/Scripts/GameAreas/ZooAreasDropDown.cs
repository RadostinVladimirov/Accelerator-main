using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZooAreasDropDown : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown ZooAreas;
    [SerializeField]
    private TMP_Dropdown ZooCategories;
    [SerializeField]
    private TMP_Text ZooCategoriesLable;


    public TMP_Text AnimalsListText;

    public bool AllListActive = true;
    public bool DomesticListActive;
    public bool FishListActive;
    public bool LizardListActive;


    public ZooAreasList ZooList;

    public void Start()
    {
        ZooCategories.options.Clear();
        ZooAreasOnValueChange();
        ZooCategoriesOnValueChange();
        AnimalsListText.text = "/";

        ZooAreas.onValueChanged.AddListener(delegate { ZooAreasOnValueChange(); });
        foreach (var item in ZooList.AreaTypes)
        {
            ZooAreas.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
        }
        ZooCategories.onValueChanged.AddListener(delegate { ZooCategoriesOnValueChange(); });
        foreach (var item in ZooList.Categories_All)
        {
            ZooCategories.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
        }
    }

    public void ZooAreasOnValueChange()
    {
        AllListActive = false;
        DomesticListActive = false;
        FishListActive = false;
        LizardListActive = false;
        int selectedIndex = ZooAreas.value;
        ZooCategories.options.Clear();
        ZooCategories.captionText.text = "...";
        AnimalsListText.text = "\n";
        if (selectedIndex == 0)
        {
            foreach (var item in ZooList.Categories_All)
            {
                ZooCategories.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
            }
            AllListActive = true;
            ZooCategoriesOnValueChange();
        }
        if(selectedIndex == 1)
        {
            foreach (var item in ZooList.Categories_Underwater)
            {
                ZooCategories.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
            }
            FishListActive = true;
            ZooCategoriesOnValueChange();
        }
        if (selectedIndex == 2)
        {
            foreach (var item in ZooList.Categories_Jungle)
            {
                ZooCategories.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
            }
            LizardListActive = true;
            ZooCategoriesOnValueChange();
        }
        if (selectedIndex == 3)
        {
            foreach (var item in ZooList.Categories_Entry)
            {
                ZooCategories.options.Add(new TMP_Dropdown.OptionData() { text = item.ToString() });
            }
            DomesticListActive = true;
            ZooCategoriesOnValueChange();
        }
    }
    public void ZooCategoriesOnValueChange()
    {
        int CategoriesSelectedIndex = ZooCategories.value;
        AnimalsListText.text = "\n";

        if (AllListActive == true)
        {
            if(CategoriesSelectedIndex == 0)
            {
                UpdateDomesticList();
            }
            if(CategoriesSelectedIndex == 1)
            {
                UpdateFishList();
            }
            if(CategoriesSelectedIndex == 2)
            {
                UpdateLizardList();
            }
        }
        if(FishListActive == true)
        {
            if(CategoriesSelectedIndex == 0)
            {
                UpdateFishList();
            }
        }
        if(LizardListActive == true)
        {
            if(CategoriesSelectedIndex == 0)
            {
                UpdateLizardList();
            }
            UpdateLizardList();
        }
        if(DomesticListActive == true)
        {
            if(CategoriesSelectedIndex == 0)
            {
                UpdateDomesticList();
            }
        }
    }


    public void UpdateDomesticList()
    {
        foreach (var item in ZooList.Animals_Domestic)
        {
            AnimalsListText.text += item.ToString() + "\n";
        }
    }
    public void UpdateFishList()
    {
        foreach (var item in ZooList.Animals_Fish)
        {
            AnimalsListText.text += item.ToString() + "\n";
        }
    }
    public void UpdateLizardList()
    {
        foreach (var item in ZooList.Animals_Lizards)
        {
            AnimalsListText.text += item.ToString() + "\n";
        }
    }

}
