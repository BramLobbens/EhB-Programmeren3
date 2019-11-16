using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public List<Rectangle> _rectangles = new List<Rectangle>();
        private int _numRectangles = 0; // Keep count of number of rectangles to draw
        private int LocationX { get; set; } // default = 0
        private int LocationY { get; set; } // default = 0
        private Point RelativePoint { get; set; }
        private Color RectangleColor { get; set; }
        public Form1()
        {
            InitializeComponent();
            UpdateToolStripStatus();
            this.Paint += Form1_Paint;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Increment number of rectangles to draw
            _numRectangles += 1;
            
            // Populate list of rectangles
            PopulateRectangles();
        }

        private void PopulateRectangles()
        {
            // Reset all rectangles
            _rectangles.Clear();

            var n = Math.Ceiling(Math.Sqrt(_numRectangles));
            var count = _numRectangles;

            var _rectangleHeight = (int) (this.Height / n);
            var _rectangleWidth = (int) (this.Width / n);

            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    if (count > 0)
                    {
                        // Add rectangle to list
                        var rectangle = new Rectangle(LocationX, LocationY, _rectangleWidth, _rectangleHeight); 
                        this._rectangles.Add(rectangle);

                        count--;
                    }
                    LocationX += _rectangleWidth;
                }
                LocationY += _rectangleHeight;
                LocationX = 0; // Reset X offset
            }
            LocationY = 0; // Reset Y offset

            // Force Redraw the form
            this.Invalidate();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                _rectangles.RemoveAt(_rectangles.Count - 1); ;
                _numRectangles -= 1;
            }

            // Force redraw the form
            this.Invalidate(); 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear rectangles
             _rectangles.Clear();
            _numRectangles = 0;

            // Reset mouse coordinates
            RelativePoint = new Point(0, 0);
            UpdateToolStripStatus();

            // Force redraw the form
            this.Invalidate(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var rectangle in this._rectangles)
            {
                // Fill rectangle with colour if a colour is selected from the context menu and rectangle is selected
                if (rectangle.Contains(RelativePoint) && RelativePoint.X != 0 && RelativePoint.Y != 0 && !RectangleColor.IsEmpty)
                {
                    e.Graphics.FillRectangle(new SolidBrush(RectangleColor), rectangle);
                }
                // Draw a black-outlined rectangle
                else
                {
                    e.Graphics.DrawRectangle(Pens.Black, rectangle);
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Save the mouse pointer coordinates relative to the form
            RelativePoint = this.PointToClient(Cursor.Position);

            // Display the coordinates in the toolstrip
            UpdateToolStripStatus();

            // Force redraw the form
            this.Invalidate();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ColorDialog())
            {
                DialogResult dialogResult = form.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    RectangleColor = form.Color;
                    UpdateToolStripStatus();
                }
            }
                
        }

        private void UpdateToolStripStatus()
        {
            toolStripStatusLabel1.Text = $"X: {RelativePoint.X}, Y: {RelativePoint.Y} | Color: {RectangleColor.Name}";
        }
    }
}
