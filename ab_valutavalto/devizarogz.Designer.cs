namespace ab_valutavalto
{
    partial class devizarogz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_devkod = new System.Windows.Forms.TextBox();
            this.tb_devnev = new System.Windows.Forms.TextBox();
            this.btn_ment = new System.Windows.Forms.Button();
            this.btn_elvet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviza rövid kódja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deviza neve";
            // 
            // tb_devkod
            // 
            this.tb_devkod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_devkod.Location = new System.Drawing.Point(155, 27);
            this.tb_devkod.Name = "tb_devkod";
            this.tb_devkod.Size = new System.Drawing.Size(100, 20);
            this.tb_devkod.TabIndex = 1;
            this.tb_devkod.TextChanged += new System.EventHandler(this.tb_devkod_TextChanged);
            // 
            // tb_devnev
            // 
            this.tb_devnev.Location = new System.Drawing.Point(127, 55);
            this.tb_devnev.Name = "tb_devnev";
            this.tb_devnev.Size = new System.Drawing.Size(188, 20);
            this.tb_devnev.TabIndex = 1;
            this.tb_devnev.TextChanged += new System.EventHandler(this.tb_devnev_TextChanged);
            // 
            // btn_ment
            // 
            this.btn_ment.Location = new System.Drawing.Point(57, 113);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(75, 23);
            this.btn_ment.TabIndex = 2;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // btn_elvet
            // 
            this.btn_elvet.Location = new System.Drawing.Point(202, 113);
            this.btn_elvet.Name = "btn_elvet";
            this.btn_elvet.Size = new System.Drawing.Size(75, 23);
            this.btn_elvet.TabIndex = 2;
            this.btn_elvet.Text = "Elvetés";
            this.btn_elvet.UseVisualStyleBackColor = true;
            this.btn_elvet.Click += new System.EventHandler(this.btn_elvet_Click);
            // 
            // devizarogz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 161);
            this.Controls.Add(this.btn_elvet);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.tb_devnev);
            this.Controls.Add(this.tb_devkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "devizarogz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deviza rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_devkod;
        private System.Windows.Forms.TextBox tb_devnev;
        private System.Windows.Forms.Button btn_ment;
        private System.Windows.Forms.Button btn_elvet;
    }
}