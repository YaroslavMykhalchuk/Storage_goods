namespace Storage
{
    partial class AddGoods
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
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddType = new System.Windows.Forms.Label();
            this.labelAddProvider = new System.Windows.Forms.Label();
            this.labelAddQuantity = new System.Windows.Forms.Label();
            this.labelAddPrimeCost = new System.Windows.Forms.Label();
            this.labelAddDateDelivery = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.textBoxAddPrimeCost = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(29, 18);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(128, 15);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "Додайте назву товару:";
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.Location = new System.Drawing.Point(29, 88);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(115, 15);
            this.labelAddType.TabIndex = 1;
            this.labelAddType.Text = "Оберіть тип товару:";
            // 
            // labelAddProvider
            // 
            this.labelAddProvider.AutoSize = true;
            this.labelAddProvider.Location = new System.Drawing.Point(29, 155);
            this.labelAddProvider.Name = "labelAddProvider";
            this.labelAddProvider.Size = new System.Drawing.Size(139, 15);
            this.labelAddProvider.TabIndex = 2;
            this.labelAddProvider.Text = "Оберіть постачальника:";
            // 
            // labelAddQuantity
            // 
            this.labelAddQuantity.AutoSize = true;
            this.labelAddQuantity.Location = new System.Drawing.Point(29, 227);
            this.labelAddQuantity.Name = "labelAddQuantity";
            this.labelAddQuantity.Size = new System.Drawing.Size(146, 15);
            this.labelAddQuantity.TabIndex = 3;
            this.labelAddQuantity.Text = "Додайте кількість товару:";
            // 
            // labelAddPrimeCost
            // 
            this.labelAddPrimeCost.AutoSize = true;
            this.labelAddPrimeCost.Location = new System.Drawing.Point(29, 296);
            this.labelAddPrimeCost.Name = "labelAddPrimeCost";
            this.labelAddPrimeCost.Size = new System.Drawing.Size(152, 15);
            this.labelAddPrimeCost.TabIndex = 4;
            this.labelAddPrimeCost.Text = "Додайте ціну собівартості:";
            // 
            // labelAddDateDelivery
            // 
            this.labelAddDateDelivery.AutoSize = true;
            this.labelAddDateDelivery.Location = new System.Drawing.Point(29, 371);
            this.labelAddDateDelivery.Name = "labelAddDateDelivery";
            this.labelAddDateDelivery.Size = new System.Drawing.Size(131, 15);
            this.labelAddDateDelivery.TabIndex = 5;
            this.labelAddDateDelivery.Text = "Оберіть дату доставки:";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(29, 46);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(241, 23);
            this.textBoxAddName.TabIndex = 6;
            // 
            // textBoxAddQuantity
            // 
            this.textBoxAddQuantity.Location = new System.Drawing.Point(29, 256);
            this.textBoxAddQuantity.Name = "textBoxAddQuantity";
            this.textBoxAddQuantity.Size = new System.Drawing.Size(241, 23);
            this.textBoxAddQuantity.TabIndex = 7;
            // 
            // textBoxAddPrimeCost
            // 
            this.textBoxAddPrimeCost.Location = new System.Drawing.Point(29, 329);
            this.textBoxAddPrimeCost.Name = "textBoxAddPrimeCost";
            this.textBoxAddPrimeCost.Size = new System.Drawing.Size(241, 23);
            this.textBoxAddPrimeCost.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(29, 115);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(241, 23);
            this.comboBoxType.TabIndex = 9;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(29, 182);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(241, 23);
            this.comboBoxProvider.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(29, 403);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 23);
            this.dateTimePicker.TabIndex = 11;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(29, 450);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(195, 450);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 485);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxAddPrimeCost);
            this.Controls.Add(this.textBoxAddQuantity);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.labelAddDateDelivery);
            this.Controls.Add(this.labelAddPrimeCost);
            this.Controls.Add(this.labelAddQuantity);
            this.Controls.Add(this.labelAddProvider);
            this.Controls.Add(this.labelAddType);
            this.Controls.Add(this.labelAddName);
            this.Name = "AddGoods";
            this.Text = "Додати товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddName;
        private Label labelAddType;
        private Label labelAddProvider;
        private Label labelAddQuantity;
        private Label labelAddPrimeCost;
        private Label labelAddDateDelivery;
        private TextBox textBoxAddName;
        private TextBox textBoxAddQuantity;
        private TextBox textBoxAddPrimeCost;
        private ComboBox comboBoxType;
        private ComboBox comboBoxProvider;
        private DateTimePicker dateTimePicker;
        private Button buttonOK;
        private Button buttonCancel;
    }
}