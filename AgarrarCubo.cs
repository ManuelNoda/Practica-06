using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MensajeAlAgarrar : MonoBehaviour
{
    public void AlAgarrar(SelectEnterEventArgs args)
    {
        Debug.Log("¡Has agarrado el cubo cercano con el Direct Interactor!");
    }

    public void AlSoltar(SelectExitEventArgs args)
    {
        Debug.Log("Has soltado el cubo cercano.");
    }
}
