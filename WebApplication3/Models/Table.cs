//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Table
    {
        public int Id { get; set; }

        [DisplayName("帳號")]
        [Required(ErrorMessage = "請填寫帳號")]
        [StringLength(20, ErrorMessage = "帳號不得超過12字")]
        [RegularExpression("[A-Za-z][A-Za-z0-9]{4,19}", ErrorMessage = "帳號格式錯誤")]
        public string account { get; set; }
        [DisplayName("密碼")]
        [Required(ErrorMessage = "請填寫密碼")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "密碼最少4碼")]
        [MaxLength(12, ErrorMessage = "密碼最多12碼")]
        public string passeard { get; set; }
        public string email { get; set; }
    }
}
