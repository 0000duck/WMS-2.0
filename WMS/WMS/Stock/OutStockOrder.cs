﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.Stock
{
    public partial class OutStockOrder : Form
    {
        private static OutStockOrder outStockOrder;
        private OutStockOrder()
        {
            InitializeComponent();
        }

        public static OutStockOrder GetOutStockOrder()
        {
            if(outStockOrder==null||outStockOrder.IsDisposed)
            {
                outStockOrder = new OutStockOrder();
                return outStockOrder;
            }
            return outStockOrder;
        }
    }
}
