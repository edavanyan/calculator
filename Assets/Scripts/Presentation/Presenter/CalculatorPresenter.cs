using Data.Usecase;
using Presentation.View;
using UnityEngine;

namespace Presentation.Presenter
{
    public class CalculatorPresenter : MonoBehaviour
    {
        [SerializeField] private CalculatorView calculatorView;

        private IDataHandler dataHandler;

        private void Awake()
        {
            dataHandler = new DataHandler();
            InitializeWithSavedData();
        }

        private void InitializeWithSavedData()
        {
            var savedData = dataHandler.GetRawData();
            calculatorView.UpdateView(savedData);
            calculatorView.OnInputFieldUpdated += dataHandler.UpdateRawData;
        }

        public void UpdateResult()
        {
            var finalResult = dataHandler.GetResultData();
            calculatorView.UpdateView(finalResult);
        }
    }
}
