namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            weightedGrayscaleToolStripMenuItem = new ToolStripMenuItem();
            oneChannelToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            optimizedFilterToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem1 = new ToolStripMenuItem();
            weightedGrayscaleToolStripMenuItem1 = new ToolStripMenuItem();
            channelToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem1 = new ToolStripMenuItem();
            greenToolStripMenuItem1 = new ToolStripMenuItem();
            blueToolStripMenuItem1 = new ToolStripMenuItem();
            mergeWithColorToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            flipToolStripMenuItem = new ToolStripMenuItem();
            yAxisToolStripMenuItem = new ToolStripMenuItem();
            xAxisToolStripMenuItem = new ToolStripMenuItem();
            rotateToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            cropToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            drawToolStripMenuItem1 = new ToolStripMenuItem();
            shapeToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem2 = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem1 = new ToolStripMenuItem();
            colorDropperToolStripMenuItem = new ToolStripMenuItem();
            chooseColorToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(209, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += openToolStripMenuItem_Click_1;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(673, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.DoubleClick += openToolStripMenuItem_Click_1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(103, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click_1;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(103, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click_1;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(103, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click_1;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayscaleToolStripMenuItem, weightedGrayscaleToolStripMenuItem, oneChannelToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 20);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(178, 22);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click_1;
            // 
            // weightedGrayscaleToolStripMenuItem
            // 
            weightedGrayscaleToolStripMenuItem.Name = "weightedGrayscaleToolStripMenuItem";
            weightedGrayscaleToolStripMenuItem.Size = new Size(178, 22);
            weightedGrayscaleToolStripMenuItem.Text = "Weighted Grayscale";
            weightedGrayscaleToolStripMenuItem.Click += weightedGrayscaleToolStripMenuItem_Click_1;
            // 
            // oneChannelToolStripMenuItem
            // 
            oneChannelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem });
            oneChannelToolStripMenuItem.Name = "oneChannelToolStripMenuItem";
            oneChannelToolStripMenuItem.Size = new Size(178, 22);
            oneChannelToolStripMenuItem.Text = "One Channel";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(105, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(105, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(105, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // optimizedFilterToolStripMenuItem
            // 
            optimizedFilterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayscaleToolStripMenuItem1, weightedGrayscaleToolStripMenuItem1, channelToolStripMenuItem, mergeWithColorToolStripMenuItem });
            optimizedFilterToolStripMenuItem.Name = "optimizedFilterToolStripMenuItem";
            optimizedFilterToolStripMenuItem.Size = new Size(103, 20);
            optimizedFilterToolStripMenuItem.Text = "Optimized Filter";
            // 
            // grayscaleToolStripMenuItem1
            // 
            grayscaleToolStripMenuItem1.Name = "grayscaleToolStripMenuItem1";
            grayscaleToolStripMenuItem1.Size = new Size(178, 22);
            grayscaleToolStripMenuItem1.Text = "Grayscale";
            grayscaleToolStripMenuItem1.Click += grayscaleToolStripMenuItem1_Click;
            // 
            // weightedGrayscaleToolStripMenuItem1
            // 
            weightedGrayscaleToolStripMenuItem1.Name = "weightedGrayscaleToolStripMenuItem1";
            weightedGrayscaleToolStripMenuItem1.Size = new Size(178, 22);
            weightedGrayscaleToolStripMenuItem1.Text = "Weighted Grayscale";
            weightedGrayscaleToolStripMenuItem1.Click += weightedGrayscaleToolStripMenuItem1_Click;
            // 
            // channelToolStripMenuItem
            // 
            channelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem1, greenToolStripMenuItem1, blueToolStripMenuItem1 });
            channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            channelToolStripMenuItem.Size = new Size(178, 22);
            channelToolStripMenuItem.Text = "Channel";
            channelToolStripMenuItem.Click += channelToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem1
            // 
            redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            redToolStripMenuItem1.Size = new Size(105, 22);
            redToolStripMenuItem1.Text = "Red";
            redToolStripMenuItem1.Click += redToolStripMenuItem1_Click;
            // 
            // greenToolStripMenuItem1
            // 
            greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            greenToolStripMenuItem1.Size = new Size(105, 22);
            greenToolStripMenuItem1.Text = "Green";
            greenToolStripMenuItem1.Click += greenToolStripMenuItem1_Click_1;
            // 
            // blueToolStripMenuItem1
            // 
            blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            blueToolStripMenuItem1.Size = new Size(105, 22);
            blueToolStripMenuItem1.Text = "Blue";
            blueToolStripMenuItem1.Click += blueToolStripMenuItem1_Click_1;
            // 
            // mergeWithColorToolStripMenuItem
            // 
            mergeWithColorToolStripMenuItem.Name = "mergeWithColorToolStripMenuItem";
            mergeWithColorToolStripMenuItem.Size = new Size(178, 22);
            mergeWithColorToolStripMenuItem.Text = "Merge With Color";
            mergeWithColorToolStripMenuItem.Click += mergeWithColorToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flipToolStripMenuItem, rotateToolStripMenuItem, rectangleToolStripMenuItem, cropToolStripMenuItem });
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(57, 20);
            modifyToolStripMenuItem.Text = "Modify";
            // 
            // flipToolStripMenuItem
            // 
            flipToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yAxisToolStripMenuItem, xAxisToolStripMenuItem });
            flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            flipToolStripMenuItem.Size = new Size(126, 22);
            flipToolStripMenuItem.Text = "Flip";
            // 
            // yAxisToolStripMenuItem
            // 
            yAxisToolStripMenuItem.Name = "yAxisToolStripMenuItem";
            yAxisToolStripMenuItem.Size = new Size(107, 22);
            yAxisToolStripMenuItem.Text = "Y-Axis";
            yAxisToolStripMenuItem.Click += yAxisToolStripMenuItem_Click;
            // 
            // xAxisToolStripMenuItem
            // 
            xAxisToolStripMenuItem.Name = "xAxisToolStripMenuItem";
            xAxisToolStripMenuItem.Size = new Size(107, 22);
            xAxisToolStripMenuItem.Text = "X-Axis";
            xAxisToolStripMenuItem.Click += xAxisToolStripMenuItem_Click_1;
            // 
            // rotateToolStripMenuItem
            // 
            rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            rotateToolStripMenuItem.Size = new Size(126, 22);
            rotateToolStripMenuItem.Text = "Rotate";
            rotateToolStripMenuItem.Click += rotateToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(126, 22);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // cropToolStripMenuItem
            // 
            cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            cropToolStripMenuItem.Size = new Size(126, 22);
            cropToolStripMenuItem.Text = "Crop";
            cropToolStripMenuItem.Click += cropToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, filterToolStripMenuItem, optimizedFilterToolStripMenuItem, modifyToolStripMenuItem, drawToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(976, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // drawToolStripMenuItem1
            // 
            drawToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { shapeToolStripMenuItem, colorDropperToolStripMenuItem, chooseColorToolStripMenuItem });
            drawToolStripMenuItem1.Name = "drawToolStripMenuItem1";
            drawToolStripMenuItem1.Size = new Size(46, 20);
            drawToolStripMenuItem1.Text = "Draw";
            // 
            // shapeToolStripMenuItem
            // 
            shapeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem2, ellipseToolStripMenuItem, triangleToolStripMenuItem1 });
            shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            shapeToolStripMenuItem.Size = new Size(155, 22);
            shapeToolStripMenuItem.Text = "Shape";
            // 
            // rectangleToolStripMenuItem2
            // 
            rectangleToolStripMenuItem2.Name = "rectangleToolStripMenuItem2";
            rectangleToolStripMenuItem2.Size = new Size(126, 22);
            rectangleToolStripMenuItem2.Text = "Rectangle";
            rectangleToolStripMenuItem2.Click += rectangleToolStripMenuItem2_Click;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(126, 22);
            ellipseToolStripMenuItem.Text = "Ellipse";
            ellipseToolStripMenuItem.Click += ellipseToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem1
            // 
            triangleToolStripMenuItem1.Name = "triangleToolStripMenuItem1";
            triangleToolStripMenuItem1.Size = new Size(126, 22);
            triangleToolStripMenuItem1.Text = "Triangle";
            triangleToolStripMenuItem1.Click += triangleToolStripMenuItem1_Click;
            // 
            // colorDropperToolStripMenuItem
            // 
            colorDropperToolStripMenuItem.Name = "colorDropperToolStripMenuItem";
            colorDropperToolStripMenuItem.Size = new Size(155, 22);
            colorDropperToolStripMenuItem.Text = "Color Dropper";
            colorDropperToolStripMenuItem.Click += colorDropperToolStripMenuItem_Click;
            colorDropperToolStripMenuItem.MouseDown += colorDropperToolStripMenuItem_MouseDown;
            // 
            // chooseColorToolStripMenuItem
            // 
            chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            chooseColorToolStripMenuItem.Size = new Size(155, 22);
            chooseColorToolStripMenuItem.Text = "Choose Color...";
            chooseColorToolStripMenuItem.Click += chooseColorToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(45, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(45, 109);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.DoubleClick += chooseColorToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 91);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Color";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(50, 390);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Fill Shape";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 662);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private ToolStripMenuItem weightedGrayscaleToolStripMenuItem;
        private ToolStripMenuItem oneChannelToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem optimizedFilterToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem1;
        private ToolStripMenuItem weightedGrayscaleToolStripMenuItem1;
        private ToolStripMenuItem channelToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem greenToolStripMenuItem1;
        private ToolStripMenuItem blueToolStripMenuItem1;
        private ToolStripMenuItem mergeWithColorToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem flipToolStripMenuItem;
        private ToolStripMenuItem yAxisToolStripMenuItem;
        private ToolStripMenuItem xAxisToolStripMenuItem;
        private ToolStripMenuItem rotateToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem drawToolStripMenuItem1;
        private ToolStripMenuItem colorDropperToolStripMenuItem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem2;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem1;
        private ToolStripMenuItem chooseColorToolStripMenuItem;
        private CheckBox checkBox1;
        private ToolStripMenuItem cropToolStripMenuItem;
    }
}