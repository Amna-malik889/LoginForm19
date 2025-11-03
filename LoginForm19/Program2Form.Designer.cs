namespace LoginForm019
{
    partial class Program2Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Celcius:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(408, 95);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 26);
            this.txtCelsius.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(229, 209);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(77, 39);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(422, 212);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "(blank)";
            // 
            // Program2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label1);
            this.Name = "Program2Form";
            this.Text = "Program2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
    }
}