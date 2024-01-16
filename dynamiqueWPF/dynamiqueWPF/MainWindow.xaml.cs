using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dynamiqueWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            creationGrid();
        }
        public void creationGrid()
        {
            ColumnDefinition[] col = new ColumnDefinition[3];
            RowDefinition[] row = new RowDefinition[3];

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = new ColumnDefinition();
                row[i] = new RowDefinition();
                GrdMain.ColumnDefinitions.Add(col[i]);
                GrdMain.RowDefinitions.Add(row[i]);
            }
        }
    }
}
