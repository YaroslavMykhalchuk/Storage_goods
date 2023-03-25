namespace Storage
{
    partial class AddProvider
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
            this.labelAddProvider = new System.Windows.Forms.Label();
            this.textBoxAddProvider = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddProvider
            // 
            this.labelAddProvider.AutoSize = true;
            this.labelAddProvider.Location = new System.Drawing.Point(25, 27);
            this.labelAddProvider.Name = "labelAddProvider";
            this.labelAddProvider.Size = new System.Drawing.Size(168, 15);
            this.labelAddProvider.TabIndex = 0;
            this.labelAddProvider.Text = "Введіть назву постачальника:";
            // 
            // textBoxAddProvider
            // 
            this.textBoxAddProvider.Location = new System.Drawing.Point(25, 59);
            this.textBoxAddProvider.Name = "textBoxAddProvider";
            this.textBoxAddProvider.Size = new System.Drawing.Size(214, 23);
            this.textBoxAddProvider.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(25, 123);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(164, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAddProvider);
            this.Controls.Add(this.labelAddProvider);
            this.Name = "AddProvider";
            this.Text = "Додати постачальника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddProvider;
        private TextBox textBoxAddProvider;
        private Button buttonOk;
        private Button buttonCancel;
    }
}