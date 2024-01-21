using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Utils;
using ProductoMVVMSQLite.Views;
using PropertyChanged;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace ProductoMVVMSQLite.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class EditProductoViewModel
    {
        public ObservableCollection<Producto> ListaProductos { get; set; }
        public Producto ProductoSeleccionado { get; set; }

        public EditProductoViewModel()
        {
            Util.ListaProductos = new ObservableCollection<Producto>(App.productoRepository.GetAll());
            ListaProductos = Util.ListaProductos;
        }

        public ICommand EditarProductos =>
            new Command(async () =>
            {
                if (ProductoSeleccionado != null)
                {
                    int IdProducto = ProductoSeleccionado.IdProducto;
                    await App.Current.MainPage.Navigation.PushAsync(new EditPage(IdProducto));
                    ProductoSeleccionado = null;
                }
            });
    }
}
