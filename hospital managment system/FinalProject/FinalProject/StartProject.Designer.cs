namespace FinalProject
{
    partial class StartProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.labelLoad = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 101);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2CircleProgressBar1);
            this.panel2.Controls.Add(this.t);
            this.panel2.Controls.Add(this.labelLoad);
            this.panel2.Controls.Add(this.labelMark);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 470);
            this.panel2.TabIndex = 2;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.Controls.Add(this.label2);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2CircleProgressBar1.ImageSize = new System.Drawing.Size(30, 40);
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(277, 6);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.guna2CircleProgressBar1.ProgressThickness = 21;
            this.guna2CircleProgressBar1.ShadowDecoration.Depth = 20;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(335, 307);
            this.guna2CircleProgressBar1.TabIndex = 7;
            this.guna2CircleProgressBar1.UseTransparentBackground = true;
            this.guna2CircleProgressBar1.Value = 30;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t
            // 
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(3, 426);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(904, 33);
            this.t.TabIndex = 6;
            this.t.Text = "------";
            this.t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoad.Location = new System.Drawing.Point(454, 370);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(127, 33);
            this.labelLoad.TabIndex = 5;
            this.labelLoad.Text = "..............";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark.Location = new System.Drawing.Point(343, 370);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(118, 33);
            this.labelMark.TabIndex = 4;
            this.labelMark.Text = "Loading";
            this.labelMark.Click += new System.EventHandler(this.labelMark_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(919, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartProject";
            this.Load += new System.EventHandler(this.StartProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelMark;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}