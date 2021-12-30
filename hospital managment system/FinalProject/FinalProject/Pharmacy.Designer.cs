namespace FinalProject
{
    partial class Pharmacy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmountaddnewproduct = new System.Windows.Forms.TextBox();
            this.txtaddnewproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddanexistsproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboaddanexistsproduct = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgetmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combogetproduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnaddnewproduct = new System.Windows.Forms.Button();
            this.btnaddanexistsproduct = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 329);
            this.dataGridView1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 350);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "medical products";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 350);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 393);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtmountaddnewproduct);
            this.tabPage1.Controls.Add(this.btnaddnewproduct);
            this.tabPage1.Controls.Add(this.txtaddnewproduct);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "add new product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mount";
            // 
            // txtmountaddnewproduct
            // 
            this.txtmountaddnewproduct.Location = new System.Drawing.Point(164, 96);
            this.txtmountaddnewproduct.Multiline = true;
            this.txtmountaddnewproduct.Name = "txtmountaddnewproduct";
            this.txtmountaddnewproduct.Size = new System.Drawing.Size(233, 30);
            this.txtmountaddnewproduct.TabIndex = 3;
            this.txtmountaddnewproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmountaddnewproduct_KeyPress);
            // 
            // txtaddnewproduct
            // 
            this.txtaddnewproduct.Location = new System.Drawing.Point(164, 40);
            this.txtaddnewproduct.Multiline = true;
            this.txtaddnewproduct.Name = "txtaddnewproduct";
            this.txtaddnewproduct.Size = new System.Drawing.Size(233, 30);
            this.txtaddnewproduct.TabIndex = 1;
            this.txtaddnewproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddnewproduct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtaddanexistsproduct);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboaddanexistsproduct);
            this.tabPage2.Controls.Add(this.btnaddanexistsproduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "add an exists product";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mount";
            // 
            // txtaddanexistsproduct
            // 
            this.txtaddanexistsproduct.Location = new System.Drawing.Point(204, 101);
            this.txtaddanexistsproduct.Multiline = true;
            this.txtaddanexistsproduct.Name = "txtaddanexistsproduct";
            this.txtaddanexistsproduct.Size = new System.Drawing.Size(262, 30);
            this.txtaddanexistsproduct.TabIndex = 2;
            this.txtaddanexistsproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddanexistsproduct_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Product Name";
            // 
            // comboaddanexistsproduct
            // 
            this.comboaddanexistsproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboaddanexistsproduct.FormattingEnabled = true;
            this.comboaddanexistsproduct.Location = new System.Drawing.Point(204, 42);
            this.comboaddanexistsproduct.Name = "comboaddanexistsproduct";
            this.comboaddanexistsproduct.Size = new System.Drawing.Size(262, 24);
            this.comboaddanexistsproduct.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnget);
            this.tabPage3.Controls.Add(this.txtgetmount);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.combogetproduct);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1156, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "get product";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mount";
            // 
            // txtgetmount
            // 
            this.txtgetmount.Location = new System.Drawing.Point(230, 97);
            this.txtgetmount.Multiline = true;
            this.txtgetmount.Name = "txtgetmount";
            this.txtgetmount.Size = new System.Drawing.Size(262, 30);
            this.txtgetmount.TabIndex = 7;
            this.txtgetmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgetmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select Product Name";
            // 
            // combogetproduct
            // 
            this.combogetproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogetproduct.FormattingEnabled = true;
            this.combogetproduct.Location = new System.Drawing.Point(230, 48);
            this.combogetproduct.Name = "combogetproduct";
            this.combogetproduct.Size = new System.Drawing.Size(262, 24);
            this.combogetproduct.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 675);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 68);
            this.panel1.TabIndex = 32;
            // 
            // btnback
            // 
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = global::FinalProject.Properties.Resources.login___Copy;
            this.btnback.Location = new System.Drawing.Point(533, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(85, 62);
            this.btnback.TabIndex = 27;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::FinalProject.Properties.Resources.ex;
            this.btnExit.Location = new System.Drawing.Point(1089, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 62);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnaddnewproduct
            // 
            this.btnaddnewproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnewproduct.Image = global::FinalProject.Properties.Resources.FontAwesome_f055_3__48;
            this.btnaddnewproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddnewproduct.Location = new System.Drawing.Point(184, 149);
            this.btnaddnewproduct.Name = "btnaddnewproduct";
            this.btnaddnewproduct.Size = new System.Drawing.Size(175, 53);
            this.btnaddnewproduct.TabIndex = 2;
            this.btnaddnewproduct.Text = "Add";
            this.btnaddnewproduct.UseVisualStyleBackColor = true;
            this.btnaddnewproduct.Click += new System.EventHandler(this.btnaddnewproduct_Click);
            // 
            // btnaddanexistsproduct
            // 
            this.btnaddanexistsproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddanexistsproduct.Image = global::FinalProject.Properties.Resources.FontAwesome_f055_3__48;
            this.btnaddanexistsproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddanexistsproduct.Location = new System.Drawing.Point(234, 160);
            this.btnaddanexistsproduct.Name = "btnaddanexistsproduct";
            this.btnaddanexistsproduct.Size = new System.Drawing.Size(182, 59);
            this.btnaddanexistsproduct.TabIndex = 3;
            this.btnaddanexistsproduct.Text = "Add";
            this.btnaddanexistsproduct.UseVisualStyleBackColor = true;
            this.btnaddanexistsproduct.Click += new System.EventHandler(this.btnaddanexistsproduct_Click);
            // 
            // btnget
            // 
            this.btnget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnget.Image = global::FinalProject.Properties.Resources.ok;
            this.btnget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnget.Location = new System.Drawing.Point(260, 153);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(187, 61);
            this.btnget.TabIndex = 8;
            this.btnget.Text = "Get";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pharmacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmountaddnewproduct;
        private System.Windows.Forms.Button btnaddnewproduct;
        private System.Windows.Forms.TextBox txtaddnewproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaddanexistsproduct;
        private System.Windows.Forms.TextBox txtaddanexistsproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboaddanexistsproduct;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.TextBox txtgetmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combogetproduct;
        private System.Windows.Forms.Panel panel1;
    }
}