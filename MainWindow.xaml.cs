using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PiGameMobile;

public partial class MainWindow : Window
{
    private const string PiDigits = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";
    private int currentPosition = 0;
    private int decimalPlaces = 0;

    public MainWindow()
    {
        InitializeComponent();
        ResetGame();
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string input = button.Content.ToString() ?? "";
            ProcessInput(input);
        }
    }

    private async void ProcessInput(string input)
    {
        if (currentPosition >= PiDigits.Length)
        {
            StatusDisplay.Text = "Congratulations! You've reached the end!";
            StatusDisplay.Foreground = Brushes.Gold;
            return;
        }

        string expectedDigit = PiDigits[currentPosition].ToString();

        if (input == expectedDigit)
        {
            currentPosition++;

            if (input != ".")
            {
                if (currentPosition > 2)
                {
                    decimalPlaces++;
                }
            }

            PiDisplay.Text = PiDigits.Substring(0, currentPosition);
            CounterDisplay.Text = $"Decimal places: {decimalPlaces}";
            StatusDisplay.Text = "Correct! Type the next digit";
            StatusDisplay.Foreground = Brushes.Green;
        }
        else
        {
            StatusDisplay.Text = "Wrong Answer!";
            StatusDisplay.Foreground = Brushes.Red;

            await Task.Delay(2000);
            ResetGame();
        }
    }

    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        ResetGame();
    }

    private void ResetGame()
    {
        currentPosition = 0;
        decimalPlaces = 0;
        PiDisplay.Text = "3.";
        CounterDisplay.Text = "Decimal places: 0";
        StatusDisplay.Text = "Type the next digit of Pi";
        StatusDisplay.Foreground = Brushes.Green;
        currentPosition = 2;
    }
}