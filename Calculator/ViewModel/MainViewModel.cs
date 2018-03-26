using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Methods;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace Calculator.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _a1;
        public string A1
        {
            get => _a1;
            set
            {
                _a1 = value;
                NotifyPropertyChanged();
            }
        }

        private string _a2;
        public string A2
        {
            get => _a2;
            set
            {
                _a2 = value;
                NotifyPropertyChanged();
            }
        }

        private string _a3;
        public string A3
        {
            get => _a3;
            set
            {
                _a3 = value;
                NotifyPropertyChanged();
            }
        }

        private string _a4;
        public string A4
        {
            get => _a4;
            set
            {
                _a4 = value;
                NotifyPropertyChanged();
            }
        }

        private string _b1;
        public string B1
        {
            get => _b1;
            set
            {
                _b1 = value;
                NotifyPropertyChanged();
            }
        }

        private string _b2;
        public string B2
        {
            get => _b2;
            set
            {
                _b2 = value;
                NotifyPropertyChanged();
            }
        }

        private string _b3;
        public string B3
        {
            get => _b3;
            set
            {
                _b3 = value;
                NotifyPropertyChanged();
            }
        }

        private string _b4;
        public string B4
        {
            get => _b4;
            set
            {
                _b4 = value;
                NotifyPropertyChanged();
            }
        }

        private string _s1;
        public string S1
        {
            get => _s1;
            set
            {
                _s1 = value;
                NotifyPropertyChanged();
            }
        }

        private string _s2;
        public string S2
        {
            get => _s2;
            set
            {
                _s2 = value;
                NotifyPropertyChanged();
            }
        }

        private string _s3;
        public string S3
        {
            get => _s3;
            set
            {
                _s3 = value;
                NotifyPropertyChanged();
            }
        }

        private string _s4;
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

        public ICommand CalculateCommand { get; set; }
        

        public MainViewModel()
        {
            CalculateCommand = new RelayCommand(CalculateExecute, CalculateCanExecute);
            IsAdd = true;
            Initialize();
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

        private void CalculateExecute(object obj)
        {
            if(IsAdd)
            {

            }
            else if (IsSubstraction)
            {

            }
            else if(IsMultiplication)
            {

            }
            else if(IsDivision)
            {
                
            }
        }

        private bool CalculateCanExecute(object arg)
        {
            return true;
        }
    }

    public class AsmProxy
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [DllImport("Asm.dll")]
        private static extern float asmAddVec(float a1, float a2, float a3, float a4, float b1, float b2, float b3, float b4);

        public double executeAsmAddVec(float a1, float a2, float a3, float a4, float b1, float b2, float b3, float b4)
        {
            return asmAddVec( a1,  a2,  a3,  a4,  b1,  b2,  b3,  b4);
        }
    }
}
