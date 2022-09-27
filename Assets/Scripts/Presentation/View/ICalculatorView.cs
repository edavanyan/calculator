
using UnityEngine.Events;

namespace Presentation.View
{
    public interface ICalculatorView
    {
        event UnityAction<string> OnInputFieldUpdated;
        void UpdateView(string result);
    }
}
