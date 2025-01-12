using System.Collections.Immutable;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Specialized;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled = false;
            filterToolStripMenuItem.Enabled = false;
            optimizedFilterToolStripMenuItem.Enabled = false;
            modifyToolStripMenuItem.Enabled = false;
            drawToolStripMenuItem1.Enabled = false;
            checkBox1.Enabled = false;
            label1.Visible = false;
        }

        private double abs(double x)
        {
            return (x < 0) ? -x : x;
        }

        public static byte[] readImage(Bitmap image)
        {
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmpData = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = Math.Abs(bmpData.Stride) * image.Height;
            byte[] rgbaValues = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, rgbaValues, 0, bytes);
            image.UnlockBits(bmpData);
            return rgbaValues;
        }

        public static void writeImage(byte[] rgbaValues, Bitmap image)
        {
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmpData = image.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(rgbaValues, 0, bmpData.Scan0, rgbaValues.Length);
            image.UnlockBits(bmpData);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        Bitmap original;
        Bitmap filter;
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();
        int mode = 0;
        bool is_mouse_down = false;
        int x_mouse = -1;
        int y_mouse = -1;
        int RectX;
        int RectY;
        int RectW;
        int RectL;
        Color chosen_color = Color.FromArgb(115, 95, 68);

        void saveState()
        {
            undoStack.Push(filter);
            original = new Bitmap(original);
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (undoStack.Count == 0) return;
            filter = undoStack.Pop();
            redoStack.Push(filter);
            pictureBox1.Image = filter;
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (redoStack.Count == 0) return;
            filter = redoStack.Pop();
            undoStack.Push(filter);
            pictureBox1.Image = filter;
        }

        private void infoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }

            string metadata = "";
            metadata += "Width:\t" + original.Width + " pixels" + "\n"; // Is the girl in that mirror still for sale?
            metadata += "Height:\t" + original.Height + " pixels" + "\n"; // ...the mirror's for sale
            metadata += "Format:\t" + original.RawFormat + "\n"; // Yeah I wanna buy "the mirror"
            metadata += "Pixel Format:\t" + original.PixelFormat + "\n"; // Seek Christ
            metadata += "Vertical Resolution:\t" + original.VerticalResolution + " pixels per inch" + "\n"; // This conversation never happened have a nice day
            metadata += "Horizontal Resolution:\t" + original.HorizontalResolution + " pixels per inch" + "\n";
            MessageBox.Show(metadata, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void grayscaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            // filter = original;
            Color c;
            int avg;
            for (int y = 0; y < filter.Height; y++)
                for (int x = 0; x < filter.Width; x++)
                {
                    c = filter.GetPixel(x, y);
                    avg = (int)((0.5 * c.R + 0.5 * c.G + 0.5 * c.B) / 3);
                    original.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            pictureBox1.Image = filter;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            // filter = original;
            Color c;
            for (int y = 0; y < filter.Height; y++)
                for (int x = 0; x < filter.Width; x++)
                {
                    c = filter.GetPixel(x, y);
                    original.SetPixel(x, y, Color.FromArgb(c.R, 0, 0));
                }
            pictureBox1.Image = filter;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            //filter = original;
            Color c;
            for (int y = 0; y < filter.Height; y++)
                for (int x = 0; x < filter.Width; x++)
                {
                    c = filter.GetPixel(x, y);
                    original.SetPixel(x, y, Color.FromArgb(0, c.G, 0));
                }
            pictureBox1.Image = filter;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            //filter = original;
            Color c;
            for (int y = 0; y < filter.Height; y++)
                for (int x = 0; x < filter.Width; x++)
                {
                    c = filter.GetPixel(x, y);
                    original.SetPixel(x, y, Color.FromArgb(0, 0, c.G));
                }
            pictureBox1.Image = filter;
        }

        private void greenToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            // filter = original;
            byte[] data = new byte[original.Width * original.Height * 4];
            data = readImage(original);
            for (int idx = 0; idx < data.Length; idx += 4)
            {
                data[idx] = 0;
                data[idx + 2] = 0;
            }
            writeImage(data, filter);
            pictureBox1.Image = filter;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            ///  filter = original;
            byte[] data = new byte[original.Width * original.Height * 4];
            data = readImage(original);
            for (int idx = 0; idx < data.Length; idx += 4)
            {
                data[idx] = 0;
                data[idx + 1] = 0;
            }
            writeImage(data, filter);
            pictureBox1.Image = filter;
        }

        private void blueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            //filter = original;
            byte[] data = new byte[original.Width * original.Height * 4];
            data = readImage(original);
            for (int idx = 0; idx < data.Length; idx += 4)
            {
                data[idx + 1] = 0;
                data[idx + 2] = 0;
            }
            writeImage(data, filter);
            pictureBox1.Image = filter;
        }

        private void mergeWithColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveState();
            // filter = original;


            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Color selectedColor = colorDialog.Color;

            IntensityForm intensityForm = new IntensityForm(0.3);
            if (intensityForm.ShowDialog() == DialogResult.Cancel)
                return;
            double intensity = intensityForm.IntensityTrackBar.Value / 100.0;

            byte[] data = readImage(filter);
            for (int i = 0; i < data.Length; i += 4)
            {
                data[i] = (byte)(data[i] * (1 - intensity) + selectedColor.B * intensity);
                data[i + 1] = (byte)(data[i + 1] * (1 - intensity) + selectedColor.G * intensity);
                data[i + 2] = (byte)(data[i + 2] * (1 - intensity) + selectedColor.R * intensity);
            }

            writeImage(data, filter);
            pictureBox1.Image = filter;
        }


        private void yAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            //  filter = original;
            filter.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox1.Image = filter;
        }

        private void xAxisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            // filter = original;
            filter.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox1.Image = filter;
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveState();
            DegreesForm degreesForm = new DegreesForm(0);
            if (degreesForm.ShowDialog() == DialogResult.Cancel)
                return;

            int rotationAngle = degreesForm.DegreesTrackBar.Value;

            double angleInRadians = rotationAngle * (Math.PI / 180);

            int rotatedWidth = (int)Math.Ceiling(
                Math.Abs(original.Width * Math.Cos(angleInRadians)) +
                Math.Abs(original.Height * Math.Sin(angleInRadians))
            );
            int rotatedHeight = (int)Math.Ceiling(
                Math.Abs(original.Width * Math.Sin(angleInRadians)) +
                Math.Abs(original.Height * Math.Cos(angleInRadians))
            );

            Bitmap rotatedBitmap = new Bitmap(rotatedWidth, rotatedHeight);

            using (Graphics g = Graphics.FromImage(rotatedBitmap))
            {
                g.Clear(Color.White);

                g.TranslateTransform(rotatedWidth / 2, rotatedHeight / 2);

                g.RotateTransform(rotationAngle);

                g.TranslateTransform(-original.Width / 2, -original.Height / 2);

                g.DrawImage(original, 0, 0);
            }

            filter = rotatedBitmap;
            pictureBox1.Image = filter;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (RectanglePropertiesDialog dialog = new RectanglePropertiesDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    int startX = dialog.StartX;
                    int startY = dialog.StartY;
                    int rectWidth = dialog.Width;
                    int rectHeight = dialog.Height;
                    Color color = dialog.RectangleColor;
                    bool fill = dialog.Fill;

                    saveState();
                    //filter = original;
                    using (Graphics g = Graphics.FromImage(filter))
                    {
                        if (fill)
                        {
                            using (Brush brush = new SolidBrush(color))
                            {
                                g.FillRectangle(brush, new Rectangle(startX, startY, rectWidth, rectHeight));
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(color, 2))
                            {
                                g.DrawRectangle(pen, new Rectangle(startX, startY, rectWidth, rectHeight));
                            }
                        }
                    }

                    pictureBox1.Image = original;
                }
            }
        }


        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Choose image...";
            d.Filter = "PNG OR JPG | *png;*.jpg";
            if (d.ShowDialog() == DialogResult.Cancel)
                return;
            original = new Bitmap(d.FileName);
            pictureBox2.Image = original;
            editToolStripMenuItem.Enabled = true;
            filterToolStripMenuItem.Enabled = true;
            optimizedFilterToolStripMenuItem.Enabled = true;
            modifyToolStripMenuItem.Enabled = true;
            drawToolStripMenuItem1.Enabled = true;
            label1.Visible = true;
            checkBox1.Enabled = true;
            filter = new Bitmap(original);
            pictureBox1.Image = filter;
            Bitmap init_color = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            using (Graphics g = Graphics.FromImage(init_color))
            {
                g.Clear(chosen_color);
            }
            pictureBox4.Image = init_color;
        }



        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void weightedGrayscaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();

            Color c;
            int avg;
            for (int y = 0; y < filter.Height; y++)
                for (int x = 0; x < filter.Width; x++)
                {
                    c = filter.GetPixel(x, y);
                    avg = (int)((0.3 * c.R + 0.6 * c.G + 0.1 * c.B) / 3);
                    original.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            pictureBox1.Image = filter;
        }

        private void grayscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            //filter = original;
            byte[] data = new byte[original.Width * original.Height * 4];
            data = readImage(original);
            for (int idx = 0; idx < data.Length; idx += 4)
            {
                int c = (data[idx] + data[idx + 1] + data[idx + 2]) / 3;
                data[idx] = data[idx + 1] = data[idx + 2] = (byte)c;
            }
            writeImage(data, filter);
            pictureBox1.Image = filter;
        }

        private void weightedGrayscaleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        }

        private void weightedGrayscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (original == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            saveState();
            // filter = original;
            byte[] data = new byte[original.Width * original.Height * 4];
            data = readImage(original);
            for (int idx = 0; idx < data.Length; idx += 4)
            {
                int c = (int)(0.1 * data[idx] + 0.6 * data[idx + 1] + 0.3 * data[idx + 2]) / 3;
                data[idx] = data[idx + 1] = data[idx + 2] = (byte)c;
            }
            writeImage(data, filter);
            pictureBox1.Image = filter;
        }



        private void channelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void colorDropperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mode = 5; // Mode 5 means color dropper
            this.Cursor = Cursors.Cross;
        }

        private void colorDropperToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (filter == null || x_mouse == -1)
                return;
            Bitmap preview = new Bitmap(filter);
            switch (mode)
            {
                case 1:
                    if (!is_mouse_down) return;
                    using (Graphics g = Graphics.FromImage(preview))
                    {
                        RectX = Math.Min(e.X, x_mouse);
                        RectY = Math.Min(e.Y, y_mouse);
                        RectW = Math.Abs(x_mouse - e.X);
                        RectL = Math.Abs(e.Y - y_mouse);
                        g.DrawImage(filter, 0, 0);
                        Rectangle r = new Rectangle(RectX, RectY, RectW, RectL);
                        Brush brush = new SolidBrush(chosen_color);
                        if (checkBox1.Checked)
                            g.FillRectangle(brush, r);
                        else
                            g.DrawRectangle(new Pen(brush), r);
                        pictureBox1.Image = preview;
                    }
                    break;
                case 2:
                    if (!is_mouse_down) return;
                    using (Graphics g = Graphics.FromImage(preview))
                    {
                        RectX = Math.Min(e.X, x_mouse);
                        RectY = Math.Min(e.Y, y_mouse);
                        RectW = Math.Abs(x_mouse - e.X);
                        RectL = Math.Abs(e.Y - y_mouse);
                        g.DrawImage(filter, 0, 0);
                        Rectangle r = new Rectangle(RectX, RectY, RectW, RectL);
                        Brush brush = new SolidBrush(chosen_color);
                        if (checkBox1.Checked)
                            g.FillEllipse(brush, r);
                        else
                            g.DrawEllipse(new Pen(brush), r);
                        pictureBox1.Image = preview;
                    }
                    break;
                case 4:
                    break;
                case 5:
                    Bitmap picked_color_bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                    using (Graphics g = Graphics.FromImage(picked_color_bmp))
                    {
                        Color picked_col = filter.GetPixel(e.X, e.Y);
                        g.Clear(picked_col);
                    }
                    pictureBox3.Image = picked_color_bmp;
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (is_mouse_down && mode != 0)
            {
                x_mouse = e.X;
                y_mouse = e.Y;
            }
            if (mode == 5)
            {
                Bitmap picked_color_bmp = new Bitmap(pictureBox4.Width, pictureBox4.Height);
                using (Graphics g = Graphics.FromImage(picked_color_bmp))
                {
                    chosen_color = filter.GetPixel(e.X, e.Y);
                    g.Clear(chosen_color);
                }
                pictureBox4.Image = picked_color_bmp;
                this.Cursor = Cursors.Default;
                mode = 0;
            }
        }

        private void rectangleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveState();
            is_mouse_down = true;
            /* filter = new Bitmap(original);*/
            mode = 1; // Mode 1 means shape is rectangle
            //pictureBox1.Image = filter;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveState();
            is_mouse_down = true;
            mode = 2; // Mode 2 means shape is elips
        }

        private void triangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("No image loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveState();
            is_mouse_down = true;
            mode = 3; // Mode 3 means shape is Triangle
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            chosen_color = colorDialog.Color;
            Bitmap init_color = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            using (Graphics g = Graphics.FromImage(init_color))
            {
                g.Clear(chosen_color);
            }
            pictureBox4.Image = init_color;
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_down)
            {
                Rectangle r = new Rectangle(RectX, RectY, RectW, RectL);
                switch (mode)
                {
                    case 1:
                        using (Graphics g = Graphics.FromImage(filter))
                        {
                            Brush brush = new SolidBrush(chosen_color);
                            if (checkBox1.Checked)
                                g.FillRectangle(brush, r);
                            else
                                g.DrawRectangle(new Pen(brush), r);
                            g.DrawImage(filter, 0, 0);

                        }

                        pictureBox1.Image = filter;
                        break;
                    case 2:
                        using (Graphics g = Graphics.FromImage(filter))
                        {
                            Pen pen = new Pen(chosen_color);
                            Brush brush = new SolidBrush(chosen_color);
                            if (checkBox1.Checked)
                                g.FillEllipse(brush, r);
                            else
                                g.DrawEllipse(pen, r);
                            g.DrawImage(filter, 0, 0);
                        }
                        pictureBox1.Image = filter;
                        break;
                    case 3: // Triangle
                        break;
                }
            }
            pictureBox1.Image = filter;
            is_mouse_down = false;
            mode = 0;
            x_mouse = -1;
            y_mouse = -1;
        }
    }
    public class DegreesForm : Form
    {
        public TrackBar DegreesTrackBar { get; private set; }
        public Label DegreesLabel { get; private set; }
        private Button okButton;
        private Button cancelButton;

        public DegreesForm(double initialIntensity)
        {

            DegreesTrackBar = new TrackBar
            {
                Minimum = 0,
                Maximum = 360,
                TickFrequency = 10,
                Value = (int)initialIntensity,
                Width = 200,
                Location = new Point(10, 10)
            };
            DegreesTrackBar.Scroll += DegreesTrackBar_Scroll;

            DegreesLabel = new Label
            {
                Text = $"{initialIntensity}%",
                Location = new Point(DegreesTrackBar.Right + 10, DegreesTrackBar.Top)
            };

            okButton = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(10, DegreesTrackBar.Bottom + 20)
            };

            cancelButton = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(okButton.Right + 10, DegreesTrackBar.Bottom + 20)
            };

            this.Controls.Add(DegreesTrackBar);
            this.Controls.Add(DegreesLabel);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);
            this.Text = "Set Intensity";
            this.Width = 300;
            this.Height = 150;

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }

        private void DegreesTrackBar_Scroll(object sender, EventArgs e)
        {
            DegreesLabel.Text = $"{DegreesTrackBar.Value}";
        }
    }
    public partial class RectanglePropertiesDialog : Form
    {
        private TextBox txtStartX;
        private TextBox txtStartY;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private CheckBox chkFill;
        private Button btnColorPicker;
        private ColorDialog colorDialog1;

        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public int rectWidth { get; private set; }
        public int rectHeight { get; private set; }
        public Color RectangleColor { get; private set; }
        public bool Fill { get; private set; }

        public RectanglePropertiesDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label lblStartX = new Label { Text = "Start X:", Location = new Point(0, 10) };
            txtStartX = new TextBox { Location = new Point(100, 10), Width = 100 };

            Label lblStartY = new Label { Text = "Start Y:", Location = new Point(0, 40) };
            txtStartY = new TextBox { Location = new Point(100, 40), Width = 100 };

            Label lblWidth = new Label { Text = "Width:", Location = new Point(0, 70) };
            txtWidth = new TextBox { Location = new Point(100, 70), Width = 100 };

            Label lblHeight = new Label { Text = "Height:", Location = new Point(0, 100) };
            txtHeight = new TextBox { Location = new Point(100, 100), Width = 100 };

            chkFill = new CheckBox { Text = "Fill Rectangle", Location = new Point(0, 130) };

            btnColorPicker = new Button { Text = "Color...", Location = new Point(0, 160) };
            btnColorPicker.Click += btnColorPicker_Click;

            Button btnOK = new Button { Text = "OK", Location = new Point(30, 200), DialogResult = DialogResult.OK };
            btnOK.Click += btnOK_Click;

            Button btnCancel = new Button { Text = "Cancel", Location = new Point(120, 200), DialogResult = DialogResult.Cancel };

            colorDialog1 = new ColorDialog();

            Controls.Add(lblStartX);
            Controls.Add(txtStartX);
            Controls.Add(lblStartY);
            Controls.Add(txtStartY);
            Controls.Add(lblWidth);
            Controls.Add(txtWidth);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(chkFill);
            Controls.Add(btnColorPicker);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);

            Text = "Rectangle Properties";
            Size = new Size(250, 300);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                StartX = int.Parse(txtStartX.Text);
                StartY = int.Parse(txtStartY.Text);
                rectWidth = int.Parse(txtWidth.Text);
                rectHeight = int.Parse(txtHeight.Text);
                RectangleColor = colorDialog1.Color;
                Fill = chkFill.Checked;

                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for the dimensions and starting point.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColorPicker.BackColor = colorDialog1.Color;
            }
        }
    }


    public class IntensityForm : Form
    {
        public TrackBar IntensityTrackBar { get; private set; }
        public Label IntensityLabel { get; private set; }
        private Button okButton;
        private Button cancelButton;

        public IntensityForm(double initialIntensity)
        {
            IntensityTrackBar = new TrackBar
            {
                Minimum = 0,
                Maximum = 100,
                TickFrequency = 10,
                Value = (int)(initialIntensity * 100),
                Width = 200,
                Location = new Point(10, 10)
            };
            IntensityTrackBar.Scroll += IntensityTrackBar_Scroll;

            IntensityLabel = new Label
            {
                Text = $"{initialIntensity * 100}%",
                Location = new Point(IntensityTrackBar.Right + 10, IntensityTrackBar.Top)
            };

            okButton = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(10, IntensityTrackBar.Bottom + 20)
            };

            cancelButton = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(okButton.Right + 10, IntensityTrackBar.Bottom + 20)
            };

            this.Controls.Add(IntensityTrackBar);
            this.Controls.Add(IntensityLabel);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);
            this.Text = "Set Intensity";
            this.Width = 300;
            this.Height = 150;

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }

        private void IntensityTrackBar_Scroll(object sender, EventArgs e)
        {
            IntensityLabel.Text = $"{IntensityTrackBar.Value}%";
        }
    }

}
