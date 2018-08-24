﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.SystemSet
{
    public partial class DepartmentSet : Form
    {
        private static DepartmentSet ds = null;
        private  DepartmentSet()
        {
            InitializeComponent();
        }

        public static DepartmentSet GetDepartmentSet()
        {
            if(ds==null||ds.IsDisposed)
            {
                ds = new DepartmentSet();
            }
            return ds;
        }
    }
}
