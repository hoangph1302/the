using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_PhamHuyHoang
{
    public class UserInfor
    {
        private string timestamp;
        private string msisdn_origin;
        private string msisdn_des;
        private double call_duration;
        private int sms_number;

        public string Timestamp { get => timestamp; set => timestamp = value; }
        public string Msisdn_origin { get => msisdn_origin; set => msisdn_origin = value; }
        public string Msisdn_des { get => msisdn_des; set => msisdn_des = value; }
        public double Call_duration { get => call_duration; set => call_duration = value; }
        public int Sms_number { get => sms_number; set => sms_number = value; }
    }
}
