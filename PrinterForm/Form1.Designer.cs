﻿
namespace PrinterForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.copies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iduser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountid = new System.Windows.Forms.TextBox();
            this.labelamount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.copiesid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(333, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(256, 20);
            this.name.TabIndex = 0;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(333, 171);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(256, 20);
            this.amount.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(230, 111);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "add amount by username";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // copies
            // 
            this.copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.copies.Location = new System.Drawing.Point(489, 312);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(100, 20);
            this.copies.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "copies available";
            // 
            // iduser
            // 
            this.iduser.Location = new System.Drawing.Point(333, 367);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(256, 20);
            this.iduser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID user";
            // 
            // amountid
            // 
            this.amountid.Location = new System.Drawing.Point(333, 422);
            this.amountid.Name = "amountid";
            this.amountid.Size = new System.Drawing.Size(256, 20);
            this.amountid.TabIndex = 9;
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.Location = new System.Drawing.Point(242, 422);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(42, 13);
            this.labelamount.TabIndex = 10;
            this.labelamount.Text = "amount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "add amount by id";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // copiesid
            // 
            this.copiesid.Location = new System.Drawing.Point(488, 557);
            this.copiesid.Name = "copiesid";
            this.copiesid.Size = new System.Drawing.Size(100, 20);
            this.copiesid.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "copies available";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copiesid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.amountid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iduser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountid;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox copiesid;
        private System.Windows.Forms.Label label4;
    }
}

