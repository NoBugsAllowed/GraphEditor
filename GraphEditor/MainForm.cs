using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Soap;

namespace GraphEditor
{
    public partial class MainForm : Form
    {
        private List<Vertice> vertices;
        private List<Edge> edges;
        private Color currColor;
        private Vertice markedVertice;
        private Point dist;
        private bool MMBPressed;
        private const int R = 18, D = 2 * R;
        public MainForm()
        {
            InitializeComponent();
            //AssignNames();
            vertices = new List<Vertice>();
            edges = new List<Edge>();
            currColor = Color.Black;
            MMBPressed = false;
            markedVertice = null;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Vertice v in vertices)
                    if ((e.X - v.Location.X) * (e.X - v.Location.X) + (e.Y - v.Location.Y) * (e.Y - v.Location.Y) < D * D)
                    {
                        if (markedVertice != null)
                        {
                            Edge tEdge = new Edge(markedVertice, v);
                            int count = edges.RemoveAll(edge => edge == tEdge);
                            if (count == 0)
                                edges.Add(tEdge);
                            pictureBox.Invalidate();
                        }
                        return;
                    }
                vertices.Add(new Vertice(new Point(e.X, e.Y), currColor, vertices.Count + 1));
                pictureBox.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (markedVertice != null)
                    markedVertice.IsMarked = false;
                markedVertice = null;
                buttonDeleteV.Enabled = false;
                foreach (Vertice v in vertices)
                {
                    if (e.X <= v.Location.X + R && e.X >= v.Location.X - R && e.Y <= v.Location.Y + R && e.Y >= v.Location.Y - R)
                    {
                        v.IsMarked = true;
                        markedVertice = v;
                        buttonDeleteV.Enabled = true;
                        break;
                    }
                }
                pictureBox.Invalidate();
            }
            else if (e.Button == MouseButtons.Middle && markedVertice != null)
            {
                dist.X = markedVertice.Location.X - e.X;
                dist.Y = markedVertice.Location.Y - e.Y;
                MMBPressed = true;

                //this.Text = dist.X.ToString() + " " + dist.Y.ToString();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteMarkedVertice();
        }

