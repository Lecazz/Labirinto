namespace Labirinto
{
    partial class frmSalaSete
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
            btnDireito = new Button();
            btnEsquerda = new Button();
            btnBaixo = new Button();
            btnCima = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDireito
            // 
            btnDireito.BackColor = SystemColors.Desktop;
            btnDireito.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDireito.ForeColor = SystemColors.ButtonHighlight;
            btnDireito.Location = new Point(696, 199);
            btnDireito.Name = "btnDireito";
            btnDireito.Size = new Size(92, 53);
            btnDireito.TabIndex = 1;
            btnDireito.Text = "Aperte";
            btnDireito.UseVisualStyleBackColor = false;
            // 
            // btnEsquerda
            // 
            btnEsquerda.BackColor = SystemColors.Desktop;
            btnEsquerda.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsquerda.ForeColor = SystemColors.ButtonHighlight;
            btnEsquerda.Location = new Point(12, 199);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(92, 53);
            btnEsquerda.TabIndex = 2;
            btnEsquerda.Text = "Aperte";
            btnEsquerda.UseVisualStyleBackColor = false;
            // 
            // btnBaixo
            // 
            btnBaixo.BackColor = SystemColors.Desktop;
            btnBaixo.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaixo.ForeColor = SystemColors.ButtonHighlight;
            btnBaixo.Location = new Point(362, 385);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(92, 53);
            btnBaixo.TabIndex = 3;
            btnBaixo.Text = "Aperte";
            btnBaixo.UseVisualStyleBackColor = false;
            // 
            // btnCima
            // 
            btnCima.BackColor = SystemColors.Desktop;
            btnCima.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCima.ForeColor = SystemColors.ButtonHighlight;
            btnCima.Location = new Point(362, 12);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(92, 53);
            btnCima.TabIndex = 4;
            btnCima.Text = "Aperte";
            btnCima.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "07";
            // 
            // frmSalaSete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.labirintooo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCima);
            Controls.Add(btnBaixo);
            Controls.Add(btnEsquerda);
            Controls.Add(btnDireito);
            Name = "frmSalaSete";
            Text = "frmSalaSete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDireito;
        private Button btnEsquerda;
        private Button btnBaixo;
        private Button btnCima;
        private Label label1;
    }
}