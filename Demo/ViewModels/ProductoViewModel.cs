using Demo.Models;
using Demo.Utilitarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.ViewModels
{
    public class ProductoViewModel : ViewModelBase
    {
        #region Propiedades

        private string _Resultado;
        public string Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }


        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private double _Precio;
        public double Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        #endregion

        public ObservableCollection<ProductoModel> Productos { get; }

        #region Comando
        public ICommand GuardarCommand { get; }

        public ProductoViewModel()
        {
            GuardarCommand = new RelayCommand(Guardar);
            Productos = new ObservableCollection<ProductoModel>();
        }
        private void Guardar()
        {
            Resultado = string.Concat(Nombre, " ", Precio, " ", Descripcion);

            Productos.Add(new ProductoModel
            {
                Nombres = this.Nombre,
                Precio = this.Precio,
                Descripcion = this.Descripcion,
                 UsuarioCreacion="htorrico"
            });

        }
        #endregion

    }
}
