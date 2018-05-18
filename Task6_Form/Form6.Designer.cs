namespace Task6_Form
{
    partial class Form6
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // FileBox
            // 
            this.FileBox.BackColor = System.Drawing.Color.Gold;
            this.FileBox.Location = new System.Drawing.Point(33, 45);
            this.FileBox.Multiline = true;
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(164, 330);
            this.FileBox.TabIndex = 0;
            this.FileBox.TextChanged += new System.EventHandler(this.FileBox_TextChanged);
            // 
            // MaxBox
            // 
            this.MaxBox.BackColor = System.Drawing.Color.Gold;
            this.MaxBox.Location = new System.Drawing.Point(498, 56);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(182, 20);
            this.MaxBox.TabIndex = 1;
            // 
            // FileButton
            // 
            this.FileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileButton.Location = new System.Drawing.Point(33, 450);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(164, 61);
            this.FileButton.TabIndex = 2;
            this.FileButton.Text = "Считать из файла";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxButton.Location = new System.Drawing.Point(498, 182);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(182, 61);
            this.MaxButton.TabIndex = 3;
            this.MaxButton.Text = "Максимальные числа";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(878, 588);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.FileBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button MaxButton;
    }
}

