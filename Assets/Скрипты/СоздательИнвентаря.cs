using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СоздательИнвентаря : MonoBehaviour
{
    [SerializeField]private GameObject buttonPrefab;
    [SerializeField]private Transform buttonContainer;
    [SerializeField]private Sprite lockIcon;
    void Start()
    {
        StartCoroutine(СоздатьИнвентарь());
    }

    public IEnumerator СоздатьИнвентарь()
    {
        yield return new WaitForEndOfFrame();

        foreach (var вещь in МенеджерВещей.Экземпляр.Вещи)
        {
            var экземпляр = Instantiate(buttonPrefab, buttonContainer);
            экземпляр.name = вещь.Name;
            var инвентарь = экземпляр.GetComponent<Инвентарь>();
            инвентарь.Вещь = вещь;
            инвентарь.Рендерер.sprite = вещь.Icon;
        } 
        //yield return new WaitForEndOfFrame();
    }
}
