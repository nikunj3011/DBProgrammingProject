using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerFields
{
    public static class UIUtilities
    {
        public static void FillListControl(ListControl control, string displayMember, string valueMember, DataTable dt, bool insertBlank = false, string defaultText = "Please select a venue. ")
        {
            if (insertBlank)
            {
                DataRow row = dt.NewRow();
                row[valueMember] = DBNull.Value;
                row[displayMember] = defaultText;
                dt.Rows.InsertAt(row, 0);
            }

            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dt;
        }
    }
}
