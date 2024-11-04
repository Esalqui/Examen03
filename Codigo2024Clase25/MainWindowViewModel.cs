using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Codigo2024Clase25
{
    public class MainWindowViewModel
    {
        private readonly IVentanaService _ventanaService;

        public MainWindowViewModel(IVentanaService ventanaService)
        {
            _ventanaService = ventanaService;
            AbrirFormulario1Command = new RelayCommand(AbrirFormulario1);
            AbrirFormulario2Command = new RelayCommand(AbrirFormulario2);
        }

        public ICommand AbrirFormulario1Command { get; }
        public ICommand AbrirFormulario2Command { get; }

        private void AbrirFormulario1()
        {
            _ventanaService.AbrirFormulario1();
        }

        private void AbrirFormulario2()
        {
            _ventanaService.AbrirFormulario2();
        }
    }
}
