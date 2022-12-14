namespace SignInSignUp.Screens
{
    partial class BoasVindas
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
            this.lblBoasvindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBoasvindas
            // 
            this.lblBoasvindas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoasvindas.AutoSize = true;
            this.lblBoasvindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasvindas.Location = new System.Drawing.Point(134, 173);
            this.lblBoasvindas.Name = "lblBoasvindas";
            this.lblBoasvindas.Size = new System.Drawing.Size(230, 39);
            this.lblBoasvindas.TabIndex = 0;
            this.lblBoasvindas.Text = "BEM VINDO!!";
            this.lblBoasvindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(507, 401);
            this.Controls.Add(this.lblBoasvindas);
            this.Name = "BoasVindas";
            this.Text = "BoasVindas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasvindas;
    }
}