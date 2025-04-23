using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CLAVEMANAGER : MonoBehaviour
{

    public TextMeshProUGUI TextoMenesaje;
    public TMP_InputField InputNombreUsuario;
    public TMP_InputField InputClave;
    string nombreUsuario = "Adm";
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

    public void ComprobarDatos()
    {
        string UsuarioIngresado = InputNombreUsuario.text;
        string ClaveIngresada = InputClave.text;
        bool IsValidUser = true;
        bool isValidPassword = true;
        if (UsuarioIngresado != nombreUsuario)
        {
            IsValidUser = false;
            InputNombreUsuario.text = string.Empty;
            TextoMenesaje.text = $"Usuario Invalido";
        }
        if (ClaveIngresada != clave)
        {
            isValidPassword = false;
            InputClave.text = string.Empty;
            TextoMenesaje.text = $"Clave Invalido";
        }
        if(!IsValidUser | !isValidPassword)
        {
            return;
        }
        if (!IsValidUser && !isValidPassword)
        {
            TextoMenesaje.text = $"Acceso Denegado";
            return;
        }

        TextoMenesaje.text = $"Bienvenido {nombreUsuario}";
        return;
    }
}
