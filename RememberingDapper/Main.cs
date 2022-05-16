using RememberingDapper.models;

namespace RememberingDapper
{
    public partial class Main : Form
    {
        Productos p = new Productos();
        List<Productos> productos = new List<Productos>();
        public Main()
        {
            InitializeComponent();
            loadProds();
        }
        private void loadProds()
        {
            productos = p.getAll();
            d_productos.DataSource = productos;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            p.cantidad = (int)n_cantidad.Value;
            p.nombre = t_nombre.Text;
            p.precio = n_precio.Value;
            //p.categoriadId = (int)id_categoria.SelectedValue;
            p.categoriaId = 1;

            p.create();
            loadProds();
        }
    }
}