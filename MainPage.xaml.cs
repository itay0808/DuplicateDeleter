using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using static System.Net.Mime.MediaTypeNames;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DuplicateDeleter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string fileName;
        public string fileHash;
        public string filePath;
        public string insideFilePath;
        public string shortestFileLength;
        public int fileCount;


        public MainPage()
        {
            this.InitializeComponent();
            textblock1.Text = "Current Path: " + "@\"C:\\Temp\\Images\"";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fileCount = Directory.GetFiles("C:\\Users\\itayb\\AppData\\Roaming\\Itay_industries\\mods", "*", SearchOption.AllDirectories).Length;

            textblock2.Text = fileCount.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            insideFilePath = "@" + textbox1.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            filePath = insideFilePath;
            textblock1.Text = "Current Path: " + filePath;
            Debug.WriteLine(insideFilePath);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
