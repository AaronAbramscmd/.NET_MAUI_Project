using System.ComponentModel;

public class QuestionViewModel : INotifyPropertyChanged
{
    private string selectedAnswer1;
    private string selectedAnswer2;
    private string selectedAnswer3;
    private string selectedAnswer4;

    public string SelectedAnswer1
    {
        get => selectedAnswer1;
        set
        {
            if (selectedAnswer1 != value)
            {
                selectedAnswer1 = value;
                OnPropertyChanged(nameof(SelectedAnswer1));
            }
        }
    }

    public string SelectedAnswer2
    {
        get => selectedAnswer2;
        set
        {
            if (selectedAnswer2 != value)
            {
                selectedAnswer2 = value;
                OnPropertyChanged(nameof(SelectedAnswer2));
            }
        }
    }

    public string SelectedAnswer3
    {
        get => selectedAnswer3;
        set
        {
            if (selectedAnswer3 != value)
            {
                selectedAnswer3 = value;
                OnPropertyChanged(nameof(SelectedAnswer3));
            }
        }
    }

    public string SelectedAnswer4
    {
        get => selectedAnswer4;
        set
        {
            if (selectedAnswer4 != value)
            {
                selectedAnswer4 = value;
                OnPropertyChanged(nameof(SelectedAnswer4));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
