using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Presentation.View
{
    public class CalculatorView : MonoBehaviour, ICalculatorView
    {
        [SerializeField]private TMP_InputField inputField;

        public event UnityAction<string> OnInputFieldUpdated;

        private void Awake()
        {
            inputField.onValueChanged.AddListener(OnInputFieldUpdated);
        }

        public void UpdateView(string result)
        {
            inputField.text = result;
        }
    }
}
