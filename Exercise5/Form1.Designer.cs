
namespace Exercise5
{
    partial class playfairCodeTranslatorForm
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
            this.cipherLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.cipherBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Location = new System.Drawing.Point(43, 42);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(113, 13);
            this.cipherLabel.TabIndex = 0;
            this.cipherLabel.Text = "Cipher \"Secret\" Word:";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(43, 91);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(131, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input Text to be Encoded:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(43, 194);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(88, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Encoded Output:";
            // 
            // cipherBox
            // 
            this.cipherBox.Location = new System.Drawing.Point(180, 39);
            this.cipherBox.Name = "cipherBox";
            this.cipherBox.Size = new System.Drawing.Size(140, 20);
            this.cipherBox.TabIndex = 3;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(180, 88);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(537, 75);
            this.inputBox.TabIndex = 4;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(180, 191);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(537, 75);
            this.outputBox.TabIndex = 5;
            // 
            // translateBtn
            // 
            this.translateBtn.Location = new System.Drawing.Point(46, 330);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(102, 23);
            this.translateBtn.TabIndex = 6;
            this.translateBtn.Text = "Translate Text";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(180, 330);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(642, 330);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // playfairCodeTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 380);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.cipherBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.cipherLabel);
            this.Name = "playfairCodeTranslatorForm";
            this.Text = "Code Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox cipherBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

