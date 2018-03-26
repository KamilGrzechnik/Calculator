using System;
using System.Collections.Generic;
using Calculator.Methods;
using System.Windows.Input;
using System.Globalization;
using System.Windows;

namespace Calculator.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _a1;
        private string _a2;
        private string _a3;
        private string _a4;
        private string _b1;
        private string _b2;
        private string _b3;
        private string _b4;
        private string _s1;
        private string _s2;
        private string _s3;
        private string _s4;

        public string A1
        {
            get => _a1;
            set
            {
                _a1 = value;
                NotifyPropertyChanged();
            }
        }
        public string A2
        {
            get => _a2;
            set
            {
                _a2 = value;
                NotifyPropertyChanged();
            }
        }
        public string A3
        {
            get => _a3;
            set
            {
                _a3 = value;
                NotifyPropertyChanged();
            }
        }
        public string A4
        {
            get => _a4;
            set
            {
                _a4 = value;
                NotifyPropertyChanged();
            }
        }
        public string B1
        {
            get => _b1;
            set
            {
                _b1 = value;
                NotifyPropertyChanged();
            }
        }
        public string B2
        {
            get => _b2;
            set
            {
                _b2 = value;
                NotifyPropertyChanged();
            }
        }
        public string B3
        {
            get => _b3;
            set
            {
                _b3 = value;
                NotifyPropertyChanged();
            }
        }
        public string B4
        {
            get => _b4;
            set
            {
                _b4 = value;
                NotifyPropertyChanged();
            }
        }
        public string S1
        {
            get => _s1;
            set
            {
                _s1 = value;
                NotifyPropertyChanged();
            }
        }
        public string S2
        {
            get => _s2;
            set
            {
                _s2 = value;
                NotifyPropertyChanged();
            }
        }
        public string S3
        {
            get => _s3;
            set
            {
                _s3 = value;
                NotifyPropertyChanged();
            }
        }
        public string S4
        {
            get => _s4;
            set
            {
                _s4 = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isAdd;
        public bool IsAdd
        {
            get => _isAdd;
            set
            {
                _isAdd = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isSubstraction;
        public bool IsSubstraction
        {
            get => _isSubstraction;
            set
            {
                _isSubstraction = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isMultiplication;
        public bool IsMultiplication
        {
            get => _isMultiplication;
            set
            {
                _isMultiplication = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isDivision;
        public bool IsDivision
        {
            get => _isDivision;
            set
            {
                _isDivision = value;
                NotifyPropertyChanged();
            }
        }

        public List<string> ValuesList;
        public List<float> FloatList;
        public List<float> ResultsSet;
        private AssemblerHandler assemblerHandler;

        public ICommand CalculateCommand { get; set; }
        public ICommand ClearCommand { get; set; }

        public MainViewModel()
        {
            CalculateCommand = new RelayCommand(CalculateExecute, CalculateCanExecute);
            ClearCommand = new RelayCommand(ClearExecute, ClearCanExecute);
            assemblerHandler = new AssemblerHandler();
            IsAdd = true;
            Initialize();
        }

        private void CalculateExecute(object obj)
        {
            ParseElements();
            if (IsAdd)
            {
                ResultsSet = assemblerHandler.Addition(FloatList);
            }
            else if (IsSubstraction)
            {
                ResultsSet = assemblerHandler.Substraction(FloatList);
            }
            else if (IsMultiplication)
            {
                ResultsSet = assemblerHandler.Multiplication(FloatList);
            }
            else if (IsDivision)
            {
                ResultsSet = assemblerHandler.Division(FloatList);
            }
            try
            {
                S1 = ResultsSet[0].ToString();
                S2 = ResultsSet[1].ToString();
                S3 = ResultsSet[2].ToString();
                S4 = ResultsSet[3].ToString();
            }
            catch (Exception)
            {
            }
        }

        private bool CalculateCanExecute(object arg)
        {
            return true;
        }

        private void ClearExecute(object obj)
        {
            Initialize();
        }

        private bool ClearCanExecute(object arg)
        {
            return true;
        }

        private void ParseElements()
        {
            ValuesList = new List<string>() { A1, A2, A3, A4, B1, B2, B3, B4 };
            FloatList = new List<float>();
            foreach (var number in ValuesList)
            {
                try
                {
                    var x = float.Parse(number, CultureInfo.InvariantCulture);
                    FloatList.Add(x);
                }
                catch (Exception)
                {
                    MessageBox.Show("Conversion to float error");
                }
            }
        }

        private void Initialize()
        {
            A1 = "0";
            A2 = "0";
            A3 = "0";
            A4 = "0";
            B1 = "0";
            B2 = "0";
            B3 = "0";
            B4 = "0";
            S1 = "0";
            S2 = "0";
            S3 = "0";
            S4 = "0";
        }
    }


}
