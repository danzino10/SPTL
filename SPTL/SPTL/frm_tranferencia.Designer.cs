namespace SPTL
{
    partial class frm_tranferencia
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_entrar = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cb_cartao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_usuario = new DevComponents.DotNetBar.LabelX();
            this.lbl_iban = new DevComponents.DotNetBar.LabelX();
            this.txt_iban = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_destinatario = new DevComponents.DotNetBar.LabelX();
            this.lbl_nome = new DevComponents.DotNetBar.LabelX();
            this.lbl_ao06 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(370, 336);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.buttonX1.Size = new System.Drawing.Size(82, 49);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 14;
            this.buttonX1.Text = "Cancelar";
            this.buttonX1.TextColor = System.Drawing.Color.Red;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_entrar.Enabled = false;
            this.btn_entrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(127, 336);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.btn_entrar.Size = new System.Drawing.Size(89, 49);
            this.btn_entrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_entrar.Symbol = "";
            this.btn_entrar.SymbolColor = System.Drawing.Color.Green;
            this.btn_entrar.TabIndex = 13;
            this.btn_entrar.Text = "Confirmar";
            this.btn_entrar.TextColor = System.Drawing.Color.Green;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_ao06);
            this.panelEx1.Controls.Add(this.lbl_nome);
            this.panelEx1.Controls.Add(this.lbl_destinatario);
            this.panelEx1.Controls.Add(this.txt_iban);
            this.panelEx1.Controls.Add(this.lbl_iban);
            this.panelEx1.Controls.Add(this.cb_cartao);
            this.panelEx1.Controls.Add(this.lbl_usuario);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(35, 84);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(486, 201);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 22;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // cb_cartao
            // 
            this.cb_cartao.DisplayMember = "Text";
            this.cb_cartao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_cartao.FormattingEnabled = true;
            this.cb_cartao.ItemHeight = 14;
            this.cb_cartao.Location = new System.Drawing.Point(247, 18);
            this.cb_cartao.Name = "cb_cartao";
            this.cb_cartao.Size = new System.Drawing.Size(222, 20);
            this.cb_cartao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_cartao.TabIndex = 4;
            this.cb_cartao.SelectedIndexChanged += new System.EventHandler(this.cb_cartao_SelectedIndexChanged);
            // 
            // lbl_usuario
            // 
            // 
            // 
            // 
            this.lbl_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_usuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(3, 18);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(179, 23);
            this.lbl_usuario.Symbol = "";
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Cartão bancário:";
            // 
            // lbl_iban
            // 
            // 
            // 
            // 
            this.lbl_iban.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_iban.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iban.Location = new System.Drawing.Point(3, 71);
            this.lbl_iban.Name = "lbl_iban";
            this.lbl_iban.Size = new System.Drawing.Size(179, 23);
            this.lbl_iban.Symbol = "";
            this.lbl_iban.TabIndex = 5;
            this.lbl_iban.Text = "Iban destinatário:";
            // 
            // txt_iban
            // 
            // 
            // 
            // 
            this.txt_iban.Border.Class = "TextBoxBorder";
            this.txt_iban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_iban.Location = new System.Drawing.Point(247, 76);
            this.txt_iban.MaxLength = 21;
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.PreventEnterBeep = true;
            this.txt_iban.Size = new System.Drawing.Size(222, 20);
            this.txt_iban.TabIndex = 6;
            this.txt_iban.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // lbl_destinatario
            // 
            // 
            // 
            // 
            this.lbl_destinatario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_destinatario.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destinatario.Location = new System.Drawing.Point(3, 126);
            this.lbl_destinatario.Name = "lbl_destinatario";
            this.lbl_destinatario.Size = new System.Drawing.Size(97, 23);
            this.lbl_destinatario.Symbol = "";
            this.lbl_destinatario.TabIndex = 7;
            this.lbl_destinatario.Text = "Nome:";
            // 
            // lbl_nome
            // 
            // 
            // 
            // 
            this.lbl_nome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_nome.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(92, 126);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(264, 59);
            this.lbl_nome.TabIndex = 8;
            // 
            // lbl_ao06
            // 
            // 
            // 
            // 
            this.lbl_ao06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ao06.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ao06.Location = new System.Drawing.Point(188, 76);
            this.lbl_ao06.Name = "lbl_ao06";
            this.lbl_ao06.Size = new System.Drawing.Size(55, 23);
            this.lbl_ao06.TabIndex = 9;
            this.lbl_ao06.Text = "AO06.";
            // 
            // frm_tranferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SPTL.Properties.Resources.Universl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 440);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btn_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_tranferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_entrar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_nome;
        private DevComponents.DotNetBar.LabelX lbl_destinatario;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_iban;
        private DevComponents.DotNetBar.LabelX lbl_iban;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_cartao;
        private DevComponents.DotNetBar.LabelX lbl_usuario;
        private DevComponents.DotNetBar.LabelX lbl_ao06;
    }
}