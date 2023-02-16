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
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.GrupoPeriodo = new System.Windows.Forms.GroupBox();
            this.RadioManha = new System.Windows.Forms.RadioButton();
            this.RadioTarde = new System.Windows.Forms.RadioButton();
            this.RadioNoite = new System.Windows.Forms.RadioButton();
            this.GrupoPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(43, 37);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(43, 15);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome:";
            this.LabelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(90, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Digite seu nome";
            this.textBoxNome.Size = new System.Drawing.Size(433, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // LabelSobreNome
            // 
            this.LabelSobreNome.AutoSize = true;
            this.LabelSobreNome.Location = new System.Drawing.Point(15, 77);
            this.LabelSobreNome.Name = "LabelSobreNome";
            this.LabelSobreNome.Size = new System.Drawing.Size(71, 15);
            this.LabelSobreNome.TabIndex = 0;
            this.LabelSobreNome.Text = "Sobrenome:";
            this.LabelSobreNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSobreNome
            // 
            this.textBoxSobreNome.Location = new System.Drawing.Point(90, 73);
            this.textBoxSobreNome.Name = "textBoxSobreNome";
            this.textBoxSobreNome.PlaceholderText = "Digite Sobrenome";
            this.textBoxSobreNome.Size = new System.Drawing.Size(433, 23);
            this.textBoxSobreNome.TabIndex = 1;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(49, 118);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(34, 15);
            this.LabelData.TabIndex = 0;
            this.LabelData.Text = "Data:";
            this.LabelData.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(90, 115);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(433, 23);
            this.dateTime.TabIndex = 2;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(260, 235);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarButton.TabIndex = 3;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // GrupoPeriodo
            // 
            this.GrupoPeriodo.Controls.Add(this.RadioManha);
            this.GrupoPeriodo.Controls.Add(this.RadioTarde);
            this.GrupoPeriodo.Controls.Add(this.RadioNoite);
            this.GrupoPeriodo.Location = new System.Drawing.Point(90, 161);
            this.GrupoPeriodo.Name = "GrupoPeriodo";
            this.GrupoPeriodo.Size = new System.Drawing.Size(433, 56);
            this.GrupoPeriodo.TabIndex = 4;
            this.GrupoPeriodo.TabStop = false;
            this.GrupoPeriodo.Text = "Periodo";
            // 
            // RadioManha
            // 
            this.RadioManha.AutoSize = true;
            this.RadioManha.Location = new System.Drawing.Point(318, 22);
            this.RadioManha.Name = "RadioManha";
            this.RadioManha.Size = new System.Drawing.Size(62, 19);
            this.RadioManha.TabIndex = 2;
            this.RadioManha.TabStop = true;
            this.RadioManha.Text = "Manhã";
            this.RadioManha.UseVisualStyleBackColor = true;
            // 
            // RadioTarde
            // 
            this.RadioTarde.AutoSize = true;
            this.RadioTarde.Location = new System.Drawing.Point(161, 22);
            this.RadioTarde.Name = "RadioTarde";
            this.RadioTarde.Size = new System.Drawing.Size(53, 19);
            this.RadioTarde.TabIndex = 1;
            this.RadioTarde.TabStop = true;
            this.RadioTarde.Text = "Tarde";
            this.RadioTarde.UseVisualStyleBackColor = true;
            this.RadioTarde.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioNoite
            // 
            this.RadioNoite.AutoSize = true;
            this.RadioNoite.Location = new System.Drawing.Point(18, 22);
            this.RadioNoite.Name = "RadioNoite";
            this.RadioNoite.Size = new System.Drawing.Size(54, 19);
            this.RadioNoite.TabIndex = 0;
            this.RadioNoite.TabStop = true;
            this.RadioNoite.Text = "Noite";
            this.RadioNoite.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 277);
            this.Controls.Add(this.GrupoPeriodo);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textBoxSobreNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.LabelSobreNome);
            this.Controls.Add(this.LabelNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LabelSobrenome_Load);
            this.GrupoPeriodo.ResumeLayout(false);
            this.GrupoPeriodo.PerformLayout();
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
        private Button ConfirmarButton;
        private GroupBox GrupoPeriodo;
        private RadioButton RadioTarde;
        private RadioButton RadioNoite;
        private RadioButton RadioManha;
    }
}
