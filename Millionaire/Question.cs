using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Millionaire
{
    public class Question : INotifyPropertyChanged
    {
        private string? text;
        private string[]? answer;
        private int rightIndex;
        private int questionStep;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string? Text { get => text; set => OnPropertyChanged(out text, value); }
        public string[]? Answer { get => answer; set => OnPropertyChanged(out answer, value); }
        public int RightIndex { get => rightIndex; set => OnPropertyChanged(out rightIndex, value); }
        public int QuestionStep { get => questionStep; set => OnPropertyChanged(out questionStep, value); }

        private void OnPropertyChanged<T>(out T prop, T value, [CallerMemberName] string? propName = null)
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
