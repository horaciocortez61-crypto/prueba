namespace Prueba
{
    public partial class Form1 : Form
    {
        public int Count { get; set; }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
            InciaLizarBoton();
        }
        private void InciaLizarBoton()
        { 
            Button btnMostrarEtiqueta = new Button();
            btnMostrarEtiqueta.Text = "Mostrar :)";
            btnMostrarEtiqueta.Size = new Size (500, 250);
            btnMostrarEtiqueta.Location = new Point(50,150);
            btnMostrarEtiqueta.Click += Mostar_Etiqueta;
            btnMostrarEtiqueta.Click += btnContar_Click;
            this.Controls.Add(btnMostrarEtiqueta);
        }
        private void Mostar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.Red;    
            lblEtiqueta.Text = "Soy una etiqueta :) ";
            lblEtiqueta.Size = new Size(300, 50);
            lblEtiqueta.Location= new Point(400, 50);
            this.Controls.Add (lblEtiqueta);
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            Count++;
            btnContar.Text = Count.ToString();  
        }
    }
}
