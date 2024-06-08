namespace ExampleCourseWork.Forms
{
    partial class EditBookForm
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
            this.panelForTextBox = new System.Windows.Forms.Panel();
            this.RemoveBookFromCollectionButton = new System.Windows.Forms.Button();
            this.CollectionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AnnotationtextBox = new System.Windows.Forms.TextBox();
            this.LanguagetextBox = new System.Windows.Forms.TextBox();
            this.GenretextBox = new System.Windows.Forms.TextBox();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.AuthortextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForTextBox
            // 
            this.panelForTextBox.BackColor = System.Drawing.Color.OldLace;
            this.panelForTextBox.Controls.Add(this.RemoveBookFromCollectionButton);
            this.panelForTextBox.Controls.Add(this.CollectionComboBox);
            this.panelForTextBox.Controls.Add(this.label8);
            this.panelForTextBox.Controls.Add(this.DeleteButton);
            this.panelForTextBox.Controls.Add(this.CancelButton);
            this.panelForTextBox.Controls.Add(this.OkButton);
            this.panelForTextBox.Controls.Add(this.AnnotationtextBox);
            this.panelForTextBox.Controls.Add(this.LanguagetextBox);
            this.panelForTextBox.Controls.Add(this.GenretextBox);
            this.panelForTextBox.Controls.Add(this.YeartextBox);
            this.panelForTextBox.Controls.Add(this.AuthortextBox);
            this.panelForTextBox.Controls.Add(this.TitleTextBox);
            this.panelForTextBox.Controls.Add(this.IdtextBox);
            this.panelForTextBox.Controls.Add(this.label7);
            this.panelForTextBox.Controls.Add(this.label6);
            this.panelForTextBox.Controls.Add(this.label5);
            this.panelForTextBox.Controls.Add(this.label4);
            this.panelForTextBox.Controls.Add(this.label3);
            this.panelForTextBox.Controls.Add(this.label2);
            this.panelForTextBox.Controls.Add(this.label1);
            this.panelForTextBox.Location = new System.Drawing.Point(67, 38);
            this.panelForTextBox.Name = "panelForTextBox";
            this.panelForTextBox.Size = new System.Drawing.Size(667, 418);
            this.panelForTextBox.TabIndex = 0;
            // 
            // RemoveBookFromCollectionButton
            // 
            this.RemoveBookFromCollectionButton.BackColor = System.Drawing.Color.White;
            this.RemoveBookFromCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBookFromCollectionButton.Location = new System.Drawing.Point(313, 316);
            this.RemoveBookFromCollectionButton.Name = "RemoveBookFromCollectionButton";
            this.RemoveBookFromCollectionButton.Size = new System.Drawing.Size(177, 47);
            this.RemoveBookFromCollectionButton.TabIndex = 19;
            this.RemoveBookFromCollectionButton.Text = "Очистити колекцію";
            this.RemoveBookFromCollectionButton.UseVisualStyleBackColor = false;
            this.RemoveBookFromCollectionButton.Click += new System.EventHandler(this.RemoveBookFromCollectionButton_Click);
            // 
            // CollectionComboBox
            // 
            this.CollectionComboBox.FormattingEnabled = true;
            this.CollectionComboBox.Location = new System.Drawing.Point(150, 321);
            this.CollectionComboBox.Name = "CollectionComboBox";
            this.CollectionComboBox.Size = new System.Drawing.Size(146, 24);
            this.CollectionComboBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(43, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Колекція";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(43, 369);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 30);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(461, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 30);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(337, 369);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 30);
            this.OkButton.TabIndex = 14;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AnnotationtextBox
            // 
            this.AnnotationtextBox.Location = new System.Drawing.Point(150, 218);
            this.AnnotationtextBox.Multiline = true;
            this.AnnotationtextBox.Name = "AnnotationtextBox";
            this.AnnotationtextBox.Size = new System.Drawing.Size(418, 92);
            this.AnnotationtextBox.TabIndex = 13;
            // 
            // LanguagetextBox
            // 
            this.LanguagetextBox.Location = new System.Drawing.Point(150, 181);
            this.LanguagetextBox.Name = "LanguagetextBox";
            this.LanguagetextBox.Size = new System.Drawing.Size(418, 22);
            this.LanguagetextBox.TabIndex = 12;
            // 
            // GenretextBox
            // 
            this.GenretextBox.Location = new System.Drawing.Point(411, 137);
            this.GenretextBox.Name = "GenretextBox";
            this.GenretextBox.Size = new System.Drawing.Size(157, 22);
            this.GenretextBox.TabIndex = 11;
            // 
            // YeartextBox
            // 
            this.YeartextBox.Location = new System.Drawing.Point(150, 137);
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.Size = new System.Drawing.Size(146, 22);
            this.YeartextBox.TabIndex = 10;
            // 
            // AuthortextBox
            // 
            this.AuthortextBox.Location = new System.Drawing.Point(150, 99);
            this.AuthortextBox.Name = "AuthortextBox";
            this.AuthortextBox.Size = new System.Drawing.Size(418, 22);
            this.AuthortextBox.TabIndex = 9;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(150, 60);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(418, 22);
            this.TitleTextBox.TabIndex = 8;
            // 
            // IdtextBox
            // 
            this.IdtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IdtextBox.Enabled = false;
            this.IdtextBox.Location = new System.Drawing.Point(150, 22);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(418, 22);
            this.IdtextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(39, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Аннотація";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Мова";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(333, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panelForTextBox);
            this.MaximumSize = new System.Drawing.Size(818, 515);
            this.MinimumSize = new System.Drawing.Size(818, 515);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.panelForTextBox.ResumeLayout(false);
            this.panelForTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.TextBox AuthortextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox AnnotationtextBox;
        private System.Windows.Forms.TextBox LanguagetextBox;
        private System.Windows.Forms.TextBox GenretextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox CollectionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RemoveBookFromCollectionButton;
    }
}