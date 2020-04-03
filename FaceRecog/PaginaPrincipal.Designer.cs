namespace FaceRecog
{
    partial class PaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.btnRegPers = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegPers
            // 
            this.btnRegPers.Location = new System.Drawing.Point(93, 53);
            this.btnRegPers.Name = "btnRegPers";
            this.btnRegPers.Size = new System.Drawing.Size(177, 79);
            this.btnRegPers.TabIndex = 0;
            this.btnRegPers.Text = "Registrar persona perdida";
            this.btnRegPers.UseVisualStyleBackColor = true;
            this.btnRegPers.Click += new System.EventHandler(this.btnRegPers_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(93, 148);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(177, 79);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Lista de personas";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 303);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRegPers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaPrincipal";
            this.Text = "Reconocimiento Facial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaginaPrincipal_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegPers;
        private System.Windows.Forms.Button btnList;
    }
}