namespace GeradorDeSenha
{
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random gera = new Random();

            string[] simbolos = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S",
                "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "&", "*", "+", "-", "/"};
            string senha = "";

            while (senha.Length < 15)
            {
                int g = gera.Next(0, 71);
                senha = senha + simbolos[g];
            }

            Visor.Text = senha;
        }
    }
}