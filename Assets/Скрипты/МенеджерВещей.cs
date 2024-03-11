using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class МенеджерВещей : MonoBehaviour
{
    public static МенеджерВещей Экземпляр;

    public Вещь[] Вещи;

    public void Awake()
    {
        Экземпляр = this;
        Вещи = Утилиты.ПолучитьВсеЭкземпляры<Вещь>();
        foreach (var вещь in Вещи)
        {
            Debug.Log(вещь.Name);
        }
    }
}
