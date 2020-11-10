using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class Shop : Form
    {
        /// <summary>
        /// Инициализация
        /// </summary>
        public Shop()
        {
            InitializeComponent();

            //Фон выделения при нажатии на ячейку таблицы будет сливаться с фоном
            dgv.DefaultCellStyle.SelectionBackColor = dgv.DefaultCellStyle.BackColor;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            dgvLibrary.DefaultCellStyle.SelectionBackColor = dgvLibrary.DefaultCellStyle.BackColor;
            dgvLibrary.DefaultCellStyle.SelectionForeColor = dgvLibrary.DefaultCellStyle.ForeColor;

        }

        /// <summary>
        /// Адаптер 
        /// </summary>
        OleDbDataAdapter sda;
        /// <summary>
        /// Таблица - результат запроса
        /// </summary>
        DataTable dt;
        /// <summary>
        /// Содержит параметры подключения к БД
        /// </summary>
        OleDbConnection con;

        /// <summary>
        /// При изменении формы её содержимое будет вырваниваться с размером формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Shop_Resize(object sender, EventArgs e)
        {
            GB.Location = new Point(this.Size.Width / 2 - GB.Size.Width / 2, (int)((float)this.Size.Height / 2.5f) - GB.Size.Height / 2);

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Height = dgv.Height / 3;
            }
            for (int i = 0; i < dgvLibrary.Rows.Count; i++)
            {
                dgvLibrary.Rows[i].Height = dgvLibrary.Height / 3;
            }
        }

        /// <summary>
        /// Делает попытку подключиться к БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void connect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\БД.accdb;");
                sda = new OleDbDataAdapter(@"SELECT " + "[Код],[Логин],[Пароль],[Счёт]" + " FROM " + "[Профили игроков] WHERE [Логин]='" + login.Text + "' AND  [Пароль]='" + password.Text + "';", con);
                dt = new DataTable();

                if (sda.Fill(dt) == 0)
                    MessageBox.Show("Неверный логин или пароль!", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    this.account.DataSource = dt;

                    money.Text = account[3, 0].Value.ToString();
                    loginLabel.Text = login.Text;


                    LoadLibraryGame();
                    LoadShop();
                    TC.SelectedIndex = 1;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загружает бибилотеку купленных игр
        /// </summary>
        public void LoadLibraryGame()
        {
            dgvLibrary.DataSource = null;
            dgvLibrary.ColumnCount = 0;

            sda = new OleDbDataAdapter(@"SELECT " + "[Название],[Обложка]" +
                " FROM " + "[Каталог игр] WHERE  exists(SELECT * FROM [Купленные игры]" +
                " WHERE [Каталог игр].[Код]=[Купленные игры].[Код игры] AND [Код профиля игрока]=" + account[0, 0].Value.ToString() + ")", con);// + login.Text + ";", con);
            dt = new DataTable();

            if (sda.Fill(dt) == 0) ;
            else
            {
                dgvLibrary.DataSource = dt;
            }
        }

        /// <summary>
        /// Загружает магазин с некупленными играми
        /// </summary>
        public void LoadShop()
        {
            dgv.DataSource = null;
            dgv.ColumnCount = 0;

            sda = new OleDbDataAdapter(@"SELECT " + "[Название],[Обложка],[Цена]" +
                " FROM " + "[Каталог игр] WHERE not exists(SELECT * FROM [Купленные игры]" +
                " WHERE [Каталог игр].[Код]=[Купленные игры].[Код игры] AND [Код профиля игрока]=" + account[0, 0].Value.ToString() + ")", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            
            for(int i=0;i<dt.Columns.Count;i++)
            {
                dt.Columns[i].ReadOnly = true;
            }


            dt.Columns.Add(new DataColumn("", Type.GetType("  System.Boolean")));
        }

        /// <summary>
        /// Необходимо для выравнивания содержимого таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TC.SelectedIndex)
            {
                case 1:
                    if (dgv.Columns.Count != 0)
                    {
                        ((DataGridViewImageColumn)dgv.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        ((DataGridViewImageColumn)dgv.Columns[1]).Description = "Zoomed";

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            dgv.Rows[i].Height = dgv.Height / 3;
                            dgv[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv[2, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                    break;
                case 2:
                    if (dgvLibrary.Columns.Count != 0)
                    {
                        ((DataGridViewImageColumn)dgvLibrary.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        ((DataGridViewImageColumn)dgvLibrary.Columns[1]).Description = "Zoomed";


                        for (int i = 0; i < dgvLibrary.Rows.Count; i++)
                        {
                            dgvLibrary.Rows[i].Height = dgvLibrary.Height / 3;
                            dgvLibrary[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Завершает изменение ячейки при клике по checkbox в таблице магазина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// Считает общую стоимость выбранных игр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cost = 0;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                if(dgv.Rows[i].Cells[3].Value.ToString()=="True")
                {
                    cost += int.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                }
            }

            if (cost == 0)
            {
                label5.Visible = false;
                buy.Visible = false;
                this.cost.Text = "";
            }
            else
            {
                label5.Visible = true;
                buy.Visible = true;
                this.cost.Text = cost.ToString();
            }
        }

        /// <summary>
        /// Совершает покупку игр путем обновления БД и таблиц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buy_Click(object sender, EventArgs e)
        {
            if(double.Parse(money.Text) - double.Parse(cost.Text)<0)
            {
                MessageBox.Show("Недостаточно средств на счете!", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sda = new OleDbDataAdapter(@"SELECT " + "[Код]" +
             " FROM " + "[Каталог игр] WHERE not exists(SELECT * FROM [Купленные игры]" +
             " WHERE [Каталог игр].[Код]=[Купленные игры].[Код игры] AND [Код профиля игрока]=" + account[0, 0].Value.ToString() + ")", con);
            dt = new DataTable();
            sda.Fill(dt);


            OleDbCommand command;
            string text ="";
            con.Open();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    text = "INSERT INTO [Купленные игры]([Код игры], [Код профиля игрока]) VALUES("+ dt.Rows[i][0].ToString() + ", "+ account[0, 0].Value.ToString() + ")";
                    command = new OleDbCommand(text, con);
                    command.ExecuteNonQuery();
                }
            }

            money.Text = (int.Parse(money.Text) - int.Parse(cost.Text)).ToString();

            text = "UPDATE [Профили игроков] SET [Счёт] = " + money.Text + " WHERE [Код]="+account[0, 0].Value.ToString();
            command = new OleDbCommand(text, con);
            command.ExecuteNonQuery();

            con.Close();

            label5.Visible = false;
            buy.Visible = false;
            cost.Visible = false;

            LoadLibraryGame();
            LoadShop();
            TC_SelectedIndexChanged(sender,e);

            MessageBox.Show("Покупка на сумму "+ cost.Text +"р. совершена!", "Спасибо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
