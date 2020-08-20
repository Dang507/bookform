namespace VuBookStorev5
{
    partial class FrmtAuthorSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã tác giả:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên tác giả:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(VuBookStorev5.Models.Author);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 203);
            this.dataGridView1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.nhậpThểLoạiToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sáchToolStripMenuItem.Text = "Nhập Sách";
            // 
            // nhậpTácGiảToolStripMenuItem
            // 
            this.nhậpTácGiảToolStripMenuItem.Name = "nhậpTácGiảToolStripMenuItem";
            this.nhậpTácGiảToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhậpTácGiảToolStripMenuItem.Text = "Nhập tác giả";
            // 
            // nhậpNhàXuấtBảnToolStripMenuItem
            // 
            this.nhậpNhàXuấtBảnToolStripMenuItem.Name = "nhậpNhàXuấtBảnToolStripMenuItem";
            this.nhậpNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhậpNhàXuấtBảnToolStripMenuItem.Text = "Nhập nhà xuất bản";
            // 
            // nhậpThểLoạiToolStripMenuItem
            // 
            this.nhậpThểLoạiToolStripMenuItem.Name = "nhậpThểLoạiToolStripMenuItem";
            this.nhậpThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhậpThểLoạiToolStripMenuItem.Text = "Nhập thể loại";
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
            // FrmtAuthorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 310);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmtAuthorSearch";
            this.Text = "Tìm kiếm theo tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoNhàXuấtBảnToolStripMenuItem;
    }
}