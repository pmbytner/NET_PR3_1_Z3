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
using System.Windows.Shapes;
using System.Xml;

namespace NET_PR3_1_Z3
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegółyKategorii.xaml
    /// </summary>
    public partial class SzczegółyKategorii : Window
    {
        public SzczegółyKategorii(XmlElement kategoria)
        {
            DataContext = kategoria;
            InitializeComponent();
        }
    }
}
