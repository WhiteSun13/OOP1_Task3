
namespace OOP1_Task3
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
            this.intValue = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intValue
            // 
            this.intValue.Location = new System.Drawing.Point(12, 12);
            this.intValue.Name = "intValue";
            this.intValue.Size = new System.Drawing.Size(125, 27);
            this.intValue.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(143, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(137, 29);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Конвертировать";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 46);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 88);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.intValue);
            this.MinimumSize = new System.Drawing.Size(315, 135);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intValue;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label Result;
    }
}

