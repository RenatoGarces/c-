namespace PicoPlaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msktxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.msktxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.msktxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msktxtPlaca
            // 
            this.msktxtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtPlaca.Location = new System.Drawing.Point(255, 44);
            this.msktxtPlaca.Mask = "???-0000";
            this.msktxtPlaca.Name = "msktxtPlaca";
            this.msktxtPlaca.Size = new System.Drawing.Size(143, 34);
            this.msktxtPlaca.TabIndex = 1;
            this.msktxtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.msktxtPlaca, "The Placa Should be 3 letters and 4 numbers");
            this.msktxtPlaca.TextChanged += new System.EventHandler(this.msktxtPlaca_TextChanged);
            // 
            // msktxtFecha
            // 
            this.msktxtFecha.Enabled = false;
            this.msktxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtFecha.Location = new System.Drawing.Point(255, 88);
            this.msktxtFecha.Mask = "00/00/0000";
            this.msktxtFecha.Name = "msktxtFecha";
            this.msktxtFecha.Size = new System.Drawing.Size(143, 34);
            this.msktxtFecha.TabIndex = 2;
            this.toolTip1.SetToolTip(this.msktxtFecha, "The date SHould be \"DD/MM/YYYY\"");
            this.msktxtFecha.ValidatingType = typeof(System.DateTime);
            this.msktxtFecha.TextChanged += new System.EventHandler(this.msktxtFecha_TextChanged);
            // 
            // msktxtHora
            // 
            this.msktxtHora.Enabled = false;
            this.msktxtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtHora.Location = new System.Drawing.Point(255, 144);
            this.msktxtHora.Mask = "00:00";
            this.msktxtHora.Name = "msktxtHora";
            this.msktxtHora.Size = new System.Drawing.Size(143, 34);
            this.msktxtHora.TabIndex = 3;
            this.toolTip1.SetToolTip(this.msktxtHora, "You shuold use 24 hours");
            this.msktxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date: dddd/MM/YY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hour:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "CHECK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblwrong);
            this.panel1.Controls.Add(this.lblcheck);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.msktxtHora);
            this.panel1.Controls.Add(this.msktxtFecha);
            this.panel1.Controls.Add(this.msktxtPlaca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 393);
            this.panel1.TabIndex = 5;
            // 
            // lblwrong
            // 
            this.lblwrong.Image = ((System.Drawing.Image)(resources.GetObject("lblwrong.Image")));
            this.lblwrong.Location = new System.Drawing.Point(423, 202);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(214, 169);
            this.lblwrong.TabIndex = 8;
            this.lblwrong.Visible = false;
            // 
            // lblcheck
            // 
            this.lblcheck.Image = ((System.Drawing.Image)(resources.GetObject("lblcheck.Image")));
            this.lblcheck.Location = new System.Drawing.Point(423, 202);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(214, 164);
            this.lblcheck.TabIndex = 6;
            this.lblcheck.Visible = false;
            this.lblcheck.Click += new System.EventHandler(this.lblcheck_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(418, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(219, 134);
            this.lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 536);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pico y Placa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxtPlaca;
        private System.Windows.Forms.MaskedTextBox msktxtFecha;
        private System.Windows.Forms.MaskedTextBox msktxtHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Label lblwrong;
    }
}

