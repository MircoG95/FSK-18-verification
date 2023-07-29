
namespace AufgabeFSK18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtp_GebDat = new System.Windows.Forms.DateTimePicker();
            bt_pruefen = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // dtp_GebDat
            // 
            dtp_GebDat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtp_GebDat.Location = new System.Drawing.Point(84, 92);
            dtp_GebDat.Name = "dtp_GebDat";
            dtp_GebDat.Size = new System.Drawing.Size(370, 36);
            dtp_GebDat.TabIndex = 0;
            // 
            // bt_pruefen
            // 
            bt_pruefen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_pruefen.Location = new System.Drawing.Point(173, 245);
            bt_pruefen.Name = "bt_pruefen";
            bt_pruefen.Size = new System.Drawing.Size(200, 78);
            bt_pruefen.TabIndex = 1;
            bt_pruefen.Text = "Check now";
            bt_pruefen.UseVisualStyleBackColor = true;
            bt_pruefen.Click += bt_pruefen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(563, 381);
            Controls.Add(bt_pruefen);
            Controls.Add(dtp_GebDat);
            Name = "Form1";
            Text = "FSK18";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_GebDat;
        private System.Windows.Forms.Button bt_pruefen;
    }
}

