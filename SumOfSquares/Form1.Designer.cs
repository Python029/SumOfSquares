
namespace SumOfSquares
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
            this.lblSum1 = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblCube = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSum1
            // 
            this.lblSum1.AutoSize = true;
            this.lblSum1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum1.Location = new System.Drawing.Point(12, 19);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(287, 22);
            this.lblSum1.TabIndex = 0;
            this.lblSum1.Text = "1^2 + 2^2 + 3^2 + ... + 100^2 = ";
            // 
            // lblSum2
            // 
            this.lblSum2.AutoSize = true;
            this.lblSum2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum2.Location = new System.Drawing.Point(12, 41);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(237, 22);
            this.lblSum2.TabIndex = 1;
            this.lblSum2.Text = "(1 + 2 + 3 + ... + 100)^2 = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(2, 2);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(12, 63);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(133, 22);
            this.lblDiff.TabIndex = 3;
            this.lblDiff.Text = "Difference: ";
            // 
            // lblCube
            // 
            this.lblCube.AutoSize = true;
            this.lblCube.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCube.Location = new System.Drawing.Point(12, 85);
            this.lblCube.Name = "lblCube";
            this.lblCube.Size = new System.Drawing.Size(122, 22);
            this.lblCube.TabIndex = 4;
            this.lblCube.Text = "Cube Root: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 107);
            this.Controls.Add(this.lblCube);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSum2);
            this.Controls.Add(this.lblSum1);
            this.Name = "Form1";
            this.Text = "Sum of Squares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSum1;
        private System.Windows.Forms.Label lblSum2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblCube;
    }
}

