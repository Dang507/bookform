namespace VuBookStorev5.Nhap
{
    partial class FrmBookTitle
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng ";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpTácGiảToolStripMenuItem,
            this.nhậpNhàXuấtBảnToolStripMenuItem,
            this.nhậpThểLoạiToolStripMenuItem,
            this.nhậpSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sáchToolStripMenuItem.Text = "Nhập Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // nhậpTácGiảToolStripMenuItem
            // 
            this.nhậpTácGiảToolStripMenuItem.Name = "nhậpTácGiảToolStripMenuItem";
            this.nhậpTácGiảToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nhậpTácGiảToolStripMenuItem.Text = "Nhập tác giả";
            // 
            // nhậpNhàXuấtBảnToolStripMenuItem
            // 
            this.nhậpNhàXuấtBảnToolStripMenuItem.Name = "nhậpNhàXuấtBảnToolStripMenuItem";
            this.nhậpNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nhậpNhàXuấtBảnToolStripMenuItem.Text = "Nhập nhà xuất bản";
            // 
            // nhậpThểLoạiToolStripMenuItem
            // 
            this.nhậpThểLoạiToolStripMenuItem.Name = "nhậpThểLoạiToolStripMenuItem";
            this.nhậpThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nhậpThểLoạiToolStripMenuItem.Text = "Nhập thể loại";
            this.nhậpThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.nhậpThểLoạiToolStripMenuItem_Click);
            // 
            // nhậpSáchToolStripMenuItem
            // 
            this.nhậpSáchToolStripMenuItem.Name = "nhậpSáchToolStripMenuItem";
            this.nhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nhậpSáchToolStripMenuItem.Text = "Nhập sách";
            this.nhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.nhậpSáchToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmTheoTácGiảToolStripMenuItem,
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // tìmKiếmTheoTácGiảToolStripMenuItem
            // 
            this.tìmKiếmTheoTácGiảToolStripMenuItem.Name = "tìmKiếmTheoTácGiảToolStripMenuItem";
            this.tìmKiếmTheoTácGiảToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.tìmKiếmTheoTácGiảToolStripMenuItem.Text = "Tìm kiếm theo tác giả";
            // 
            // tìmKiếmTheoNhàXuấtBảnToolStripMenuItem
            // 
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem.Name = "tìmKiếmTheoNhàXuấtBảnToolStripMenuItem";
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem.Text = "Tìm kiếm theo nhà xuất bản";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 49;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 48;
            this.button2.Text = "Hiển thị thể loại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 47;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mã thể loại:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tên thể loại:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(91, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bTIDDataGridViewTextBoxColumn,
            this.bTNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookTitleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(283, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 318);
            this.dataGridView1.TabIndex = 50;
            // 
            // bookTitleBindingSource
            // 
            this.bookTitleBindingSource.DataSource = typeof(VuBookStorev5.Models.BookTitle);
            // 
            // bTIDDataGridViewTextBoxColumn
            // 
            this.bTIDDataGridViewTextBoxColumn.DataPropertyName = "BT_ID";
            this.bTIDDataGridViewTextBoxColumn.HeaderText = "Mã thể loại";
            this.bTIDDataGridViewTextBoxColumn.Name = "bTIDDataGridViewTextBoxColumn";
            // 
            // bTNameDataGridViewTextBoxColumn
            // 
            this.bTNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bTNameDataGridViewTextBoxColumn.DataPropertyName = "BT_Name";
            this.bTNameDataGridViewTextBoxColumn.HeaderText = "Tên thể loại";
            this.bTNameDataGridViewTextBoxColumn.Name = "bTNameDataGridViewTextBoxColumn";
            // 
            // FrmBookTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmBookTitle";
            this.Text = "Nhập thể loại";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem nhậpSáchToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookTitleBindingSource;
    }
}