using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;



namespace SilverlightApplication3
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            MyImage im1 = new MyImage();
            Image myImage1 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.UriSource = new Uri(@"Images/Chrysanthemum.jpg", UriKind.Relative);
            myImage1.Stretch = Stretch.Fill;
            
            im1.MyCollImage = bi3;
            im1.ImageName = "Desert";


            MyImage im2 = new MyImage();
            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.UriSource = new Uri(@"Images/Desert.jpg", UriKind.Relative);
            myImage2.Stretch = Stretch.Fill;

            im2.MyCollImage = bi2;
            im2.ImageName = "Chrysanthemum";

            list.Add(im1);
            list.Add(im2);

            imageBook.DataSource = list;
            this.DataContext = im2;

        }
        List<MyImage> list = new List<MyImage>();


    }

    public class MyImage
    {
        public string ImageName { get; set; }
        public ImageSource MyCollImage { get; set; }
    }
}
