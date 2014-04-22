using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better517Na.MVCExcerise.Junior.ViewModel
{
    /// <summary>
    /// 员工信息
    /// </summary>
    public class VMStaffInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public Int32 Age
        {
            get;
            set;
        }
        /// <summary>
        /// 职位
        /// </summary>
        public Int32 Position
        {
            get;
            set;
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get;
            set;
        }
    }
}
