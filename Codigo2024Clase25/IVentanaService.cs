using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase25
{
    public interface IVentanaService
    {
        void AbrirFormulario1();
        void AbrirFormulario2();
    }
    public class VentanaService : IVentanaService
    {
        public void AbrirFormulario1()
        {
            Formulario1 form1 = new Formulario1();
            form1.Show();
        }

        public void AbrirFormulario2()
        {
            Formulario2 form2 = new Formulario2();
            form2.Show();
        }
    }
}
