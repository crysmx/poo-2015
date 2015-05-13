using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        public AreaDeDesenho()
        {
            InitializeComponent();
        }

/*        private void AdicionarFigura(Figura f)
        {
               
        }
*/           
        public void Desenha(object sender, PaintEventArgs e)
        {
/*5            Graphics g = e.Graphics;
            for (int i = 0; i < this.figuras.Length; i++)
            {
                Figura f = this.figuras[i];
                f.Desenha(g);
            }
*/        }
    }
}
