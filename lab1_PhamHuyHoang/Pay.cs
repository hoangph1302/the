using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_PhamHuyHoang
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            List<UserInfor> listUser = new List<UserInfor>();
            listUser = Data.Instance.LoadData();
            dataGridViewUser.DataSource = listUser;

            //тармфикация
             CultureInfo cultureRu = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = cultureRu;
             Data.Instance.PayOutCall(listUser).ToString("c");

            textBoxOutCall.Text = Data.Instance.PayOutCall(listUser).ToString("c");
            textBoxIncomingCall.Text = Data.Instance.PayIncomingCall(listUser).ToString("c");
            textBoxSms.Text = Data.Instance.PaySms(listUser).ToString("c");

            textBoxTotal.Text = (Convert.ToDouble(Data.Instance.PayOutCall(listUser).ToString()) +
                Convert.ToDouble(Data.Instance.PayIncomingCall(listUser).ToString()) +
                Convert.ToDouble(Data.Instance.PaySms(listUser).ToString())).ToString("c");


        }

      

    }
}
