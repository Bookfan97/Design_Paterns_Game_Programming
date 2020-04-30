using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "plantData", menuName ="Plant Data", order = 51)]
public class PlantData : ScriptableObject
{
public enum THREAT { None, Low, Moderate, High, Midnight}
    [SerializeField]
    private string plantName;
    [SerializeField]
    private THREAT plantThreat;
    [SerializeField]
    private Texture icon;
}
