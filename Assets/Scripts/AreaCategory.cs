using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaCategory : MonoBehaviour
{
    private Dropdown dropDown;

    [SerializeField] private Dropdown animalDropDown;

     void Start()
    {
        dropDown = GetComponent<Dropdown>();
    }

     void Update()
    {
        dropDown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropDown);
        });
    }
    public void DropdownValueChanged(object dropDown)
    {
        animalDropDown.Show();
    }
}
