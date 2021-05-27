using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThu_Vien1
{
    public partial class UCLogout : UserControl
    {
        private static UCLogout _Instance;
        public static UCLogout Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCLogout();
                }
                return _Instance;
            }
        }
        public UCLogout()
        {
            InitializeComponent();
        }
    }
}
