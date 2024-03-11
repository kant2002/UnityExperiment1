using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Инвентарь : MonoBehaviour
{
    public Button Кнопка;
    public SpriteRenderer Рендерер;
    public TextMeshProUGUI ТекстКоличества;
    [HideInInspector]public Вещь Вещь;
}
