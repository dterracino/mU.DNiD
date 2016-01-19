﻿/*
    DNiD 2 - PE Identifier.
    Copyright (C) 2016  mammon

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNiD2.intForms
{
    public partial class frmError : ReaperTheme.ReaperForm
    {
        public frmError(string error)
        {
            InitializeComponent();
            reaperTextbox1.Text = error;
        }

        private void frmError_Load(object sender, EventArgs e)
        {

        }

        private void reaperButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reaperButton2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(reaperTextbox1.Text);
        }
    }
}
