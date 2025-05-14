namespace WinTesteTarget_Sistemas
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
            Questao1 = new Button();
            textQuestao1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Questao2 = new Button();
            label3 = new Label();
            textResultadoFB = new TextBox();
            entradaNumeroFB = new NumericUpDown();
            Questao3 = new Button();
            label4 = new Label();
            txtMenorFaturamento = new TextBox();
            label5 = new Label();
            txtMaiorFaturamento = new TextBox();
            label6 = new Label();
            txtQtdeMaiorMediaDia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)entradaNumeroFB).BeginInit();
            SuspendLayout();
            // 
            // Questao1
            // 
            Questao1.Location = new Point(68, 50);
            Questao1.Name = "Questao1";
            Questao1.Size = new Size(117, 23);
            Questao1.TabIndex = 0;
            Questao1.Text = "Questão 1";
            Questao1.UseVisualStyleBackColor = true;
            Questao1.Click += Questao1_Click;
            // 
            // textQuestao1
            // 
            textQuestao1.Location = new Point(265, 50);
            textQuestao1.Name = "textQuestao1";
            textQuestao1.Size = new Size(100, 23);
            textQuestao1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 54);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Resposta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 96);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 5;
            label2.Text = "Informe um numero :";
            // 
            // Questao2
            // 
            Questao2.Location = new Point(68, 92);
            Questao2.Name = "Questao2";
            Questao2.Size = new Size(117, 23);
            Questao2.TabIndex = 3;
            Questao2.Text = "Questão 2";
            Questao2.UseVisualStyleBackColor = true;
            Questao2.Click += Questao2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 99);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 7;
            label3.Text = "Sequência de Fibonacci:";
            // 
            // textResultadoFB
            // 
            textResultadoFB.Location = new Point(585, 91);
            textResultadoFB.Name = "textResultadoFB";
            textResultadoFB.Size = new Size(589, 23);
            textResultadoFB.TabIndex = 6;
            // 
            // entradaNumeroFB
            // 
            entradaNumeroFB.Location = new Point(335, 92);
            entradaNumeroFB.Name = "entradaNumeroFB";
            entradaNumeroFB.Size = new Size(80, 23);
            entradaNumeroFB.TabIndex = 8;
            // 
            // Questao3
            // 
            Questao3.Location = new Point(69, 140);
            Questao3.Name = "Questao3";
            Questao3.Size = new Size(116, 23);
            Questao3.TabIndex = 9;
            Questao3.Text = "Qestão 3";
            Questao3.UseVisualStyleBackColor = true;
            Questao3.Click += Questao3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 148);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "O menor valor:";
            // 
            // txtMenorFaturamento
            // 
            txtMenorFaturamento.Location = new Point(315, 141);
            txtMenorFaturamento.Name = "txtMenorFaturamento";
            txtMenorFaturamento.Size = new Size(100, 23);
            txtMenorFaturamento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 144);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 13;
            label5.Text = "O maior valor:";
            // 
            // txtMaiorFaturamento
            // 
            txtMaiorFaturamento.Location = new Point(559, 137);
            txtMaiorFaturamento.Name = "txtMaiorFaturamento";
            txtMaiorFaturamento.Size = new Size(100, 23);
            txtMaiorFaturamento.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(686, 137);
            label6.Name = "label6";
            label6.Size = new Size(168, 15);
            label6.TabIndex = 15;
            label6.Text = "Qtde superior à média mensal:";
            // 
            // txtQtdeMaiorMediaDia
            // 
            txtQtdeMaiorMediaDia.Location = new Point(862, 136);
            txtQtdeMaiorMediaDia.Name = "txtQtdeMaiorMediaDia";
            txtQtdeMaiorMediaDia.Size = new Size(100, 23);
            txtQtdeMaiorMediaDia.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(label6);
            Controls.Add(txtQtdeMaiorMediaDia);
            Controls.Add(label5);
            Controls.Add(txtMaiorFaturamento);
            Controls.Add(label4);
            Controls.Add(txtMenorFaturamento);
            Controls.Add(Questao3);
            Controls.Add(entradaNumeroFB);
            Controls.Add(label3);
            Controls.Add(textResultadoFB);
            Controls.Add(label2);
            Controls.Add(Questao2);
            Controls.Add(label1);
            Controls.Add(textQuestao1);
            Controls.Add(Questao1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)entradaNumeroFB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Questao1;
        private TextBox textQuestao1;
        private Label label1;
        private Label label2;
        private Button Questao2;
        private Label label3;
        private TextBox textResultadoFB;
        private NumericUpDown entradaNumeroFB;
        private Button Questao3;
        private Label label4;
        private TextBox txtMenorFaturamento;
        private Label label5;
        private TextBox txtMaiorFaturamento;
        private Label label6;
        private TextBox txtQtdeMaiorMediaDia;
    }
}
