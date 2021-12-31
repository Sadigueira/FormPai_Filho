namespace FormPai_Filho
{
    partial class FrmPai
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPai));
            this.pnlPai = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPai = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnFormFilho = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPai
            // 
            this.pnlPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlPai.Controls.Add(this.pbLogo);
            this.pnlPai.Controls.Add(this.btnFormFilho);
            this.pnlPai.Controls.Add(this.txtTelefone);
            this.pnlPai.Controls.Add(this.txtNome);
            this.pnlPai.Controls.Add(this.lblTelefone);
            this.pnlPai.Controls.Add(this.lblNome);
            this.pnlPai.Controls.Add(this.lblPai);
            this.pnlPai.Controls.Add(this.flowLayoutPanel1);
            this.pnlPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPai.Location = new System.Drawing.Point(0, 0);
            this.pnlPai.Name = "pnlPai";
            this.pnlPai.Size = new System.Drawing.Size(432, 291);
            this.pnlPai.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(595, 182);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPai.ForeColor = System.Drawing.Color.White;
            this.lblPai.Location = new System.Drawing.Point(37, 30);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(108, 24);
            this.lblPai.TabIndex = 1;
            this.lblPai.Text = "FORM PAI";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(37, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(15, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(92, 22);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(108, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 27);
            this.txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(108, 130);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 27);
            this.txtTelefone.TabIndex = 5;
            // 
            // btnFormFilho
            // 
            this.btnFormFilho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormFilho.Location = new System.Drawing.Point(138, 199);
            this.btnFormFilho.Name = "btnFormFilho";
            this.btnFormFilho.Size = new System.Drawing.Size(154, 33);
            this.btnFormFilho.TabIndex = 1;
            this.btnFormFilho.Text = "Form Filho";
            this.btnFormFilho.UseVisualStyleBackColor = true;
            this.btnFormFilho.Click += new System.EventHandler(this.btnFormFilho_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FormPai_Filho.Properties.Resources.Logo_Transparente;
            this.pbLogo.Location = new System.Drawing.Point(367, 228);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 51);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // FrmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 291);
            this.Controls.Add(this.pnlPai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Form Pai :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPai_FormClosed);
            this.pnlPai.ResumeLayout(false);
            this.pnlPai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFormFilho;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPai;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

