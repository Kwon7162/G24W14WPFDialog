using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace G24W14WPFDialog
{
    /// <summary>
    /// GundamDlg.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GundamDlg : Window
    {
        public GundamDlg()
        {
            InitializeComponent();

            Name2.Focus();
        }

        public string MSName
        {
            get { return Name2.Text; }
        }

        public string MSModel => Model.Text;

        public string MSParty => Party.Text;

        private void OnOk(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(MSName))
            {
                MessageBox.Show(
                    "이름을 입력하십시오.", 
                    "입력 부족",
                    MessageBoxButton.OK, 
                    MessageBoxImage.Warning);

                Name2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(MSModel))
            {
                MessageBox.Show(
                    "모델을 입력하십시오.",
                    "입력 부족",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                Model.Focus();
                return;
            }

            if (string.IsNullOrEmpty(MSParty))
            {
                MessageBox.Show(
                    "소속을 입력하십시오.",
                    "입력 부족",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                Party.Focus();
                return;
            }

            DialogResult = true;
        }

    

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
          

    }
}
