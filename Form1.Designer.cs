namespace TH_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(703, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnFill);
            this.panel4.Controls.Add(this.btnColorPicker);
            this.panel4.Controls.Add(this.btnPen);
            this.panel4.Controls.Add(this.btnEllipse);
            this.panel4.Controls.Add(this.btnErase);
            this.panel4.Controls.Add(this.btnRect);
            this.panel4.Location = new System.Drawing.Point(3, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 84);
            this.panel4.TabIndex = 5;
            // 
            // btnFill
            // 
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(113, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(94, 75);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill";
            this.btnFill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnColorPicker.Image")));
            this.btnColorPicker.Location = new System.Drawing.Point(513, 3);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(100, 75);
            this.btnColorPicker.TabIndex = 5;
            this.btnColorPicker.Text = "Color picker";
            this.btnColorPicker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnPen
            // 
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.Location = new System.Drawing.Point(13, 3);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(94, 75);
            this.btnPen.TabIndex = 1;
            this.btnPen.Text = "Pen";
            this.btnPen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(413, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(94, 75);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnErase
            // 
            this.btnErase.Image = ((System.Drawing.Image)(resources.GetObject("btnErase.Image")));
            this.btnErase.Location = new System.Drawing.Point(213, 3);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(94, 75);
            this.btnErase.TabIndex = 2;
            this.btnErase.Text = "Erase";
            this.btnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnRect
            // 
            this.btnRect.Image = ((System.Drawing.Image)(resources.GetObject("btnRect.Image")));
            this.btnRect.Location = new System.Drawing.Point(313, 3);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(94, 75);
            this.btnRect.TabIndex = 3;
            this.btnRect.Text = "Rect";
            this.btnRect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 29);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 438);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(113, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fill";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(642, 13);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(34, 34);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(703, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSave;
    }
}

