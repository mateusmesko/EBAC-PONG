using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;
    public bool isColorPlayer = false;
    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;
        Debug.Log(uiButton.colors.normalColor);
            SaveController.Instance.colorPlayer = paddleReference.color;
    }
}
