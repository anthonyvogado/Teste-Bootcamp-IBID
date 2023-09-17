namespace WF_ADONet
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
            dataGridView1 = new DataGridView();
            textBox_nomeAdicionar = new TextBox();
            button_adicionarItem = new Button();
            label1 = new Label();
            textBox_idRemover = new TextBox();
            label_idRemover = new Label();
            button_removerItem = new Button();
            textBox_nomeEditar = new TextBox();
            label3 = new Label();
            button_editarItem = new Button();
            label5 = new Label();
            textBox_idEditar = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(324, 298);
            dataGridView1.TabIndex = 2;
            // 
            // textBox_nomeAdicionar
            // 
            textBox_nomeAdicionar.Location = new Point(28, 122);
            textBox_nomeAdicionar.Name = "textBox_nomeAdicionar";
            textBox_nomeAdicionar.Size = new Size(100, 23);
            textBox_nomeAdicionar.TabIndex = 4;
            // 
            // button_adicionarItem
            // 
            button_adicionarItem.Location = new Point(27, 151);
            button_adicionarItem.Name = "button_adicionarItem";
            button_adicionarItem.Size = new Size(75, 23);
            button_adicionarItem.TabIndex = 6;
            button_adicionarItem.Text = "Adicionar";
            button_adicionarItem.UseVisualStyleBackColor = true;
            button_adicionarItem.Click += button_adicionarItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(27, 104);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // textBox_idRemover
            // 
            textBox_idRemover.Location = new Point(25, 452);
            textBox_idRemover.Name = "textBox_idRemover";
            textBox_idRemover.Size = new Size(100, 23);
            textBox_idRemover.TabIndex = 9;
            // 
            // label_idRemover
            // 
            label_idRemover.AutoSize = true;
            label_idRemover.Location = new Point(27, 434);
            label_idRemover.Name = "label_idRemover";
            label_idRemover.Size = new Size(18, 15);
            label_idRemover.TabIndex = 10;
            label_idRemover.Text = "ID";
            // 
            // button_removerItem
            // 
            button_removerItem.Location = new Point(25, 481);
            button_removerItem.Name = "button_removerItem";
            button_removerItem.Size = new Size(75, 23);
            button_removerItem.TabIndex = 11;
            button_removerItem.Text = "Remover";
            button_removerItem.UseVisualStyleBackColor = true;
            button_removerItem.Click += button_removerItem_Click;
            // 
            // textBox_nomeEditar
            // 
            textBox_nomeEditar.Location = new Point(27, 257);
            textBox_nomeEditar.Name = "textBox_nomeEditar";
            textBox_nomeEditar.Size = new Size(100, 23);
            textBox_nomeEditar.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 239);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 14;
            label3.Text = "Nome";
            // 
            // button_editarItem
            // 
            button_editarItem.Location = new Point(25, 330);
            button_editarItem.Name = "button_editarItem";
            button_editarItem.Size = new Size(75, 23);
            button_editarItem.TabIndex = 16;
            button_editarItem.Text = "Editar";
            button_editarItem.UseVisualStyleBackColor = true;
            button_editarItem.Click += button_editarItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 283);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 17;
            label5.Text = "ID";
            // 
            // textBox_idEditar
            // 
            textBox_idEditar.Location = new Point(27, 301);
            textBox_idEditar.Name = "textBox_idEditar";
            textBox_idEditar.Size = new Size(100, 23);
            textBox_idEditar.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(331, 9);
            label2.Name = "label2";
            label2.Size = new Size(281, 29);
            label2.TabIndex = 19;
            label2.Text = "GERENCIAMENTO DE ESTOQUE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(27, 72);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 20;
            label4.Text = "ADICIONAR ITEM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 204);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 21;
            label6.Text = "EDITAR ITEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 397);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 22;
            label7.Text = "REMOVER ITEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(918, 558);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox_idEditar);
            Controls.Add(label5);
            Controls.Add(button_editarItem);
            Controls.Add(label3);
            Controls.Add(textBox_nomeEditar);
            Controls.Add(button_removerItem);
            Controls.Add(label_idRemover);
            Controls.Add(textBox_idRemover);
            Controls.Add(label1);
            Controls.Add(button_adicionarItem);
            Controls.Add(textBox_nomeAdicionar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox_nomeAdicionar;
        private Button button_adicionarItem;
        private Label label1;
        private TextBox textBox_idRemover;
        private Label label_idRemover;
        private Button button_removerItem;
        private TextBox textBox_nomeEditar;
        private Label label3;
        private Button button_editarItem;
        private Label label5;
        private TextBox textBox_idEditar;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}