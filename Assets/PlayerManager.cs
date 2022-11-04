using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] int Vida;
    [SerializeField] int Moedas;
    [SerializeField] TMP_Text MoedasTexto;
    [SerializeField] int MaxMoedas;
    [SerializeField] GameObject victoryPanel;
    [SerializeField] Canvas cv;
    Animator anim;
    public void PegouMoeda()
    {
        Debug.Log("Coletou uma moeda");
        Moedas++;
        MoedasTexto.text = Moedas.ToString();
        if (Moedas >= MaxMoedas)
        {
            //SceneManager.LoadScene(2);
            Instantiate(victoryPanel, cv.transform);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void SofreuDano()
    {
        Vida--;
        if (Vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
    }

}
