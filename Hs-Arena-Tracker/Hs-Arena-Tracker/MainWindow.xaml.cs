using Hs_Arena_Tracker.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Hs_Arena_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadJson();
            Console.WriteLine("Done");
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("AllSets.json"))
            {
                string json = r.ReadToEnd();
                List<HearthstoneObject> hsObjects = JsonConvert.DeserializeObject<List<HearthstoneObject>>(json);
            }
        }
    }
}
