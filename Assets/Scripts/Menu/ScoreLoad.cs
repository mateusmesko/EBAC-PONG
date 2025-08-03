using TMPro;
using UnityEngine;

public class ScoreLoad : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public SaveController SCI = SaveController.Instance;
    private void Start()
    {
        textMeshPro.text = "hi-score:"+ SCI.namePlayer+" :"+ SCI.score.ToString();
        textMeshPro.color = SCI.colorPlayer;
    }
}
