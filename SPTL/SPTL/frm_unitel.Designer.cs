namespace SPTL
{
    partial class frm_unitel
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_entidade = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbo_produto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_numero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_enviar = new DevComponents.DotNetBar.ButtonX();
            this.txt_valor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(80, 148);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(226, 19);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Produto";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(80, 338);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(226, 19);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Numero de telemovel";
            // 
            // lbl_entidade
            // 
            this.lbl_entidade.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_entidade.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_entidade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entidade.Location = new System.Drawing.Point(80, 65);
            this.lbl_entidade.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_entidade.Name = "lbl_entidade";
            this.lbl_entidade.Size = new System.Drawing.Size(226, 19);
            this.lbl_entidade.TabIndex = 3;
            this.lbl_entidade.Text = "Entidade";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(132, 104);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(226, 19);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Unitel recargas diretas";
            // 
            // cbo_produto
            // 
            this.cbo_produto.DisplayMember = "Text";
            this.cbo_produto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_produto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_produto.FormattingEnabled = true;
            this.cbo_produto.ItemHeight = 20;
            this.cbo_produto.Location = new System.Drawing.Point(132, 181);
            this.cbo_produto.Name = "cbo_produto";
            this.cbo_produto.Size = new System.Drawing.Size(174, 26);
            this.cbo_produto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_produto.TabIndex = 5;
            // 
            // txt_numero
            // 
            // 
            // 
            // 
            this.txt_numero.Border.Class = "TextBoxBorder";
            this.txt_numero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_numero.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(139, 376);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.PreventEnterBeep = true;
            this.txt_numero.Size = new System.Drawing.Size(197, 25);
            this.txt_numero.TabIndex = 6;
            // 
            // btn_enviar
            // 
            this.btn_enviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_enviar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_enviar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(342, 376);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.btn_enviar.Size = new System.Drawing.Size(82, 49);
            this.btn_enviar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_enviar.SymbolColor = System.Drawing.Color.Green;
            this.btn_enviar.TabIndex = 14;
            this.btn_enviar.Text = "Enviiar";
            this.btn_enviar.TextColor = System.Drawing.Color.Green;
            // 
            // txt_valor
            // 
            // 
            // 
            // 
            this.txt_valor.Border.Class = "TextBoxBorder";
            this.txt_valor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_valor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(132, 294);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PreventEnterBeep = true;
            this.txt_valor.Size = new System.Drawing.Size(197, 25);
            this.txt_valor.TabIndex = 25;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(80, 249);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(226, 19);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Valor";
            // 
            // frm_unitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPTL.Properties.Resources.Universl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 453);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cbo_produto);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.lbl_entidade);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_unitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_entidade;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_produto;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_numero;
        private DevComponents.DotNetBar.ButtonX btn_enviar;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_valor;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}