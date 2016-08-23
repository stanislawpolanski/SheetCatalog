using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace SheetCatalog
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public SheetCatalogDataSet dataSet;
		public SheetCatalogDataSetTableAdapters.PiecesTableAdapter piecesDataAdapter;

		public MainWindow()
		{
			InitializeComponent();
			dataSet = new SheetCatalogDataSet();
			dataGrid.DataContext = dataSet;
			piecesDataAdapter = new SheetCatalogDataSetTableAdapters.PiecesTableAdapter();
			piecesDataAdapter.Fill(dataSet.Pieces);
		}

		public void AddPiece(Piece piece)
		{
			SheetCatalogDataSet.PiecesRow newrow = dataSet.Pieces.NewPiecesRow();
			newrow.Composer = piece.Composer;
			newrow.Title = piece.Title;
			dataSet.Pieces.AddPiecesRow(newrow);
			piecesDataAdapter.Update(dataSet);
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			AddNewPieceWindow nw = new AddNewPieceWindow();
			nw.Show();
		}
	}
}
