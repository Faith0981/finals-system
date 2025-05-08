using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace StudentInformationSystemfinal
{
    public interface IDataAccess //interface ni, diri magbutang ug mga methods pero wala lay implementation blueprint sa method
    {
        void LoadData(GridControl gridControl1);
    }
}
