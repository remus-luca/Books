namespace Books
{
    partial class Form2
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
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputPublisher = new System.Windows.Forms.TextBox();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.inputAuthor = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonRenounce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTitle.Location = new System.Drawing.Point(195, 97);
            this.inputTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(358, 35);
            this.inputTitle.TabIndex = 0;
            this.inputTitle.TextChanged += new System.EventHandler(this.inputTitle_TextChanged);
            this.inputTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            // 
            // inputPublisher
            // 
            this.inputPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputPublisher.Location = new System.Drawing.Point(195, 309);
            this.inputPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPublisher.Name = "inputPublisher";
            this.inputPublisher.Size = new System.Drawing.Size(358, 35);
            this.inputPublisher.TabIndex = 1;
            this.inputPublisher.TextChanged += new System.EventHandler(this.inputPublisher_TextChanged);
            this.inputPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPublisher_KeyPress);
            // 
            // inputYear
            // 
            this.inputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputYear.Location = new System.Drawing.Point(288, 232);
            this.inputYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(200, 35);
            this.inputYear.TabIndex = 2;
            this.inputYear.TextChanged += new System.EventHandler(this.inputYear_TextChanged);
            this.inputYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputYear_KeyPress);
            // 
            // inputAuthor
            // 
            this.inputAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputAuthor.Location = new System.Drawing.Point(195, 166);
            this.inputAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputAuthor.Name = "inputAuthor";
            this.inputAuthor.Size = new System.Drawing.Size(358, 35);
            this.inputAuthor.TabIndex = 3;
            this.inputAuthor.TextChanged += new System.EventHandler(this.inputAuthor_TextChanged);
            this.inputAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputAuthor_KeyPress);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(74, 102);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(61, 29);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(195, 426);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 60);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPublisher.Location = new System.Drawing.Point(74, 309);
            this.labelPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(115, 29);
            this.labelPublisher.TabIndex = 6;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.Location = new System.Drawing.Point(74, 237);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(208, 29);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "YearOfPublication";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthor.Location = new System.Drawing.Point(74, 166);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(82, 29);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "Author";
            // 
            // buttonRenounce
            // 
            this.buttonRenounce.Location = new System.Drawing.Point(423, 426);
            this.buttonRenounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRenounce.Name = "buttonRenounce";
            this.buttonRenounce.Size = new System.Drawing.Size(132, 60);
            this.buttonRenounce.TabIndex = 9;
            this.buttonRenounce.Text = "Renounce";
            this.buttonRenounce.UseVisualStyleBackColor = true;
            this.buttonRenounce.Click += new System.EventHandler(this.buttonRenounce_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 587);
            this.Controls.Add(this.buttonRenounce);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.inputAuthor);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.inputPublisher);
            this.Controls.Add(this.inputTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add-Modify";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox inputPublisher;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.TextBox inputAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonRenounce;
    }
}