namespace konyvtar_BarthaAriana_14sl_grafikus
{
    partial class FormBookMuvelet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookMuvelet));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuPublishYear = new System.Windows.Forms.NumericUpDown();
            this.nuPages = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMuvelet = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuPublishYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPages)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "könyv cím";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(153, 102);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(303, 22);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAuthor.Location = new System.Drawing.Point(153, 158);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(303, 22);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "író";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "kiadás éve";
            // 
            // nuPublishYear
            // 
            this.nuPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nuPublishYear.Location = new System.Drawing.Point(153, 212);
            this.nuPublishYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nuPublishYear.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nuPublishYear.Name = "nuPublishYear";
            this.nuPublishYear.Size = new System.Drawing.Size(120, 22);
            this.nuPublishYear.TabIndex = 7;
            this.nuPublishYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuPublishYear.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // nuPages
            // 
            this.nuPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nuPages.Location = new System.Drawing.Point(153, 270);
            this.nuPages.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nuPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPages.Name = "nuPages";
            this.nuPages.Size = new System.Drawing.Size(120, 22);
            this.nuPages.TabIndex = 9;
            this.nuPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "oldalak száma";
            // 
            // buttonMuvelet
            // 
            this.buttonMuvelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMuvelet.Location = new System.Drawing.Point(525, 270);
            this.buttonMuvelet.Name = "buttonMuvelet";
            this.buttonMuvelet.Size = new System.Drawing.Size(195, 41);
            this.buttonMuvelet.TabIndex = 10;
            this.buttonMuvelet.Text = "button1";
            this.buttonMuvelet.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.Location = new System.Drawing.Point(153, 60);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(75, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "id";
            // 
            // FormBookMuvelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMuvelet);
            this.Controls.Add(this.nuPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuPublishYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBookMuvelet";
            this.Text = "FormBookMuvelet";
            this.Load += new System.EventHandler(this.FormBookMuvelet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPublishYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuPublishYear;
        private System.Windows.Forms.NumericUpDown nuPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMuvelet;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}