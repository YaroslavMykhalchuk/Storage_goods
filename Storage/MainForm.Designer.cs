namespace Storage
{
    partial class MainForm
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
            this.button_SwitchOnOff = new System.Windows.Forms.Button();
            this.labelConnStatus = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Goods = new System.Windows.Forms.TabPage();
            this.buttonDeleteGoods = new System.Windows.Forms.Button();
            this.buttonChangeGoods = new System.Windows.Forms.Button();
            this.buttonAddGoods = new System.Windows.Forms.Button();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.Type_Goods = new System.Windows.Forms.TabPage();
            this.buttonDeleteType = new System.Windows.Forms.Button();
            this.buttonChangeType = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.dataGridViewType_Goods = new System.Windows.Forms.DataGridView();
            this.Providers = new System.Windows.Forms.TabPage();
            this.buttonChangeProvider = new System.Windows.Forms.Button();
            this.buttonDeleteProvider = new System.Windows.Forms.Button();
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.Others = new System.Windows.Forms.TabPage();
            this.labelInputNumber = new System.Windows.Forms.Label();
            this.numericUpDownInputNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChooseItem = new System.Windows.Forms.ComboBox();
            this.dataGridViewOthers = new System.Windows.Forms.DataGridView();
            this.buttonQueries = new System.Windows.Forms.Button();
            this.comboBoxChooseQuery = new System.Windows.Forms.ComboBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.Type_Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_Goods)).BeginInit();
            this.Providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            this.Others.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOthers)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SwitchOnOff
            // 
            this.button_SwitchOnOff.Location = new System.Drawing.Point(660, 12);
            this.button_SwitchOnOff.Name = "button_SwitchOnOff";
            this.button_SwitchOnOff.Size = new System.Drawing.Size(128, 30);
            this.button_SwitchOnOff.TabIndex = 0;
            this.button_SwitchOnOff.Text = "Під\'єднатися до БД";
            this.button_SwitchOnOff.UseVisualStyleBackColor = true;
            this.button_SwitchOnOff.Click += new System.EventHandler(this.button_SwitchOnOff_Click);
            // 
            // labelConnStatus
            // 
            this.labelConnStatus.AutoSize = true;
            this.labelConnStatus.Location = new System.Drawing.Point(518, 20);
            this.labelConnStatus.Name = "labelConnStatus";
            this.labelConnStatus.Size = new System.Drawing.Size(115, 15);
            this.labelConnStatus.TabIndex = 2;
            this.labelConnStatus.Text = "Статус: Відключено";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.Goods);
            this.tabControlMain.Controls.Add(this.Type_Goods);
            this.tabControlMain.Controls.Add(this.Providers);
            this.tabControlMain.Controls.Add(this.Others);
            this.tabControlMain.Location = new System.Drawing.Point(12, 48);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 416);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // Goods
            // 
            this.Goods.Controls.Add(this.buttonDeleteGoods);
            this.Goods.Controls.Add(this.buttonChangeGoods);
            this.Goods.Controls.Add(this.buttonAddGoods);
            this.Goods.Controls.Add(this.dataGridViewGoods);
            this.Goods.Location = new System.Drawing.Point(4, 24);
            this.Goods.Name = "Goods";
            this.Goods.Padding = new System.Windows.Forms.Padding(3);
            this.Goods.Size = new System.Drawing.Size(768, 388);
            this.Goods.TabIndex = 0;
            this.Goods.Text = "Goods";
            this.Goods.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGoods
            // 
            this.buttonDeleteGoods.Location = new System.Drawing.Point(348, 362);
            this.buttonDeleteGoods.Name = "buttonDeleteGoods";
            this.buttonDeleteGoods.Size = new System.Drawing.Size(165, 23);
            this.buttonDeleteGoods.TabIndex = 3;
            this.buttonDeleteGoods.Text = "Видалити товар";
            this.buttonDeleteGoods.UseVisualStyleBackColor = true;
            this.buttonDeleteGoods.Click += new System.EventHandler(this.buttonDeleteGoods_Click);
            // 
            // buttonChangeGoods
            // 
            this.buttonChangeGoods.Location = new System.Drawing.Point(177, 362);
            this.buttonChangeGoods.Name = "buttonChangeGoods";
            this.buttonChangeGoods.Size = new System.Drawing.Size(165, 23);
            this.buttonChangeGoods.TabIndex = 2;
            this.buttonChangeGoods.Text = "Змінити дані";
            this.buttonChangeGoods.UseVisualStyleBackColor = true;
            this.buttonChangeGoods.Click += new System.EventHandler(this.buttonChangeGoods_Click);
            // 
            // buttonAddGoods
            // 
            this.buttonAddGoods.Location = new System.Drawing.Point(6, 362);
            this.buttonAddGoods.Name = "buttonAddGoods";
            this.buttonAddGoods.Size = new System.Drawing.Size(165, 23);
            this.buttonAddGoods.TabIndex = 1;
            this.buttonAddGoods.Text = "Додати новий товар";
            this.buttonAddGoods.UseVisualStyleBackColor = true;
            this.buttonAddGoods.Click += new System.EventHandler(this.buttonAddGoods_Click);
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.ReadOnly = true;
            this.dataGridViewGoods.RowTemplate.Height = 25;
            this.dataGridViewGoods.Size = new System.Drawing.Size(756, 350);
            this.dataGridViewGoods.TabIndex = 0;
            // 
            // Type_Goods
            // 
            this.Type_Goods.Controls.Add(this.buttonDeleteType);
            this.Type_Goods.Controls.Add(this.buttonChangeType);
            this.Type_Goods.Controls.Add(this.buttonAddType);
            this.Type_Goods.Controls.Add(this.dataGridViewType_Goods);
            this.Type_Goods.Location = new System.Drawing.Point(4, 24);
            this.Type_Goods.Name = "Type_Goods";
            this.Type_Goods.Padding = new System.Windows.Forms.Padding(3);
            this.Type_Goods.Size = new System.Drawing.Size(768, 388);
            this.Type_Goods.TabIndex = 1;
            this.Type_Goods.Text = "Type Goods";
            this.Type_Goods.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteType
            // 
            this.buttonDeleteType.Location = new System.Drawing.Point(348, 362);
            this.buttonDeleteType.Name = "buttonDeleteType";
            this.buttonDeleteType.Size = new System.Drawing.Size(165, 23);
            this.buttonDeleteType.TabIndex = 3;
            this.buttonDeleteType.Text = "Видалити категорію";
            this.buttonDeleteType.UseVisualStyleBackColor = true;
            this.buttonDeleteType.Click += new System.EventHandler(this.buttonDeleteType_Click);
            // 
            // buttonChangeType
            // 
            this.buttonChangeType.Location = new System.Drawing.Point(177, 362);
            this.buttonChangeType.Name = "buttonChangeType";
            this.buttonChangeType.Size = new System.Drawing.Size(165, 23);
            this.buttonChangeType.TabIndex = 2;
            this.buttonChangeType.Text = "Змінити дані";
            this.buttonChangeType.UseVisualStyleBackColor = true;
            this.buttonChangeType.Click += new System.EventHandler(this.buttonChangeType_Click);
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(6, 362);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(165, 23);
            this.buttonAddType.TabIndex = 1;
            this.buttonAddType.Text = "Додати нову категорію";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // dataGridViewType_Goods
            // 
            this.dataGridViewType_Goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType_Goods.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewType_Goods.Name = "dataGridViewType_Goods";
            this.dataGridViewType_Goods.ReadOnly = true;
            this.dataGridViewType_Goods.RowTemplate.Height = 25;
            this.dataGridViewType_Goods.Size = new System.Drawing.Size(756, 350);
            this.dataGridViewType_Goods.TabIndex = 0;
            // 
            // Providers
            // 
            this.Providers.Controls.Add(this.buttonChangeProvider);
            this.Providers.Controls.Add(this.buttonDeleteProvider);
            this.Providers.Controls.Add(this.buttonAddProvider);
            this.Providers.Controls.Add(this.dataGridViewProviders);
            this.Providers.Location = new System.Drawing.Point(4, 24);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(768, 388);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Providers";
            this.Providers.UseVisualStyleBackColor = true;
            // 
            // buttonChangeProvider
            // 
            this.buttonChangeProvider.Location = new System.Drawing.Point(177, 362);
            this.buttonChangeProvider.Name = "buttonChangeProvider";
            this.buttonChangeProvider.Size = new System.Drawing.Size(168, 23);
            this.buttonChangeProvider.TabIndex = 3;
            this.buttonChangeProvider.Text = "Змінити дані";
            this.buttonChangeProvider.UseVisualStyleBackColor = true;
            this.buttonChangeProvider.Click += new System.EventHandler(this.buttonChangeProvider_Click);
            // 
            // buttonDeleteProvider
            // 
            this.buttonDeleteProvider.Location = new System.Drawing.Point(351, 362);
            this.buttonDeleteProvider.Name = "buttonDeleteProvider";
            this.buttonDeleteProvider.Size = new System.Drawing.Size(168, 23);
            this.buttonDeleteProvider.TabIndex = 2;
            this.buttonDeleteProvider.Text = "Видалити постачальника";
            this.buttonDeleteProvider.UseVisualStyleBackColor = true;
            this.buttonDeleteProvider.Click += new System.EventHandler(this.buttonDeleteProvider_Click);
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Location = new System.Drawing.Point(3, 362);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(168, 23);
            this.buttonAddProvider.TabIndex = 1;
            this.buttonAddProvider.Text = "Додати постачальника";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            this.buttonAddProvider.Click += new System.EventHandler(this.buttonAddProvider_Click);
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.ReadOnly = true;
            this.dataGridViewProviders.RowTemplate.Height = 25;
            this.dataGridViewProviders.Size = new System.Drawing.Size(762, 356);
            this.dataGridViewProviders.TabIndex = 0;
            // 
            // Others
            // 
            this.Others.Controls.Add(this.labelInputNumber);
            this.Others.Controls.Add(this.numericUpDownInputNumber);
            this.Others.Controls.Add(this.comboBoxChooseItem);
            this.Others.Controls.Add(this.dataGridViewOthers);
            this.Others.Controls.Add(this.buttonQueries);
            this.Others.Controls.Add(this.comboBoxChooseQuery);
            this.Others.Location = new System.Drawing.Point(4, 24);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(768, 388);
            this.Others.TabIndex = 3;
            this.Others.Text = "Others";
            this.Others.UseVisualStyleBackColor = true;
            // 
            // labelInputNumber
            // 
            this.labelInputNumber.AutoSize = true;
            this.labelInputNumber.CausesValidation = false;
            this.labelInputNumber.Location = new System.Drawing.Point(404, 19);
            this.labelInputNumber.Name = "labelInputNumber";
            this.labelInputNumber.Size = new System.Drawing.Size(95, 15);
            this.labelInputNumber.TabIndex = 10;
            this.labelInputNumber.Text = "Виберіть число:";
            // 
            // numericUpDownInputNumber
            // 
            this.numericUpDownInputNumber.Location = new System.Drawing.Point(505, 17);
            this.numericUpDownInputNumber.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownInputNumber.Name = "numericUpDownInputNumber";
            this.numericUpDownInputNumber.ReadOnly = true;
            this.numericUpDownInputNumber.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownInputNumber.TabIndex = 9;
            // 
            // comboBoxChooseItem
            // 
            this.comboBoxChooseItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseItem.FormattingEnabled = true;
            this.comboBoxChooseItem.Location = new System.Drawing.Point(404, 17);
            this.comboBoxChooseItem.Name = "comboBoxChooseItem";
            this.comboBoxChooseItem.Size = new System.Drawing.Size(213, 23);
            this.comboBoxChooseItem.TabIndex = 8;
            this.comboBoxChooseItem.Visible = false;
            this.comboBoxChooseItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseItem_SelectedIndexChanged);
            // 
            // dataGridViewOthers
            // 
            this.dataGridViewOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOthers.Location = new System.Drawing.Point(14, 46);
            this.dataGridViewOthers.Name = "dataGridViewOthers";
            this.dataGridViewOthers.ReadOnly = true;
            this.dataGridViewOthers.RowTemplate.Height = 25;
            this.dataGridViewOthers.Size = new System.Drawing.Size(740, 327);
            this.dataGridViewOthers.TabIndex = 7;
            // 
            // buttonQueries
            // 
            this.buttonQueries.Location = new System.Drawing.Point(626, 12);
            this.buttonQueries.Name = "buttonQueries";
            this.buttonQueries.Size = new System.Drawing.Size(128, 30);
            this.buttonQueries.TabIndex = 6;
            this.buttonQueries.Text = "Виконати";
            this.buttonQueries.UseVisualStyleBackColor = true;
            this.buttonQueries.Click += new System.EventHandler(this.buttonQueries_Click);
            // 
            // comboBoxChooseQuery
            // 
            this.comboBoxChooseQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseQuery.FormattingEnabled = true;
            this.comboBoxChooseQuery.Items.AddRange(new object[] {
            "Показати товар з максимальною кількістю.",
            "Показати товар з мінімальною кількістю.",
            "Показати товар з мінімальною собівартістю.",
            "Показати товар з максимальною собівартістю.",
            "Показати товари заданої категорії.",
            "Показати товари заданого постачальника.",
            "Показати товар, який знаходиться на складі найдовше з усіх.",
            "Показати середню кількість товарів за кожним типом товару.",
            "Показати інформацію про постачальника, в якого кількість товарів на складі найбіл" +
                "ьша.",
            "Показати інформацію про постачальника, в якого кількість товарів на складі наймен" +
                "ша.",
            "Показати інформацію про тип товару з найбільшою кількістю одиниць на складі.",
            "Показати інформацію про тип товарів з найменшою кількістю товарів на складі.",
            "Показати товари, з постачання яких минула задана кількість днів."});
            this.comboBoxChooseQuery.Location = new System.Drawing.Point(14, 17);
            this.comboBoxChooseQuery.Name = "comboBoxChooseQuery";
            this.comboBoxChooseQuery.Size = new System.Drawing.Size(384, 23);
            this.comboBoxChooseQuery.TabIndex = 0;
            this.comboBoxChooseQuery.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseQuery_SelectedIndexChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 12);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(175, 30);
            this.buttonDownload.TabIndex = 5;
            this.buttonDownload.Text = "Завантажити Goods";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelConnStatus);
            this.Controls.Add(this.button_SwitchOnOff);
            this.Name = "MainForm";
            this.Text = "Storage";
            this.tabControlMain.ResumeLayout(false);
            this.Goods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.Type_Goods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_Goods)).EndInit();
            this.Providers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            this.Others.ResumeLayout(false);
            this.Others.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOthers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_SwitchOnOff;
        private Label labelConnStatus;
        private TabControl tabControlMain;
        private TabPage Goods;
        private DataGridView dataGridViewGoods;
        private TabPage Type_Goods;
        private DataGridView dataGridViewType_Goods;
        private TabPage Providers;
        private DataGridView dataGridViewProviders;
        private TabPage Others;
        private DataGridView dataGridViewOthers;
        private Button buttonQueries;
        private ComboBox comboBoxChooseQuery;
        private Button buttonDownload;
        private ComboBox comboBoxChooseItem;
        private NumericUpDown numericUpDownInputNumber;
        private Label labelInputNumber;
        private Button buttonAddGoods;
        private Button buttonAddType;
        private Button buttonAddProvider;
        private Button buttonDeleteGoods;
        private Button buttonChangeGoods;
        private Button buttonDeleteType;
        private Button buttonChangeType;
        private Button buttonChangeProvider;
        private Button buttonDeleteProvider;
    }
}