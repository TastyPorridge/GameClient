namespace Main
{
    partial class Shop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TC = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GB = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.TC.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Controls.Add(this.tabPage4);
            this.TC.Controls.Add(this.tabPage1);
            this.TC.Controls.Add(this.tabPage2);
            this.TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC.HotTrack = true;
            this.TC.Location = new System.Drawing.Point(0, 0);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(614, 487);
            this.TC.TabIndex = 1;
            this.TC.SelectedIndexChanged += new System.EventHandler(this.TC_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GB);
            this.tabPage4.Controls.Add(this.account);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(606, 461);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Вход";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GB
            // 
            this.GB.Controls.Add(this.password);
            this.GB.Controls.Add(this.login);
            this.GB.Controls.Add(this.label4);
            this.GB.Controls.Add(this.label3);
            this.GB.Controls.Add(this.connect);
            this.GB.Location = new System.Drawing.Point(177, 106);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(276, 208);
            this.GB.TabIndex = 0;
            this.GB.TabStop = false;
            this.GB.Text = "Авторизация";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(111, 99);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(147, 20);
            this.password.TabIndex = 9;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(111, 57);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(147, 20);
            this.login.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(183, 177);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 5;
            this.connect.Text = "Войти";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // account
            // 
            this.account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.account.Location = new System.Drawing.Point(24, 59);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(22, 24);
            this.account.TabIndex = 1;
            this.account.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cost);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buy);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазин";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cost
            // 
            this.cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(425, 439);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(0, 13);
            this.cost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Сумма:";
            this.label5.Visible = false;
            // 
            // buy
            // 
            this.buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buy.Location = new System.Drawing.Point(531, 434);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 2;
            this.buy.Text = "Купить";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Visible = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(3, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(604, 423);
            this.dgv.TabIndex = 1;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_CurrentCellDirtyStateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLibrary);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Библиотека";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AllowUserToAddRows = false;
            this.dgvLibrary.AllowUserToDeleteRows = false;
            this.dgvLibrary.AllowUserToResizeColumns = false;
            this.dgvLibrary.AllowUserToResizeRows = false;
            this.dgvLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.ColumnHeadersVisible = false;
            this.dgvLibrary.Location = new System.Drawing.Point(1, 5);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.ReadOnly = true;
            this.dgvLibrary.RowHeadersVisible = false;
            this.dgvLibrary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLibrary.Size = new System.Drawing.Size(604, 448);
            this.dgvLibrary.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(471, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Счет:";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(343, 5);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 13);
            this.loginLabel.TabIndex = 7;
            // 
            // money
            // 
            this.money.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(510, 4);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(0, 13);
            this.money.TabIndex = 8;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 487);
            this.Controls.Add(this.money);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TC);
            this.Name = "Shop";
            this.Text = "Игроман";
            this.Resize += new System.EventHandler(this.Shop_Resize);
            this.TC.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.DataGridView account;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buy;
    }
}

