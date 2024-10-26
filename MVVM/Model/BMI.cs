using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Model
{
    public class BMI : INotifyPropertyChanged
    {
        private int _height;
        private int _weight;
        private double _result;
        private string _resultText = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Height
        {
            get => _height;
            set
            {
                if (value != _height)
                {
                    _height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }

        public int Weight
        {
            get => _weight;
            set
            {
                if (value != _weight)
                {
                    _weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        public double Result
        {
            get => _result;
            set
            {
                if (value != _result)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public string ResultText
        {
            get => _resultText;
            set
            {
                if (value != _resultText)
                {
                    _resultText = value;
                    OnPropertyChanged(nameof(ResultText));
                }
            }
        }

        private void CalculateBMI()
        {
            double getMeter = Height / 100.0;
            double getBMI = Weight / (getMeter * getMeter);
            Result = getBMI;
            UpdateResultText();
        }

        private void UpdateResultText()
        {
            if (Result < 16)
                ResultText = "Malnourished";
            else if (Result >= 16 && Result < 18.5)
                ResultText = "Underweight";
            else if (Result >= 18.5 && Result < 25)
                ResultText = "Normal weight";
            else if (Result >= 25 && Result < 29.9)
                ResultText = "Overweight";
            else if (Result >= 29.9 && Result < 34.9)
                ResultText = "Obese I";
            else if (Result >= 34.9 && Result < 39.9)
                ResultText = "Obese II";
            else
                ResultText = "Obese III";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            CalculateBMI();
        }
    }

}
