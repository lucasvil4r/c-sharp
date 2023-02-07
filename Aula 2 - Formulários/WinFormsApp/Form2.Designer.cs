namespace WinFormsApp
{
    partial class Form2
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
            this.LabelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.LabelSobreNome = new System.Windows.Forms.Label();
            this.textBoxSobreNome = new System.Windows.Forms.TextBox();
            this.LabelData = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(126, 97);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(43, 15);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome:";
            this.LabelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(173, 93);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Digite seu nome";
            this.textBoxNome.Size = new System.Drawing.Size(271, 23);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.UseSystemPasswordChar = true;
            // 
            // LabelSobreNome
            // 
            this.LabelSobreNome.AutoSize = true;
            this.LabelSobreNome.Location = new System.Drawing.Point(98, 137);
            this.LabelSobreNome.Name = "LabelSobreNome";
            this.LabelSobreNome.Size = new System.Drawing.Size(71, 15);
            this.LabelSobreNome.TabIndex = 0;
            this.LabelSobreNome.Text = "Sobrenome:";
            this.LabelSobreNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSobreNome
            // 
            this.textBoxSobreNome.Location = new System.Drawing.Point(173, 133);
            this.textBoxSobreNome.Name = "textBoxSobreNome";
            this.textBoxSobreNome.PlaceholderText = "Digite Sobrenome";
            this.textBoxSobreNome.Size = new System.Drawing.Size(271, 23);
            this.textBoxSobreNome.TabIndex = 1;
            this.textBoxSobreNome.UseSystemPasswordChar = true;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(132, 178);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(34, 15);
            this.LabelData.TabIndex = 0;
            this.LabelData.Text = "Data:";
            this.LabelData.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(173, 175);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 23);
            this.dateTime.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 304);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textBoxSobreNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.LabelSobreNome);
            this.Controls.Add(this.LabelNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LabelSobrenome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNome;
        private TextBox textBoxNome;
        private Label LabelSobreNome;
        private TextBox textBoxSobreNome;
        private Label LabelData;
        private DateTimePicker dateTime;
    }
}