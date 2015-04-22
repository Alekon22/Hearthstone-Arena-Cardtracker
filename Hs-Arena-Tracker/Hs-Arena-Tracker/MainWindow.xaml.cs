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
            //OtherLoadJson();
            Console.WriteLine("Done");
        }

        public void LoadJson()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "AllSets.json";

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<object> hsObjects = JsonConvert.DeserializeObject<List<object>>(json);
            }
        }

        public void OtherLoadJson()
        {
            string current;
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "AllSets.json";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] card = line.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                    while (sr.Peek() > 0)
                    {
                        HearthstoneObject c = new HearthstoneObject();
                    }
                }
            }
        }
    }
}
