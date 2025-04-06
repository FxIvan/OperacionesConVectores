using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OperacionesConVectores
{
    public partial class Form1 : Form
    {
        int[] vector;
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstText.Items.Clear();
            vector = new int[10];
            
            for (i = 0; i < vector.Length; i++) {
                if (i == 0 && txtNombreUno.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreUno.Text);
                } else if (i == 1 && txtNombreDos.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreDos.Text);
                }else if (i == 2 && txtNombreTres.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreTres.Text);
                }else if (i == 3 && txtNombreCuatro.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreCuatro.Text);
                }else if (i == 4 && txtNombreCinco.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreCinco.Text);
                }else if (i == 5 && txtNombreSeis.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreSeis.Text);
                }else if (i == 6 && txtNombreSiete.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreSiete.Text);
                }else if (i == 7 && txtNombreOcho.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreOcho.Text);
                }else if (i == 8 && txtNombreNueve.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreNueve.Text);
                }else if (i == 9 && txtNombreDiez.Text.Length != 0)
                {
                    vector[i] = Int32.Parse(txtNombreDiez.Text);
                }

            }

            for (int i = 0; i < 10; i++)
            {
                lstText.Items.Add("En la posición : " + i + " el valor es: " +
               vector[i]);
            }
            txtNombreUno.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            lstText.Items.Clear();
            this.Close();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstText.Items.Clear();
            Array.Sort(vector);
            for (int i = 0; i < 10; i++)
            {
                lstText.Items.Add("El valor es: " + vector[i] + " en la posición : " + i);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            lstText.Items.Clear();
            int[] vectorDestino = new int[20];
            Array.Copy(vector, 0, vectorDestino, 0, 10);
            for (int i = 0; i < 10; i++)
            {
                lstText.Items.Add(vectorDestino[i] + " en la posición " + i);
            }
        }

        /*
         NOTA: El algoritmo de búsqueda binaria es un excelente método para buscar datos dentro de una 
        estructura (generalmente un arreglo unidimensional). Se le da el nombre de búsqueda binaria por 
        que el algoritmo divide en dos el array, aludiendo al concepto de bit, el cual puede tener dos 
        estados.
        La única condición para usar este algoritmo es que los datos dentro del array estén ordenados de 
        menor a mayor.
         */

        private void btnBusquedaBinaria_Click(object sender, EventArgs e)
        {
            int posicion;
            int bynaryValue = Int32.Parse(txtValueSearchBinary.Text);
            posicion = Array.BinarySearch(vector, bynaryValue);
            lstText.Items.Clear();
            lstText.Items.Add("En la posicion " + posicion + " se encuentra el número " + bynaryValue);

        }

        private void btnLimites_Click(object sender, EventArgs e)
        {
            int superior;
            int inferior;
            lstText.Items.Clear();
            // https://learn.microsoft.com/es-es/dotnet/api/system.array.getupperbound?view=net-8.0
            // GetUpperBound nos dice Índice máximo y minimo del array(GetUpperBound y GetLowerBound)
            superior = vector.GetUpperBound(0);
            inferior = vector.GetLowerBound(0);
            lstText.Items.Add("El límite inferior es " + inferior + " y el superior es " + superior);
        }
    }
}
