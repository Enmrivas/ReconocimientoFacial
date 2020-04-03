namespace FaceRecog
{
    partial class BusquedaAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaAPI));
            this.imgLost = new System.Windows.Forms.PictureBox();
            this.imgTest = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMatch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLost
            // 
            this.imgLost.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgLost.InitialImage")));
            this.imgLost.Location = new System.Drawing.Point(33, 31);
            this.imgLost.Name = "imgLost";
            this.imgLost.Size = new System.Drawing.Size(271, 279);
            this.imgLost.TabIndex = 0;
            this.imgLost.TabStop = false;
            // 
            // imgTest
            // 
            this.imgTest.Location = new System.Drawing.Point(416, 31);
            this.imgTest.Name = "imgTest";
            this.imgTest.Size = new System.Drawing.Size(276, 279);
            this.imgTest.TabIndex = 1;
            this.imgTest.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Subir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Comparar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMatch
            // 
            this.txtMatch.AutoSize = true;
            this.txtMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtMatch.Location = new System.Drawing.Point(399, 359);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(326, 63);
            this.txtMatch.TabIndex = 5;
            this.txtMatch.Text = "100% Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Persona Perdida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BusquedaAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imgTest);
            this.Controls.Add(this.imgLost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaAPI";
            this.Text = "BusquedaAPI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BusquedaAPI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLost;
        private System.Windows.Forms.PictureBox imgTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label txtMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}