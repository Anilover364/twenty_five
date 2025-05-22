using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
       static private Canvas _starsContainer = new Canvas();
        public  System.Windows.Shapes.Path star = new System.Windows.Shapes.Path();
        public static void nana(int x,int y,Canvas lalala) 
        {
      //Global Gg= new Global();  
Random rnd = new Random();
            System.Windows.Shapes.Path star = new System.Windows.Shapes.Path();
            int r;
            r=rnd.Next(3);
            switch (r) 
            {
            case 0:
                    star.Data = Geometry.Parse("M 50,0 L 60,30 L 90,30 L 65,45 L 75,75 L 50,60 L 25,75 L 35,45 L 10,30 L 40,30 Z");
                    break;
                    case 1:
                    star.Data = Geometry.Parse("M 100,0 L 120,60 L 180,60 L 130,90 L 150,150 L 100,120 L 50,150 L 70,90 L 20,60 L 80,60 Z");
                    break ;
                    case 2:
                    star.Data = Geometry.Parse( "M 25,0 L 30,15 L 45,15 L 32.5,22.5 L 37.5,37.5 L 25,30 L 12.5,37.5 L 17.5,22.5 L 5,15 L 20,15 Z");
                    break;
            }
            star.Fill = Brushes.Gold;
            star.Stroke = Brushes.Black;
            star.StrokeThickness = 2;
            star.RenderTransform = new TranslateTransform(x, y);

            lalala.Children.Add(star);
        }
        private SolidColorBrush GenerateColor()
        {
            Random rnd = new Random();
            return new SolidColorBrush(Color.FromRgb(
                (byte)rnd.Next(256),
                (byte)rnd.Next(256),
                (byte)rnd.Next(256)
            ));
        }
        static void GenerStar(Canvas lalala) 
        {
        Random random = new Random();
            int rndX, rndY;
            Local class1 = new Local();
           


                for (int i = 0; i < 3; i++)
                {

                    rndX = random.Next(1850);
                    class1.X = rndX;

                    rndY = random.Next(850);
                    class1.Y = rndY;
                    nana(class1.X, class1.Y, lalala);
                }
       

                
            
        }
        void NoDickGener() 
        {
            
            GeometryGroup g = new GeometryGroup();
            EllipseGeometry el1 = new EllipseGeometry();
            el1.Center = new Point(50, 50);
            el1.RadiusX = 50;
            el1.RadiusY = 50;
            EllipseGeometry el2 = new EllipseGeometry();
            el2.Center = new Point(50, 200);
            el2.RadiusX = 50;
            el2.RadiusY = 50;
            RectangleGeometry rc = new RectangleGeometry();
            rc.Rect = new Rect(30, 100, 1550, 50);

            g.Children.Add(el1);
            g.Children.Add(el2);
            g.Children.Add(rc);
            System.Windows.Shapes.Path p = new System.Windows.Shapes.Path();
            p.Data = g;
            p.Fill = Brushes.Brown;
   


            _starsContainer.Children.Add(p);
            Canvas.SetLeft(p, -1625);
            Canvas.SetTop(p, 500);
            Random rnd = new Random();
        }
        void Paint1() 
        {
            SolidColorBrush color = GenerateColor();
            Gg.Bruh = color.ToString();


            PainIco.Fill = color;
     
        }
        void Paint2() 
        {
            var stars = _starsContainer.Children.OfType<System.Windows.Shapes.Path>();


            Color color = (Color)ColorConverter.ConvertFromString(Gg.Bruh);


            SolidColorBrush bruh = new SolidColorBrush(color);
            star.Fill = bruh;
          
            foreach (var star in stars)
            {
                star.Fill = bruh;
            }
            Paint1 ();

        }
        public MainWindow()
        {
            InitializeComponent();
            lalala.Children.Add(_starsContainer);
            NoDickGener();
            Paint1();
            GenerStar(_starsContainer);


        }
      
     

          Global Gg= new Global();

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D:
                    Gg.X = Gg.X + 5;
                    Canvas.SetLeft(_starsContainer, Gg.X);
                    break;
                case Key.A: 
                    Gg.X = Gg.X - 5;
                    Canvas.SetLeft(_starsContainer, Gg.X);
                    break;
                case Key.W: 
                    Gg.Y = Gg.Y - 5;
                    Canvas.SetTop(_starsContainer, Gg.Y);
                    break;
                case Key.S: 
                    Gg.Y = Gg.Y + 5;
                    Canvas.SetTop(_starsContainer, Gg.Y);
                    break;
                    case Key.Enter:
                    GenerStar(_starsContainer);
                    break;
            }
        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            var send=sender as MenuItem;
            switch (send.Name) 
            {
                case "Delete":
                    _starsContainer.Children.Clear();
                    Canvas.SetLeft(_starsContainer,0);
                    Gg.X = 0;
                    Canvas.SetTop(_starsContainer,0);
                    Gg.Y = 0;
                    NoDickGener();
                    break;
                case "Painte":
                    Paint2();
                    break;
                case "AddStar":
                    GenerStar(_starsContainer);
                    break;
            }
        }
    }

}
class Local
{
    private int Locx ,Locy;
    public int X { get { return Locx; } set { Locx = value; } }
    public int Y { get { return Locy; } set { Locy = value; } }
}
class Global 
{
    private int Globx, Globy;
    private string Fill;

    public int X { get { return Globx; } set { Globx = value; } }
    public int Y { get { return Globy; } set { Globy = value; } }
    public string Bruh { get { return Fill; } set { Fill = value;  } }
}