namespace StringVariable
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
            this.btnLetters = new System.Windows.Forms.Button();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.lblLetters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLetters
            // 
            this.btnLetters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetters.Location = new System.Drawing.Point(0, 120);
            this.btnLetters.Name = "btnLetters";
            this.btnLetters.Size = new System.Drawing.Size(361, 35);
            this.btnLetters.TabIndex = 0;
            this.btnLetters.Text = "OK";
            this.btnLetters.UseVisualStyleBackColor = true;
            this.btnLetters.Click += new System.EventHandler(this.btnLetters_Click);
            // 
            // txtLetters
            // 
            this.txtLetters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetters.Location = new System.Drawing.Point(0, 89);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(361, 31);
            this.txtLetters.TabIndex = 1;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.Location = new System.Drawing.Point(0, 0);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(113, 25);
            this.lblLetters.TabIndex = 2;
            this.lblLetters.Text = "ABCDEFG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 155);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.txtLetters);
            this.Controls.Add(this.btnLetters);
            this.Name = "Form1";
            this.Text = "Reorder Letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLetters;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.Label lblLetters;
    }
}

