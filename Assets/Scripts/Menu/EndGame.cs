using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public void Start()
    {
        textMeshPro.text = SaveController.Instance.namePlayer;
    }
}
