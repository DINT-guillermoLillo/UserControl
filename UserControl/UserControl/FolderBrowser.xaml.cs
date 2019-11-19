using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContolDeUsuario
{
    /// <summary>
    /// Lógica de interacción para FolderBrowser.xaml
    /// </summary>
    public partial class FolderBrowser : System.Windows.Controls.UserControl
    {
        public FolderBrowser()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string title
        {
            get { return (string)GetValue(titleProperty); }
            set { SetValue(titleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty titleProperty =
            DependencyProperty.Register("title", typeof(string), typeof(FolderBrowser), new PropertyMetadata("Directorio"));



        public string directorio
        {
            get { return (string)GetValue(directorioProperty); }
            set { SetValue(directorioProperty, value); }
        }

        // Using a DependencyProperty as the backing store for directorio.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty directorioProperty =
            DependencyProperty.Register("directorio", typeof(string), typeof(FolderBrowser), new PropertyMetadata(""));




        public bool lectura
        {
            get { return (bool)GetValue(lecturaProperty); }
            set { SetValue(lecturaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for lectura.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty lecturaProperty =
            DependencyProperty.Register("lectura", typeof(bool), typeof(FolderBrowser), new PropertyMetadata(false));




        public bool nuevaCarpeta
        {
            get { return (bool)GetValue(nuevaCarpetaProperty); }
            set { SetValue(nuevaCarpetaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for nuevaCarpeta.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nuevaCarpetaProperty =
            DependencyProperty.Register("nuevaCarpeta", typeof(bool), typeof(FolderBrowser), new PropertyMetadata(true));




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
                dialogo.ShowNewFolderButton = nuevaCarpeta;

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                directorio = dialogo.SelectedPath;
            }
        }
    }
}
