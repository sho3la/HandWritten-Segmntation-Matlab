namespace Matlab_HandWritten
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
            this.Load = new System.Windows.Forms.Button();
            this.UniformThreshold = new System.Windows.Forms.Button();
            this.NonUniformThreshold = new System.Windows.Forms.Button();
            this.CountLine = new System.Windows.Forms.Button();
            this.CountChars = new System.Windows.Forms.Button();
            this.CountWords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(13, 13);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(259, 23);
            this.Load.TabIndex = 0;
            this.Load.Text = "LoadImage";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // UniformThreshold
            // 
            this.UniformThreshold.Location = new System.Drawing.Point(13, 42);
            this.UniformThreshold.Name = "UniformThreshold";
            this.UniformThreshold.Size = new System.Drawing.Size(100, 23);
            this.UniformThreshold.TabIndex = 1;
            this.UniformThreshold.Text = "UniformThreshold";
            this.UniformThreshold.UseVisualStyleBackColor = true;
            this.UniformThreshold.Click += new System.EventHandler(this.UniformThreshold_Click);
            // 
            // NonUniformThreshold
            // 
            this.NonUniformThreshold.Location = new System.Drawing.Point(119, 42);
            this.NonUniformThreshold.Name = "NonUniformThreshold";
            this.NonUniformThreshold.Size = new System.Drawing.Size(153, 23);
            this.NonUniformThreshold.TabIndex = 2;
            this.NonUniformThreshold.Text = "NonUniform";
            this.NonUniformThreshold.UseVisualStyleBackColor = true;
            this.NonUniformThreshold.Click += new System.EventHandler(this.NonUniformThreshold_Click);
            // 
            // CountLine
            // 
            this.CountLine.Location = new System.Drawing.Point(13, 72);
            this.CountLine.Name = "CountLine";
            this.CountLine.Size = new System.Drawing.Size(259, 23);
            this.CountLine.TabIndex = 3;
            this.CountLine.Text = "CountLine";
            this.CountLine.UseVisualStyleBackColor = true;
            this.CountLine.Click += new System.EventHandler(this.CountLine_Click);
            // 
            // CountChars
            // 
            this.CountChars.Location = new System.Drawing.Point(12, 101);
            this.CountChars.Name = "CountChars";
            this.CountChars.Size = new System.Drawing.Size(259, 23);
            this.CountChars.TabIndex = 4;
            this.CountChars.Text = "CountChars";
            this.CountChars.UseVisualStyleBackColor = true;
            this.CountChars.Click += new System.EventHandler(this.CountChars_Click);
            // 
            // CountWords
            // 
            this.CountWords.Location = new System.Drawing.Point(13, 130);
            this.CountWords.Name = "CountWords";
            this.CountWords.Size = new System.Drawing.Size(259, 23);
            this.CountWords.TabIndex = 5;
            this.CountWords.Text = "CountWords";
            this.CountWords.UseVisualStyleBackColor = true;
            this.CountWords.Click += new System.EventHandler(this.CountWords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lines :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Words :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chars :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountWords);
            this.Controls.Add(this.CountChars);
            this.Controls.Add(this.CountLine);
            this.Controls.Add(this.NonUniformThreshold);
            this.Controls.Add(this.UniformThreshold);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button UniformThreshold;
        private System.Windows.Forms.Button NonUniformThreshold;
        private System.Windows.Forms.Button CountLine;
        private System.Windows.Forms.Button CountChars;
        private System.Windows.Forms.Button CountWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

