namespace Paint
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PencilBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.FillBtn = new System.Windows.Forms.Button();
            this.Fill2Btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 372);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDialogToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // colorDialogToolStripMenuItem
            // 
            this.colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            this.colorDialogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorDialogToolStripMenuItem.Text = "ColorDialog";
            this.colorDialogToolStripMenuItem.Click += new System.EventHandler(this.colorDialogToolStripMenuItem_Click);
            // 
            // PencilBtn
            // 
            this.PencilBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PencilBtn.Location = new System.Drawing.Point(708, 28);
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(75, 23);
            this.PencilBtn.TabIndex = 3;
            this.PencilBtn.Text = "Pencil";
            this.PencilBtn.UseVisualStyleBackColor = false;
            this.PencilBtn.Click += new System.EventHandler(this.PencilBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.LineBtn.Location = new System.Drawing.Point(708, 78);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(75, 23);
            this.LineBtn.TabIndex = 4;
            this.LineBtn.Text = "Line";
            this.LineBtn.UseVisualStyleBackColor = false;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.RectangleBtn.Location = new System.Drawing.Point(708, 132);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(75, 23);
            this.RectangleBtn.TabIndex = 5;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = false;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.EllipseBtn.Location = new System.Drawing.Point(708, 181);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(75, 23);
            this.EllipseBtn.TabIndex = 6;
            this.EllipseBtn.Text = "Ellipse";
            this.EllipseBtn.UseVisualStyleBackColor = false;
            this.EllipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.BackColor = System.Drawing.Color.Red;
            this.FillBtn.Location = new System.Drawing.Point(708, 232);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(75, 23);
            this.FillBtn.TabIndex = 7;
            this.FillBtn.Text = "Fill";
            this.FillBtn.UseVisualStyleBackColor = false;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // Fill2Btn
            // 
            this.Fill2Btn.Location = new System.Drawing.Point(708, 274);
            this.Fill2Btn.Name = "Fill2Btn";
            this.Fill2Btn.Size = new System.Drawing.Size(75, 23);
            this.Fill2Btn.TabIndex = 8;
            this.Fill2Btn.Text = "Fiil2";
            this.Fill2Btn.UseVisualStyleBackColor = true;
            this.Fill2Btn.Click += new System.EventHandler(this.Fill2Btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fill2Btn);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.LineBtn);
            this.Controls.Add(this.PencilBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDialogToolStripMenuItem;
        private System.Windows.Forms.Button PencilBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button Fill2Btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

