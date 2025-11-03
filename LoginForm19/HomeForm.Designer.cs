namespace LoginForm019
{
    partial class HomeForm
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
            this.btnProgram1 = new System.Windows.Forms.Button();
            this.btnProgram2 = new System.Windows.Forms.Button();
            this.btnProgram3 = new System.Windows.Forms.Button();
            this.btnProgram4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgram1
            // 
            this.btnProgram1.Location = new System.Drawing.Point(210, 107);
            this.btnProgram1.Name = "btnProgram1";
            this.btnProgram1.Size = new System.Drawing.Size(115, 42);
            this.btnProgram1.TabIndex = 0;
            this.btnProgram1.Text = "Program1";
            this.btnProgram1.UseVisualStyleBackColor = true;
            // 
            // btnProgram2
            // 
            this.btnProgram2.Location = new System.Drawing.Point(444, 107);
            this.btnProgram2.Name = "btnProgram2";
            this.btnProgram2.Size = new System.Drawing.Size(99, 42);
            this.btnProgram2.TabIndex = 1;
            this.btnProgram2.Text = "Program2";
            this.btnProgram2.UseVisualStyleBackColor = true;
            // 
            // btnProgram3
            // 
            this.btnProgram3.Location = new System.Drawing.Point(210, 208);
            this.btnProgram3.Name = "btnProgram3";
            this.btnProgram3.Size = new System.Drawing.Size(115, 43);
            this.btnProgram3.TabIndex = 2;
            this.btnProgram3.Text = "Program3";
            this.btnProgram3.UseVisualStyleBackColor = true;
            // 
            // btnProgram4
            // 
            this.btnProgram4.Location = new System.Drawing.Point(444, 208);
            this.btnProgram4.Name = "btnProgram4";
            this.btnProgram4.Size = new System.Drawing.Size(99, 43);
            this.btnProgram4.TabIndex = 3;
            this.btnProgram4.Text = "Program4";
            this.btnProgram4.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProgram4);
            this.Controls.Add(this.btnProgram3);
            this.Controls.Add(this.btnProgram2);
            this.Controls.Add(this.btnProgram1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgram1;
        private System.Windows.Forms.Button btnProgram2;
        private System.Windows.Forms.Button btnProgram3;
        private System.Windows.Forms.Button btnProgram4;
    }
}