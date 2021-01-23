namespace SPTL
{
    partial class frm_levantamento
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
            this.txt_valor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btn_enviar = new DevComponents.DotNetBar.ButtonX();
            this.lbl_entidade = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_codigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            // 
            // 
            // 
            this.txt_valor.Border.Class = "TextBoxBorder";
            this.txt_valor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_valor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(103, 123);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PreventEnterBeep = true;
            this.txt_valor.Size = new System.Drawing.Size(197, 25);
            this.txt_valor.TabIndex = 41;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(30, 66);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(226, 19);
            this.labelX4.TabIndex = 40;
            this.labelX4.Text = "Quantidade";
            // 
            // btn_enviar
            // 
            this.btn_enviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_enviar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_enviar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(346, 245);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(13, 13, 14, 13);
            this.btn_enviar.Size = new System.Drawing.Size(82, 49);
            this.btn_enviar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_enviar.SymbolColor = System.Drawing.Color.Green;
            this.btn_enviar.TabIndex = 39;
            this.btn_enviar.Text = "Confirmar";
            this.btn_enviar.TextColor = System.Drawing.Color.Green;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_entidade
            // 
            this.lbl_entidade.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_entidade.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_entidade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entidade.Location = new System.Drawing.Point(121, 1);
            this.lbl_entidade.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_entidade.Name = "lbl_entidade";
            this.lbl_entidade.Size = new System.Drawing.Size(226, 19);
            this.lbl_entidade.TabIndex = 37;
            this.lbl_entidade.Text = "Levantamento sem cartão";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(30, 172);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(226, 19);
            this.labelX1.TabIndex = 42;
            this.labelX1.Text = "Codigo secreto";
            // 
            // txt_codigo
            // 
            // 
            // 
            // 
            this.txt_codigo.Border.Class = "TextBoxBorder";
            this.txt_codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_codigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(103, 215);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PreventEnterBeep = true;
            this.txt_codigo.Size = new System.Drawing.Size(197, 25);
            this.txt_codigo.TabIndex = 43;
            // 
            // frm_levantamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPTL.Properties.Resources.Universl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 306);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_entidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_levantamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_valor;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btn_enviar;
        private DevComponents.DotNetBar.LabelX lbl_entidade;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_codigo;
    }
}