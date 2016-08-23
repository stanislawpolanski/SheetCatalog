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
using System.Windows.Shapes;

namespace SheetCatalog
{
	/// <summary>
	/// Interaction logic for AddNewPieceWindow.xaml
	/// </summary>
	public partial class AddNewPieceWindow : Window
	{
		public AddNewPieceWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			Piece np = new Piece();
			np.Composer = composerTextBox.Text;
			np.Title = titleTextBox.Text;
			Owner.AddPiece();

		}
	}
}
