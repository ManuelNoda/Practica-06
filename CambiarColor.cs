using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarColorSeleccionar : MonoBehaviour
{
    private MeshRenderer rend;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    public void AlSeleccionar(SelectEnterEventArgs args)
    {
        // Generar un color aleatorio
        Color nuevoColor = new Color(Random.value, Random.value, Random.value);
        rend.material.color = nuevoColor;
    }
}
