namespace InputValidater
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.errInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(210, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(109, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(160, 138);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(95, 23);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // errInput
            // 
            this.errInput.ContainerControl = this;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(357, 88);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Must have 2 digits, 2 upper & lower case letters, 2 non-letters, length 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reg Ex Demo";
            ((System.ComponentModel.ISupportInitialize)(this.errInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.ErrorProvider errInput;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

