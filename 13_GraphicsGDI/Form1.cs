using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_GraphicsGDI
{
    public partial class Form1 : Form
    {
        enum ShapeType { Rectangle, Line , Ellipse};
        int redraw_count = 0;
        List<Point> points = new List<Point>();
        List<MyShape> shapes = new List<MyShape>();
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            colorCb.Items.Add(Color.Gray);
            colorCb.Items.Add(Color.Green);
            colorCb.Items.Add(Color.Red);
            colorCb.Items.Add(Color.Yellow);
            colorCb.Items.Add(Color.Chartreuse);
            colorCb.SelectedIndex = 0;
            foreach (var item in Enum.GetValues(typeof(ShapeType)))
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = 33;
            int y = 33;
            int width = 300;
            int height = 300;
            Pen pen = new Pen(Brushes.Yellow, 5);
            Point point = new Point(10, 10);
            Size size = new Size(350, 350);

            Rectangle rectangle1  =new Rectangle(point, size);

            Rectangle rectangle2 = new Rectangle(x,y,width,height);
            g.DrawEllipse(pen, rectangle1);
            g.FillEllipse(Brushes.Blue, rectangle2);    
        }
        private void PrintPoints(Graphics g)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Teal, p.X - 10, p.Y - 10, 20, 20);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //PrintPoints(e.Graphics);
            //Exapmle 1
            //this.Text = $"{redraw_count++}";
            //Graphics g = e.Graphics;
            //int x = 33;
            //int y = 33;
            //int width = 300;
            //int height = 300;
            //Pen pen = new Pen(Brushes.Yellow, 5);
            //Point point = new Point(10, 10);
            //Size size = new Size(350, 350);

            //Rectangle rectangle1 = new Rectangle(point, size);

            //Rectangle rectangle2 = new Rectangle(x, y, width, height);
            //g.DrawEllipse(pen, rectangle1);
            //g.FillEllipse(Brushes.Blue, rectangle2);

            //Exapmle 2
            //using (Graphics g = e.Graphics)
            //{
            //    Pen pen = new Pen(Color.Green, 20);
            //    pen.StartCap = LineCap.SquareAnchor;
            //    pen.EndCap = LineCap.ArrowAnchor;
            //    pen.DashStyle = DashStyle.DashDot;  
            //    pen.DashCap = DashCap.Triangle;

            //    g.DrawLine(pen, 20, 200, 900, 200);

            //    Pen p = new Pen(Brushes.Red, 8);
            //    p.DashStyle = DashStyle.Dash;
            //    Rectangle rectangle = new Rectangle(33, 33, 500, 500);
            //    g.DrawEllipse(p, rectangle);

            //    Rectangle rectangle1 = new Rectangle(60, 60, 300, 300);
            //    g.FillEllipse(Brushes.Brown, rectangle1);

            //}//Dispose();

            ///example 3
             Graphics g =  e.Graphics;
            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }

            Font f = new Font("Verdana", 15, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello world ", f, Brushes.Black, 50, 50);


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Graphics g = e.Graphics;
        }     
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        //    Point point = e.Location;
        //    points.Add(point);
        //    this.CreateGraphics().FillEllipse(Brushes.Teal, point.X-10, point.Y-10, 20, 20);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down";
            startLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {


            this.Text = "Up";
            Point end = e.Location;
            Graphics g = this.CreateGraphics();
            var type = (ShapeType)comboBox1.SelectedItem;
            Color color = (Color)colorCb.SelectedItem;
            MyShape shape = null;
            if (type == ShapeType.Rectangle || type == ShapeType.Ellipse)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.X = startLocation.X < end.X ? startLocation.X : end.X;
                rectangle.Y = startLocation.Y < end.Y ? startLocation.Y : end.Y;

                rectangle.Width = Math.Abs(e.X - startLocation.X);
                rectangle.Height = Math.Abs(e.Y - startLocation.Y);

                if(type == ShapeType.Rectangle)
                {
                     shape = new MyRectangle(color, rectangle);          
                }
                else
                {
                    shape = new MyEllipse(color, rectangle);
                }
            }
            else if(type == ShapeType.Line)
            {
                shape = new MyLine(color, startLocation, end);               
            }

            shape.Draw(g);
            shapes.Add(shape);
        }
    }
    abstract class MyShape
    {
        public abstract void Draw(Graphics g);
    }
    class MyRectangle :MyShape
    {
        //public Color Color { get; set; }
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }
        public MyRectangle()  {     }
        public MyRectangle(Color Color, Rectangle Rectangle)
        {
            this.Brush = new SolidBrush(Color); 
            this.Rectangle = Rectangle;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, Rectangle);  
        }
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine()   {     }
        public MyLine(Color c, Point s, Point e)
        {
            Pen = new Pen(c);
            Start = s;
            End = e;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
    class MyEllipse :MyRectangle
    {
        public MyEllipse() {  }
        public MyEllipse(Color c, Rectangle r): base(c,r){}
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, Rectangle);
        }

    }
}
