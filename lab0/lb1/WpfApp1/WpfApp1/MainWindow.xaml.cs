using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double Unit = 10;
        Grid Grid;
        Draw Draw;

        public MainWindow()
        {
            InitializeComponent();
            Draw = new Draw(Canvas, 10);
            Grid = new Grid(Canvas, 720, 720, 10);
        }
        
        

        private void gridon_Checked(object sender, RoutedEventArgs e)
        {
            Grid.drawGrid();
            
        }
        public void Axison_Checked(object sender, RoutedEventArgs e)
        {
            Grid.drawAxis();
       //     Draw.SetText();

        }

        private void SetSizes_Checked(object sender, RoutedEventArgs e)
        {
            Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
        }

        private void HelpLines_Checked(object sender, RoutedEventArgs e)
        {
            Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
        }

        public void gridon_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.clearGrid();
            Draw.SetDraw(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            if (Axison.IsChecked == true)
            {
                Grid.drawAxis();
        //        Draw.SetText();
            }

            if (SetSizes.IsChecked == true)
            {
                Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }

            if (HelpLines.IsChecked == true)
            {
                Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }

        }
        public void Axison_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.clearAxis();
            
            //Draw.Ddraw();
            Draw.SetDraw(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            if (gridon.IsChecked == true)
            {
                Grid.drawGrid();
          
            }

            if (SetSizes.IsChecked == true)
            {
                Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }

            if (HelpLines.IsChecked == true)
            {
                Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }
        }

        private void SetSizes_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.clearSizes();
            Draw.SetDraw(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            if (gridon.IsChecked == true)
            {
                Grid.drawGrid();
            }
            if (Axison.IsChecked == true)
            {
                Grid.drawAxis();
        //        Draw.SetText();
            }

            if (HelpLines.IsChecked == true)
            {
                Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }


        }

        private void HelpLines_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.clearHelpes();
            Draw.SetDraw(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));

            if (gridon.IsChecked == true)
            {
                Grid.drawGrid();
            }
            if (Axison.IsChecked == true)
            {
                Grid.drawAxis();
            }
            if (SetSizes.IsChecked == true)
            {
                Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }


        }

        private void button_draw(object sender, RoutedEventArgs e)
        {
            //Draw.Ddraw();
            //Draw.SetDraw();
            //Draw.Ddraw(Convert.ToDouble(r.Text));
            Draw.SetDraw(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            if (gridon.IsChecked == true)
            {
                Grid.drawGrid();
            }
            if (Axison.IsChecked == true)
            {
                Grid.drawAxis();
        //        Draw.SetText();
            }

            if (SetSizes.IsChecked == true)
            {
                Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }

            if (HelpLines.IsChecked == true)
            {
                Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            r1.Text = "25";
            r2.Text = "45";
            H.Text = "105";
            r3.Text = "25";

            Draw.SetDraw(25, 45, 80, 25);
            if (gridon.IsChecked == true)
            {
                Grid.drawGrid();
            }
            if (Axison.IsChecked == true)
            {
                Grid.drawAxis();
             //   Draw.SetText();
            }
            if (SetSizes.IsChecked == true)
            {
                Draw.SetSizes(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }

            if (HelpLines.IsChecked == true)
            {
                Draw.HelpLines(Convert.ToDouble(r1.Text), Convert.ToDouble(r2.Text), Convert.ToDouble(H.Text), Convert.ToDouble(r3.Text));
            }
        }

        //private void EuclidTransform_Click(object sender, RoutedEventArgs e)
        //{
        //    Draw.PerformEuclid(Convert.ToDouble(Euclid_Axis_x.Text), Convert.ToDouble(Euclid_Axis_y.Text), Convert.ToDouble(Euclid_alp_x.Text) * Unit, Convert.ToDouble(Euclid_alp_y.Text) * Unit, Convert.ToDouble(Euclid_alp.Text));
        //}

        //private void Affine_transform_Click(object sender, RoutedEventArgs e)
        //{
        //    Draw.PerformAffine(Convert.ToDouble(X0_rad.Text), Convert.ToDouble(Y0_rad.Text), Convert.ToDouble(X1_rad.Text), Convert.ToDouble(Y1_rad.Text), Convert.ToDouble(X2_rad.Text), Convert.ToDouble(Y2_rad.Text));
        //}

        //private void Projective_transform_Click(object sender, RoutedEventArgs e)
        //{
        //    Draw.PerformProjective(Convert.ToDouble(X0_proj.Text), Convert.ToDouble(Y0_proj.Text), Convert.ToDouble(W0_proj.Text), Convert.ToDouble(Xx_proj.Text), Convert.ToDouble(Yx_proj.Text), Convert.ToDouble(Wx_proj.Text), Convert.ToDouble(Xy_proj.Text), Convert.ToDouble(Yy_proj.Text), Convert.ToDouble(Wy_proj.Text));
        //}


    }
}
