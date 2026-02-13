using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExpressionsSample;

public class MainViewModel : INotifyPropertyChanged
{
    private string _name = "Syncfusion Users";
    private double _price = 1000;
    private double _quantity = 1;
    private bool _isHidden = false;
    private bool _checkBox1 = true;
    private bool _checkBox2 = false;
    private int _clickCount = 0;

    public string Name
    {
        get => _name;
        set { _name = value; OnPropertyChanged(); OnPropertyChanged(nameof(Greeting)); }
    }

    public double Price
    {
        get => _price;
        set { _price = value; OnPropertyChanged(); }
    }

    public double Quantity
    {
        get => _quantity;
        set { _quantity = value; OnPropertyChanged(); }
    }

    public bool IsHidden
    {
        get => _isHidden;
        set { _isHidden = value; OnPropertyChanged(); }
    }

    public bool CheckBox1
    {
        get => _checkBox1;
        set { _checkBox1 = value; OnPropertyChanged(); }
    }

    public bool CheckBox2
    {
        get => _checkBox2;
        set { _checkBox2 = value; OnPropertyChanged(); }
    }

    public int ClickCount
    {
        get => _clickCount;
        set { _clickCount = value; OnPropertyChanged(); }
    }

    public void IncrementCount() => ClickCount++;

    // For traditional binding comparison
    public string Greeting => $"Hello, {Name}!";

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
