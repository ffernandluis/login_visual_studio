namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.jMetroTextBox1 = new JMetroTextBox.JMetroTextBox();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.jMetroTextBox2 = new JMetroTextBox.JMetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jMetroTextBox1
            // 
            this.jMetroTextBox1.AllowDrop = true;
            this.jMetroTextBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.jMetroTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox1.BorderRadius = 15;
            this.jMetroTextBox1.CausesValidation = false;
            this.jMetroTextBox1.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox1.ForeColors = System.Drawing.Color.Gray;
            this.jMetroTextBox1.IsPassword = false;
            this.jMetroTextBox1.LineThickness = 2;
            this.jMetroTextBox1.Location = new System.Drawing.Point(68, 151);
            this.jMetroTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox1.MaxLength = 32767;
            this.jMetroTextBox1.MouseOnHover = System.Drawing.Color.DarkGray;
            this.jMetroTextBox1.Name = "jMetroTextBox1";
            this.jMetroTextBox1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox1.OnFocusColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox1.OnFocusFontColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox1.ReadOnly = false;
            this.jMetroTextBox1.Size = new System.Drawing.Size(220, 38);
            this.jMetroTextBox1.TabIndex = 1;
            this.jMetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMetroTextBox1.TextName = "";
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.jThinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.jThinButton1.BorderRadius = 17;
            this.jThinButton1.ButtonText = "Submit";
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.Color.White;
            this.jThinButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.jThinButton1.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.jThinButton1.HoverFontColor = System.Drawing.Color.White;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(108, 291);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(141, 37);
            this.jThinButton1.TabIndex = 3;
            // 
            // jMetroTextBox2
            // 
            this.jMetroTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox2.BorderRadius = 15;
            this.jMetroTextBox2.CausesValidation = false;
            this.jMetroTextBox2.FillColor = System.Drawing.Color.White;
            this.jMetroTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox2.ForeColors = System.Drawing.Color.Gray;
            this.jMetroTextBox2.IsPassword = true;
            this.jMetroTextBox2.LineThickness = 2;
            this.jMetroTextBox2.Location = new System.Drawing.Point(68, 220);
            this.jMetroTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMetroTextBox2.MaxLength = 32767;
            this.jMetroTextBox2.MouseOnHover = System.Drawing.Color.DarkGray;
            this.jMetroTextBox2.Name = "jMetroTextBox2";
            this.jMetroTextBox2.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox2.OnFocusColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox2.OnFocusFontColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox2.ReadOnly = false;
            this.jMetroTextBox2.Size = new System.Drawing.Size(220, 38);
            this.jMetroTextBox2.TabIndex = 2;
            this.jMetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMetroTextBox2.TextName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(78, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "USER NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(78, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(124, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "FORGET PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(324, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jMetroTextBox2);
            this.Controls.Add(this.jMetroTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jThinButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton jThinButton1;
        private JMetroTextBox.JMetroTextBox jMetroTextBox1;
        private JMetroTextBox.JMetroTextBox jMetroTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

