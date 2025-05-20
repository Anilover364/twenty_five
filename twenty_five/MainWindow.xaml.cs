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

namespace twenty_five
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void nana(int x,int y,GeometryGroup gg,Canvas lalala) 
        {
            System.Windows.Shapes.Path pathe = new System.Windows.Shapes.Path();
            pathe.Data = gg;
            pathe.Stroke = Brushes.Red;
            pathe.Fill = Brushes.Black;
            pathe.RenderTransform = new TranslateTransform(x, y);
            lalala.Children.Add(pathe);
        }
        public MainWindow()
        {
            InitializeComponent();
            class1 class1 = new class1();
            class1.X = 20;
            class1.Y = 20;
            //System.Windows.Shapes.Path pathe = new System.Windows.Shapes.Path();
            GeometryGroup gg = new GeometryGroup();
            EllipseGeometry EG = new EllipseGeometry();
            EG.Center = new Point(30, 30);
            EG.RadiusX = 20;
            EG.RadiusY = 20;
            gg.Children.Add(EG);
            nana(class1.X, class1.Y, gg, lalala);
            class1.X = 120;
            class1.Y = 120;
            nana(class1.X, class1.Y, gg, lalala);
            //pathe.Data= gg;
            //pathe.Stroke=Brushes.Red;
            //Path star = new Path
            //{
            //    Fill = Brushes.Gold,
            //    Stroke = Brushes.Black,
            //    StrokeThickness = 2,
            //    // Форма звезды (M - начало, L - линия, Z - замкнуть)
            //    Data = Geometry.Parse("M 100,0 L 120,60 L 180,60 L 130,90 L 150,150 L 100,120 L 50,150 L 70,90 L 20,60 L 80,60 Z")
            //};

            //pathe.Fill = Brushes.Black;
            //lalala.Children.Add(pathe);
            //Canvas.SetLeft(pathe, 100);
            //Canvas.SetTop(pathe, 100);


        }
      
        private void ll_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
    class Pointes
    {
        //    private int _x, _y;
        //    Path _path= new Path();
        //    //private int X 
        //    //{
        //    //    get { return _x; }
        //    //}
        //    //public int Y
        //    //{
        //    //    get { return _y; }
        //    //}
        //    public Pointes(int x, int y,Path path) 
        //    {
        //    _x = x;_y = y;
        //        _path = path;
        //        Canvas.SetLeft(_path, _x);
        //        Canvas.SetTop(_path, _y);

        //    }

    }
}
class class1
{
    private int x ,y;
    public int X { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }
}
