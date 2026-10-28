namespace frmArrayLencina
{
    partial class frmArray
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
            ltsLista = new ListBox();
            cboGrupo = new ComboBox();
            lblGrupos = new Label();
            btnArray = new Button();
            btnGrabar = new Button();
            lblGrupos2 = new Label();
            lblDato = new Label();
            cboGrupos2 = new ComboBox();
            txtDato = new TextBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // ltsLista
            // 
            ltsLista.FormattingEnabled = true;
            ltsLista.Location = new Point(32, 74);
            ltsLista.Name = "ltsLista";
            ltsLista.Size = new Size(212, 64);
            ltsLista.TabIndex = 0;
            // 
            // cboGrupo
            // 
            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(123, 25);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(121, 23);
            cboGrupo.TabIndex = 1;
            cboGrupo.SelectedIndexChanged += cboGrupo_SelectedIndexChanged;
            // 
            // lblGrupos
            // 
            lblGrupos.AutoSize = true;
            lblGrupos.Location = new Point(32, 33);
            lblGrupos.Name = "lblGrupos";
            lblGrupos.Size = new Size(45, 15);
            lblGrupos.TabIndex = 2;
            lblGrupos.Text = "Grupos";
            // 
            // btnArray
            // 
            btnArray.Location = new Point(32, 144);
            btnArray.Name = "btnArray";
            btnArray.Size = new Size(212, 23);
            btnArray.TabIndex = 3;
            btnArray.Text = "Sobreescribir Array";
            btnArray.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(161, 277);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(83, 23);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblGrupos2
            // 
            lblGrupos2.AutoSize = true;
            lblGrupos2.Location = new Point(32, 210);
            lblGrupos2.Name = "lblGrupos2";
            lblGrupos2.Size = new Size(45, 15);
            lblGrupos2.TabIndex = 5;
            lblGrupos2.Text = "Grupos";
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(32, 246);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 6;
            lblDato.Text = "Dato";
            // 
            // cboGrupos2
            // 
            cboGrupos2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupos2.FormattingEnabled = true;
            cboGrupos2.Location = new Point(123, 202);
            cboGrupos2.Name = "cboGrupos2";
            cboGrupos2.Size = new Size(121, 23);
            cboGrupos2.TabIndex = 7;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(123, 238);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(121, 23);
            txtDato.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(32, 304);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "Mensaje";
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 328);
            Controls.Add(lblMensaje);
            Controls.Add(txtDato);
            Controls.Add(cboGrupos2);
            Controls.Add(lblDato);
            Controls.Add(lblGrupos2);
            Controls.Add(btnGrabar);
            Controls.Add(btnArray);
            Controls.Add(lblGrupos);
            Controls.Add(cboGrupo);
            Controls.Add(ltsLista);
            Name = "frmArray";
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ltsLista;
        private ComboBox cboGrupo;
        private Label lblGrupos;
        private Button btnArray;
        private Button btnGrabar;
        private Label lblGrupos2;
        private Label lblDato;
        private ComboBox cboGrupos2;
        private TextBox txtDato;
        private Label lblMensaje;
    }
}