        private void deleteMarkedVertice()
        {
            if (markedVertice != null)
            {
                edges.RemoveAll(edge => edge.From == markedVertice || edge.To == markedVertice);
                vertices.Remove(markedVertice);
                markedVertice = null;
                buttonDeleteV.Enabled = false;
                int i = 1;
                foreach (Vertice v in vertices)
                    v.Number = i++;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MMBPressed)
            {
                markedVertice.Location = new Point(e.X + dist.X, e.Y + dist.Y);
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && markedVertice!=null)
            {
                MMBPressed = false;
                (int X, int Y) = (markedVertice.Location.X, markedVertice.Location.Y);

                if (X < 0)
                    X = 0;
                else if (X > pictureBox.Width)
                    X = pictureBox.Width;

                if (Y < 0)
                    Y = 0;
                else if (Y > pictureBox.Height)
                    Y = pictureBox.Height;

                markedVertice.Location = new Point(X, Y);
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Brush whiteBrush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 12);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen penLine = new Pen(new SolidBrush(Color.Black), 3);
            foreach (Edge edge in edges)
            {
                e.Graphics.DrawLine(penLine, edge.From.Location, edge.To.Location);
            }
            foreach (Vertice v in vertices)
            {
                SolidBrush brush = new SolidBrush(v.Color);
                Pen pen = new Pen(brush, 3);
                if (v.IsMarked)
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                e.Graphics.FillEllipse(whiteBrush, v.Location.X - R, v.Location.Y - R, D, D);
                e.Graphics.DrawEllipse(pen, v.Location.X - R, v.Location.Y - R, D, D);
                e.Graphics.DrawString(v.Number.ToString(), font, brush, v.Location.X, v.Location.Y, format);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currColor = colorDialog.Color;
                pictureBoxColor.BackColor = currColor;
                if (markedVertice != null)
                {
                    markedVertice.Color = currColor;
                    pictureBox.Invalidate();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            vertices.Clear();
            edges.Clear();
            markedVertice = null;
            pictureBox.Invalidate();
        }

        private void buttonDeleteV_Click(object sender, EventArgs e) => deleteMarkedVertice();

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            Reload();
        }

        private void buttonPolish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl-PL");
            Reload();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    try
                    {
                        sw.WriteLine(vertices.Count);
                        foreach (Vertice v in vertices)
                            sw.WriteLine(v.Location.X.ToString() + "," + v.Location.Y.ToString() + "," + v.Color.ToArgb());
                        foreach (Edge edge in edges)
                            sw.WriteLine(edge.From.Number.ToString() + "," + edge.To.Number.ToString());
                        sw.Close();
                        MessageBox.Show(GraphEditorStrings.msgSaveSuccess);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(GraphEditorStrings.msgSaveFailure);
                    }
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    Vertice[] tVertices;
                    List<Edge> tEdges = new List<Edge>();
                    try
                    {
                        int count = int.Parse(sr.ReadLine());
                        tVertices = new Vertice[count + 1];
                        string[] buf;
                        for (int i = 1; i <= count; i++)
                        {
                            buf = sr.ReadLine().Split(',');
                            tVertices[i] = (new Vertice(new Point(int.Parse(buf[0]), int.Parse(buf[1])), Color.FromArgb(int.Parse(buf[2])), i));
                        }
                        while (!sr.EndOfStream)
                        {
                            buf = sr.ReadLine().Split(',');
                            tEdges.Add(new Edge(tVertices[int.Parse(buf[0])], tVertices[int.Parse(buf[1])]));
                        }
                        vertices = tVertices.ToList();
                        vertices.RemoveAt(0);
                        edges = tEdges;
                        pictureBox.Invalidate();
                        MessageBox.Show(GraphEditorStrings.msgLoadSuccess);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(GraphEditorStrings.msgLoadFailure);
                    }
                }
            }
        }

        public void AssignNames()
        {
            groupBoxEdit.Text = GraphEditorStrings.boxEdit;
            groupBoxImportExport.Text = GraphEditorStrings.boxImportExport;
            groupBoxLang.Text = GraphEditorStrings.boxLang;
            buttonClear.Text = GraphEditorStrings.btnClear;
            buttonColor.Text = GraphEditorStrings.btnColor;
            buttonEnglish.Text = GraphEditorStrings.btnEnglish;
            buttonPolish.Text = GraphEditorStrings.btnPolish;
            buttonLoad.Text = GraphEditorStrings.btnOpen;
            buttonDeleteV.Text = GraphEditorStrings.btnRemoveV;
            buttonSave.Text = GraphEditorStrings.btnSave;
            this.Text = GraphEditorStrings.Caption;
        }

        public void Reload()
        {
            Point location = this.Location;
            Size size = this.Size;
            this.Controls.Clear();
            InitializeComponent();
            this.Location = location;
            this.Size = size;
            //AssignNames();
        }
    }

    public class Vertice
    {
        public int Number { get; set; }
        public Point Location { get; set; }
        public Color Color { get; set; }
        public bool IsMarked { get; set; }

        public Vertice(Point p, Color c, int n, bool f = false)
        {
            Location = p;
            Color = c;
            Number = n;
            IsMarked = f;
        }
    }
    public class Edge
    {
        public Vertice From { get; set; }
        public Vertice To { get; set; }

        public Edge(Vertice from, Vertice to)
        {
            From = from;
            To = to;
        }

        public static bool operator ==(Edge e1, Edge e2) => (e1.From == e2.From && e1.To == e2.To) || (e1.From == e2.To && e1.To == e2.From);
        public static bool operator !=(Edge e1, Edge e2) => !(e1 == e2);

        public override bool Equals(object obj) => this==(Edge)obj;
        public override int GetHashCode() => base.GetHashCode();

    }
}
