namespace Am_I_Positive
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.integerInputLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.positiveNegativeOutput = new System.Windows.Forms.Label();
            this.divisableBy7Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerInputLabel
            // 
            this.integerInputLabel.Location = new System.Drawing.Point(45, 68);
            this.integerInputLabel.Name = "integerInputLabel";
            this.integerInputLabel.Size = new System.Drawing.Size(121, 23);
            this.integerInputLabel.TabIndex = 0;
            this.integerInputLabel.Text = "Input an integer";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(233, 68);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(83, 26);
            this.numberInput.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(233, 124);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 49);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // positiveNegativeOutput
            // 
            this.positiveNegativeOutput.Location = new System.Drawing.Point(45, 255);
            this.positiveNegativeOutput.Name = "positiveNegativeOutput";
            this.positiveNegativeOutput.Size = new System.Drawing.Size(242, 51);
            this.positiveNegativeOutput.TabIndex = 3;
            // 
            // divisableBy7Output
            // 
            this.divisableBy7Output.Location = new System.Drawing.Point(45, 335);
            this.divisableBy7Output.Name = "divisableBy7Output";
            this.divisableBy7Output.Size = new System.Drawing.Size(242, 51);
            this.divisableBy7Output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.divisableBy7Output);
            this.Controls.Add(this.positiveNegativeOutput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.integerInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerInputLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label positiveNegativeOutput;
        private System.Windows.Forms.Label divisableBy7Output;
    }
}

