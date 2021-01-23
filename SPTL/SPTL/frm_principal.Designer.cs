namespace SPTL
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            this.btn_caixa = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.btn_visualização = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cadastro = new DevComponents.DotNetBar.ButtonX();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Data = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btn_caixa
            // 
            this.btn_caixa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_caixa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_caixa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caixa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_caixa.Location = new System.Drawing.Point(623, 133);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.btn_caixa.Size = new System.Drawing.Size(134, 118);
            this.btn_caixa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_caixa.Symbol = "";
            this.btn_caixa.SymbolColor = System.Drawing.Color.Tomato;
            this.btn_caixa.SymbolSize = 70F;
            this.btn_caixa.TabIndex = 10;
            this.btn_caixa.Text = "Difinições";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX3.Location = new System.Drawing.Point(444, 133);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX3.Size = new System.Drawing.Size(134, 118);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolColor = System.Drawing.Color.Maroon;
            this.buttonX3.SymbolSize = 70F;
            this.buttonX3.TabIndex = 9;
            this.buttonX3.Text = "Recargas";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btn_visualização
            // 
            this.btn_visualização.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_visualização.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_visualização.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualização.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_visualização.Location = new System.Drawing.Point(284, 133);
            this.btn_visualização.Name = "btn_visualização";
            this.btn_visualização.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.btn_visualização.Size = new System.Drawing.Size(134, 118);
            this.btn_visualização.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_visualização.Symbol = "";
            this.btn_visualização.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.btn_visualização.SymbolSize = 70F;
            this.btn_visualização.TabIndex = 8;
            this.btn_visualização.Text = "Transferencia";
            this.btn_visualização.Click += new System.EventHandler(this.btn_visualização_Click);
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cadastro.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Cadastro.Location = new System.Drawing.Point(110, 133);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.btn_Cadastro.Size = new System.Drawing.Size(134, 118);
            this.btn_Cadastro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cadastro.Symbol = "57775";
            this.btn_Cadastro.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_Cadastro.SymbolSize = 70F;
            this.btn_Cadastro.TabIndex = 7;
            this.btn_Cadastro.Text = "Consulta";
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(151, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 22);
            this.lbl_nome.TabIndex = 14;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cargo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(289, 15);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(0, 22);
            this.lbl_cargo.TabIndex = 13;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(440, 15);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 22);
            this.lbl_hora.TabIndex = 12;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(10, -6);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(90, 70);
            this.reflectionLabel1.TabIndex = 11;
            this.reflectionLabel1.Text = "Bem Vindo <font color=\"#000000\"></font><font color=\"#1F497D\"></font>";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Data.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(629, 7);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(0, 22);
            this.lbl_Data.TabIndex = 15;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(100, 271);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX1.Size = new System.Drawing.Size(134, 118);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Red;
            this.buttonX1.SymbolSize = 70F;
            this.buttonX1.TabIndex = 16;
            this.buttonX1.Text = "Cancelar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(284, 271);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX2.Size = new System.Drawing.Size(134, 118);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.buttonX2.SymbolSize = 70F;
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "Levantamento sem Cartão";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPTL.Properties.Resources.Universl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 445);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btn_caixa);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.btn_visualização);
            this.Controls.Add(this.btn_Cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_caixa;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX btn_visualização;
        private DevComponents.DotNetBar.ButtonX btn_Cadastro;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_hora;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Data;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}