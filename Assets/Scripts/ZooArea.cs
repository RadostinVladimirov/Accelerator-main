using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooArea : MonoBehaviour
{
    
    private Dropdown dropDown;

    [SerializeField]
    private Dropdown CategorieAreaDropDown;

    void Start()
    {
        dropDown = GetComponent<Dropdown>();
    }
    public void Update()
    {
        dropDown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropDown);
        });
    }

    private void DropdownValueChanged(object DropDown)
    {
        CategorieAreaDropDown.Show();
    }
}
