using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObject/Item")]
public class Вещь : ScriptableObject
{
    public string Id;
    public string Name;
    public int Quantity;
    public Sprite Icon;
    public int PerSecond;
}
