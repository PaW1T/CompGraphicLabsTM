using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    class Outline
    {
        private Canvas Canvas;
        private BrushConverter Converter;
        private Storyboard storyboard;
        private FontWeightConverter WConverter;

        public Outline(Canvas Canvas)
        {
            this.Canvas = Canvas;
            Converter = new BrushConverter();
            WConverter = new FontWeightConverter();
        }
        public void Draw(double x1, double y1, double x2, double y2, double Thickness, string Color, string Tag)
        {
            Line Line = new Line();
            SetLine(Line, x1, y1, x2, y2, Thickness, Color, Tag);
            storyboard = new Storyboard();
        }
        public void SetSizes(double x1, double y1, double x2, double y2, double Thickness, double x3, double y3, string text, string fontWeight, string Color, string Tag)
        {
            Line Sizeline = new Line();
            SetLine(Sizeline, x1, y1, x2, y2, Thickness, Color, Tag);
            storyboard = new Storyboard();

            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = (Brush)Converter.ConvertFromString(Color);
            Canvas.SetLeft(textBlock, x3);
            Canvas.SetTop(textBlock, y3);
            textBlock.FontWeight = (FontWeight)WConverter.ConvertFromString(fontWeight);
            Canvas.Children.Add(textBlock);


            textBlock.Tag = Tag;
        }

        public void HelpLines(double x1, double y1, double x2, double y2, double Thickness, double x3, double y3, string text, string fontWeight, string Color, string Tag)
        {
            Line Helpline = new Line();
            SetLine(Helpline, x1, y1, x2, y2, Thickness, Color, Tag);
            storyboard = new Storyboard();

            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = (Brush)Converter.ConvertFromString(Color);
            Canvas.SetLeft(textBlock, x3);
            Canvas.SetTop(textBlock, y3);
            textBlock.FontWeight = (FontWeight)WConverter.ConvertFromString(fontWeight);
            Canvas.Children.Add(textBlock);


            textBlock.Tag = Tag;
        }

        private void SetLine(Line Line, double x1, double y1, double x2, double y2, double Thickness, string Color, string Tag)
        {
            Line.X1 = x1;
            Line.Y1 = y1;
            Line.X2 = x2;
            Line.Y2 = y2;

            Line.Tag = Tag;

            Line.Stroke = (Brush)Converter.ConvertFromString(Color);
            Line.StrokeThickness = Thickness;

            Canvas.Children.Add(Line);
        }
        public void SetText(double x, double y, string text, string fontWeight, string Color, string Tag)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = (Brush)Converter.ConvertFromString(Color);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            textBlock.FontWeight = (FontWeight)WConverter.ConvertFromString(fontWeight);
            Canvas.Children.Add(textBlock);
            

            textBlock.Tag = Tag;
        }
    }
}
