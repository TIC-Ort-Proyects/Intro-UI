using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{

    public TextMeshProUGUI TextoSaludo;
    public TMP_InputField InputNombre;
    string nombreIngresado;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        TextoSaludo.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        // Obtener el nombre desde el inputField

        nombreIngresado = InputNombre.text;

        // Concatenar el nombre con el saludo

        saludo = $"Hola {nombreIngresado}!";

        // Mostrar el saludo en TextoSaludo

        TextoSaludo.text = saludo;

    }
}
