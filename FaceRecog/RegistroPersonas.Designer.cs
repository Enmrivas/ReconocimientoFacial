﻿namespace FaceRecog
{
    partial class Registro_de_personas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_de_personas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImgUpload = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnBackLP = new System.Windows.Forms.Button();
            this.btnRegisterLP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subir Imagen";
            // 
            // btnImgUpload
            // 
            this.btnImgUpload.Location = new System.Drawing.Point(182, 51);
            this.btnImgUpload.Name = "btnImgUpload";
            this.btnImgUpload.Size = new System.Drawing.Size(75, 23);
            this.btnImgUpload.TabIndex = 2;
            this.btnImgUpload.Text = "Upload";
            this.btnImgUpload.UseVisualStyleBackColor = true;
            this.btnImgUpload.Click += new System.EventHandler(this.btnImgUpload_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(182, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 26);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(182, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLName.Location = new System.Drawing.Point(182, 146);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(174, 26);
            this.txtLName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ultimo lugar visto/a";
            // 
            // txtLastPlace
            // 
            this.txtLastPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastPlace.Location = new System.Drawing.Point(389, 97);
            this.txtLastPlace.Name = "txtLastPlace";
            this.txtLastPlace.Size = new System.Drawing.Size(174, 26);
            this.txtLastPlace.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtState.Location = new System.Drawing.Point(389, 146);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(174, 26);
            this.txtState.TabIndex = 10;
            // 
            // btnBackLP
            // 
            this.btnBackLP.Location = new System.Drawing.Point(491, 190);
            this.btnBackLP.Name = "btnBackLP";
            this.btnBackLP.Size = new System.Drawing.Size(75, 48);
            this.btnBackLP.TabIndex = 11;
            this.btnBackLP.Text = "Atras";
            this.btnBackLP.UseVisualStyleBackColor = true;
            this.btnBackLP.Click += new System.EventHandler(this.btnBackLP_Click);
            // 
            // btnRegisterLP
            // 
            this.btnRegisterLP.Location = new System.Drawing.Point(389, 190);
            this.btnRegisterLP.Name = "btnRegisterLP";
            this.btnRegisterLP.Size = new System.Drawing.Size(75, 48);
            this.btnRegisterLP.TabIndex = 12;
            this.btnRegisterLP.Text = "Registrar";
            this.btnRegisterLP.UseVisualStyleBackColor = true;
            this.btnRegisterLP.Click += new System.EventHandler(this.btnRegisterLP_Click);
            // 
            // Registro_de_personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 250);
            this.Controls.Add(this.btnRegisterLP);
            this.Controls.Add(this.btnBackLP);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnImgUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_de_personas";
            this.Text = "Registro de personas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_de_personas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImgUpload;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnBackLP;
        private System.Windows.Forms.Button btnRegisterLP;
    }
}