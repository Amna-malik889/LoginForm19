namespace LoginForm019
{
    partial class Program4Form
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
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(236, 122);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(76, 29);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Message";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(396, 126);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(57, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "(blank)";
            // 
            // Program4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Name = "Program4Form";
            this.Text = "Program4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
    }
}