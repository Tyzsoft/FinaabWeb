//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AnswerSheetComment
    {
        public int ID { get; set; }
        public int AnswerSheetID { get; set; }
        public int RaterID { get; set; }
        public string CommentContent { get; set; }
        public string UserCom { get; set; }
    
        public virtual T_AnswerSheet T_AnswerSheet { get; set; }
        public virtual T_TeacherInfo T_TeacherInfo { get; set; }
    }
}
