using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CLAVEMANAGER : MonoBehaviour
{

    public TextMeshProUGUI TextoMenesaje;
    public TMP_InputField InputClave;
    string clave = "tic2025";

    // Start is called before the first frame update
    void Start()
    {
        TextoMenesaje.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComprobarClave()
    {
        string ClaveIngresada = InputClave.text;
        if (ClaveIngresada != clave)
        {
            TextoMenesaje.text = "Acceso denegado";
            InputClave.text = string.Empty;
            return;
        }

        TextoMenesaje.text = "Bienvenido!";
        return;
    }
}
