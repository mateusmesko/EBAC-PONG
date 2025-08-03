using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public TMP_InputField inputField;
    private void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }
    public void UpdateName(string name)
    {
       SaveController.Instance.namePlayer = name;
      
    }
}
