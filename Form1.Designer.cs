namespace Assignment_4
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
            inputTextBox = new TextBox();
            CalculateButton = new Button();
            panel1 = new Panel();
            resultLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a nonnegative integer:";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 46);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(391, 27);
            inputTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(164, 171);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 47);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(resultLabel);
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 86);
            panel1.TabIndex = 3;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(3, 10);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(45, 20);
            resultLabel.TabIndex = 0;
            resultLabel.Text = "result";
            resultLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 230);
            Controls.Add(panel1);
            Controls.Add(CalculateButton);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Factorial calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Button CalculateButton;
        private Panel panel1;
        private Label resultLabel;
    }
}