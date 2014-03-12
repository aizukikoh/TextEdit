using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
//using System.Windows.Controls.Ribbon.RibbonWindow;
//using System.Windows.Controls.Ribbon.Ribbon;
//using System.Windows.Controls.Ribbon;
using System.Windows.Forms;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
	public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
			Top = Properties.Settings.Default.top;
			Left = Properties.Settings.Default.left;
			Width = Properties.Settings.Default.width;
			Height = Properties.Settings.Default.height;

			InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

		private void Button_Open(object sender, RoutedEventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			Stream stream = ofd.OpenFile();
/*			FileStream fs = stream.
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				FileStream infs  = new FileStream(ofd.OpenFile(), FileMode.Open);
				//OKボタンがクリックされたとき
				//選択されたファイル名を表示する
				Console.WriteLine(ofd.FileName);
			}
 * */
		}
		private void Button_Save(object sender, RoutedEventArgs e)
		{
		}

		private void Ribbon_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void GridSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{

		}

		private void Button_Font(object sender, RoutedEventArgs e)
		{
			var dlg = new System.Windows.Forms.FontDialog();
/*
			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				editor.FontFamily = new FontFamily(dlg.Font.FontFamily.Name);
				editor.FontSize = dlg.Font.SizeInPoints / 72.0 * 96.0;
				editor.FontStyle = (dlg.Font.Style & System.Drawing.FontStyle.Italic) == 0
					? FontStyles.Normal : FontStyles.Italic;
				editor.FontWeight = (dlg.Font.Style & System.Drawing.FontStyle.Bold) == 0
					? FontWeights.Normal : FontWeights.Bold;
			}
 */
		}

		private void editor_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			 if (WindowState == WindowState.Normal)
			 {
				 // ウィンドウの値を Settings に格納
				 Properties.Settings.Default.left = Left;
				 Properties.Settings.Default.top = Top;
				 Properties.Settings.Default.width = Width;
				 Properties.Settings.Default.height = Height;
				 Properties.Settings.Default.Window_maximize = false;
			 }
			 else if (WindowState == WindowState.Maximized)
			 {
				 Properties.Settings.Default.Window_maximize = true;
			 }
			 // ファイルに保存
			 Properties.Settings.Default.Save();
		}

		private void Ribbon_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
		{

		}
    }
}
