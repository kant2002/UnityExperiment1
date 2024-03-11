using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ВыходВМеню : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("ИгровоеМеню");
        }
    }
}
