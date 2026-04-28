using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

using System.IO; 
using System.Xml;   
using Microsoft.VisualBasic;

namespace Pantalla
{
    public partial class Main : Form
    {
        //private AccesoDatos accesoDatos;
        private SqlConnection conn = new SqlConnection("Persist Security Info=False;User ID=usreprac;pwd=usreprac;Initial Catalog=WMS_FIRETECH;Data Source=66.225.246.159");
        //private SqlConnection conn = new SqlConnection("Persist Security Info=False;User ID=usreprac;pwd=usreprac;Initial Catalog=EFLOW_ILG_3PL;Data Source=172.23.55.8");
        CapaObjetos.TextPrinter clsNoSpooler = new CapaObjetos.TextPrinter();
        string _ImpresoraSeleccionada = string.Empty;
        private string archOrigen;
        private string ARCHDESTINO;
        private string strImpresora;

        public Main()
        {
            InitializeComponent(); 
            textBox1.Text = "";

        }

 

        private string imprimir()
        {

            string Name;
            Name = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\etiquetas.xml";
            Name = Name.Replace(@"bin\", "");
            Name = Name.Replace(@"file:\", "");
            Name = Name.Replace(@"x86\", "");
            Name = Name.Replace(@"Debug\", "");
            XmlDataDocument x = new XmlDataDocument();
            x.Load(Name);
            string tipoEtiqueta ;
            int pTamanoEtiqueta = 0;

            // cuatroXdos = 1
            // cuatroXcuatro = 2
            // dosXdos = 3
            // tresXuno = 4
            if (pTamanoEtiqueta == 2)
                tipoEtiqueta = "UbicacionZPL_4X4";
            else if (pTamanoEtiqueta == 3)
                tipoEtiqueta = "UbicacionZPL_2X2";
            else if (pTamanoEtiqueta == 4)
                tipoEtiqueta = "UbicacionZPL_3X1";
            else if (pTamanoEtiqueta == 5)
                tipoEtiqueta = "UbicacionZPL_3X2";
            else
                tipoEtiqueta = "ZPL_ALBARAN";

            //if (pTipoEtiquetaSistema == 2)
                //tipoEtiqueta += "_QR";

            XmlNode node;
            string NombreParametro;
            NombreParametro = "texto";
            node = x.SelectSingleNode("//main/etiqueta[@id='" + tipoEtiqueta + "']/" + NombreParametro);
            if (node == null)
                return null;
            else
            {
                string value;
                value = node.InnerXml.Clone().ToString();
                value = value.Replace("&gt;", ">");
                value = value.Replace("&lt;", "<");
                return value;
            }         

         }

        private string imprimir2()
        {

            string Name;
            Name = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\etiquetas.xml";
            Name = Name.Replace(@"bin\", "");
            Name = Name.Replace(@"file:\", "");
            Name = Name.Replace(@"x86\", "");
            Name = Name.Replace(@"Debug\", "");
            XmlDataDocument x = new XmlDataDocument();
            x.Load(Name);
            string tipoEtiqueta;
            int pTamanoEtiqueta = 0;

            // cuatroXdos = 1
            // cuatroXcuatro = 2
            // dosXdos = 3
            // tresXuno = 4
            if (pTamanoEtiqueta == 2)
                tipoEtiqueta = "UbicacionZPL_4X4";
            else if (pTamanoEtiqueta == 3)
                tipoEtiqueta = "UbicacionZPL_2X2";
            else if (pTamanoEtiqueta == 4)
                tipoEtiqueta = "UbicacionZPL_3X1";
            else if (pTamanoEtiqueta == 5)
                tipoEtiqueta = "UbicacionZPL_3X2";
            else
                tipoEtiqueta = "ArticuloEanZPL";

            //if (pTipoEtiquetaSistema == 2)
            //tipoEtiqueta += "_QR";

            XmlNode node;
            string NombreParametro;
            NombreParametro = "texto";
            node = x.SelectSingleNode("//main/etiqueta[@id='" + tipoEtiqueta + "']/" + NombreParametro);
            if (node == null)
                return null;
            else
            {
                string value;
                value = node.InnerXml.Clone().ToString();
                value = value.Replace("&gt;", ">");
                value = value.Replace("&lt;", "<");
                return value;
            }

        }

        private string imprimir3()
        {

            string Name;
            Name = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\etiquetas.xml";
            Name = Name.Replace(@"bin\", "");
            Name = Name.Replace(@"file:\", "");
            Name = Name.Replace(@"x86\", "");
            Name = Name.Replace(@"Debug\", "");
            XmlDataDocument x = new XmlDataDocument();
            x.Load(Name);
            string tipoEtiqueta;
            int pTamanoEtiqueta = 0;

            // cuatroXdos = 1
            // cuatroXcuatro = 2
            // dosXdos = 3
            // tresXuno = 4
            if (pTamanoEtiqueta == 2)
                tipoEtiqueta = "UbicacionZPL_4X4";
            else if (pTamanoEtiqueta == 3)
                tipoEtiqueta = "UbicacionZPL_2X2";
            else if (pTamanoEtiqueta == 4)
                tipoEtiqueta = "UbicacionZPL_3X1";
            else if (pTamanoEtiqueta == 5)
                tipoEtiqueta = "UbicacionZPL_3X2";
            else
                tipoEtiqueta = "CONTENEDORES";

            //if (pTipoEtiquetaSistema == 2)
            //tipoEtiqueta += "_QR";

            XmlNode node;
            string NombreParametro;
            NombreParametro = "texto";
            node = x.SelectSingleNode("//main/etiqueta[@id='" + tipoEtiqueta + "']/" + NombreParametro);
            if (node == null)
                return null;
            else
            {
                string value;
                value = node.InnerXml.Clone().ToString();
                value = value.Replace("&gt;", ">");
                value = value.Replace("&lt;", "<");
                return value;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {              
            clsNoSpooler.ImprimirTextoPlano(ObtenerArchivoArticuloEanZPL(textBox1.Text), strImpresora);

        }

        public string ObtenerArchivoArticuloEanZPL(string pCONTENEDOR)
        {
            try
            {
                
                // Limpar archivo de eiquetas
                archOrigen = this.imprimir();
                ARCHDESTINO = "";

                archOrigen = archOrigen.Replace("pCONTENEDOR", pCONTENEDOR);

              
                ARCHDESTINO = archOrigen;

                return ARCHDESTINO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerArchivoArticuloEanZPL2(string pCONTENEDOR)
        {
            try
            {

                // Limpar archivo de eiquetas
                archOrigen = this.imprimir2();
                ARCHDESTINO = "";
                DateTime date = DateTime.Now; // will give the date for today
                string dateWithFormat = date.ToString("dd-MM-yyyy");

                archOrigen = archOrigen.Replace("pIDARTICULO", pCONTENEDOR);
                archOrigen = archOrigen.Replace("pDESCRIPCION", obtenerDescripcion(pCONTENEDOR));
                archOrigen = archOrigen.Replace("pFECHA", dateWithFormat);

                ARCHDESTINO = archOrigen;

                return ARCHDESTINO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerArchivoArticuloEanZPL3(string pCONTENEDOR)
        {
            try
            {
                // Limpar archivo de eiquetas
                archOrigen = this.imprimir3();
                ARCHDESTINO = ""; 

                archOrigen = archOrigen.Replace("pIDCONTENEDOR", pCONTENEDOR); 

                ARCHDESTINO = archOrigen;

                return ARCHDESTINO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int pCantidad = 1;

            pCantidad = Convert.ToInt32(textCantidad.Text);

            for (int cont = 1; cont <= pCantidad; cont++)
                clsNoSpooler.ImprimirTextoPlano(ObtenerArchivoArticuloEanZPL2(textBox2.Text), strImpresora);
            
        }

        private string obtenerDescripcion(string idarticulo)
        {
            try
            {

                string descripcion= "";
                conn.Open();
                string query = @"SELECT TOP 1 DESCRIPCIONCORTA FROM ARTICULOSGESTION  ";

                SqlCommand command = new SqlCommand();
                query += "WHERE IDARTICULO = @idarticulo ";
                command.Parameters.Add(new SqlParameter("@idarticulo", idarticulo));

                command.CommandText = query;
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    descripcion = reader["DESCRIPCIONCORTA"].ToString();
                }

                

                return descripcion;
            }
            catch (Exception)
            {
                throw;
            }

            finally { conn.Close(); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
                clsNoSpooler.ImprimirTextoPlano(ObtenerArchivoArticuloEanZPL3(textBox3.Text), strImpresora);
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDialog prd = new PrintDialog();


            prd.AllowPrintToFile = false;
            prd.AllowSomePages = false;
            prd.UseEXDialog = true;
            prd.AllowPrintToFile = false;
            if (prd.ShowDialog() != DialogResult.Cancel)
                strImpresora = prd.PrinterSettings.PrinterName.ToString();

            else
            {
                prd.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string contenedor = "";
            int pCantidad = 1;
            pCantidad = Convert.ToInt32(textBox4.Text);

            SqlConnection miconexion = new SqlConnection("Persist Security Info=False;User ID=usreprac;pwd=usreprac;Initial Catalog=WMS_FIRETECH;Data Source=66.225.246.159");

            conn.Open();

            string query = @"SELECT TOP " + pCantidad + " IDCONTENEDOR FROM CONTENEDOR WHERE TPCNES = 'PEND' AND TPCNSI = 'DISP' AND IDCONTENEDOR NOT IN ('0') AND IDCLIENTERESERVA IS NULL ORDER BY IDCONTENEDOR ";

            SqlCommand command = new SqlCommand();

            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                contenedor = reader["IDCONTENEDOR"].ToString();

                clsNoSpooler.ImprimirTextoPlano(ObtenerArchivoArticuloEanZPL3(contenedor), strImpresora);

                //Coloca los contenedores como leidos con el cliente reserva 1
                miconexion.Open();
                string sql = @"UPDATE CONTENEDOR SET IDCLIENTERESERVA = '1' WHERE IDCONTENEDOR =  @CONTENEDOR ";

                SqlCommand command2 = new SqlCommand(sql, miconexion);

                command2.Parameters.AddWithValue("@CONTENEDOR", contenedor);
                command2.ExecuteNonQuery(); 
                miconexion.Close();

            }
            conn.Close();
            MessageBox.Show("Proceso completado.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
