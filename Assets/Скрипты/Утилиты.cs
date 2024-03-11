using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Утилиты
{
    public static T[] ПолучитьВсеЭкземпляры<T>() where T : ScriptableObject
    {
        return Resources.LoadAll<T>("СкриптовыеОбъекты");
    }
}
