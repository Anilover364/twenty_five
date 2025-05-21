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
            //System.Windows.Shapes.Path pathe = new System.Windows.Shapes.Path();
            //pathe.Data = gg;
            //pathe.Stroke = Brushes.Red;
            //pathe.Fill = Brushes.Black;
            //pathe.RenderTransform = new TranslateTransform(x, y);
            //lalala.Children.Add(pathe); 
            System.Windows.Shapes.Path star = new System.Windows.Shapes.Path
            {
                Fill = Brushes.Gold,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                // Форма звезды (M - начало, L - линия, Z - замкнуть)
                Data = Geometry.Parse("M 100,0 L 120,60 L 180,60 L 130,90 L 150,150 L 100,120 L 50,150 L 70,90 L 20,60 L 80,60 Z"),
                RenderTransform = new TranslateTransform(x, y)
            };
            lalala.Children.Add(star);
        }
        Random random = new Random();
        GeometryGroup gg = new GeometryGroup();
        List<int> PointX = new List<int>();
        List<int> PointY = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            int rndX,rndY;
            class1 class1 = new class1();
            for (int i = 0; i < 3; i++) 
            {
                m1:
                rndX = random.Next(320);
                class1.X = rndX;

                rndY = random.Next(250);
              
                    PointX.Add(class1.X);
            
                if (i != 0)
                    for (int j = 0; j < PointX.Count; j++) 
                    {
                        if ((class1.X <= PointX[j] || class1.X <= PointX[j] + 80) || (PointX[j]>=class1.X+80 || class1.X >= PointX[j]))
                        { /*MessageBox.Show(class1.X.ToString());*/
                            PointX.Remove(PointX[i]);
                            goto m1;
                        } 
                          //MessageBox.Show(class1.X.ToString()); 

                        }
                         //MessageBox.Show(PointX[i].ToString());
                        class1.Y = rndY;
            
                PointY.Add(class1.Y);
                nana(class1.X, class1.Y, gg, lalala);
            }
            //class1.X = 20;
            //class1.Y = 20;
            //System.Windows.Shapes.Path pathe = new System.Windows.Shapes.Path();
       
         
            //nana(class1.X, class1.Y, gg, lalala);
            //lalala.Children.Clear();

        }
      
        private void ll_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
    class Pointes
    {
    }
}
class class1
{
    private int x ,y;
    public int X { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }
}
