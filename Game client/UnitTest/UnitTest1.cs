using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void connectBD()
        {
            OleDbDataAdapter sda;
            DataTable dt;
            OleDbConnection con;

            bool flag = false;
            try
            {
                string login = "Тест";
                string password = "123";

                con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\SuperPuperPC\\Desktop\\КПО - лабораторные\\Проект\\Game client\\Main\\bin\\x64\\Debug\\БД.accdb;");
                sda = new OleDbDataAdapter(@"SELECT " + "[Код],[Логин],[Пароль],[Счёт]" + " FROM " + "[Профили игроков] WHERE [Логин]='" + login + "' AND  [Пароль]='" + password + "';", con);
                dt = new DataTable();

                if (sda.Fill(dt) != 0)
                {
                    flag = true;
                }
            }
            catch (Exception)
            {
            }

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void GetMoney()
        {
            OleDbDataAdapter sda;
            DataTable dt = new DataTable();
            OleDbConnection con;

            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\SuperPuperPC\\Desktop\\КПО - лабораторные\\Проект\\Game client\\Main\\bin\\x64\\Debug\\БД.accdb;");
            sda = new OleDbDataAdapter("SELECT[Счёт] FROM[Профили игроков] WHERE[Код] = 1", con);
            sda.Fill(dt);

            Assert.AreEqual(dt.Rows[0].ItemArray[0].ToString(), "2704");
        }

        [TestMethod]
        public void GetName()
        {
            OleDbDataAdapter sda;
            DataTable dt = new DataTable();
            OleDbConnection con;

            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\SuperPuperPC\\Desktop\\КПО - лабораторные\\Проект\\Game client\\Main\\bin\\x64\\Debug\\БД.accdb;");
            sda = new OleDbDataAdapter("SELECT[Логин] FROM[Профили игроков] WHERE[Код] = 1", con);
            sda.Fill(dt);

            Assert.AreEqual(dt.Rows[0].ItemArray[0].ToString(), "Тест");
        }
        [TestMethod]
        public void GetPassword()
        {
            OleDbDataAdapter sda;
            DataTable dt = new DataTable();
            OleDbConnection con;

            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\SuperPuperPC\\Desktop\\КПО - лабораторные\\Проект\\Game client\\Main\\bin\\x64\\Debug\\БД.accdb;");
            sda = new OleDbDataAdapter("SELECT[Пароль] FROM[Профили игроков] WHERE[Код] = 1", con);
            sda.Fill(dt);

            Assert.AreEqual(dt.Rows[0].ItemArray[0].ToString(), "123");
        }
    }
}
