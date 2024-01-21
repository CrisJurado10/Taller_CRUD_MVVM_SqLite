using ProductoMVVMSQLite.ViewModels;
namespace ProductoMVVMSQLite.Views;

public partial class EditPage : ContentPage
{
	public EditPage()
	{
		InitializeComponent();
	}

    public EditPage(int IdProducto)
    {
        InitializeComponent();
        BindingContext = new NuevoProductoViewModel(IdProducto);
    }
}