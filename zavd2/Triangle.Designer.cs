namespace zavd2
{
    partial class Triangle
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
            this.firstside = new System.Windows.Forms.Label();
            this.thirdside = new System.Windows.Forms.Label();
            this.secondside = new System.Windows.Forms.Label();
            this.FS = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.TextBox();
            this.ts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstside
            // 
            this.firstside.AutoSize = true;
            this.firstside.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstside.Location = new System.Drawing.Point(167, 45);
            this.firstside.Name = "firstside";
            this.firstside.Size = new System.Drawing.Size(134, 25);
            this.firstside.TabIndex = 0;
            this.firstside.Text = "Enter first side";
            // 
            // thirdside
            // 
            this.thirdside.AutoSize = true;
            this.thirdside.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdside.Location = new System.Drawing.Point(167, 275);
            this.thirdside.Name = "thirdside";
            this.thirdside.Size = new System.Drawing.Size(141, 25);
            this.thirdside.TabIndex = 1;
            this.thirdside.Text = "Enter third side";
            // 
            // secondside
            // 
            this.secondside.AutoSize = true;
            this.secondside.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondside.Location = new System.Drawing.Point(167, 160);
            this.secondside.Name = "secondside";
            this.secondside.Size = new System.Drawing.Size(168, 25);
            this.secondside.TabIndex = 2;
            this.secondside.Text = "Enter second side";
            // 
            // FS
            // 
            this.FS.Location = new System.Drawing.Point(171, 92);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(462, 26);
            this.FS.TabIndex = 3;
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(171, 210);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(462, 26);
            this.ss.TabIndex = 4;
            // 
            // ts
            // 
            this.ts.Location = new System.Drawing.Point(171, 333);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(462, 26);
            this.ts.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(298, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Triangle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.FS);
            this.Controls.Add(this.secondside);
            this.Controls.Add(this.thirdside);
            this.Controls.Add(this.firstside);
            this.Name = "Triangle2";
            this.Text = "Triangle2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstside;
        private System.Windows.Forms.Label thirdside;
        private System.Windows.Forms.Label secondside;
        private System.Windows.Forms.TextBox FS;
        private System.Windows.Forms.TextBox ss;
        private System.Windows.Forms.TextBox ts;
        private System.Windows.Forms.Button button1;
    }
}