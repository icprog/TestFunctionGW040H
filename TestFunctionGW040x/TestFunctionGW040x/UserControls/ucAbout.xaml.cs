﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestFunctionGW040x.UserControls {
    /// <summary>
    /// Interaction logic for ucAbout.xaml
    /// </summary>
    public partial class ucAbout : UserControl {

        List<history> listHist = new List<history>();
        public ucAbout() {
            InitializeComponent();
            listHist.Add(new history() { ID = "1", VERSION = "1.0.0.0", CONTENT = "- Phát hành lần đầu", DATE = "09/02/2018", CHANGETYPE = "Tạo mới", PERSON = "Hồ Đức Anh" });
            listHist.Add(new history() { ID = "2", VERSION = "1.0.0.1", CONTENT = "- Kiểm tra công suất phát quang TX 10 lần. Nếu 1 trong 10 lần OK => PASS\n" +
                                                                                  "- Kiểm tra đồng bộ quang 3 lần. Nếu 1 trong 3 lần OK => PASS", DATE = "09/04/2018", CHANGETYPE = "Chỉnh sửa", PERSON = "Hồ Đức Anh" });
            listHist.Add(new history() { ID = "3", VERSION = "1.0.0.2", CONTENT = "- Kiểm tra công suất phát quang TX 30 lần.Nếu 1 trong 30 lần OK => PASS", DATE = "09/06/2018", CHANGETYPE = "Chỉnh sửa", PERSON = "Hồ Đức Anh" });
            this.GridAbout.ItemsSource = listHist;
        }

        private class history {
            public string ID { get; set; }
            public string VERSION { get; set; }
            public string CONTENT { get; set; }
            public string DATE { get; set; }
            public string CHANGETYPE { get; set; }
            public string PERSON { get; set; }
        }
    }
}
