using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ПереключениеСцены : MonoBehaviour
{
    public void ВыбратьСцену(string названиеСцены)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(названиеСцены);
    }

    public void Выход()
    {
        Application.Quit();
    }
}
