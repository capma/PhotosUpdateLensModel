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
            panel1 = new Panel();
            panel2 = new Panel();
            chkIncludeSubFolders = new CheckBox();
            chkOverrideLensModel = new CheckBox();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panTop.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 206);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(815, 22);
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
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panTop, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.22681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7731953F));
            tableLayoutPanel1.Size = new Size(815, 206);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panTop
            // 
            panTop.Controls.Add(panel2);
            panTop.Controls.Add(panel1);
            panTop.Dock = DockStyle.Fill;
            panTop.Location = new Point(4, 4);
            panTop.Name = "panTop";
            panTop.Size = new Size(807, 144);
            panTop.TabIndex = 0;
            // 
            // btnBrowsePhotos
            // 
            btnBrowsePhotos.Location = new Point(723, 13);
            btnBrowsePhotos.Name = "btnBrowsePhotos";
            btnBrowsePhotos.Size = new Size(75, 23);
            btnBrowsePhotos.TabIndex = 5;
            btnBrowsePhotos.Text = "Browse";
            btnBrowsePhotos.UseVisualStyleBackColor = true;
            btnBrowsePhotos.Click += btnBrowsePhotos_Click;
            // 
            // txtPhotos
            // 
            txtPhotos.Location = new Point(74, 14);
            txtPhotos.Name = "txtPhotos";
            txtPhotos.Size = new Size(643, 23);
            txtPhotos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Photos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnStart, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 155);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(807, 47);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(406, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(398, 41);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPhotos);
            panel1.Controls.Add(btnBrowsePhotos);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 52);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkOverrideLensModel);
            panel2.Controls.Add(chkIncludeSubFolders);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 90);
            panel2.TabIndex = 7;
            // 
            // chkIncludeSubFolders
            // 
            chkIncludeSubFolders.AutoSize = true;
            chkIncludeSubFolders.Location = new Point(17, 15);
            chkIncludeSubFolders.Name = "chkIncludeSubFolders";
            chkIncludeSubFolders.Size = new Size(129, 19);
            chkIncludeSubFolders.TabIndex = 0;
            chkIncludeSubFolders.Text = "Include Sub Folders";
            chkIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // chkOverrideLensModel
            // 
            chkOverrideLensModel.AutoSize = true;
            chkOverrideLensModel.Location = new Point(18, 43);
            chkOverrideLensModel.Name = "chkOverrideLensModel";
            chkOverrideLensModel.Size = new Size(135, 19);
            chkOverrideLensModel.TabIndex = 1;
            chkOverrideLensModel.Text = "Override Lens Model";
            chkOverrideLensModel.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 228);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Update Lens Model";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panTop.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Panel panel1;
        private CheckBox chkOverrideLensModel;
        private CheckBox chkIncludeSubFolders;
    }
}
