using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooArea : MonoBehaviour, IDroppable
{
    private Dropdown dropDown;

    void Start()
    {
        dropDown = GetComponent<Dropdown>();
    }
    public void ExpandDropDown()
    {
         
    }

}
