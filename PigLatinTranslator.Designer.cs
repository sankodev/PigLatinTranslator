namespace ITS228_Project1_PigLatinTranslator_KCSS
{
    partial class PigLatinTranslator
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
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.textBoxOutcome = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Location = new System.Drawing.Point(13, 25);
            this.textBoxOrigin.Multiline = true;
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(183, 116);
            this.textBoxOrigin.TabIndex = 0;
            // 
            // textBoxOutcome
            // 
            this.textBoxOutcome.Location = new System.Drawing.Point(335, 25);
            this.textBoxOutcome.Multiline = true;
            this.textBoxOutcome.Name = "textBoxOutcome";
            this.textBoxOutcome.Size = new System.Drawing.Size(183, 116);
            this.textBoxOutcome.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(227, 62);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 45);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "&Translate to Pig Latin";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(155, 168);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(302, 168);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // PigLatinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 215);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.textBoxOutcome);
            this.Controls.Add(this.textBoxOrigin);
            this.Name = "PigLatinTranslator";
            this.Text = "Pig Latin Translator";
            this.Load += new System.EventHandler(this.PigLatinTranslator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.TextBox textBoxOutcome;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

