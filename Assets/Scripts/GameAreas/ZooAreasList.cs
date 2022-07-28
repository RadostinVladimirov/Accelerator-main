using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ZooAreasList : MonoBehaviour
{
    public enum Areas { All, Underwater, Jungle, Entry }
    public enum AllCategories { Domestic, Fish, Lizards}
    public enum UnderwaterCategories { Fish}
    public enum JungleCategories { Lizards}
    public enum EntryCategories { Domestic}


    //Areas
    public List<Areas> AreaTypes = new List<Areas>();
    public List<AllCategories> Categories_All = new List<AllCategories>();

    //Categories
    public List<UnderwaterCategories> Categories_Underwater = new List<UnderwaterCategories>();
    public List<EntryCategories> Categories_Entry = new List<EntryCategories>();
    public List<JungleCategories> Categories_Jungle = new List<JungleCategories>();

    //Animals
    public List<string> Animals_Domestic = new List<string>();
    public List<string> Animals_Fish = new List<string>();
    public List<string> Animals_Lizards = new List<string>();
}

