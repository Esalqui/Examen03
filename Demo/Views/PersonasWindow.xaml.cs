using Demo.ViewModels;
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

namespace Demo.Views
{
    /// <summary>
    /// Lógica de interacción para PersonasWindow.xaml
    /// </summary>
    public partial class PersonasWindow : Window
    {
        public PersonasWindow()
        {
            InitializeComponent();
            this.DataContext = new ProductoViewModel();
        }
    }
}
