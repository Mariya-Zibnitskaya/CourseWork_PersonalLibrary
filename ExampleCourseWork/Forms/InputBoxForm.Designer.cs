namespace ExampleCourseWork.Forms
{
    partial class InputBoxForm
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
            this.SaveNameButton = new System.Windows.Forms.Button();
            this.CancelNameButton = new System.Windows.Forms.Button();
            this.collectionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveNameButton
            // 
            this.SaveNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveNameButton.Location = new System.Drawing.Point(245, 144);
            this.SaveNameButton.Name = "SaveNameButton";
            this.SaveNameButton.Size = new System.Drawing.Size(102, 38);
            this.SaveNameButton.TabIndex = 0;
            this.SaveNameButton.Text = "Зберегти";
            this.SaveNameButton.UseVisualStyleBackColor = true;
            this.SaveNameButton.Click += new System.EventHandler(this.SaveNameButton_Click);
            // 
            // CancelNameButton
            // 
            this.CancelNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelNameButton.Location = new System.Drawing.Point(363, 144);
            this.CancelNameButton.Name = "CancelNameButton";
            this.CancelNameButton.Size = new System.Drawing.Size(102, 38);
            this.CancelNameButton.TabIndex = 1;
            this.CancelNameButton.Text = "Відмінити";
            this.CancelNameButton.UseVisualStyleBackColor = true;
            this.CancelNameButton.Click += new System.EventHandler(this.CancelNameButton_Click);
            // 
            // collectionTextBox
            // 
            this.collectionTextBox.Location = new System.Drawing.Point(158, 81);
            this.collectionTextBox.Name = "collectionTextBox";
            this.collectionTextBox.Size = new System.Drawing.Size(307, 22);
            this.collectionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва колекції:";
            // 
            // InputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collectionTextBox);
            this.Controls.Add(this.CancelNameButton);
            this.Controls.Add(this.SaveNameButton);
            this.Name = "InputBoxForm";
            this.Text = "Створення нової колекції";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveNameButton;
        private System.Windows.Forms.Button CancelNameButton;
        private System.Windows.Forms.TextBox collectionTextBox;
        private System.Windows.Forms.Label label1;
    }
}