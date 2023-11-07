namespace YolaChat
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBTEL = new System.Windows.Forms.RadioButton();
            this.RBOK = new System.Windows.Forms.RadioButton();
            this.RBVK = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBTEL);
            this.groupBox1.Controls.Add(this.RBOK);
            this.groupBox1.Controls.Add(this.RBVK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип авторизации";
            // 
            // RBTEL
            // 
            this.RBTEL.AutoSize = true;
            this.RBTEL.Location = new System.Drawing.Point(6, 65);
            this.RBTEL.Name = "RBTEL";
            this.RBTEL.Size = new System.Drawing.Size(108, 28);
            this.RBTEL.TabIndex = 2;
            this.RBTEL.Text = "Телефон";
            this.RBTEL.UseVisualStyleBackColor = true;
            this.RBTEL.CheckedChanged += new System.EventHandler(this.RBTEL_CheckedChanged);
            // 
            // RBOK
            // 
            this.RBOK.AutoSize = true;
            this.RBOK.Location = new System.Drawing.Point(6, 42);
            this.RBOK.Name = "RBOK";
            this.RBOK.Size = new System.Drawing.Size(55, 28);
            this.RBOK.TabIndex = 1;
            this.RBOK.Text = "ОК";
            this.RBOK.UseVisualStyleBackColor = true;
            // 
            // RBVK
            // 
            this.RBVK.AutoSize = true;
            this.RBVK.Checked = true;
            this.RBVK.Location = new System.Drawing.Point(6, 19);
            this.RBVK.Name = "RBVK";
            this.RBVK.Size = new System.Drawing.Size(52, 28);
            this.RBVK.TabIndex = 0;
            this.RBVK.TabStop = true;
            this.RBVK.Text = "ВК";
            this.RBVK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(296, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(378, 12);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(371, 29);
            this.TextBoxLogin.TabIndex = 3;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Location = new System.Drawing.Point(378, 54);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(371, 29);
            this.TextBoxPass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(737, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Шифрованный файл|*.bin";
            this.saveFileDialog1.Title = "Введите имя файла";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать файл для оператора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBTEL;
        private System.Windows.Forms.RadioButton RBOK;
        private System.Windows.Forms.RadioButton RBVK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}