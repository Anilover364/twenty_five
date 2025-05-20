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

namespace twenty_five
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            poly.Stroke=Brushes.Blue;
            poly.Fill=Brushes.Red;
            poly.Points.Add(new Point(20,100));
            poly.Points.Add(new Point(35, 65));
            poly.Points.Add(new Point(5, 50));
            poly.Points.Add(new Point(50, 45));
            poly.Points.Add(new Point(65, 15));//
            poly.Points.Add(new Point(80, 45));
            poly.Points.Add(new Point(125, 50));
            poly.Points.Add(new Point(95, 65));
            poly.Points.Add(new Point(110, 100));
            poly.Points.Add(new Point(65, 80));
            lalala.Children.Add(poly);
            Canvas.SetLeft(poly, 10);
            Canvas.SetTop(poly, 10);
            Canvas.SetLeft(poly, 50);
            Canvas.SetTop(poly, 10);
            Random r=new Random();
            int t = r.Next(100);
            for (int i = 0; i < 10; i++) 
            {

                Canvas.SetLeft(poly, t);
                Canvas.SetTop(poly, t);
            }
        }

     Path path= new Path();
        GeometryGroup Gg= new GeometryGroup(); 

        Polygon poly= new Polygon();  
       
    
    }
}
