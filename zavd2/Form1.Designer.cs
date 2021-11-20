namespace zavd2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttontriangle = new System.Windows.Forms.RadioButton();
            this.buttondiamond = new System.Windows.Forms.RadioButton();
            this.buttonsquare = new System.Windows.Forms.RadioButton();
            this.buttonrectangle = new System.Windows.Forms.RadioButton();
            this.buttoncircle = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a figure";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttontriangle
            // 
            this.buttontriangle.AutoSize = true;
            this.buttontriangle.Location = new System.Drawing.Point(122, 81);
            this.buttontriangle.Name = "buttontriangle";
            this.buttontriangle.Size = new System.Drawing.Size(90, 24);
            this.buttontriangle.TabIndex = 1;
            this.buttontriangle.TabStop = true;
            this.buttontriangle.Text = "Triangle";
            this.buttontriangle.UseVisualStyleBackColor = true;
            // 
            // buttondiamond
            // 
            this.buttondiamond.AutoSize = true;
            this.buttondiamond.Location = new System.Drawing.Point(122, 246);
            this.buttondiamond.Name = "buttondiamond";
            this.buttondiamond.Size = new System.Drawing.Size(98, 24);
            this.buttondiamond.TabIndex = 2;
            this.buttondiamond.TabStop = true;
            this.buttondiamond.Text = "Diamond";
            this.buttondiamond.UseVisualStyleBackColor = true;
            // 
            // buttonsquare
            // 
            this.buttonsquare.AutoSize = true;
            this.buttonsquare.Location = new System.Drawing.Point(122, 203);
            this.buttonsquare.Name = "buttonsquare";
            this.buttonsquare.Size = new System.Drawing.Size(86, 24);
            this.buttonsquare.TabIndex = 3;
            this.buttonsquare.TabStop = true;
            this.buttonsquare.Text = "Square";
            this.buttonsquare.UseVisualStyleBackColor = true;
            // 
            // buttonrectangle
            // 
            this.buttonrectangle.AutoSize = true;
            this.buttonrectangle.Location = new System.Drawing.Point(122, 160);
            this.buttonrectangle.Name = "buttonrectangle";
            this.buttonrectangle.Size = new System.Drawing.Size(107, 24);
            this.buttonrectangle.TabIndex = 4;
            this.buttonrectangle.TabStop = true;
            this.buttonrectangle.Text = "Rectangle";
            this.buttonrectangle.UseVisualStyleBackColor = true;
            // 
            // buttoncircle
            // 
            this.buttoncircle.AutoSize = true;
            this.buttoncircle.Location = new System.Drawing.Point(122, 121);
            this.buttoncircle.Name = "buttoncircle";
            this.buttoncircle.Size = new System.Drawing.Size(73, 24);
            this.buttoncircle.TabIndex = 5;
            this.buttoncircle.TabStop = true;
            this.buttoncircle.Text = "Circle";
            this.buttoncircle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(154, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(417, 374);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 49);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttoncircle);
            this.Controls.Add(this.buttonrectangle);
            this.Controls.Add(this.buttonsquare);
            this.Controls.Add(this.buttondiamond);
            this.Controls.Add(this.buttontriangle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton buttontriangle;
        private System.Windows.Forms.RadioButton buttondiamond;
        private System.Windows.Forms.RadioButton buttonsquare;
        private System.Windows.Forms.RadioButton buttonrectangle;
        private System.Windows.Forms.RadioButton buttoncircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}

