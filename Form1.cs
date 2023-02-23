using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_OOP.Models;

namespace TH_OOP
{
    public partial class Form1 : Form
    {
        private Point old = new Point();
        private Point current = new Point();
        private Graphics g;
        private Pen pen = new Pen(Color.Black);
        private Pen erase = new Pen(Color.White, 10);
        private bool paint = false;
        private PaintStatus status;
        private Bitmap bm;

        private readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        private readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            status = PaintStatus.Pen;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (status == PaintStatus.Rect)
                {
                    g.DrawRectangle(pen, GetRect());
                }
                else if (status == PaintStatus.Ellipse)
                {
                    g.DrawEllipse(pen, GetRect());
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            old = e.Location;

            UndoStack.Push((Bitmap)bm.Clone());
            RedoStack.Clear();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                current = e.Location;
                if (status == PaintStatus.Pen)
                {
                    g.DrawLine(pen, old, current);
                    old = current;
                }
                else if (status == PaintStatus.Erase)
                {
                    g.DrawLine(erase, old, current);
                    old = current;
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                current = e.Location;
                if (status == PaintStatus.Rect)
                {
                    g.DrawRectangle(pen, GetRect());
                }
                else if (status == PaintStatus.Ellipse)
                {
                    g.DrawEllipse(pen, GetRect());
                }
                paint = false;
            }
        }

        private Rectangle GetRect()
        {
            Rectangle shape = new Rectangle();
            shape.X = Math.Min(old.X, current.X);
            shape.Y = Math.Min(old.Y, current.Y);
            shape.Width = Math.Abs(old.X - current.X);
            shape.Height = Math.Abs(old.Y - current.Y);
            return shape;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            status = PaintStatus.Pen;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            status = PaintStatus.Erase;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            status = PaintStatus.Rect;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            status = PaintStatus.Ellipse;
        }        
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            status = PaintStatus.ColorPicker;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(status == PaintStatus.ColorPicker)
            {
                Point p = SetPoint(pictureBox1, e.Location);
                Color c = ((Bitmap)pictureBox1.Image).GetPixel(p.X, p.Y);            }            
            else if (status == PaintStatus.Fill)
            {
                Point p = SetPoint(pictureBox1, e.Location);
                Fill(bm, p.X, p.Y, btnColor.BackColor);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == oldColor)
            {
                Point p = new Point(x, y);
                if (!sp.Contains(p))
                {
                    sp.Push(p);
                }                
                bm.SetPixel(x, y, newColor);
            }
        }

        private void Fill(Bitmap bm, int x, int y, Color newColor)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newColor);

            if (oldColor == newColor)
                return;

            while (pixel.Count > 0)
            {
                Point pt = (Point) pixel.Pop();                
                if (pt.X > 0 && pt.Y > 0
                    && pt.X < bm.Width -1 && pt.Y < bm.Height -1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, oldColor, newColor);
                    validate(bm, pixel, pt.X + 1 , pt.Y, oldColor, newColor);
                    validate(bm, pixel, pt.X, pt.Y -1, oldColor, newColor);
                    validate(bm, pixel, pt.X , pt.Y + 1, oldColor, newColor);
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            status = PaintStatus.Fill;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                pen.Color = btnColor.BackColor;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, bm.Width, bm.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bm.Clone());
                bm = UndoStack.Pop();
                g = Graphics.FromImage(bm);
                pictureBox1.Image = bm;
                pictureBox1.Invalidate();                
            }
            else
            {
                MessageBox.Show("Nothing to Undo");
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {
                UndoStack.Push((Bitmap)bm.Clone());
                bm = RedoStack.Pop();
                g = Graphics.FromImage(bm);
                pictureBox1.Image = bm;
                pictureBox1.Invalidate();

            }
            else
            {
                MessageBox.Show("Nothing to Redo");
            }
        }
    }
}
