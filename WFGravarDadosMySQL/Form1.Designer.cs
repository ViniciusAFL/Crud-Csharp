﻿
namespace WFGravarDadosMySQL
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_busca = new System.Windows.Forms.Button();
            this.lst_contatos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(91, 175);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(220, 23);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(418, 80);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(380, 23);
            this.txt_buscar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar contato";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(817, 79);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(75, 23);
            this.txt_busca.TabIndex = 10;
            this.txt_busca.Text = "Buscar";
            this.txt_busca.UseVisualStyleBackColor = true;
            this.txt_busca.Click += new System.EventHandler(this.button3_Click);
            // 
            // lst_contatos
            // 
            this.lst_contatos.HideSelection = false;
            this.lst_contatos.Location = new System.Drawing.Point(418, 124);
            this.lst_contatos.Name = "lst_contatos";
            this.lst_contatos.Size = new System.Drawing.Size(474, 174);
            this.lst_contatos.TabIndex = 11;
            this.lst_contatos.UseCompatibleStateImageBehavior = false;
            this.lst_contatos.SelectedIndexChanged += new System.EventHandler(this.lst_contatos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 355);
            this.Controls.Add(this.lst_contatos);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txt_busca;
        private System.Windows.Forms.ListView lst_contatos;
    }
}

