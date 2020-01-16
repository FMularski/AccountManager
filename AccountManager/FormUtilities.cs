﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    class FormUtilities
    {
        public static void ClearTextBoxes(params TextBox[] fields)
        {
            foreach (TextBox field in fields)
                field.Text = "";
        }
    }
}