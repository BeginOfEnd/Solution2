namespace Task7_Form
{
    partial class Form7
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
            this.InBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // InBox
            // 
            this.InBox.Location = new System.Drawing.Point(40, 38);
            this.InBox.Multiline = true;
            this.InBox.Name = "InBox";
            this.InBox.Size = new System.Drawing.Size(186, 406);
            this.InBox.TabIndex = 0;
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(529, 38);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.Size = new System.Drawing.Size(242, 412);
            this.OutBox.TabIndex = 1;
            // 
            // FileButton
            // 
            this.FileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileButton.Location = new System.Drawing.Point(40, 472);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(186, 64);
            this.FileButton.TabIndex = 2;
            this.FileButton.Text = "Считать из файла";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortButton.Location = new System.Drawing.Point(529, 472);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(242, 51);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 564);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InBox);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
    }
}

