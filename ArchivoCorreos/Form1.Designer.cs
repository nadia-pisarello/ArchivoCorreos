namespace ArchivoCorreos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoriasBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.trabajoTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Location = new System.Drawing.Point(3, 3);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFile.Size = new System.Drawing.Size(412, 586);
            this.txtFile.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.txt";
            // 
            // categoriasBox
            // 
            this.categoriasBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasBox.Location = new System.Drawing.Point(421, 3);
            this.categoriasBox.Multiline = true;
            this.categoriasBox.Name = "categoriasBox";
            this.categoriasBox.ReadOnly = true;
            this.categoriasBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categoriasBox.Size = new System.Drawing.Size(412, 586);
            this.categoriasBox.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.toolStripDropDownButton1,
            this.btnExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 38);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(88, 33);
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajoTSMItem,
            this.familiaTSMItem,
            this.promoTSMItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(164, 33);
            this.toolStripDropDownButton1.Text = "Choose category";
            // 
            // trabajoTSMItem
            // 
            this.trabajoTSMItem.Name = "trabajoTSMItem";
            this.trabajoTSMItem.Size = new System.Drawing.Size(270, 34);
            this.trabajoTSMItem.Text = "Job";
            this.trabajoTSMItem.Click += new System.EventHandler(this.trabajoTSMItem_Click);
            // 
            // familiaTSMItem
            // 
            this.familiaTSMItem.Name = "familiaTSMItem";
            this.familiaTSMItem.Size = new System.Drawing.Size(270, 34);
            this.familiaTSMItem.Text = "Family";
            this.familiaTSMItem.Click += new System.EventHandler(this.familiaTSMItem_Click);
            // 
            // promoTSMItem
            // 
            this.promoTSMItem.Name = "promoTSMItem";
            this.promoTSMItem.Size = new System.Drawing.Size(270, 34);
            this.promoTSMItem.Text = "Promotions";
            this.promoTSMItem.Click += new System.EventHandler(this.promoTSMItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoriasBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 592);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnExportar
            // 
            this.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(141, 33);
            this.btnExportar.Text = "Export category";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emails categorizer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox categoriasBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem trabajoTSMItem;
        private System.Windows.Forms.ToolStripMenuItem familiaTSMItem;
        private System.Windows.Forms.ToolStripMenuItem promoTSMItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton btnExportar;
    }
}

