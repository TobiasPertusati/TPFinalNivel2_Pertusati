using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public class Helper
    {
        public void cargarImagen(string imagen, PictureBox pictureBox)
        {
            try
            {
                pictureBox.Load(imagen);
            }
            catch
            {
                pictureBox.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        public bool validarEmptyCbo(ComboBox cbo, string parametro)
        {
            if (cbo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor selecione el " + parametro + " para filtrar");
                return true;
            }
            return false;
        }
        public void validarCbo(ComboBox cbo, Label label) 
        {
            if (cbo.SelectedIndex < 0)
            {
                label.Visible = true;   
            }
            else 
                label.Visible = false;
        }
        public void validadEmptyTxt(TextBox textBox, Label label) 
        {
            if (textBox.Text == "")
                label.Visible = true;
            else
                label.Visible = false;
        }
    }
}
