namespace SPTL
{
    partial class frm_login
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_usuario = new DevComponents.DotNetBar.LabelX();
            this.txt_user = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_senha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_entrar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_usuario);
            this.panelEx1.Controls.Add(this.txt_user);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txt_senha);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(47, 61);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(338, 163);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // lbl_usuario
            // 
            // 
            // 
            // 
            this.lbl_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_usuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(3, 13);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(127, 23);
            this.lbl_usuario.Symbol = "";
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txt_user
            // 
            // 
            // 
            // 
            this.txt_user.Border.Class = "TextBoxBorder";
            this.txt_user.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(150, 18);
            this.txt_user.Name = "txt_user";
            this.txt_user.PreventEnterBeep = true;
            this.txt_user.Size = new System.Drawing.Size(178, 23);
            this.txt_user.TabIndex = 11;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 92);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(127, 23);
            this.labelX2.Symbol = "59533";
            this.labelX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Senha";
            // 
            // txt_senha
            // 
            // 
            // 
            // 
            this.txt_senha.Border.Class = "TextBoxBorder";
            this.txt_senha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_senha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(150, 92);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PreventEnterBeep = true;
            this.txt_senha.Size = new System.Drawing.Size(129, 26);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.UseSystemPasswordChar = true;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(303, 345);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.buttonX1.Size = new System.Drawing.Size(82, 49);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Text = "Sair";
            this.buttonX1.TextColor = System.Drawing.Color.Red;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_entrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_entrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(50, 345);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.btn_entrar.Size = new System.Drawing.Size(82, 49);
            this.btn_entrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_entrar.Symbol = "";
            this.btn_entrar.SymbolColor = System.Drawing.Color.Green;
            this.btn_entrar.TabIndex = 11;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.TextColor = System.Drawing.Color.Green;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(176, 345);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.buttonX2.Size = new System.Drawing.Size(82, 49);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.MidnightBlue;
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "Registar";
            this.buttonX2.TextColor = System.Drawing.Color.MidnightBlue;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPTL.Properties.Resources.Universl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 419);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btn_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_usuario;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_user;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_senha;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_entrar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}