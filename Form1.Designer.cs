namespace Practica_1_Unidad_4
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
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            textMonto = new TextBox();
            textCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRetiro = new Button();
            btnDeposito = new Button();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            txtSaldo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listRetiros = new ListBox();
            listDepositos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(textMonto);
            groupBox1.Controls.Add(textCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos ";
            // 
            // btnAbrir
            // 
            btnAbrir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrir.Location = new Point(266, 37);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(120, 30);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta ";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // textMonto
            // 
            textMonto.Location = new Point(86, 58);
            textMonto.Name = "textMonto";
            textMonto.Size = new Size(142, 23);
            textMonto.TabIndex = 3;
            // 
            // textCliente
            // 
            textCliente.Location = new Point(86, 22);
            textCliente.Name = "textCliente";
            textCliente.Size = new Size(142, 23);
            textCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Location = new Point(15, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacción";
            // 
            // btnRetiro
            // 
            btnRetiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.Location = new Point(201, 39);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(120, 31);
            btnRetiro.TabIndex = 1;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeposito.Location = new Point(42, 39);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(122, 31);
            btnDeposito.TabIndex = 0;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(listRetiros);
            groupBox3.Controls.Add(listDepositos);
            groupBox3.Location = new Point(15, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 199);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(332, 144);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(327, 115);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(80, 23);
            txtSaldo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 92);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(201, 28);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Retiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 28);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Depositos";
            // 
            // listRetiros
            // 
            listRetiros.FormattingEnabled = true;
            listRetiros.ItemHeight = 15;
            listRetiros.Location = new Point(201, 58);
            listRetiros.Name = "listRetiros";
            listRetiros.Size = new Size(120, 124);
            listRetiros.TabIndex = 1;
            // 
            // listDepositos
            // 
            listDepositos.FormattingEnabled = true;
            listDepositos.ItemHeight = 15;
            listDepositos.Location = new Point(14, 58);
            listDepositos.Name = "listDepositos";
            listDepositos.Size = new Size(120, 124);
            listDepositos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAbrir;
        private TextBox textMonto;
        private TextBox textCliente;
        private Label label2;
        private Label label1;
        private Button btnRetiro;
        private Button btnDeposito;
        private ListBox listRetiros;
        private ListBox listDepositos;
        private Button btnNuevo;
        private TextBox txtSaldo;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}