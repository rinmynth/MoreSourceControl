namespace MoreSourceControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtNumber1 = new TextBox();
            TxtNumber2 = new TextBox();
            TxtResult = new TextBox();
            label3 = new Label();
            BtnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 126);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 177);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Number 2: ";
            // 
            // TxtNumber1
            // 
            TxtNumber1.Location = new Point(357, 128);
            TxtNumber1.Name = "TxtNumber1";
            TxtNumber1.Size = new Size(100, 23);
            TxtNumber1.TabIndex = 2;
            // 
            // TxtNumber2
            // 
            TxtNumber2.Location = new Point(357, 186);
            TxtNumber2.Name = "TxtNumber2";
            TxtNumber2.Size = new Size(100, 23);
            TxtNumber2.TabIndex = 3;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(357, 251);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(100, 23);
            TxtResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 259);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(302, 324);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(119, 63);
            BtnCalculate.TabIndex = 6;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCalculate);
            Controls.Add(label3);
            Controls.Add(TxtResult);
            Controls.Add(TxtNumber2);
            Controls.Add(TxtNumber1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtNumber1;
        private TextBox TxtNumber2;
        private TextBox TxtResult;
        private Label label3;
        private Button BtnCalculate;
    }
}
