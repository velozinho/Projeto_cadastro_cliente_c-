namespace Database
{
    partial class Busca_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busca_Cliente));
            this.txt_pesq_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_txt_cell = new System.Windows.Forms.MaskedTextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.mask_txt_hora = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_atendi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mask_txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mask_txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_end = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_pesq_nome
            // 
            this.txt_pesq_nome.Location = new System.Drawing.Point(220, 14);
            this.txt_pesq_nome.Name = "txt_pesq_nome";
            this.txt_pesq_nome.Size = new System.Drawing.Size(319, 20);
            this.txt_pesq_nome.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Pesquisa Por Nome :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Celular :";
            // 
            // mask_txt_cell
            // 
            this.mask_txt_cell.Location = new System.Drawing.Point(409, 133);
            this.mask_txt_cell.Mask = "(00)00000-0000";
            this.mask_txt_cell.Name = "mask_txt_cell";
            this.mask_txt_cell.Size = new System.Drawing.Size(100, 20);
            this.mask_txt_cell.TabIndex = 32;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.Location = new System.Drawing.Point(702, 124);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(87, 80);
            this.btn_editar.TabIndex = 31;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.Location = new System.Drawing.Point(702, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 80);
            this.btn_buscar.TabIndex = 30;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deletar.BackgroundImage")));
            this.btn_deletar.Location = new System.Drawing.Point(702, 242);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(87, 81);
            this.btn_deletar.TabIndex = 29;
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // mask_txt_hora
            // 
            this.mask_txt_hora.Location = new System.Drawing.Point(199, 421);
            this.mask_txt_hora.Mask = "00:00";
            this.mask_txt_hora.Name = "mask_txt_hora";
            this.mask_txt_hora.Size = new System.Drawing.Size(68, 20);
            this.mask_txt_hora.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hora Atendimento";
            // 
            // date_atendi
            // 
            this.date_atendi.Location = new System.Drawing.Point(186, 360);
            this.date_atendi.Name = "date_atendi";
            this.date_atendi.Size = new System.Drawing.Size(200, 20);
            this.date_atendi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Atendimento";
            // 
            // mask_txt_tel
            // 
            this.mask_txt_tel.Location = new System.Drawing.Point(139, 128);
            this.mask_txt_tel.Mask = "(00)0000-0000";
            this.mask_txt_tel.Name = "mask_txt_tel";
            this.mask_txt_tel.Size = new System.Drawing.Size(120, 20);
            this.mask_txt_tel.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefone :";
            // 
            // mask_txt_cpf
            // 
            this.mask_txt_cpf.Location = new System.Drawing.Point(524, 71);
            this.mask_txt_cpf.Mask = "000.000.000.00";
            this.mask_txt_cpf.Name = "mask_txt_cpf";
            this.mask_txt_cpf.Size = new System.Drawing.Size(112, 20);
            this.mask_txt_cpf.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "CPF :";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(113, 71);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(260, 20);
            this.text_nome.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome :";
            // 
            // text_bairro
            // 
            this.text_bairro.Location = new System.Drawing.Point(409, 309);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(184, 20);
            this.text_bairro.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(296, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Bairro :";
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(139, 304);
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(100, 20);
            this.text_numero.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Numero :";
            // 
            // text_end
            // 
            this.text_end.Location = new System.Drawing.Point(139, 248);
            this.text_end.Name = "text_end";
            this.text_end.Size = new System.Drawing.Size(358, 20);
            this.text_end.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Endereço :";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(113, 176);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(189, 20);
            this.text_email.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "E-mail :";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.Location = new System.Drawing.Point(701, 349);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 79);
            this.btn_salvar.TabIndex = 44;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(518, 405);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 46;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Busca_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.text_bairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_end);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_pesq_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mask_txt_cell);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.mask_txt_hora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_atendi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mask_txt_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mask_txt_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Busca_Cliente";
            this.Text = "Busca_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pesq_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mask_txt_cell;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.MaskedTextBox mask_txt_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_atendi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_txt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_end;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_sair;
    }
}