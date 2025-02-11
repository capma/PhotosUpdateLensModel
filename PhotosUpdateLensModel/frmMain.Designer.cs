namespace PhotosUpdateLensModel
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panTop = new Panel();
            btnBrowsePhotos = new Button();
            txtPhotos = new TextBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnStart = new Button();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panTop.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 210);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panTop, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.8095245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.1904755F));
            tableLayoutPanel1.Size = new Size(800, 207);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panTop
            // 
            panTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panTop.Controls.Add(btnBrowsePhotos);
            panTop.Controls.Add(txtPhotos);
            panTop.Controls.Add(label2);
            panTop.Location = new Point(3, 3);
            panTop.Name = "panTop";
            panTop.Size = new Size(794, 105);
            panTop.TabIndex = 0;
            // 
            // btnBrowsePhotos
            // 
            btnBrowsePhotos.Location = new Point(715, 34);
            btnBrowsePhotos.Name = "btnBrowsePhotos";
            btnBrowsePhotos.Size = new Size(75, 23);
            btnBrowsePhotos.TabIndex = 5;
            btnBrowsePhotos.Text = "Browse";
            btnBrowsePhotos.UseVisualStyleBackColor = true;
            btnBrowsePhotos.Click += btnBrowsePhotos_Click;
            // 
            // txtPhotos
            // 
            txtPhotos.Location = new Point(66, 35);
            txtPhotos.Name = "txtPhotos";
            txtPhotos.Size = new Size(643, 23);
            txtPhotos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Photos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnStart, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 114);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 90);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(400, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(390, 55);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 232);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Update Lens Model";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panTop.ResumeLayout(false);
            panTop.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panTop;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPhotos;
        private Label label2;
        private Button btnStart;
        private Button btnBrowsePhotos;
    }
}
