namespace Labirinto
{
    partial class frmSalaDois
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
            btnEsquerda = new Button();
            btnBaixo = new Button();
            btnCima = new Button();
            btnDireita = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEsquerda
            // 
            btnEsquerda.BackColor = SystemColors.Desktop;
            btnEsquerda.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsquerda.ForeColor = SystemColors.ButtonHighlight;
            btnEsquerda.Location = new Point(12, 215);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(92, 53);
            btnEsquerda.TabIndex = 1;
            btnEsquerda.Text = "Aperte";
            btnEsquerda.UseVisualStyleBackColor = false;
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // btnBaixo
            // 
            btnBaixo.BackColor = SystemColors.Desktop;
            btnBaixo.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaixo.ForeColor = SystemColors.ButtonHighlight;
            btnBaixo.Location = new Point(362, 385);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(92, 53);
            btnBaixo.TabIndex = 2;
            btnBaixo.Text = "Aperte";
            btnBaixo.UseVisualStyleBackColor = false;
            btnBaixo.Click += btnBaixo_Click;
            // 
            // btnCima
            // 
            btnCima.BackColor = SystemColors.Desktop;
            btnCima.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCima.ForeColor = SystemColors.ButtonHighlight;
            btnCima.Location = new Point(362, 12);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(92, 53);
            btnCima.TabIndex = 3;
            btnCima.Text = "Aperte";
            btnCima.UseVisualStyleBackColor = false;
            btnCima.Click += btnCima_Click;
            // 
            // btnDireita
            // 
            btnDireita.BackColor = SystemColors.Desktop;
            btnDireita.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDireita.ForeColor = SystemColors.Control;
            btnDireita.Location = new Point(696, 215);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(92, 53);
            btnDireita.TabIndex = 4;
            btnDireita.Text = "Aperte";
            btnDireita.UseVisualStyleBackColor = false;
            btnDireita.Click += btnDireita_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1, -1);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "02";
            // 
            // frmSalaDois
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.labirintooo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDireita);
            Controls.Add(btnCima);
            Controls.Add(btnBaixo);
            Controls.Add(btnEsquerda);
            Name = "frmSalaDois";
            Text = "frmSalaDois";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEsquerda;
        private Button btnBaixo;
        private Button btnCima;
        private Button btnDireita;
        private Label label1;
    }
}