namespace WinFormsLoginWithDB
{
    partial class MenuForm
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
            this.btn_opvul_afdruk = new System.Windows.Forms.Button();
            this.txt_multidimarray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_opvul_afdruk
            // 
            this.btn_opvul_afdruk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_opvul_afdruk.Location = new System.Drawing.Point(166, 34);
            this.btn_opvul_afdruk.Name = "btn_opvul_afdruk";
            this.btn_opvul_afdruk.Size = new System.Drawing.Size(489, 60);
            this.btn_opvul_afdruk.TabIndex = 0;
            this.btn_opvul_afdruk.Text = "Opvullen / Afdrukken";
            this.btn_opvul_afdruk.UseVisualStyleBackColor = true;
            this.btn_opvul_afdruk.Click += new System.EventHandler(this.btn_opvul_afdruk_Click);
            // 
            // txt_multidimarray
            // 
            this.txt_multidimarray.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_multidimarray.Location = new System.Drawing.Point(30, 121);
            this.txt_multidimarray.Multiline = true;
            this.txt_multidimarray.Name = "txt_multidimarray";
            this.txt_multidimarray.Size = new System.Drawing.Size(730, 280);
            this.txt_multidimarray.TabIndex = 1;
            this.txt_multidimarray.WordWrap = false;
            this.txt_multidimarray.TextChanged += new System.EventHandler(this.txt_multidimarray_TextChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_multidimarray);
            this.Controls.Add(this.btn_opvul_afdruk);
            this.Name = "MenuForm";
            this.Text = "Meerdimensionale Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_opvul_afdruk;
        private TextBox textBox1;
        private TextBox txt_multidimarray;
    }
}