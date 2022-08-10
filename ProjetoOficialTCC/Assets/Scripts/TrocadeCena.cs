using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrocadeCena : MonoBehaviour
{
    public string NomedaCena;
    public void ChangeS()
    {
        SceneManager.LoadScene("Instruções");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
